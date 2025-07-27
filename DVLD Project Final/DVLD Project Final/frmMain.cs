using System;
using System.Data;
using System.Windows.Forms;
using DVLD_Buisness;

namespace DVLD_Project_Final
{
    public partial class frmMain : Form
    {
       private frmLogin _frmLogin;
        
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }


        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListPeople();
            frm.ShowDialog();


        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageTestTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmListApplicationTypes();
            frm.ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void localLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // Form frm = new frmLocal();
          //  frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsers(-1);
            frm.ShowDialog();
        }

        private void currentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = 1;
            frmUserHnfo frm = new frmUserHnfo(UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void sigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();

        }
    }
}
