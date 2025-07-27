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
    public partial class frmUserHnfo : Form
    {
        private int _UserID;
       
        public frmUserHnfo(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserHnfo_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void ctrlUserCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
