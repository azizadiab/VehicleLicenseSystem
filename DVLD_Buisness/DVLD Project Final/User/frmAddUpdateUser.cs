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

        public delegate void DataBackeEventHendel(object sender, int UserID);
        public event DataBackeEventHendel DataBack;


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
                btnSave.Enabled = true;
              

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
            //the following code will not be executed if the person was not found
            llUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = _User.IsActive;
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);

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

            _User.PersonID = ctrlPersonCardWithFilter1.PersonID;
            _User.UserName = txtUserName.Text;
            _User.Salt = clsSecurity.GenerateSalt();
            _User.PasswordHash = clsSecurity.Has256Password(txtPassword.Text, _User.Salt);
            _User.IsActive = chkIsActive.Checked;

            if (_User.Save())
            {

                llUserID.Text = _User.PersonID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update User";
                this.Text= "Update User";


                MessageBox.Show("Data Saved Successfully.", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlPersonCardWithFilter1.FilterEnabled = false;

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

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {

                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            if(string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                e.Cancel = true;

                errorProvider1.SetError(txtPassword, "Password cannot be blank");
            }
            else
            {
                e.Cancel = true;

                errorProvider1.SetError(txtPassword, null);
            }

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {

            if(string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "UserName cannot be blank");
            }else
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, null);
            }

            if(_Mode==enMode.AddNew)
            {
                if (clsUser.IsUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtUserName, null);
                }

            }
            else
            {
                //incase update make sure not to use anothers user name

                if (_User.UserName != txtUserName.Text.Trim())
                {

                    if (clsUser.IsUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        e.Cancel = false;
                        errorProvider1.SetError(txtUserName, null);
                    }
                }
            }

        }

        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {

        }
    }



}
