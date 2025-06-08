using DVLD_Buisness;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace DVLD_Project_Final
{
    public partial class frmAddUpdatePerson : Form
    {

        private delegate void DataBackeEventHendel(object sender, int PersonId);
        private event DataBackeEventHendel DataBacke;
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1};

        private enMode _Mode;
        private int _PersonID = -1;
        clsPerson _Person;

        public frmAddUpdatePerson()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
          
            _Mode = enMode.Update;
            
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblMode.Text = "Update Person";
            }

            //set default image for the person.
            if (rbMale.Checked)
            {
                
                pbPersonImage.Image = Properties.Resources.Male_512;
            }
            else 
            {
            
                pbPersonImage.Image = Properties.Resources.Female_512;
            }

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBrith.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBrith.Value = dtpDateOfBrith.MaxDate;

            //should not allow adding age more than 100 years
            dtpDateOfBrith.MinDate = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            coCountry.SelectedIndex = coCountry.FindString("Jordan");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                coCountry.Items.Add(row["CountryName"]);

            }
        }

       
        private void _LoadData()
        {

            _Person = clsPerson.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            //the following code will not be executed if the person was not found
            lblMode.Text = "Update New Person";
            lblPersonID.Text = _PersonID.ToString();
            txtNationalNo.Text = _Person.NationalNo;
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            dtpDateOfBrith.Value =  _Person.DateOfBirth;
            txtAddress.Text = _Person.Address;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            rbMale.Checked = true;

          
            if(_Person.Gendor==0)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }

            coCountry.SelectedIndex = coCountry.FindString(_Person.CountryInfo.CountryName);

            if (_Person.ImagePath !="")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (_Person.ImagePath != "");
            
        }

        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_HandlePersonImage())
                return;

            int CountryID = clsCountry.Find(coCountry.Text).CountryID;

            _Person.NationalNo = txtNationalNo.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.DateOfBirth = dtpDateOfBrith.Value;
            _Person.Phone = txtPhone.Text;
            _Person.Address = txtAddress.Text;
            _Person.Email = txtEmail.Text;
            _Person.NationalityCountryID = CountryID;

            if(rbMale.Checked)
            {
                _Person.Gendor = (short)enGendor.Male;
            }else
            {
                _Person.Gendor = (short)enGendor.Female;
            }

                if (pbPersonImage.ImageLocation != null)
            {
                _Person.ImagePath = pbPersonImage.ImageLocation;
            }
            else
            {
                _Person.ImagePath = "";
            }


            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();

                //change form mode to update.
                _Mode = enMode.Update;
                lblMode.Text = "Edit Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Trigger the event to send data back to the caller form.
                DataBacke?.Invoke(this, _Person.PersonID);
                
            }

            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private bool _HandlePersonImage()
        {
            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image

            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {

                    //first we delete the old image from the folder in case there is any.
                    try
                    {
                        File.Delete(_Person.ImagePath);

                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later
                    }
                }
                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();
                    if (clsUtil.CopyImageToPRojectImagesFolder(SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copy Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                        return false;
                    }
                }
            }
            return true;
        }



        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

           
            if (rbMale.Checked)
            {

                pbPersonImage.Image = Properties.Resources.Male_512;
            }
            else
            {

                pbPersonImage.Image = Properties.Resources.Female_512;
            }

            llRemoveImage.Visible = false;

        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void rbMale_Clicked(object sender, EventArgs e)
        {
            //change the defualt image to male incase there is no image set.

            if (pbPersonImage.ImageLocation==null)
            {
                pbPersonImage.Image = Properties.Resources.Male_512;
            }
        }

        private void rbFemale_Clicked(object sender, EventArgs e)
        {
            //change the defualt image to female incase there is no image set.

            if (pbPersonImage.ImageLocation==null)
            {
                pbPersonImage.Image = Properties.Resources.Female_512;
            }
        }


        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }
        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required!!");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, "");
            }

            //Make sure the national number is not used by another person
            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.isPersonExist(txtNationalNo.Text))
            {
                e.Cancel = true;
                txtNationalNo.Focus();
                errorProvider1.SetError(txtNationalNo, " tne National No Exist Please Enter anthor No");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNo, null);
            }


        }

     
        private void txtEmail_Validting(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if(txtEmail.Text.Trim() == "")
            {
                return;
            }
            //Validate Email Formate
            if(!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
               
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
            
           

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            this.txtFirstName.Validating += ValidateEmptyTextBox;

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lalNationalNo_Click(object sender, EventArgs e)
        {

        }
    }







































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































}
