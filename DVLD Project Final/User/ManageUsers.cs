using DVLD_Buisness;
using System;
using System.Collections;
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
    public partial class frmManageUsers : Form
    {
        private static DataTable _dtAllUser;


        private int _PersonID;


        public frmManageUsers(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;


        }

        private void _RefreshContactsList()
        {
           _dtAllUser = clsUser.GetAllUsers();
       
            dgvUsers.DataSource = _dtAllUser;
            coFilterBy.SelectedIndex = 0;

        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _dtAllUser = clsUser.GetAllUsers();
            dgvUsers.DataSource = _dtAllUser;
            coFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = "#Record :" + dgvUsers.Rows.Count.ToString();
            if(dgvUsers.Rows.Count>0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 100;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 100;

                dgvUsers.Columns[2].HeaderText = "Full Name";
                dgvUsers.Columns[2].Width = 200;

                dgvUsers.Columns[3].HeaderText = "UserName";
                dgvUsers.Columns[3].Width = 120;

              
            }

        }

        private void coFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                coIsActive.Visible = true;
                coIsActive.Focus();
                coIsActive.SelectedIndex = 0;

            }
            else
            {
                txtFilterValue.Visible = (coFilterBy.Text != "None");
                coIsActive.Visible = false;
            }
          
            txtFilterValue.Text = "";
            txtFilterValue.Focus();


        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch(coFilterBy.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "UserName":
                    FilterColumn = "UserName";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if(txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {

                //Reset the filters in case nothing selected or filter value conains nothing.
                _dtAllUser.DefaultView.RowFilter = "";
                lblRecordsCount.Text = "# Record :" + dgvUsers.Rows.Count.ToString();
                return;

            }
            if(FilterColumn != "UserName" && FilterColumn != "FullName")

                _dtAllUser.DefaultView.RowFilter = string.Format("[{0}]= {1}", FilterColumn, txtFilterValue.Text.Trim());
            else

                _dtAllUser.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());


            lblRecordsCount.Text = "# Record :" + _dtAllUser.Rows.Count.ToString();

        }


        private void coIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = coIsActive.Text;
            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }

            if(FilterValue=="All")
            {
                _dtAllUser.DefaultView.RowFilter = " ";
            }else
            {
                //in this case we deal with numbers not string.
                _dtAllUser.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);
            }
            lblRecordsCount.Text = "# Record :" + _dtAllUser.Rows.Count.ToString();
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {

            
            //if (int.TryParse(txtFilterValue.Text, out int SelectPersonId ))
            //{
            //    MessageBox.Show("Please enter a valid Person ID.");
            //    return;
            //}

            frmAddNewUser frm = new frmAddNewUser();
           frm.DataBack+= frmAddNewUser_DataBack;
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }

        private void frmAddNewUser_DataBack(Object Sender, int PersonID)
        {

            _RefreshContactsList();
        }

        private void ctmsAddNewUser_Click(object sender, EventArgs e)
        {

        }

        private void ctmsEdit_Click(object sender, EventArgs e)
        {
            frmUpdateUser frm = new frmUpdateUser();
            frm.ShowDialog();
        }

        private void ctmsShowDetails_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            frmUserHnfo frm = new frmUserHnfo(UserID);
            frm.ShowDialog();
        }

       
    }
}
