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
    public partial class ctPersonCard : UserControl
    {
   
        public ctPersonCard()

        {

            InitializeComponent();
        }

    
            public  void LoadPersonInfo(clsPerson Contact)
            {
               lbPersonId.Text = Contact.PersonID.ToString();
               lbName.Text = Contact.FirstName + " " + Contact.LastName;
                lbNationalNo.Text = Contact.NationalNo;
                lbPhone.Text = Contact.Phone;
                lbEmail.Text = Contact.Email;
                 lbBirthOfDate.Text = Contact.DateOfBirth.ToString();
                lbAddress.Text = Contact.Address;
               lbGendor.Text = Contact.Gendor.ToString();
              pictureBox1.Text = Contact.ImagePath;
               lbCountry.Text = clsCountry.Find(Contact.NationalityCountryID).CountryName;
            }

        



        private void ctPersonCard_Load(object sender, EventArgs e)
        {



        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void llBirthOfDate_Click(object sender, EventArgs e)
        {

        }
    }
}
