namespace DVLD_Project_Final
{
    partial class frmAddUpdateUser
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tnPersonInfoNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btmClose = new System.Windows.Forms.Button();
            this.tcUserInfo = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.llUserID = new System.Windows.Forms.Label();
            this.lalUserID = new System.Windows.Forms.Label();
            this.llConfirmPassword = new System.Windows.Forms.Label();
            this.llPassword = new System.Windows.Forms.Label();
            this.llUsuerName = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.ctrlPersonCardWithFilter1 = new DVLD_Project_Final.ctrlPersonCardWithFilter();
            this.tcUserInfo.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(361, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add New User";
            // 
            // tnPersonInfoNext
            // 
            this.tnPersonInfoNext.Image = global::DVLD_Project_Final.Properties.Resources.Next_32;
            this.tnPersonInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tnPersonInfoNext.Location = new System.Drawing.Point(691, 451);
            this.tnPersonInfoNext.Name = "tnPersonInfoNext";
            this.tnPersonInfoNext.Size = new System.Drawing.Size(110, 35);
            this.tnPersonInfoNext.TabIndex = 4;
            this.tnPersonInfoNext.Text = "Next";
            this.tnPersonInfoNext.UseVisualStyleBackColor = true;
            this.tnPersonInfoNext.Click += new System.EventHandler(this.tnPersonInfoNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DVLD_Project_Final.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(726, 606);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 42);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btmClose
            // 
            this.btmClose.Image = global::DVLD_Project_Final.Properties.Resources.Close_321;
            this.btmClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmClose.Location = new System.Drawing.Point(590, 606);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(112, 42);
            this.btmClose.TabIndex = 2;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.tpPersonInfo);
            this.tcUserInfo.Controls.Add(this.tpLoginInfo);
            this.tcUserInfo.Location = new System.Drawing.Point(12, 52);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(906, 528);
            this.tcUserInfo.TabIndex = 5;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonInfo.Controls.Add(this.tnPersonInfoNext);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(898, 499);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.llUserID);
            this.tpLoginInfo.Controls.Add(this.lalUserID);
            this.tpLoginInfo.Controls.Add(this.llConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.llPassword);
            this.tpLoginInfo.Controls.Add(this.llUsuerName);
            this.tpLoginInfo.Controls.Add(this.chkIsActive);
            this.tpLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.txtPassword);
            this.tpLoginInfo.Controls.Add(this.txtUserName);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(898, 499);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "LoginInfo";
            this.tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // llUserID
            // 
            this.llUserID.AutoSize = true;
            this.llUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llUserID.ForeColor = System.Drawing.Color.Maroon;
            this.llUserID.Location = new System.Drawing.Point(230, 63);
            this.llUserID.Name = "llUserID";
            this.llUserID.Size = new System.Drawing.Size(36, 20);
            this.llUserID.TabIndex = 8;
            this.llUserID.Text = "???";
            // 
            // lalUserID
            // 
            this.lalUserID.AutoSize = true;
            this.lalUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalUserID.Location = new System.Drawing.Point(33, 63);
            this.lalUserID.Name = "lalUserID";
            this.lalUserID.Size = new System.Drawing.Size(62, 20);
            this.lalUserID.TabIndex = 7;
            this.lalUserID.Text = "UserID";
            // 
            // llConfirmPassword
            // 
            this.llConfirmPassword.AutoSize = true;
            this.llConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llConfirmPassword.Location = new System.Drawing.Point(16, 224);
            this.llConfirmPassword.Name = "llConfirmPassword";
            this.llConfirmPassword.Size = new System.Drawing.Size(147, 20);
            this.llConfirmPassword.TabIndex = 6;
            this.llConfirmPassword.Text = "Confirm Password";
            // 
            // llPassword
            // 
            this.llPassword.AutoSize = true;
            this.llPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPassword.Location = new System.Drawing.Point(33, 169);
            this.llPassword.Name = "llPassword";
            this.llPassword.Size = new System.Drawing.Size(83, 20);
            this.llPassword.TabIndex = 5;
            this.llPassword.Text = "Password";
            // 
            // llUsuerName
            // 
            this.llUsuerName.AutoSize = true;
            this.llUsuerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llUsuerName.Location = new System.Drawing.Point(32, 114);
            this.llUsuerName.Name = "llUsuerName";
            this.llUsuerName.Size = new System.Drawing.Size(89, 20);
            this.llUsuerName.TabIndex = 4;
            this.llUsuerName.Text = "UserName";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(201, 269);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(76, 20);
            this.chkIsActive.TabIndex = 3;
            this.chkIsActive.Text = "IsActive";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(201, 217);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(100, 22);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(201, 165);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(201, 113);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 0;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(6, 21);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(855, 406);
            this.ctrlPersonCardWithFilter1.TabIndex = 5;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 697);
            this.Controls.Add(this.tcUserInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddUpdateUser";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.tcUserInfo.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button tnPersonInfoNext;
        private System.Windows.Forms.TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Label llConfirmPassword;
        private System.Windows.Forms.Label llPassword;
        private System.Windows.Forms.Label llUsuerName;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label llUserID;
        private System.Windows.Forms.Label lalUserID;
    }
}