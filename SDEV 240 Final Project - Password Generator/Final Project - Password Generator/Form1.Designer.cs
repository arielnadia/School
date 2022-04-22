namespace Final_Project___Password_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb8 = new System.Windows.Forms.RadioButton();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.rdb12 = new System.Windows.Forms.RadioButton();
            this.rdb16 = new System.Windows.Forms.RadioButton();
            this.rdb20 = new System.Windows.Forms.RadioButton();
            this.lblSpecialChars = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.ckbSpecChars = new System.Windows.Forms.CheckBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("High Tower Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(107, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(424, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Random Password Generator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(30, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Length";
            // 
            // rdb8
            // 
            this.rdb8.AutoSize = true;
            this.rdb8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb8.ForeColor = System.Drawing.Color.Teal;
            this.rdb8.Location = new System.Drawing.Point(35, 184);
            this.rdb8.Name = "rdb8";
            this.rdb8.Size = new System.Drawing.Size(35, 23);
            this.rdb8.TabIndex = 2;
            this.rdb8.TabStop = true;
            this.rdb8.Text = "8";
            this.rdb8.UseVisualStyleBackColor = true;
            this.rdb8.CheckedChanged += new System.EventHandler(this.rdb8_CheckedChanged);
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb10.ForeColor = System.Drawing.Color.Teal;
            this.rdb10.Location = new System.Drawing.Point(35, 213);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(43, 23);
            this.rdb10.TabIndex = 3;
            this.rdb10.TabStop = true;
            this.rdb10.Text = "10";
            this.rdb10.UseVisualStyleBackColor = true;
            this.rdb10.CheckedChanged += new System.EventHandler(this.rdb10_CheckedChanged);
            // 
            // rdb12
            // 
            this.rdb12.AutoSize = true;
            this.rdb12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb12.ForeColor = System.Drawing.Color.Teal;
            this.rdb12.Location = new System.Drawing.Point(35, 242);
            this.rdb12.Name = "rdb12";
            this.rdb12.Size = new System.Drawing.Size(43, 23);
            this.rdb12.TabIndex = 4;
            this.rdb12.TabStop = true;
            this.rdb12.Text = "12";
            this.rdb12.UseVisualStyleBackColor = true;
            this.rdb12.CheckedChanged += new System.EventHandler(this.rdb12_CheckedChanged);
            // 
            // rdb16
            // 
            this.rdb16.AutoSize = true;
            this.rdb16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb16.ForeColor = System.Drawing.Color.Teal;
            this.rdb16.Location = new System.Drawing.Point(35, 271);
            this.rdb16.Name = "rdb16";
            this.rdb16.Size = new System.Drawing.Size(43, 23);
            this.rdb16.TabIndex = 5;
            this.rdb16.TabStop = true;
            this.rdb16.Text = "16";
            this.rdb16.UseVisualStyleBackColor = true;
            this.rdb16.CheckedChanged += new System.EventHandler(this.rdb16_CheckedChanged);
            // 
            // rdb20
            // 
            this.rdb20.AutoSize = true;
            this.rdb20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb20.ForeColor = System.Drawing.Color.Teal;
            this.rdb20.Location = new System.Drawing.Point(35, 300);
            this.rdb20.Name = "rdb20";
            this.rdb20.Size = new System.Drawing.Size(43, 23);
            this.rdb20.TabIndex = 6;
            this.rdb20.TabStop = true;
            this.rdb20.Text = "20";
            this.rdb20.UseVisualStyleBackColor = true;
            this.rdb20.CheckedChanged += new System.EventHandler(this.rdb20_CheckedChanged);
            // 
            // lblSpecialChars
            // 
            this.lblSpecialChars.AutoSize = true;
            this.lblSpecialChars.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialChars.ForeColor = System.Drawing.Color.Teal;
            this.lblSpecialChars.Location = new System.Drawing.Point(118, 142);
            this.lblSpecialChars.Name = "lblSpecialChars";
            this.lblSpecialChars.Size = new System.Drawing.Size(177, 26);
            this.lblSpecialChars.TabIndex = 7;
            this.lblSpecialChars.Text = "Special Characters?";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Teal;
            this.lblResult.Location = new System.Drawing.Point(372, 142);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(207, 26);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Here is your password!";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Teal;
            this.txtResult.Location = new System.Drawing.Point(329, 186);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(288, 27);
            this.txtResult.TabIndex = 11;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Teal;
            this.btnReset.Location = new System.Drawing.Point(474, 278);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 33);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Teal;
            this.btnGenerate.Location = new System.Drawing.Point(394, 230);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(154, 35);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // ckbSpecChars
            // 
            this.ckbSpecChars.AutoSize = true;
            this.ckbSpecChars.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSpecChars.ForeColor = System.Drawing.Color.Teal;
            this.ckbSpecChars.Location = new System.Drawing.Point(123, 184);
            this.ckbSpecChars.Name = "ckbSpecChars";
            this.ckbSpecChars.Size = new System.Drawing.Size(50, 23);
            this.ckbSpecChars.TabIndex = 14;
            this.ckbSpecChars.Text = "Yes";
            this.ckbSpecChars.UseVisualStyleBackColor = true;
            this.ckbSpecChars.CheckedChanged += new System.EventHandler(this.ckbSpecChars_CheckedChanged);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Teal;
            this.lblInstructions.Location = new System.Drawing.Point(119, 70);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(402, 38);
            this.lblInstructions.TabIndex = 15;
            this.lblInstructions.Text = "Select your desired length, whether you would like to include\r\nspecial characters" +
    ", and click Generate Password!";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.Teal;
            this.btnCopy.Location = new System.Drawing.Point(394, 278);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(74, 33);
            this.btnCopy.TabIndex = 16;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(638, 385);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.ckbSpecChars);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSpecialChars);
            this.Controls.Add(this.rdb20);
            this.Controls.Add(this.rdb16);
            this.Controls.Add(this.rdb12);
            this.Controls.Add(this.rdb10);
            this.Controls.Add(this.rdb8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb8;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.RadioButton rdb12;
        private System.Windows.Forms.RadioButton rdb16;
        private System.Windows.Forms.RadioButton rdb20;
        private System.Windows.Forms.Label lblSpecialChars;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox ckbSpecChars;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnCopy;
    }
}

