namespace LoginFormUI
{
    partial class ChangePasswordForm
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
            this.newPasswordConfirmValue = new System.Windows.Forms.TextBox();
            this.newPasswordConfirmLabel = new System.Windows.Forms.Label();
            this.newPasswordValue = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.currentPasswordValue = new System.Windows.Forms.TextBox();
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.confirmChangePasswordButton = new System.Windows.Forms.Button();
            this.showAllPasswordsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(96, 34);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(297, 47);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Change password";
            // 
            // newPasswordConfirmValue
            // 
            this.newPasswordConfirmValue.Location = new System.Drawing.Point(266, 255);
            this.newPasswordConfirmValue.Name = "newPasswordConfirmValue";
            this.newPasswordConfirmValue.PasswordChar = '*';
            this.newPasswordConfirmValue.Size = new System.Drawing.Size(167, 35);
            this.newPasswordConfirmValue.TabIndex = 23;
            // 
            // newPasswordConfirmLabel
            // 
            this.newPasswordConfirmLabel.AutoSize = true;
            this.newPasswordConfirmLabel.Location = new System.Drawing.Point(55, 258);
            this.newPasswordConfirmLabel.Name = "newPasswordConfirmLabel";
            this.newPasswordConfirmLabel.Size = new System.Drawing.Size(180, 30);
            this.newPasswordConfirmLabel.TabIndex = 22;
            this.newPasswordConfirmLabel.Text = "Confirm password";
            // 
            // newPasswordValue
            // 
            this.newPasswordValue.Location = new System.Drawing.Point(266, 205);
            this.newPasswordValue.Name = "newPasswordValue";
            this.newPasswordValue.PasswordChar = '*';
            this.newPasswordValue.Size = new System.Drawing.Size(167, 35);
            this.newPasswordValue.TabIndex = 21;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(55, 208);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(148, 30);
            this.newPasswordLabel.TabIndex = 20;
            this.newPasswordLabel.Text = "New password";
            // 
            // currentPasswordValue
            // 
            this.currentPasswordValue.Location = new System.Drawing.Point(266, 132);
            this.currentPasswordValue.Name = "currentPasswordValue";
            this.currentPasswordValue.PasswordChar = '*';
            this.currentPasswordValue.Size = new System.Drawing.Size(167, 35);
            this.currentPasswordValue.TabIndex = 19;
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.Location = new System.Drawing.Point(55, 135);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(175, 30);
            this.currentPasswordLabel.TabIndex = 18;
            this.currentPasswordLabel.Text = "Current password";
            // 
            // confirmChangePasswordButton
            // 
            this.confirmChangePasswordButton.Location = new System.Drawing.Point(162, 350);
            this.confirmChangePasswordButton.Name = "confirmChangePasswordButton";
            this.confirmChangePasswordButton.Size = new System.Drawing.Size(165, 61);
            this.confirmChangePasswordButton.TabIndex = 24;
            this.confirmChangePasswordButton.Text = "Confirm";
            this.confirmChangePasswordButton.UseVisualStyleBackColor = true;
            this.confirmChangePasswordButton.Click += new System.EventHandler(this.confirmChangePasswordButton_Click);
            // 
            // showAllPasswordsCheckBox
            // 
            this.showAllPasswordsCheckBox.AutoSize = true;
            this.showAllPasswordsCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showAllPasswordsCheckBox.Location = new System.Drawing.Point(269, 296);
            this.showAllPasswordsCheckBox.Name = "showAllPasswordsCheckBox";
            this.showAllPasswordsCheckBox.Size = new System.Drawing.Size(124, 21);
            this.showAllPasswordsCheckBox.TabIndex = 25;
            this.showAllPasswordsCheckBox.Text = "Show Passwords";
            this.showAllPasswordsCheckBox.UseVisualStyleBackColor = true;
            this.showAllPasswordsCheckBox.CheckedChanged += new System.EventHandler(this.showAllPasswordsCheckBox_CheckedChanged);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 451);
            this.Controls.Add(this.showAllPasswordsCheckBox);
            this.Controls.Add(this.confirmChangePasswordButton);
            this.Controls.Add(this.newPasswordConfirmValue);
            this.Controls.Add(this.newPasswordConfirmLabel);
            this.Controls.Add(this.newPasswordValue);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.currentPasswordValue);
            this.Controls.Add(this.currentPasswordLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePasswordForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox newPasswordConfirmValue;
        private System.Windows.Forms.Label newPasswordConfirmLabel;
        private System.Windows.Forms.TextBox newPasswordValue;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox currentPasswordValue;
        private System.Windows.Forms.Label currentPasswordLabel;
        private System.Windows.Forms.Button confirmChangePasswordButton;
        private System.Windows.Forms.CheckBox showAllPasswordsCheckBox;
    }
}