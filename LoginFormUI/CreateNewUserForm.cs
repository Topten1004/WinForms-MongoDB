using DeviceId;
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
    public partial class CreateNewUserForm : Form
    {
        LoginDataAccess db = new LoginDataAccess();
        DataValidation dv = new DataValidation();

        public CreateNewUserForm()
        {
            InitializeComponent();
        }

        private void CreateNewUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Show();
        }

        private void createNewUserButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm().isValid)
            {
                if (db.UsernameIsAvailable(newEmailValue.Text))
                {
                    string deviceId = new DeviceIdBuilder()
 .AddMachineName()
 .AddMacAddress()
 .ToString();
                    var newUser = new UserModel();
                    newUser.Password = newPasswordValue.Text;
                    newUser.Country = newCountryValue.Text;
                    newUser.Email = newEmailValue.Text;
                    newUser.Status = "Disable";
                    newUser.Access = new List<int>();
                    newUser.Found = new List<string>();
                    newUser.ComputerId = deviceId;
                    for(int i = 0; i <= 6; i++)
                    {
                        newUser.Access.Add(i);
                    }    

                    db.CreateUser(newUser);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("That username is already taken");
                }
             
            }
            else
            {
                MessageBox.Show($"Invalid form.\nThe following inputs were incorrect:\n{ValidateForm().message}");
            }
        }

        /// <summary>
        /// Simple validation of the inputs. 
        /// Outputs where there were errors if there were any.
        /// </summary>
        /// <returns></returns>
        private (bool isValid, string message) ValidateForm()
        {
            bool output = true;
            string outputMessage = "";

            if (newPasswordValue.Text.Length < 6 && newPasswordValue.Text != newConfirmPasswordValue.Text)
            {
                output = false;
                outputMessage += "Password\n";
            }

            if (newCountryValue.Text == "")
            {
                output = false;
                outputMessage += "Country\n";
            }

            if (newPasswordValue.Text != newConfirmPasswordValue.Text)
            {
                output = false;
                outputMessage += "Password not match\n" ;
            }

            if (!dv.ValidEmail(newEmailValue.Text))
            {
                output = false;
                outputMessage += "Email";
            }

            return (output, outputMessage);
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newPasswordValue.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
            newPasswordValue.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }
    }
}
