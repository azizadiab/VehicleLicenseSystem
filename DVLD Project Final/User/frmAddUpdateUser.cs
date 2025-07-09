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
    public partial class frmAddUpdateUser : Form
    {

       public enum enMode { AddNew = 0, Update = 1}
        private enMode _Mode;
        private int _UserID = -1;
        clsUser _User;

        public frmAddUpdateUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;

        }




        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;

        }


        private void _ResetDefualtValues()
        {
            if(_Mode==enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();
                tpLoginInfo.Enabled = false;

                ctrlPersonCardWithFilter1.FilterFocus();
            }else
            {
                lblTitle.Text = "Update User";
                this.Text = "Update User";
                tpLoginInfo.Enabled = true;
                btnSave.Enabled = false;
              

            }
          
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;
        }


        private void _LoadData()
        {

            _User = clsUser.FindByUserID(_UserID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            if(_User==null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }
            llUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.UserID);

        }


        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ctrlPersonCardWithFilter1.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _User.UserID = ctrlPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = chkIsActive.Checked;

            if (_User.Save())
            {


                MessageBox.Show("Data Saved Successfully.", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if(_Mode==enMode.Update)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                return;
            }
            //incase of add new mode.
            if(ctrlPersonCardWithFilter1.PersonID !=-1)
            {
                if(clsUser.isUserExistForPersonID(ctrlPersonCardWithFilter1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.",
                    "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];

                }

            }



            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();

            }
        }

       
    }
}
