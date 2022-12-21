using DeviceId;
using LoginFormDataAccess.DataAccess;
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
    public partial class UserLoginForm : Form
    {
        LoginDataAccess db = new LoginDataAccess();
        public UserLoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On New User button press; hides the main window form and opens a new Create New User form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newUser = new CreateNewUserForm();
            newUser.Show();
        }

        /// <summary>
        /// Specifies what happends when the login button is pressed.
        /// Validates the form and then the input username and password, 
        /// first against the database and then, if a user was found, against the user it found.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Get Device code
            string deviceId = new DeviceIdBuilder()
.AddMachineName()
.AddMacAddress()
.ToString();

            if (ValidateForm())
            {
                if (db.GetUserFromUsername(usernameValue.Text).isValid)
                {
                    var user = db.GetUserFromUsername(usernameValue.Text).user;

                    // Password Check
                    if (db.ValidatePassword(user, passwordValue.Text))
                    {
                        // Device Id check
                        if(db.ValidateComputerId(user, deviceId))
                        {
                            if (user.Status != "Disable")
                            {
                                this.Hide();
                                usernameValue.Clear();
                                passwordValue.Clear();
                                var userLoggedIn = new UserProfileForm();
                                userLoggedIn.SetUser(this, user.Id);
                                userLoggedIn.Show();
                            }
                            else
                            {
                                MessageBox.Show("Please contact support center");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Computer Id doesn't not match");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username");
                }
            }
            else
            {
                MessageBox.Show("Form input invalid");
            }
            
        }

        /// <summary>
        /// Simple method to validate the form against empty inputs.
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            bool output = true;

            if (usernameValue.Text == "")
            {
                output = false;
            }

            if (passwordValue.Text == "")
            {
                output = false;
            }

            return output;
        }
    }
}
