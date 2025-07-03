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

       
        public frmUserHnfo(int UserID)
        {
            InitializeComponent();

            ctrlPersonCard1.LoadPersonInfo(UserID);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
