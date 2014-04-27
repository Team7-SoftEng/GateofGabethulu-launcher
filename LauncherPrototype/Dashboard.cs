using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Process gameProcess;
        private Customer user;
        private Player player;
        private String Username;
        private Int32 LauncherID;

        public Dashboard(String uName)
        {

            Username = uName;
            loginClient = new DBClient();
            user = new Customer();
            player = new Player();
            user = this.loginClient.getCustomer(uName);
            player = this.loginClient.getPlayer(uName);
            InitializeComponent();
            this.usernameLbl.Text = user.getUserName();
            this.HealthLbl.Text = player.getVitality().ToString();
            this.DefenseLbl.Text = player.getDefense().ToString();
            this.SpeedLbl.Text = player.getSpeed().ToString();
            this.EXPLbl.Text = player.getExp().ToString();
            this.TotalPlayTimeLbl.Text = player.getPlaytime().ToString();
            this.ServerLbl.Text = player.getLastServer();
            this.WelcomeLbl.Text = String.Concat(this.WelcomeLbl.Text, user.getFullName() + '!');

            System.Console.WriteLine("Vitality: " + player.getVitality());
        }

        private void ChangePasswdBtn_Click(object sender, EventArgs e)
        {

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

        private void PlayGameBtn_Click(object sender, EventArgs e)
        {

            LauncherID = Process.GetCurrentProcess().Id;
            Process gameProcess = new Process();
            gameProcess.StartInfo.FileName = "..\\..\\..\\..\\GateofGabethulu-game\\BuildTest.exe";
            gameProcess.StartInfo.Arguments = user.getUserName() + 
                                              " " + player.getAttack() +
                                              " " + player.getDefense() +
                                              " " + player.getVitality() +
                                              " " + player.getExp() +
                                              " " + LauncherID;
            this.Hide();
            gameProcess.Start();

        }

    }

}
