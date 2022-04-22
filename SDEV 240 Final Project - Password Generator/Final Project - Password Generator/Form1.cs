/* Final Project - Random Password Generator Program
 * Author: Ariel Merriman
 * Date: December 10, 2019
 * SDEV 240
 * 
 * Purpose: This program allows the user to generate a random password
 * by selecting a desired length and indicating whether they would like
 * to include special characters.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project___Password_Generator
{
    public partial class Form1 : Form
    {
        // declares global variables
        int PassLength;
        bool SpecialChars;
        // declares two arrays containing all possible characters for password
        // one array includes special characters
        // 71 items
        string[] WithSpecialCharacters = { "!", "@", "#", "$", "%", "^", "&", "?", "+", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        // 62 items
        string[] NoSpecialCharacters = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public Form1()
        {
            InitializeComponent();
        }

        // checks selection and determines password length
        private void rdb8_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb8.Checked)
            {
                PassLength = Convert.ToInt32(rdb8.Text);
            }
        }

        private void rdb10_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb10.Checked)
            {
                PassLength = Convert.ToInt32(rdb10.Text);
            }
        }

        private void rdb12_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb12.Checked)
            {
                PassLength = Convert.ToInt32(rdb12.Text);
            }
        }

        private void rdb16_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb16.Checked)
            {
                PassLength = Convert.ToInt32(rdb16.Text);
            }
        }

        private void rdb20_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb20.Checked)
            {
                PassLength = Convert.ToInt32(rdb20.Text);
            }
        }

        // checks selection to determine whether or not to include special characters
        private void ckbSpecChars_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSpecChars.Checked)
            {
                SpecialChars = true;
            } else
            {
                SpecialChars = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // declares variables
            Random RanNumGen = new Random();
            int RanNum = 0;
            int i = 0;
            string Password;
            string[] PassArray = new string[PassLength];
            // loop assigns random value from appropriate array to
            // new password array until it reaches desired length
            while (i < PassLength)
            {
                if (SpecialChars == true)
                {
                    RanNum = RanNumGen.Next(0, WithSpecialCharacters.Length);
                    PassArray[i] = WithSpecialCharacters[RanNum];
                    i++;
                } else
                {
                    RanNum = RanNumGen.Next(0, NoSpecialCharacters.Length);
                    PassArray[i] = NoSpecialCharacters[RanNum];
                    i++;
                }
            }
            // converts array to string and displays results
            Password = string.Join("", PassArray);
            txtResult.Text = Password;
        }

        // copies password to clipboard
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        // resets all values back to defaults
        private void btnReset_Click(object sender, EventArgs e)
        {
            rdb8.Checked = true;
            rdb10.Checked = false;
            rdb12.Checked = false;
            rdb16.Checked = false;
            rdb20.Checked = false;
            ckbSpecChars.Checked = false;
            txtResult.Text = "";
        }
    }
}
