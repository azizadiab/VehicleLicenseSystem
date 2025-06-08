using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project_Final
{
    public partial class ctrlPersonCard : UserControl
    {

        private int _PersonID = -1;
        private clsPerson _Person;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectPersonInfo
        {
            get { return _Person; }
        }

        public ctrlPersonCard()

        {

            InitializeComponent();
        }

       public void LoadPersonInfo(int NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with Person ID: " + NationalNo.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo(_Person);
        }


        public void ResetPersonInfo()
        {
           
            _PersonID = -1;
            lbPersonId.Text = "[??]";
            lbNationalNo.Text = "[??]";
            lbName.Text = "[??]";
            lbAddress.Text = "[??]";
            llEmail.Text = "[??]";
            lbPhone.Text = "[??]";
            lbGendor.Text ="[??]";
            llBirthOfDate.Text = "[??]";
            llCountry.Text = "[??]";
            pictureBox1.Image = Properties.Resources.Male_512;


        }
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with Person ID: " + NationalNo.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo(_Person);
        }

        public void _LoadPersonImage()
        {
            if(_Person.Gendor==0)
            {
                pictureBox1.Image = Properties.Resources.Male_512;
            }else
            {
                pictureBox1.Image = Properties.Resources.Female_512;

            }
            string ImagePath = _Person.ImagePath;
            if(ImagePath != "" )
            {
                if(File.Exists(ImagePath))
                {
                    pictureBox1.ImageLocation = ImagePath;
                }else
                {
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void _FillPersonInfo(clsPerson _Person)
        {
            llEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lbPersonId.Text = _Person.PersonID.ToString();
            lbNationalNo.Text = _Person.NationalNo;
            lbName.Text = _Person.FullName;
            lbAddress.Text = _Person.Address;
            lbEmail.Text = _Person.Email;
            lbPhone.Text = _Person.Phone;
            lbGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";
            lbBirthOfDate.Text = _Person.DateOfBirth.ToShortDateString();
            lbCountry.Text = clsCountry.Find(_Person.NationalityCountryID).CountryName;
            _LoadPersonImage();

        }
        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

            //refresh
            LoadPersonInfo(_PersonID);
        }
    }
}
