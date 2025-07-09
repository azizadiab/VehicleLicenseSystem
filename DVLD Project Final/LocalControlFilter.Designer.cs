namespace DVLD_Project_Final
{
    partial class frmLocalDrivingLiceneseApplication
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
            this.lalNewLocalDrivingLiceneseApplication = new System.Windows.Forms.Label();
            this.ctrlPersonCardWithFilter1 = new DVLD_Project_Final.ctrlPersonCardWithFilter();
            this.SuspendLayout();
            // 
            // lalNewLocalDrivingLiceneseApplication
            // 
            this.lalNewLocalDrivingLiceneseApplication.AutoSize = true;
            this.lalNewLocalDrivingLiceneseApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalNewLocalDrivingLiceneseApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lalNewLocalDrivingLiceneseApplication.Location = new System.Drawing.Point(198, 18);
            this.lalNewLocalDrivingLiceneseApplication.Name = "lalNewLocalDrivingLiceneseApplication";
            this.lalNewLocalDrivingLiceneseApplication.Size = new System.Drawing.Size(437, 29);
            this.lalNewLocalDrivingLiceneseApplication.TabIndex = 1;
            this.lalNewLocalDrivingLiceneseApplication.Text = "New Local Driving Licenese Application";
            // 
            // ctrlPersonCardWithFilter1
            // 
            
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(2, 50);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(860, 536);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.Load += new System.EventHandler(this.ctrlPersonCardWithFilter1_Load);
            // 
            // frmLocalDrivingLiceneseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 633);
            this.Controls.Add(this.lalNewLocalDrivingLiceneseApplication);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Name = "frmLocalDrivingLiceneseApplication";
            this.Text = "LocalDrivingLiceneseApplication";
            this.Load += new System.EventHandler(this.frmLocalControlFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lalNewLocalDrivingLiceneseApplication;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}