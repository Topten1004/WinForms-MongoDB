namespace LoginFormUI
{
    partial class CreateNewUserForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.newConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.newConfirmPasswordValue = new System.Windows.Forms.TextBox();
            this.newPasswordValue = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newCountryLabel = new System.Windows.Forms.Label();
            this.newEmailValue = new System.Windows.Forms.TextBox();
            this.newEmailLabel = new System.Windows.Forms.Label();
            this.createNewUserButton = new System.Windows.Forms.Button();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comBoCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(136, 51);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(168, 47);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "New User";
            // 
            // newConfirmPasswordLabel
            // 
            this.newConfirmPasswordLabel.AutoSize = true;
            this.newConfirmPasswordLabel.Location = new System.Drawing.Point(74, 275);
            this.newConfirmPasswordLabel.Name = "newConfirmPasswordLabel";
            this.newConfirmPasswordLabel.Size = new System.Drawing.Size(87, 30);
            this.newConfirmPasswordLabel.TabIndex = 2;
            this.newConfirmPasswordLabel.Text = "Confirm";
            // 
            // newConfirmPasswordValue
            // 
            this.newConfirmPasswordValue.Location = new System.Drawing.Point(199, 272);
            this.newConfirmPasswordValue.Name = "newConfirmPasswordValue";
            this.newConfirmPasswordValue.PasswordChar = '*';
            this.newConfirmPasswordValue.Size = new System.Drawing.Size(167, 35);
            this.newConfirmPasswordValue.TabIndex = 3;
            // 
            // newPasswordValue
            // 
            this.newPasswordValue.Location = new System.Drawing.Point(199, 221);
            this.newPasswordValue.Name = "newPasswordValue";
            this.newPasswordValue.PasswordChar = '*';
            this.newPasswordValue.Size = new System.Drawing.Size(167, 35);
            this.newPasswordValue.TabIndex = 5;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(74, 221);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(99, 30);
            this.newPasswordLabel.TabIndex = 4;
            this.newPasswordLabel.Text = "Password";
            // 
            // newCountryLabel
            // 
            this.newCountryLabel.AutoSize = true;
            this.newCountryLabel.Location = new System.Drawing.Point(74, 347);
            this.newCountryLabel.Name = "newCountryLabel";
            this.newCountryLabel.Size = new System.Drawing.Size(86, 30);
            this.newCountryLabel.TabIndex = 6;
            this.newCountryLabel.Text = "Country";
            // 
            // newEmailValue
            // 
            this.newEmailValue.Location = new System.Drawing.Point(199, 170);
            this.newEmailValue.Name = "newEmailValue";
            this.newEmailValue.Size = new System.Drawing.Size(167, 35);
            this.newEmailValue.TabIndex = 11;
            // 
            // newEmailLabel
            // 
            this.newEmailLabel.AutoSize = true;
            this.newEmailLabel.Location = new System.Drawing.Point(74, 173);
            this.newEmailLabel.Name = "newEmailLabel";
            this.newEmailLabel.Size = new System.Drawing.Size(63, 30);
            this.newEmailLabel.TabIndex = 10;
            this.newEmailLabel.Text = "Email";
            // 
            // createNewUserButton
            // 
            this.createNewUserButton.Location = new System.Drawing.Point(149, 426);
            this.createNewUserButton.Name = "createNewUserButton";
            this.createNewUserButton.Size = new System.Drawing.Size(189, 50);
            this.createNewUserButton.TabIndex = 12;
            this.createNewUserButton.Text = "Create New User";
            this.createNewUserButton.UseVisualStyleBackColor = true;
            this.createNewUserButton.Click += new System.EventHandler(this.createNewUserButton_Click);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showPasswordCheckBox.Location = new System.Drawing.Point(199, 313);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(118, 21);
            this.showPasswordCheckBox.TabIndex = 13;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comBoCountry
            // 
            this.comBoCountry.DropDownHeight = 100;
            this.comBoCountry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBoCountry.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoCountry.FormattingEnabled = true;
            this.comBoCountry.IntegralHeight = false;
            this.comBoCountry.ItemHeight = 25;
            this.comBoCountry.Location = new System.Drawing.Point(196, 353);
            this.comBoCountry.MaxDropDownItems = 5;
            this.comBoCountry.Name = "comBoCountry";
            this.comBoCountry.Size = new System.Drawing.Size(170, 33);
            this.comBoCountry.TabIndex = 15;
            // 
            // CreateNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 539);
            this.Controls.Add(this.comBoCountry);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.createNewUserButton);
            this.Controls.Add(this.newEmailValue);
            this.Controls.Add(this.newEmailLabel);
            this.Controls.Add(this.newCountryLabel);
            this.Controls.Add(this.newPasswordValue);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.newConfirmPasswordValue);
            this.Controls.Add(this.newConfirmPasswordLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateNewUserForm";
            this.Text = "Create New User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateNewUserForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox newPasswordValue;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label newConfirmPasswordLabel;
        private System.Windows.Forms.TextBox newConfirmPasswordValue;
        private System.Windows.Forms.Label newCountryLabel;
        private System.Windows.Forms.TextBox newEmailValue;
        private System.Windows.Forms.Label newEmailLabel;
        private System.Windows.Forms.Button createNewUserButton;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comBoCountry;
    }
}