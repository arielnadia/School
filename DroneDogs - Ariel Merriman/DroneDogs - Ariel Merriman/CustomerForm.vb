Public Class CustomerForm
    'Form level member
    Private objCustomers As New ArrayList
    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click

        'Get new customer info from text boxes
        Dim FirstName = txtFirstName.Text
        Dim LastName = txtLastName.Text
        Dim Email = txtEmail.Text
        CreateCustomer(FirstName, LastName, Email)

    End Sub
    Public Sub CreateCustomer(firstName As String, lastName As String, email As String)

        'Declare a customer object
        Dim objNewCustomer As Customer

        'Create the new customer
        objNewCustomer.FirstName = firstName
        objNewCustomer.LastName = lastName
        objNewCustomer.Email = email

        'Add the new customer to the list
        objCustomers.Add(objNewCustomer)

        'Add the new customer to the ListBox control
        lbxCustList.Items.Add(objNewCustomer)

    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Pre-load 3 customers into the list
        CreateCustomer("Fred", "Garvin", "fgarvin@thiscompanysn1.com")
        CreateCustomer("Fran", "Pepper", "fpepper@notthesoftdrink.org")
        CreateCustomer("Will", "Robinson", "wrobinson@lostinspacetown.gov")

    End Sub
    Public ReadOnly Property SelectedCustomer() As Customer

        Get
            If lbxCustList.SelectedIndex <> -1 Then
                'Return this customer
                Return CType(objCustomers(lbxCustList.SelectedIndex), Customer)
            End If
        End Get

    End Property

    Private Sub btnSelectCust_Click(sender As Object, e As EventArgs) Handles btnSelectCust.Click

        'If no customer is selected, then error and exit
        If lbxCustList.SelectedIndex = -1 Then
            'Display error message and exit
            MessageBox.Show("ERROR: No customer selected.")
            Exit Sub
        End If

        'Get customer info and display it in the order form
        Dim objCustomerSelected As Customer = SelectedCustomer
        OrderForm.txtFirstName.Text = objCustomerSelected.FirstName
        OrderForm.txtLastName.Text = objCustomerSelected.LastName
        OrderForm.txtEmail.Text = objCustomerSelected.Email

        'Close the customer form
        Me.Close()
    End Sub
End Class