using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project_Final
{
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        private void lbLoginInfo_Click(object sender, EventArgs e)
        {
            frmLoginInfo frm = new frmLoginInfo();
            frm.ShowDialog();
        }
    }
}
