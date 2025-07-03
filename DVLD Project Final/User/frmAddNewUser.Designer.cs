namespace DVLD_Project_Final
{
    partial class frmAddNewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btmSave = new System.Windows.Forms.Button();
            this.btmClose = new System.Windows.Forms.Button();
            this.btmPersonalInfo = new System.Windows.Forms.Button();
            this.btnLoginInfo = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLD_Project_Final.ctrlPersonCardWithFilter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(366, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New User";
            // 
            // btnNext
            // 
            this.btnNext.Image = global::DVLD_Project_Final.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(703, 568);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 35);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnSendBack_Click);
            // 
            // btmSave
            // 
            this.btmSave.Image = global::DVLD_Project_Final.Properties.Resources.Save_32;
            this.btmSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmSave.Location = new System.Drawing.Point(703, 620);
            this.btmSave.Name = "btmSave";
            this.btmSave.Size = new System.Drawing.Size(110, 42);
            this.btmSave.TabIndex = 3;
            this.btmSave.Text = "Save";
            this.btmSave.UseVisualStyleBackColor = true;
            // 
            // btmClose
            // 
            this.btmClose.Image = global::DVLD_Project_Final.Properties.Resources.Close_321;
            this.btmClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmClose.Location = new System.Drawing.Point(585, 620);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(112, 42);
            this.btmClose.TabIndex = 2;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            // 
            // btmPersonalInfo
            // 
            this.btmPersonalInfo.Location = new System.Drawing.Point(55, 54);
            this.btmPersonalInfo.Name = "btmPersonalInfo";
            this.btmPersonalInfo.Size = new System.Drawing.Size(108, 23);
            this.btmPersonalInfo.TabIndex = 5;
            this.btmPersonalInfo.Text = "Personal Info";
            this.btmPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnLoginInfo
            // 
            this.btnLoginInfo.Location = new System.Drawing.Point(179, 54);
            this.btnLoginInfo.Name = "btnLoginInfo";
            this.btnLoginInfo.Size = new System.Drawing.Size(108, 23);
            this.btnLoginInfo.TabIndex = 6;
            this.btnLoginInfo.Text = "Login Info";
            this.btnLoginInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(37, 83);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddNew = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(862, 531);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
          
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 697);
            this.Controls.Add(this.btnLoginInfo);
            this.Controls.Add(this.btmPersonalInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btmSave);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Name = "frmAddNewUser";
            this.Text = "Add New User";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Button btmSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btmPersonalInfo;
        private System.Windows.Forms.Button btnLoginInfo;
    }
}