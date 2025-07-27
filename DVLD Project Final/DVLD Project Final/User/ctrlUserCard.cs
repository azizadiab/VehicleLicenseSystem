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
    public partial class ctrlUserCard : UserControl
    {
        private clsUser _User;

        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;

             _User = clsUser.FindByUserID(UserID);
            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with User ID: " + UserID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserInfo();

        }


        private void _FillUserInfo()
        {
            laUserID.Text = _User.UserID.ToString();
            laUserName.Text = _User.UserName;
            
            if (_User.IsActive)
            {
                laIsActive.Text = "Yes";
            }else
            {
                laIsActive.Text = "No";
            }

        }

        private void _ResetPersonInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();
            laUserID.Text = " [???]";
            laUserName.Text = "[???]";
            laIsActive.Text = "[???]";
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }
    }
}

