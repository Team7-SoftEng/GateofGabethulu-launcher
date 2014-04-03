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
    public partial class registerForm : Form
    {

        private String inputBuff;

        public registerForm()
        {

            DBClient regClient = new DBClient();
            InitializeComponent();            

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void userNameField_TextChanged(object sender, EventArgs e)
        {

            inputBuff = userNameField.Text;





        }

    }

}
