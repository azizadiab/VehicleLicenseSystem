using DVLD_Buisness;
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
    public partial class frmShowPersonInfo : Form
    {

        public frmShowPersonInfo(int PersonID)
        {
            InitializeComponent();
            ctPersonCard1.LoadPersonInfo(PersonID);
        }

        public frmShowPersonInfo(string NationalNo)
        {
            InitializeComponent();
            ctPersonCard1.LoadPersonInfo(NationalNo);
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
