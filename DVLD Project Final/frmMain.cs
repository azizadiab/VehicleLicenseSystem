using System;
using System.Data;
using System.Windows.Forms;
using DVLD_Buisness;

namespace DVLD_Project_Final
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            Form frm = new frmListPeople();
            frm.ShowDialog();

        }


        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {


         
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageTestTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
