using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleApplication
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = tbUser.Text;
            string Password = tbUser.Text;

            if ((this.tbUser.Text=="User")&&(this.tbPassword.Text=="Admin"))
            {
                FrmMain Main = new FrmMain();
                Main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }

        }
    }
}
