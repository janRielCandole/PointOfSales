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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnCloseCategory_Click(object sender, EventArgs e)
        {
            string MessageBoxContent = "Are you sure";
            DialogResult message = MessageBox.Show(MessageBoxContent);
            if (message == DialogResult.Yes)
            {
                Close();
            }
            else if (message == DialogResult.No)
            {
            }

        }
    }
}
