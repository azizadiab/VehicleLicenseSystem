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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD_Project_Final
{
    public partial class frmLogin : Form
    {
        clsUser _User;
        public frmLogin ()
        {
            InitializeComponent();

        }

       
        private void btnLogin_Click(object sender, EventArgs e)
        {

            
            clsUser User = clsUser.FindByUsernameAndPassword(txtUserName.Text.Trim(),
                                              txtPassword.Text.Trim());
            if(User != null)
            {
                if(chkRememberMe.Checked)
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("");
                }

                //incase the user is not active
                if (!User.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", 
                        "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    clsGlobal.CurrentUser = User;
                    this.Hide();
                    frmMain frm = new frmMain(this);
                    frm.ShowDialog();
                }

            }


            else
            {
                MessageBox.Show("Invalid Username/Password.\", \"Wrong Credintials\"," +
                    " MessageBoxButtons.OK, MessageBoxIcon.Error");
                txtUserName.Focus();

            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "";
            if(clsGlobal.GetStoredCredential(ref UserName))
            {
                txtUserName.Text = UserName;
               
                chkRememberMe.Checked = true;
            }else
            {
                chkRememberMe.Checked = false;
            }
        }
    }
}
