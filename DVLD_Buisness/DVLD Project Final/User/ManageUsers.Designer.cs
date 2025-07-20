namespace DVLD_Project_Final
{
    partial class frmManageUsers
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
            this.lalManageUsers = new System.Windows.Forms.Label();
            this.lalFilterBy = new System.Windows.Forms.Label();
            this.coFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsShangPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctmsSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coIsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lalManageUsers
            // 
            this.lalManageUsers.AutoSize = true;
            this.lalManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.lalManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalManageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lalManageUsers.Location = new System.Drawing.Point(317, 110);
            this.lalManageUsers.Name = "lalManageUsers";
            this.lalManageUsers.Size = new System.Drawing.Size(169, 29);
            this.lalManageUsers.TabIndex = 0;
            this.lalManageUsers.Text = "Manage Users";
            // 
            // lalFilterBy
            // 
            this.lalFilterBy.AutoSize = true;
            this.lalFilterBy.Location = new System.Drawing.Point(12, 144);
            this.lalFilterBy.Name = "lalFilterBy";
            this.lalFilterBy.Size = new System.Drawing.Size(55, 16);
            this.lalFilterBy.TabIndex = 2;
            this.lalFilterBy.Text = "Filter By";
            // 
            // coFilterBy
            // 
            this.coFilterBy.FormattingEnabled = true;
            this.coFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "User Name",
            "Person ID",
            "Full Name",
            "Is Active"});
            this.coFilterBy.Location = new System.Drawing.Point(78, 141);
            this.coFilterBy.Name = "coFilterBy";
            this.coFilterBy.Size = new System.Drawing.Size(121, 24);
            this.coFilterBy.TabIndex = 3;
            this.coFilterBy.SelectedIndexChanged += new System.EventHandler(this.coFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(205, 143);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(117, 22);
            this.txtFilterValue.TabIndex = 4;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 191);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(893, 253);
            this.dgvUsers.TabIndex = 6;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRecordsCount.Location = new System.Drawing.Point(24, 468);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(82, 20);
            this.lblRecordsCount.TabIndex = 7;
            this.lblRecordsCount.Text = "#Record :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsShowDetails,
            this.toolStripSeparator1,
            this.ctmsAddNewUser,
            this.ctmsEdit,
            this.ctmsDelete,
            this.ctmsShangPassword,
            this.toolStripSeparator2,
            this.ctmsSendEmail,
            this.ctmsPhoneCall});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 212);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ctmsShowDetails
            // 
            this.ctmsShowDetails.Name = "ctmsShowDetails";
            this.ctmsShowDetails.Size = new System.Drawing.Size(210, 24);
            this.ctmsShowDetails.Text = "Show Details";
            this.ctmsShowDetails.Click += new System.EventHandler(this.ctmsShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // ctmsAddNewUser
            // 
            this.ctmsAddNewUser.Name = "ctmsAddNewUser";
            this.ctmsAddNewUser.Size = new System.Drawing.Size(210, 24);
            this.ctmsAddNewUser.Text = "Add New User";
            this.ctmsAddNewUser.Click += new System.EventHandler(this.ctmsAddNewUser_Click);
            // 
            // ctmsEdit
            // 
            this.ctmsEdit.Name = "ctmsEdit";
            this.ctmsEdit.Size = new System.Drawing.Size(210, 24);
            this.ctmsEdit.Text = "Edit User";
            this.ctmsEdit.Click += new System.EventHandler(this.ctmsEdit_Click);
            // 
            // ctmsDelete
            // 
            this.ctmsDelete.Name = "ctmsDelete";
            this.ctmsDelete.Size = new System.Drawing.Size(210, 24);
            this.ctmsDelete.Text = "Delete";
            this.ctmsDelete.Click += new System.EventHandler(this.ctmsDelete_Click);
            // 
            // ctmsShangPassword
            // 
            this.ctmsShangPassword.Name = "ctmsShangPassword";
            this.ctmsShangPassword.Size = new System.Drawing.Size(210, 24);
            this.ctmsShangPassword.Text = "Shang Password";
            this.ctmsShangPassword.Click += new System.EventHandler(this.ctmsShangPassword_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // ctmsSendEmail
            // 
            this.ctmsSendEmail.Name = "ctmsSendEmail";
            this.ctmsSendEmail.Size = new System.Drawing.Size(210, 24);
            this.ctmsSendEmail.Text = "Send Email";
            // 
            // ctmsPhoneCall
            // 
            this.ctmsPhoneCall.Name = "ctmsPhoneCall";
            this.ctmsPhoneCall.Size = new System.Drawing.Size(210, 24);
            this.ctmsPhoneCall.Text = "Phone Call";
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSize = true;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Image = global::DVLD_Project_Final.Properties.Resources.Users_2_64;
            this.btnAddUser.Location = new System.Drawing.Point(698, 89);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(72, 72);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DVLD_Project_Final.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(311, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // coIsActive
            // 
            this.coIsActive.FormattingEnabled = true;
            this.coIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.coIsActive.Location = new System.Drawing.Point(205, 142);
            this.coIsActive.Name = "coIsActive";
            this.coIsActive.Size = new System.Drawing.Size(121, 24);
            this.coIsActive.TabIndex = 8;
            this.coIsActive.Visible = false;
            this.coIsActive.SelectedIndexChanged += new System.EventHandler(this.coIsActive_SelectedIndexChanged);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 496);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.coIsActive);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.coFilterBy);
            this.Controls.Add(this.lalFilterBy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lalManageUsers);
            this.Name = "frmManageUsers";
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalManageUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lalFilterBy;
        private System.Windows.Forms.ComboBox coFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctmsShowDetails;
        private System.Windows.Forms.ToolStripMenuItem ctmsAddNewUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctmsEdit;
        private System.Windows.Forms.ToolStripMenuItem ctmsDelete;
        private System.Windows.Forms.ToolStripMenuItem ctmsShangPassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctmsSendEmail;
        private System.Windows.Forms.ToolStripMenuItem ctmsPhoneCall;
        private System.Windows.Forms.ComboBox coIsActive;
    }
}