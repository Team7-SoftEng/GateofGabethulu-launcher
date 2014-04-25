using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LauncherPrototype
{
    public partial class ChangePasswdDialog : Form
    {

        private DBClient pwdClient;
        private Crypto pwdCrypto;
        private String userName;
        private String cipherText;
        private bool passwdPasses;

        public ChangePasswdDialog(String uName)
        {

            userName = uName;
            passwdPasses = false;
            pwdClient = new DBClient();
            pwdCrypto = new Crypto();
            InitializeComponent();

        }

        private void PasswdCancelBtn_Click(object sender, EventArgs e)
        {

            this.pwdClient.closeConnection();
            this.Close();

        }

        private void ChangePasswdDialog_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.pwdClient.closeConnection();
            this.Close();

        }

        private void ChangePasswdBtn_Click(object sender, EventArgs e)
        {

            if (pwdClient.verifyCredentials(userName, pwdCrypto.generateSHA512PasswordHash(CurrentPasswdField.Text)))
            {



                if (passwdPasses == true)
                {

                    this.pwdClient.changePassword(userName, pwdCrypto.generateSHA512PasswordHash(ReenterNewPasswdField.Text));

                    //TESTING FOR ERRORS
                    //System.Diagnostics.Debug.WriteLine("" + pwdCrypto.generateSHA512PasswordHash(ReenterNewPasswdField.Text));
                    System.Diagnostics.Debug.WriteLine("userName is: " + userName);

                    MessageBox.Show("Your password has been successfully changed!", "Change Account Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.pwdClient.closeConnection();
                    this.Close();

                }

                else
                {

                    MessageBox.Show("ERROR: There is a problem with your input.  Please check your password entered and try again.", "Change Account Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }



            }else
            {
                 MessageBox.Show("ERROR:  INCORRECT CURRENT PASSWORD.", "Change Account Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


          

        }

        private void ReenterNewPasswdField_TextChanged(object sender, EventArgs e)
        {

            this.comparePasswords(NewPasswdField.Text, ReenterNewPasswdField.Text);

        }

        private void comparePasswords(String passwd1, String passwd2)
        {
            //needs another Check to see if the entered current password is correct as well
            if ((String.Compare(passwd1, passwd2) == 0) && (String.Compare(passwd1, "") != 0) && (String.Compare(passwd2, "") != 0))
            {

                this.passwdValidationLbl.Text = "Passwords Match!";
                this.passwdValidationLbl.ForeColor = Color.Lime;
                this.passwdValidationLbl.Visible = true;
                cipherText = this.pwdCrypto.generateSHA512PasswordHash(passwd2);
                passwdPasses = true;

            }

            else
            {

                this.passwdValidationLbl.Text = "Passwords do not match!";
                this.passwdValidationLbl.ForeColor = Color.Red;
                this.passwdValidationLbl.Visible = true;
                passwdPasses = false;

            }

            if ((passwd1.Length > 15) || (passwd2.Length > 15))
            {

                this.passwdValidationLbl.Text = "Password is too long!";
                this.passwdValidationLbl.ForeColor = Color.Red;
                this.passwdValidationLbl.Visible = true;
                passwdPasses = false;

            }

            if ((String.Compare(passwd1, "") == 0) || (String.Compare(passwd2, "") == 0))
            {

                this.passwdValidationLbl.Visible = false;
                passwdPasses = false;

            }

        }

    }
}
