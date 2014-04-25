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
    public partial class Dashboard : Form
    {

        private DBClient loginClient;
        private Customer user;
        private Player player;
        private String Username;

        public Dashboard(String uName)
        {

            Username = uName;
            loginClient = new DBClient();
            user = new Customer();
            player = new Player();
            user = this.loginClient.getCustomer(uName);
            player = this.loginClient.getPlayer(uName);
            InitializeComponent();
            this.usernameLbl.Text = user.getUserName().ToString();
            this.HealthLbl.Text = player.getVitality().ToString();
            this.SpeedLbl.Text = player.getSpeed().ToString();
            this.EXPLbl.Text = player.getExp().ToString();
            this.TotalPlayTimeLbl.Text = player.getPlaytime().ToString();
            this.ServerLbl.Text = player.getLastServer();



            //STILL TRACING THE LACK OF USER NAME BACK TO ITS SOURCE
            System.Diagnostics.Debug.WriteLine("Dashboard uName is: " + uName);


        }

        private void ChangePasswdBtn_Click(object sender, EventArgs e)
        {

            //MORE AND MORE AND MORE TESTING
            //STILL TRACING THE LACK OF USER NAME BACK TO ITS SOURCE
            //System.Diagnostics.Debug.WriteLine("Dashboard UserName is: " + user.getUserName());

            ChangePasswdDialog changePass = new ChangePasswdDialog(user.getUserName());
            changePass.ShowDialog();
            return;

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

            this.loginClient.closeConnection();
            Application.Exit();

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.loginClient.closeConnection();
            Application.Exit();

        }

        private void DeleteAcctBtn_Click(object sender, EventArgs e)
        {

            DialogResult deletion = MessageBox.Show("Are you sure you want to delete your account?  If you delete your account, it cannot be recovered.", "Account Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (deletion == DialogResult.No)
            {

                return;

            }

            else
            {

                this.loginClient.deleteAccount(Username, user.getEmailAddress());
                Application.Restart();

            }




        }

    }
}
