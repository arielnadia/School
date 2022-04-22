/* Author: Ariel Merriman
 * Date: July 28, 2019

 * Filename: ghibli.js
 */

/* declare global variables */

var pctSeen = 0;
var pastDate;
var today = new Date();
var emailValid = false;
var typeValid = false;
var filmValid = false;
var emailType = [];
var emailString;
var weekly = "Weekly News";
var monthly = "Monthly News";
var newfilm = "New Film Announcements";
var deals = "Product Deals";
var updates = "Website Updates";

/* validate newsletter entries */

// validate email entry

function validateEmail() {
	var emailPattern = /^[_a-zA-Z0-9\\-]+(\.[_a-zA-Z0-9\\-]+)*@[a-zA-Z0-9\\-]+(\.[a-zA-Z0-9\\-]+)*(\.[a-z]{2,6})$/;
	var emailTest = emailPattern.test(document.getElementById("email").value);
	if ((document.getElementById("email").value) === "" || emailTest === false) {
		document.getElementById("email").style.border = "1px solid #B30000";
		document.getElementById("emailerror").innerHTML = "You must enter a valid email address.";
		emailValid = false;
	} else {
		document.getElementById("email").style.border = "";
		document.getElementById("emailerror").style.display = "none";
		emailValid = true;
	}
}

// validate checkbox entry

function validateType() {
	if (!(document.getElementById("weekly").checked) && !(document.getElementById("monthly").checked) && !(document.getElementById("newfilm").checked) && !(document.getElementById("deals").checked) && !(document.getElementById("updates").checked)) {
		document.getElementById("typeerror").innerHTML = "You must select at least one.";
		typeValid = false;
	} else {
		document.getElementById("typeerror").style.display = "none";
		typeValid = true;
	}
}

// add checkbox entry(s) to array

function registerWeekly() {
	if (document.getElementById("weekly").checked) {
		emailType.push(weekly);
	}
	else {
		for (var count = 0; count < emailType.length; count++) {
			if (emailType[count] === weekly) {
				emailType.splice(count, 1);
			}
		}
	}
	emailString = emailType.join(", ");
}
function registerMonthly() {
	if (document.getElementById("monthly").checked) {
		emailType.push(monthly);
	}
	else {
		for (var count = 0; count < emailType.length; count++) {
			if (emailType[count] === monthly) {
				emailType.splice(count, 1);
			}
		}
	}
	emailString = emailType.join(", ");
}
function registerNewfilm() {
	if (document.getElementById("newfilm").checked) {
		emailType.push(newfilm);
	}
	else {
		for (var count = 0; count < emailType.length; count++) {
			if (emailType[count] === newfilm) {
				emailType.splice(count, 1);
			}
		}
	}
	emailString = emailType.join(", ");
}
function registerDeals() {
	if (document.getElementById("deals").checked) {
		emailType.push(deals);
	}
	else {
		for (var count = 0; count < emailType.length; count++) {
			if (emailType[count] === deals) {
				emailType.splice(count, 1);
			}
		}
	}
	emailString = emailType.join(", ");
}
function registerUpdates() {
	if (document.getElementById("updates").checked) {
		emailType.push(updates);
	}
	else {
		for (var count = 0; count < emailType.length; count++) {
			if (emailType[count] === updates) {
				emailType.splice(count, 1);
			}
		}
	}
	emailString = emailType.join(", ");
}

// validate film selection entry

function validateFilm() {
	if (document.getElementById("favfilm").value === "blank") {
		document.getElementById("favfilm").style.border = "1px solid #B30000";
		document.getElementById("filmerror").innerHTML = "You must select a film.";
		filmValid = false;
	} else {
		document.getElementById("favfilm").style.border = "";
		document.getElementById("filmerror").style.display = "none";
		filmValid = true;
	}
}

// validate all entries upon submit

function validateForm() {
	validateEmail();
	validateType();
	validateFilm();
	if ((emailValid == true) && (typeValid == true) && (filmValid == true)) {
		window.alert("Thank you for your interest! You are subscribed.");
		resetForm();
	} else {
		window.alert("Thank you for your interest! Please fix the indicated errors.");;
	}
}

/* calculate the % of films seen */

function calcFilms() {
	var totalFilms = (document.getElementById("filmTable").rows.length) - 1;
	var numFilms = document.getElementById("numfilms");

	// verify user input is integer

	if (isNaN(numFilms.value)) {
		document.getElementById("pctseen").innerHTML = "Please enter a number.";
		document.getElementById("numfilms").value = "";

	// verify number is in valid range

} else if (numFilms.value < 0 || numFilms.value > totalFilms) {
		document.getElementById("pctseen").innerHTML = "Number must be between 0 and " + totalFilms + ".";
		document.getElementById("numfilms").value = "";
	} else {

	// perform calculation

		pctSeen = ((numFilms.value / totalFilms) * 100);
		document.getElementById("pctseen").innerHTML = "That's " + Math.round(pctSeen) + "%!";

	// popup if 100% films seen

		if (pctSeen == "100") {
			window.alert("Wow, you're a big fan of Studio Ghibli!");
		}
	}
}

/* get user location */

function getLoc(position) {
	document.getElementById("lat").innerHTML = "Latitude: " + position.coords.latitude;
	document.getElementById("long").innerHTML = "Longitude: " + position.coords.longitude;
	document.getElementById("alt").innerHTML = "Altitude: " + position.coords.altitude;
}

function noLoc() {
	document.getElementById("lat").innerHTML = "Latitude: unknown";
	document.getElementById("long").innerHTML = "Longitude: unknown";
	document.getElementById("alt").innerHTML = "Altitude: unknown";
}

/* calculate time elapsed since chosen date */

function timeElapsed() {
	var pastDate = new Date(document.getElementById("date").value);
	var dateFrom = Date.UTC(pastDate.getFullYear(), pastDate.getMonth(), pastDate.getDate());
	var dateTo = Date.UTC(today.getFullYear(), today.getMonth(), today.getDate());
	if (pastDate > today) {
		document.getElementById("elapsed").innerHTML = "You can't enter a date in the future!";
		document.getElementById("date").value = "";
	}
	else {

		// days elapsed

		var totalDays = Math.floor(((dateTo - dateFrom) / 86400000) - 1);
		var days = Math.floor(totalDays % 31);

		// months elapsed

		var totalMonths = Math.floor(totalDays / 31);
		var months = Math.floor(totalMonths % 12);

		// years elapsed

		var years = Math.floor(totalMonths / 12);
		document.getElementById("elapsed").innerHTML = years + " Years, " + months + " Months, " + days + " Days have elapsed.";
	}
}

/* reset to defaults */

function resetFilms() {
	document.getElementById("numfilms").value = 0;
}

function resetDays() {
	document.getElementById("date").value = "";
}

function resetForm() {
	document.getElementById("email").value = "";
	document.getElementById("weekly").checked = false;
	document.getElementById("monthly").checked = false;
	document.getElementById("newfilm").checked = false;
	document.getElementById("deals").checked = false;
	document.getElementById("updates").checked = false;
	document.getElementById("favfilm").value = "blank";
}
