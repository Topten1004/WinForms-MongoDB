using LoginFormDataAccess.DataAccess;
using LoginFormDataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormUI
{
    public partial class ChangePasswordForm : Form
    {
        UserModel currentUser = new UserModel();
        LoginDataAccess db = new LoginDataAccess();
        ChangeUserInformationForm userForm;

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        public void SetUser(object sender, string userId)
        {
            currentUser = db.GetUserFromId(userId);
            userForm = sender as ChangeUserInformationForm;
        }

        private void confirmChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (ValidateFormInput())
            {
                currentUser.Password = newPasswordConfirmValue.Text;
                db.UpdateUser(currentUser);
                MessageBox.Show("Password was changed.");
                this.Close();
            }
            else
            {
                currentPasswordValue.Clear();
                newPasswordValue.Clear();
                newPasswordConfirmValue.Clear();
            }
        }

        private bool ValidateFormInput()
        {
            bool output = false;

            if (currentPasswordValue.Text == currentUser.Password)
            {
                if (newPasswordValue.Text == newPasswordConfirmValue.Text)
                {
                    output = true;
                }
                else
                {
                    MessageBox.Show("New passwords do not match.");
                }
            }
            else
            {
                MessageBox.Show("Invalid password.");
            }

            return output;
        }

        private void showAllPasswordsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            currentPasswordValue.PasswordChar = showAllPasswordsCheckBox.Checked ? '\0' : '*';
            newPasswordValue.PasswordChar = showAllPasswordsCheckBox.Checked ? '\0' : '*';
            newPasswordConfirmValue.PasswordChar = showAllPasswordsCheckBox.Checked ? '\0' : '*';
        }

        private void ChangePasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userForm.FillUserInformation(currentUser);
            userForm.Show();
        }
    }
}
