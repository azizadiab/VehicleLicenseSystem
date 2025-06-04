namespace DVLD_Project_Final
{
    partial class frmAddUpdatePerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lalFirst = new System.Windows.Forms.Label();
            this.lalSecond = new System.Windows.Forms.Label();
            this.lalThird = new System.Windows.Forms.Label();
            this.lalLast = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lalName = new System.Windows.Forms.Label();
            this.lalNationalNo = new System.Windows.Forms.Label();
            this.lalGendor = new System.Windows.Forms.Label();
            this.lalEmail = new System.Windows.Forms.Label();
            this.lalAddress = new System.Windows.Forms.Label();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lalDateOfBirth = new System.Windows.Forms.Label();
            this.lalPhone = new System.Windows.Forms.Label();
            this.lalCountry = new System.Windows.Forms.Label();
            this.btmSave = new System.Windows.Forms.Button();
            this.btmClose = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.dtpDateOfBrith = new System.Windows.Forms.DateTimePicker();
            this.coCountry = new System.Windows.Forms.ComboBox();
            this.ltSetImage = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.llPersonID = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lalFirst
            // 
            this.lalFirst.AutoSize = true;
            this.lalFirst.Location = new System.Drawing.Point(143, 120);
            this.lalFirst.Name = "lalFirst";
            this.lalFirst.Size = new System.Drawing.Size(45, 22);
            this.lalFirst.TabIndex = 0;
            this.lalFirst.Text = "First";
            // 
            // lalSecond
            // 
            this.lalSecond.AutoSize = true;
            this.lalSecond.Location = new System.Drawing.Point(368, 120);
            this.lalSecond.Name = "lalSecond";
            this.lalSecond.Size = new System.Drawing.Size(71, 22);
            this.lalSecond.TabIndex = 1;
            this.lalSecond.Text = "Second";
            // 
            // lalThird
            // 
            this.lalThird.AutoSize = true;
            this.lalThird.Location = new System.Drawing.Point(602, 120);
            this.lalThird.Name = "lalThird";
            this.lalThird.Size = new System.Drawing.Size(52, 22);
            this.lalThird.TabIndex = 2;
            this.lalThird.Text = "Third";
            // 
            // lalLast
            // 
            this.lalLast.AutoSize = true;
            this.lalLast.Location = new System.Drawing.Point(787, 120);
            this.lalLast.Name = "lalLast";
            this.lalLast.Size = new System.Drawing.Size(44, 22);
            this.lalLast.TabIndex = 3;
            this.lalLast.Text = "Last";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(123, 169);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(124, 28);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(341, 166);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(124, 28);
            this.txtSecondName.TabIndex = 5;
            this.txtSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point(577, 166);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(124, 28);
            this.txtThirdName.TabIndex = 6;
            this.txtThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(760, 166);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(124, 28);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // lalName
            // 
            this.lalName.AutoSize = true;
            this.lalName.Location = new System.Drawing.Point(15, 169);
            this.lalName.Name = "lalName";
            this.lalName.Size = new System.Drawing.Size(54, 22);
            this.lalName.TabIndex = 8;
            this.lalName.Text = "name";
            // 
            // lalNationalNo
            // 
            this.lalNationalNo.AutoSize = true;
            this.lalNationalNo.Location = new System.Drawing.Point(15, 242);
            this.lalNationalNo.Name = "lalNationalNo";
            this.lalNationalNo.Size = new System.Drawing.Size(99, 22);
            this.lalNationalNo.TabIndex = 9;
            this.lalNationalNo.Text = "NationalNo";
            // 
            // lalGendor
            // 
            this.lalGendor.AutoSize = true;
            this.lalGendor.Location = new System.Drawing.Point(15, 315);
            this.lalGendor.Name = "lalGendor";
            this.lalGendor.Size = new System.Drawing.Size(70, 22);
            this.lalGendor.TabIndex = 10;
            this.lalGendor.Text = "Gendor";
            // 
            // lalEmail
            // 
            this.lalEmail.AutoSize = true;
            this.lalEmail.Location = new System.Drawing.Point(15, 388);
            this.lalEmail.Name = "lalEmail";
            this.lalEmail.Size = new System.Drawing.Size(54, 22);
            this.lalEmail.TabIndex = 11;
            this.lalEmail.Text = "Email";
            // 
            // lalAddress
            // 
            this.lalAddress.AutoSize = true;
            this.lalAddress.Location = new System.Drawing.Point(15, 460);
            this.lalAddress.Name = "lalAddress";
            this.lalAddress.Size = new System.Drawing.Size(76, 22);
            this.lalAddress.TabIndex = 12;
            this.lalAddress.Text = "Address";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Location = new System.Drawing.Point(123, 242);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(124, 28);
            this.txtNationalNo.TabIndex = 13;
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(577, 286);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(124, 28);
            this.txtPhone.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(123, 388);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(124, 28);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validting);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(208, 457);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(446, 109);
            this.txtAddress.TabIndex = 19;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(123, 315);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(69, 26);
            this.rbMale.TabIndex = 20;
            this.rbMale.TabStop = true;
            this.rbMale.Tag = "1";
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.Click += new System.EventHandler(this.rbMale_Clicked);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(208, 315);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(90, 26);
            this.rbFemale.TabIndex = 21;
            this.rbFemale.TabStop = true;
            this.rbFemale.Tag = "2";
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.Click += new System.EventHandler(this.rbFemale_Clicked);
            // 
            // lalDateOfBirth
            // 
            this.lalDateOfBirth.AutoSize = true;
            this.lalDateOfBirth.Location = new System.Drawing.Point(433, 220);
            this.lalDateOfBirth.Name = "lalDateOfBirth";
            this.lalDateOfBirth.Size = new System.Drawing.Size(104, 22);
            this.lalDateOfBirth.TabIndex = 22;
            this.lalDateOfBirth.Text = "DateOfBirth";
            // 
            // lalPhone
            // 
            this.lalPhone.AutoSize = true;
            this.lalPhone.Location = new System.Drawing.Point(470, 289);
            this.lalPhone.Name = "lalPhone";
            this.lalPhone.Size = new System.Drawing.Size(62, 22);
            this.lalPhone.TabIndex = 23;
            this.lalPhone.Text = "Phone";
            // 
            // lalCountry
            // 
            this.lalCountry.AutoSize = true;
            this.lalCountry.Location = new System.Drawing.Point(463, 355);
            this.lalCountry.Name = "lalCountry";
            this.lalCountry.Size = new System.Drawing.Size(73, 22);
            this.lalCountry.TabIndex = 24;
            this.lalCountry.Text = "Country";
            // 
            // btmSave
            // 
            this.btmSave.Location = new System.Drawing.Point(543, 613);
            this.btmSave.Name = "btmSave";
            this.btmSave.Size = new System.Drawing.Size(93, 32);
            this.btmSave.TabIndex = 25;
            this.btmSave.Text = "Save";
            this.btmSave.UseVisualStyleBackColor = true;
            this.btmSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btmClose
            // 
            this.btmClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btmClose.Location = new System.Drawing.Point(372, 613);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(93, 32);
            this.btmClose.TabIndex = 26;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Red;
            this.lblMode.Location = new System.Drawing.Point(395, 41);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(225, 32);
            this.lblMode.TabIndex = 28;
            this.lblMode.Text = "Add New Person";
            // 
            // dtpDateOfBrith
            // 
            this.dtpDateOfBrith.Location = new System.Drawing.Point(577, 212);
            this.dtpDateOfBrith.MaxDate = new System.DateTime(2025, 11, 1, 0, 0, 0, 0);
            this.dtpDateOfBrith.MinDate = new System.DateTime(2007, 4, 29, 0, 0, 0, 0);
            this.dtpDateOfBrith.Name = "dtpDateOfBrith";
            this.dtpDateOfBrith.Size = new System.Drawing.Size(249, 28);
            this.dtpDateOfBrith.TabIndex = 0;
            this.dtpDateOfBrith.Value = new System.DateTime(2007, 5, 1, 0, 0, 0, 0);
            // 
            // coCountry
            // 
            this.coCountry.FormattingEnabled = true;
            this.coCountry.Location = new System.Drawing.Point(563, 355);
            this.coCountry.Name = "coCountry";
            this.coCountry.Size = new System.Drawing.Size(151, 30);
            this.coCountry.TabIndex = 31;
            // 
            // ltSetImage
            // 
            this.ltSetImage.AutoSize = true;
            this.ltSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltSetImage.Location = new System.Drawing.Point(917, 521);
            this.ltSetImage.Name = "ltSetImage";
            this.ltSetImage.Size = new System.Drawing.Size(90, 22);
            this.ltSetImage.TabIndex = 32;
            this.ltSetImage.TabStop = true;
            this.ltSetImage.Text = "Set Image";
            this.ltSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // llPersonID
            // 
            this.llPersonID.AutoSize = true;
            this.llPersonID.Location = new System.Drawing.Point(28, 63);
            this.llPersonID.Name = "llPersonID";
            this.llPersonID.Size = new System.Drawing.Size(84, 22);
            this.llPersonID.TabIndex = 33;
            this.llPersonID.Text = "PersonID";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.Red;
            this.lblPersonID.Location = new System.Drawing.Point(163, 63);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(40, 22);
            this.lblPersonID.TabIndex = 34;
            this.lblPersonID.Text = "???";
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Image = global::DVLD_Project_Final.Properties.Resources.Male_512;
            this.pbPersonImage.Location = new System.Drawing.Point(883, 269);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(193, 232);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonImage.TabIndex = 27;
            this.pbPersonImage.TabStop = false;
            this.pbPersonImage.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemoveImage.Location = new System.Drawing.Point(917, 580);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(129, 22);
            this.llRemoveImage.TabIndex = 36;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove Image";
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // frmAddUpdatePerson
            // 
            this.AcceptButton = this.btmSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btmClose;
            this.ClientSize = new System.Drawing.Size(1135, 653);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.llRemoveImage);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.llPersonID);
            this.Controls.Add(this.ltSetImage);
            this.Controls.Add(this.coCountry);
            this.Controls.Add(this.dtpDateOfBrith);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.btmSave);
            this.Controls.Add(this.lalCountry);
            this.Controls.Add(this.lalPhone);
            this.Controls.Add(this.lalDateOfBirth);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lalLast);
            this.Controls.Add(this.lalThird);
            this.Controls.Add(this.lalSecond);
            this.Controls.Add(this.lalFirst);
            this.Controls.Add(this.lalAddress);
            this.Controls.Add(this.lalEmail);
            this.Controls.Add(this.lalGendor);
            this.Controls.Add(this.lalNationalNo);
            this.Controls.Add(this.lalName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNationalNo);
            this.Controls.Add(this.txtThirdName);
            this.Controls.Add(this.txtPhone);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdatePerson";
            this.Text = "AddUpdatePerson";
            this.Load += new System.EventHandler(this.frmAddNewPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalFirst;
        private System.Windows.Forms.Label lalSecond;
        private System.Windows.Forms.Label lalThird;
        private System.Windows.Forms.Label lalLast;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lalName;
        private System.Windows.Forms.Label lalNationalNo;
        private System.Windows.Forms.Label lalGendor;
        private System.Windows.Forms.Label lalEmail;
        private System.Windows.Forms.Label lalAddress;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lalDateOfBirth;
        private System.Windows.Forms.Label lalPhone;
        private System.Windows.Forms.Label lalCountry;
        private System.Windows.Forms.Button btmSave;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.DateTimePicker dtpDateOfBrith;
        private System.Windows.Forms.ComboBox coCountry;
        private System.Windows.Forms.LinkLabel ltSetImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label llPersonID;
        private System.Windows.Forms.LinkLabel llRemoveImage;
    }
}