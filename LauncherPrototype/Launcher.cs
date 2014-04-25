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
    public partial class Launcher : Form
    {

        private DBClient login;
        private Crypto secureLogin;

        public Launcher()
        {

            InitializeComponent();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {

            if (login != null)
            {

                login.closeConnection();

            }

            Application.Exit();

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

            registerForm regForm = new registerForm();
            regForm.ShowDialog();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            login = new DBClient();
            secureLogin = new Crypto();

            if (String.Compare(usernameField.Text, "") == 0)
            {

                MessageBox.Show("ERROR: Please enter a username.", "Gate of Gabethulu Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            else if (login.verifyCredentials(usernameField.Text, secureLogin.generateSHA512PasswordHash(passwdField.Text)))
            {

                login.closeConnection();

                //STILL TRACING THE LACK OF USER NAME BACK TO ITS SOURCE  22222
                //THIS SEEMS TO WORK
                System.Diagnostics.Debug.WriteLine("Luncher usernameField.Text.ToSting() is: " + usernameField.Text.ToString());
                System.Diagnostics.Debug.WriteLine("Luncher usernameField.Text is: " + usernameField.Text);


                Dashboard mainWindow = new Dashboard(usernameField.Text.ToString());
                this.Visible = false;
                mainWindow.Show();

            }

            else
            {

                MessageBox.Show("ERROR:  Credentials not verified!", "Gate of Gabethulu Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.usernameField.Text = "";
                this.passwdField.Text = "";
                return;

            }

        }

        private void Launcher_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (login != null)
            {

                login.closeConnection();

            }

            Application.Exit();

        }

        private void passwdField_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {

                this.loginBtn_Click(sender, e);

            }

        }

    }
}
