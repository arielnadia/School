<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblBeef = New System.Windows.Forms.Label()
        Me.lblPork = New System.Windows.Forms.Label()
        Me.lblTurkey = New System.Windows.Forms.Label()
        Me.txtBeef = New System.Windows.Forms.TextBox()
        Me.txtPork = New System.Windows.Forms.TextBox()
        Me.txtTurkey = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnGetCustInfo = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.ckbLocation = New System.Windows.Forms.CheckBox()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(73, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(241, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "DroneDogs Order Form"
        '
        'lblBeef
        '
        Me.lblBeef.AutoSize = True
        Me.lblBeef.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBeef.Location = New System.Drawing.Point(62, 88)
        Me.lblBeef.Name = "lblBeef"
        Me.lblBeef.Size = New System.Drawing.Size(74, 18)
        Me.lblBeef.TabIndex = 1
        Me.lblBeef.Text = "Beef Dogs:"
        '
        'lblPork
        '
        Me.lblPork.AutoSize = True
        Me.lblPork.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPork.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPork.Location = New System.Drawing.Point(64, 120)
        Me.lblPork.Name = "lblPork"
        Me.lblPork.Size = New System.Drawing.Size(72, 18)
        Me.lblPork.TabIndex = 2
        Me.lblPork.Text = "Pork Dogs:"
        '
        'lblTurkey
        '
        Me.lblTurkey.AutoSize = True
        Me.lblTurkey.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurkey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTurkey.Location = New System.Drawing.Point(48, 154)
        Me.lblTurkey.Name = "lblTurkey"
        Me.lblTurkey.Size = New System.Drawing.Size(88, 18)
        Me.lblTurkey.TabIndex = 3
        Me.lblTurkey.Text = "Turkey Dogs:"
        '
        'txtBeef
        '
        Me.txtBeef.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBeef.Location = New System.Drawing.Point(143, 85)
        Me.txtBeef.Name = "txtBeef"
        Me.txtBeef.Size = New System.Drawing.Size(36, 26)
        Me.txtBeef.TabIndex = 4
        '
        'txtPork
        '
        Me.txtPork.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPork.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPork.Location = New System.Drawing.Point(143, 120)
        Me.txtPork.Name = "txtPork"
        Me.txtPork.Size = New System.Drawing.Size(36, 26)
        Me.txtPork.TabIndex = 5
        '
        'txtTurkey
        '
        Me.txtTurkey.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTurkey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTurkey.Location = New System.Drawing.Point(143, 153)
        Me.txtTurkey.Name = "txtTurkey"
        Me.txtTurkey.Size = New System.Drawing.Size(36, 26)
        Me.txtTurkey.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCalculate.Location = New System.Drawing.Point(206, 95)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(108, 33)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(206, 138)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 33)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSubtotal.Location = New System.Drawing.Point(70, 207)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(64, 18)
        Me.lblSubtotal.TabIndex = 9
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTax.Location = New System.Drawing.Point(61, 246)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(73, 18)
        Me.lblTax.TabIndex = 10
        Me.lblTax.Text = "Sales Tax:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(90, 283)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 18)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Total:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSubtotal.Location = New System.Drawing.Point(140, 204)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(58, 26)
        Me.txtSubtotal.TabIndex = 12
        '
        'txtTax
        '
        Me.txtTax.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTax.Location = New System.Drawing.Point(140, 242)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(58, 26)
        Me.txtTax.TabIndex = 13
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(140, 280)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(58, 26)
        Me.txtTotal.TabIndex = 14
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSubmit.Location = New System.Drawing.Point(206, 228)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(108, 51)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "Submit Order"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnGetCustInfo
        '
        Me.btnGetCustInfo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetCustInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGetCustInfo.Location = New System.Drawing.Point(390, 21)
        Me.btnGetCustInfo.Name = "btnGetCustInfo"
        Me.btnGetCustInfo.Size = New System.Drawing.Size(106, 53)
        Me.btnGetCustInfo.TabIndex = 17
        Me.btnGetCustInfo.Text = "Get Customer Info"
        Me.btnGetCustInfo.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(514, 21)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 53)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(472, 176)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(135, 26)
        Me.txtEmail.TabIndex = 24
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(472, 142)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(135, 26)
        Me.txtLastName.TabIndex = 23
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(472, 107)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(135, 26)
        Me.txtFirstName.TabIndex = 22
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(411, 179)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(44, 18)
        Me.lblEmail.TabIndex = 21
        Me.lblEmail.Text = "Email:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLastName.Location = New System.Drawing.Point(381, 145)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(74, 18)
        Me.lblLastName.TabIndex = 20
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFirstName.Location = New System.Drawing.Point(381, 110)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(78, 18)
        Me.lblFirstName.TabIndex = 19
        Me.lblFirstName.Text = "First Name:"
        '
        'ckbLocation
        '
        Me.ckbLocation.AutoSize = True
        Me.ckbLocation.Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ckbLocation.Location = New System.Drawing.Point(344, 228)
        Me.ckbLocation.Name = "ckbLocation"
        Me.ckbLocation.Size = New System.Drawing.Size(283, 17)
        Me.ckbLocation.TabIndex = 25
        Me.ckbLocation.Text = "I give DroneDogs permission to use my location information."
        Me.ckbLocation.UseVisualStyleBackColor = True
        '
        'imgLogo
        '
        Me.imgLogo.BackgroundImage = Global.DroneDogs___Ariel_Merriman.My.Resources.Resources.DroneDogsLogo2
        Me.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgLogo.Location = New System.Drawing.Point(3, 0)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(64, 94)
        Me.imgLogo.TabIndex = 15
        Me.imgLogo.TabStop = False
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(639, 328)
        Me.Controls.Add(Me.ckbLocation)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGetCustInfo)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.imgLogo)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTurkey)
        Me.Controls.Add(Me.txtPork)
        Me.Controls.Add(Me.txtBeef)
        Me.Controls.Add(Me.lblTurkey)
        Me.Controls.Add(Me.lblPork)
        Me.Controls.Add(Me.lblBeef)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "OrderForm"
        Me.Text = "DroneDogs - Ariel Merriman"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblBeef As Label
    Friend WithEvents lblPork As Label
    Friend WithEvents lblTurkey As Label
    Friend WithEvents txtBeef As TextBox
    Friend WithEvents txtPork As TextBox
    Friend WithEvents txtTurkey As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnGetCustInfo As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents ckbLocation As CheckBox
End Class
