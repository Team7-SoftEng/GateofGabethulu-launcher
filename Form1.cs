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
        public Launcher()
        {
            InitializeComponent();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

            registerForm regForm = new registerForm();
            regForm.ShowDialog();

        }
    }
}
