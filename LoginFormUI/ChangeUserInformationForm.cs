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
    public partial class ChangeUserInformationForm : Form
    {
        string userId;
        UserModel currentUser;
        UserProfileForm userForm;

        LoginDataAccess db = new LoginDataAccess();
        DataValidation dv = new DataValidation();

        public ChangeUserInformationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Logout button press. 
        /// Closes the form and opens the main login form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doneUpdatingButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetUser(object sender, string userId)
        {
            currentUser = db.GetUserFromId(userId);
            userForm = sender as UserProfileForm;
        }

        /// <summary>
        /// This method is used my the main login form to occupy the fields
        /// with the logged in users information. User id is stored globally
        /// for access to user via id.
        /// </summary>
        /// <param name="user">User logging/logged in.</param>
        public void FillUserInformation(UserModel user)
        {
            userId = user.Id;
            userLoggedInLabel.Text = user.Status;
            userEmailValue.Text = user.Email;
            userFirstNameValue.Text = user.Country;
        }

        /// <summary>
        /// Specifies what happens when the Update Info button is pressed.
        /// If form is invalid the users original information is displayed again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateUserInfoButton_Click(object sender, EventArgs e)
        {
            var user = db.GetUserFromId(userId);

            if (ValidateForm().isValid)
            {
                //user.FirstName = userFirstNameValue.Text;
                //user.LastName = userLastNameValue.Text;
                user.Email = userEmailValue.Text;

                db.UpdateUser(user);

                MessageBox.Show("User information successfully updated");
                this.Close();
            }
            else
            {
                MessageBox.Show($"Invalid form.\nThe following inputs were incorrect:\n{ValidateForm().message}");

                userEmailValue.Text= user.Email;
            }
        }

        private (bool isValid, string message) ValidateForm()
        {
            bool output = true;
            string outputMessage = "";


            if (userFirstNameValue.Text == "")
            {
                output = false;
                outputMessage += "First Name\n";
            }

            if (userLastNameValue.Text == "")
            {
                output = false;
                outputMessage += "Last Name\n";
            }

            if (!dv.ValidEmail(userEmailValue.Text))
            {
                output = false;
                outputMessage += "Email";
            }

            return (output, outputMessage);
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var passwordForm = new ChangePasswordForm();
            passwordForm.SetUser(this, userId);
            passwordForm.Show();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userForm.Show();
        }
    }
}
