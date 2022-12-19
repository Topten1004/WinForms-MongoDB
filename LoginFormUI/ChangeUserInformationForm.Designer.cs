namespace LoginFormUI
{
    partial class ChangeUserInformationForm
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
            this.userLoggedInLabel = new System.Windows.Forms.Label();
            this.userEmailValue = new System.Windows.Forms.TextBox();
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.userLastNameValue = new System.Windows.Forms.TextBox();
            this.userLastNameLabel = new System.Windows.Forms.Label();
            this.userFirstNameValue = new System.Windows.Forms.TextBox();
            this.userFirstNameLabel = new System.Windows.Forms.Label();
            this.updateUserInfoButton = new System.Windows.Forms.Button();
            this.doneUpdatingButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(33, 41);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(227, 47);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Logged in as:";
            // 
            // userLoggedInLabel
            // 
            this.userLoggedInLabel.AutoSize = true;
            this.userLoggedInLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLoggedInLabel.Location = new System.Drawing.Point(264, 49);
            this.userLoggedInLabel.Name = "userLoggedInLabel";
            this.userLoggedInLabel.Size = new System.Drawing.Size(102, 37);
            this.userLoggedInLabel.TabIndex = 3;
            this.userLoggedInLabel.Text = "<user>";
            // 
            // userEmailValue
            // 
            this.userEmailValue.Location = new System.Drawing.Point(170, 236);
            this.userEmailValue.Name = "userEmailValue";
            this.userEmailValue.Size = new System.Drawing.Size(167, 35);
            this.userEmailValue.TabIndex = 17;
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.Location = new System.Drawing.Point(45, 239);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(63, 30);
            this.userEmailLabel.TabIndex = 16;
            this.userEmailLabel.Text = "Email";
            // 
            // userLastNameValue
            // 
            this.userLastNameValue.Location = new System.Drawing.Point(170, 186);
            this.userLastNameValue.Name = "userLastNameValue";
            this.userLastNameValue.Size = new System.Drawing.Size(167, 35);
            this.userLastNameValue.TabIndex = 15;
            // 
            // userLastNameLabel
            // 
            this.userLastNameLabel.AutoSize = true;
            this.userLastNameLabel.Location = new System.Drawing.Point(45, 189);
            this.userLastNameLabel.Name = "userLastNameLabel";
            this.userLastNameLabel.Size = new System.Drawing.Size(112, 30);
            this.userLastNameLabel.TabIndex = 14;
            this.userLastNameLabel.Text = "Last Name";
            // 
            // userFirstNameValue
            // 
            this.userFirstNameValue.Location = new System.Drawing.Point(170, 136);
            this.userFirstNameValue.Name = "userFirstNameValue";
            this.userFirstNameValue.Size = new System.Drawing.Size(167, 35);
            this.userFirstNameValue.TabIndex = 13;
            // 
            // userFirstNameLabel
            // 
            this.userFirstNameLabel.AutoSize = true;
            this.userFirstNameLabel.Location = new System.Drawing.Point(45, 139);
            this.userFirstNameLabel.Name = "userFirstNameLabel";
            this.userFirstNameLabel.Size = new System.Drawing.Size(113, 30);
            this.userFirstNameLabel.TabIndex = 12;
            this.userFirstNameLabel.Text = "First Name";
            // 
            // updateUserInfoButton
            // 
            this.updateUserInfoButton.Location = new System.Drawing.Point(170, 315);
            this.updateUserInfoButton.Name = "updateUserInfoButton";
            this.updateUserInfoButton.Size = new System.Drawing.Size(147, 51);
            this.updateUserInfoButton.TabIndex = 19;
            this.updateUserInfoButton.Text = "Update Info";
            this.updateUserInfoButton.UseVisualStyleBackColor = true;
            this.updateUserInfoButton.Click += new System.EventHandler(this.updateUserInfoButton_Click);
            // 
            // doneUpdatingButton
            // 
            this.doneUpdatingButton.Location = new System.Drawing.Point(180, 406);
            this.doneUpdatingButton.Name = "doneUpdatingButton";
            this.doneUpdatingButton.Size = new System.Drawing.Size(123, 51);
            this.doneUpdatingButton.TabIndex = 18;
            this.doneUpdatingButton.Text = "Done";
            this.doneUpdatingButton.UseVisualStyleBackColor = true;
            this.doneUpdatingButton.Click += new System.EventHandler(this.doneUpdatingButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(371, 162);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(131, 84);
            this.changePasswordButton.TabIndex = 20;
            this.changePasswordButton.Text = "Change password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // ChangeUserInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 503);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.updateUserInfoButton);
            this.Controls.Add(this.doneUpdatingButton);
            this.Controls.Add(this.userEmailValue);
            this.Controls.Add(this.userEmailLabel);
            this.Controls.Add(this.userLastNameValue);
            this.Controls.Add(this.userLastNameLabel);
            this.Controls.Add(this.userFirstNameValue);
            this.Controls.Add(this.userFirstNameLabel);
            this.Controls.Add(this.userLoggedInLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ChangeUserInformationForm";
            this.Text = "Change User Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label userLoggedInLabel;
        private System.Windows.Forms.TextBox userEmailValue;
        private System.Windows.Forms.Label userEmailLabel;
        private System.Windows.Forms.TextBox userLastNameValue;
        private System.Windows.Forms.Label userLastNameLabel;
        private System.Windows.Forms.TextBox userFirstNameValue;
        private System.Windows.Forms.Label userFirstNameLabel;
        private System.Windows.Forms.Button updateUserInfoButton;
        private System.Windows.Forms.Button doneUpdatingButton;
        private System.Windows.Forms.Button changePasswordButton;
    }
}