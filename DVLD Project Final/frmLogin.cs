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
      
  
        public frmLogin ()
        {
            InitializeComponent();

          

        }

      

     
        private void btnLogin_Click(object sender, EventArgs e)
        {

            clsUser User = clsUser.FindByUsernameAndPassword(textBox1.Text, textBox2.Text);

            if (User !=null)

            {
                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("UserName nof Found ");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
