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
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }

        private clsUser _User;

        public ctrlUserCard()
        {
            InitializeComponent();
        }

       

        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.FindByUserID(UserID);
            if (_User == null)
            {

                MessageBox.Show("No User with User ID: " + UserID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserInfo();

        }


        private void _FillUserInfo()
        {
            llLoginInformation.Enabled = true;
            laUserID.Text = _User.UserID.ToString();
            laUserName.Text = _User.UserName;
            laIsActive.Text = _User.IsActive.ToString();


        }
        private void ctrlUserCard_Load(object sender, EventArgs e)
        {

        }

        private void gbLoginInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}

