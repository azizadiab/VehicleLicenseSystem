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
    public partial class frmAddNewUser : Form
    {
        private int _UserID;


        public delegate void DataBackEventHandler(Object sender, int UserID);
        public event DataBackEventHandler DataBack;

        public frmAddNewUser()
        {
            InitializeComponent();
           
        }

        public frmAddNewUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;


        }

        private void btnSendBack_Click(object sender, EventArgs e)
        {
            bool UserExist = clsUser.IsUserExist(_UserID);
            MessageBox.Show("Checking PersonID: " + _UserID);
            
            if (UserExist)

            {
                MessageBox.Show("This Person ID already Exist");
               
            }
            else
            {
                MessageBox.Show("This Person ID not already Exist, Will send Back");

               
                
            }

            DataBack?.Invoke(this,_UserID);
        }

      
    }
}
