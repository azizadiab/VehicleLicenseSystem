using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project_Final
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> hendler = OnPersonSelected;
            if (hendler != null)
            {
                hendler(PersonID); // Raise the event with the parameter
            }
        }

        private bool _ShowAddNew = true;
        public bool ShowAddNew
        {
            get { return _ShowAddNew; }
            set { _ShowAddNew = value;
                btnAddNewPerson.Visible = _ShowAddNew;
            }
        }

        private bool _FilterEnable = true;
        public bool FilterEnabled
        {
            get { return _FilterEnable; }
            set { _FilterEnable = value;
                gbFilters.Enabled = _FilterEnable;
            }
        }

        private int _PersonID = -1;
        public int PersonID 
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public clsPerson selectPersonInfo
        {
            get { return ctrlPersonCard1.SelectPersonInfo; }
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            FindNow();
        }

        private void FindNow()
        {
            switch(cbFilterBy.Text)
            {

                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;
                case "National No":
                    ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text);
                    break;
                default:
                   
                    break;
            }

            if(OnPersonSelected !=null && FilterEnabled)
            {
                // Raise the event with a parameter
                OnPersonSelected(ctrlPersonCard1.PersonID);
            }

        }


        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

            private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 1;
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
           if(!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            FindNow();
        }

        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterValue.Text = " ";
            txtFilterValue.Focus();
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                e.Cancel = false; errorProvider1.SetError(txtFilterValue, null);
            }

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += DataEvent;
            frm.ShowDialog();
        }

        private void DataEvent(Object snder, int PersonID)
        {
            // Handle the data received

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }
    }

       
    }
