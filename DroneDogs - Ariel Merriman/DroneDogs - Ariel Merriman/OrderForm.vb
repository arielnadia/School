Public Class OrderForm
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declare constants
        Const SALES_TAX_RATE As Double = 0.07
        Const DOG_PRICE As Double = 1.99
        'Declare variables
        Dim NumBeef As Integer
        Dim NumPork As Integer
        Dim NumTurkey As Integer
        Dim TotalDogs As Integer
        Dim Subtotal As Double
        Dim SalesTax As Double
        Dim TotalCost As Double
        'Extract user typed quantities from text boxes and convert to integers while checking for valid input
        'Convert blank entries to zero
        If txtBeef.Text = "" Then
            txtBeef.Text = "0"
        End If
        If txtPork.Text = "" Then
            txtPork.Text = "0"
        End If
        If txtTurkey.Text = "" Then
            txtTurkey.Text = "0"
        End If
        'Validate that entries are integers
        If IsNumeric(txtBeef.Text) Then    'Is the entry a number?
            If Int(txtBeef.Text) = txtBeef.Text Then    'Is the entry a whole number?
                txtBeef.Text = Int(txtBeef.Text)
                NumBeef = txtBeef.Text     'Number of Beef Dogs ordered
                If NumBeef >= 0 Then     'Is the entry a positive number?

                Else
                    MessageBox.Show("ERROR: Invalid entry for Beef Dogs. You cannot order a negative amount of dogs!")
                    txtBeef.Text = "0"
                    NumBeef = 0
                End If
            Else
                MessageBox.Show("ERROR: Invalid entry for Beef Dogs. You may only order whole dogs.")
                txtBeef.Text = "0"
            End If
        Else
            MessageBox.Show("ERROR: Invalid entry for Beef Dogs. You can only order a numeric amount of dogs.")
            txtBeef.Text = "0"
        End If

        If IsNumeric(txtPork.Text) Then     'Is the entry a number?
            If Int(txtPork.Text) = txtPork.Text Then    'Is the entry a whole number?
                txtPork.Text = Int(txtPork.Text)
                NumPork = txtPork.Text    'Number of Pork Dogs ordered
                If NumPork >= 0 Then    'Is the entry a positive number?

                Else
                    MessageBox.Show("ERROR: Invalid entry for Pork Dogs. You cannot order a negative amount of dogs!")
                    txtPork.Text = "0"
                    NumPork = 0
                End If
            Else
                MessageBox.Show("ERROR: Invalid entry for Pork Dogs. You may only order whole dogs.")
                txtPork.Text = "0"
            End If
        Else
            MessageBox.Show("ERROR: Invalid entry for Pork Dogs. You can only order a numeric amount of dogs.")
            txtPork.Text = "0"
        End If

        If IsNumeric(txtTurkey.Text) Then   'Is the entry a number?
            If Int(txtTurkey.Text) = txtTurkey.Text Then    'Is the entry a whole number?
                txtTurkey.Text = Int(txtTurkey.Text)
                NumTurkey = txtTurkey.Text    'Number of Turkey Dogs ordered
                If NumTurkey >= 0 Then     'Is the entry a positive number?

                Else
                    MessageBox.Show("ERROR: Invalid entry for Turkey Dogs. You cannot order a negative amount of dogs!")
                    txtTurkey.Text = "0"
                    NumTurkey = 0
                End If
            Else
                MessageBox.Show("ERROR: Invalid entry for Turkey Dogs. You may only order whole dogs.")
                txtTurkey.Text = "0"
            End If
        Else
            MessageBox.Show("ERROR: Invalid entry for Turkey Dogs. You can only order a numeric amount of dogs.")
            txtTurkey.Text = "0"
        End If
        'Calculate total number of hot dogs ordered
        TotalDogs = NumBeef + NumPork + NumTurkey
        'Calculate subtotal, sales tax, and total amounts
        Subtotal = TotalDogs * DOG_PRICE
        SalesTax = Subtotal * SALES_TAX_RATE
        TotalCost = Subtotal + SalesTax
        'Convert numbers back to text and display in text boxes
        txtSubtotal.Text = Subtotal.ToString("c2")
        txtTax.Text = SalesTax.ToString("c2")
        txtTotal.Text = TotalCost.ToString("c2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close form
        Me.Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Check to make sure all necessary fields are completed
        If ckbLocation.Checked = False Then
            MessageBox.Show("ERROR: You must check the location permission box.")
        ElseIf txtTotal.Text = "" Then
            MessageBox.Show("ERROR: You must order at least one item.")
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("ERROR: Please complete customer information for this order.")
        Else
            'Display message box thanking the user
            MessageBox.Show("Thank you for ordering from DroneDogs!")
        End If

    End Sub

    Private Sub btnGetCustInfo_Click(sender As Object, e As EventArgs) Handles btnGetCustInfo.Click

        'Get info from the customer form
        CustomerForm.Show()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear all of the text boxes
        txtBeef.Text = ""
        txtPork.Text = ""
        txtTurkey.Text = ""
        txtSubtotal.Text = ""
        txtTax.Text = ""
        txtTotal.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
        ckbLocation.Checked = False

    End Sub
End Class
