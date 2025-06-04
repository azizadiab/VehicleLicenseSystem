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
    public partial class frmPersonInformation : Form
    {
        int _Person ;

        public frmPersonInformation(int Id)
        {
            InitializeComponent();
            _Person = Id;
        }

        private void ctPersonCard1_Load(object sender, EventArgs e)
        {
            

            //clsBuisness Countect = clsBuisness.Find(_Person);
            //ctPersonCard1.LoadPersonInfo(Countect);
        }

        private void frmPersonInformation_Load(object sender, EventArgs e)
        {
            clsPerson Countect = clsPerson.Find(_Person);
            ctPersonCard1.LoadPersonInfo(Countect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
