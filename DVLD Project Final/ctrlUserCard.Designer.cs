namespace DVLD_Project_Final
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.laIsActive = new System.Windows.Forms.Label();
            this.laUserName = new System.Windows.Forms.Label();
            this.laUserID = new System.Windows.Forms.Label();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserId = new System.Windows.Forms.Label();
            this.llLoginInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laIsActive
            // 
            this.laIsActive.AutoSize = true;
            this.laIsActive.Location = new System.Drawing.Point(653, 113);
            this.laIsActive.Name = "laIsActive";
            this.laIsActive.Size = new System.Drawing.Size(21, 16);
            this.laIsActive.TabIndex = 5;
            this.laIsActive.Text = "??";
            // 
            // laUserName
            // 
            this.laUserName.AutoSize = true;
            this.laUserName.Location = new System.Drawing.Point(384, 113);
            this.laUserName.Name = "laUserName";
            this.laUserName.Size = new System.Drawing.Size(21, 16);
            this.laUserName.TabIndex = 4;
            this.laUserName.Text = "??";
            // 
            // laUserID
            // 
            this.laUserID.AutoSize = true;
            this.laUserID.Location = new System.Drawing.Point(135, 113);
            this.laUserID.Name = "laUserID";
            this.laUserID.Size = new System.Drawing.Size(21, 16);
            this.laUserID.TabIndex = 3;
            this.laUserID.Text = "??";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Location = new System.Drawing.Point(543, 113);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(57, 16);
            this.lbIsActive.TabIndex = 2;
            this.lbIsActive.Text = "IsActive:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(248, 113);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(76, 16);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "UserName:";
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(44, 113);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(52, 16);
            this.lbUserId.TabIndex = 0;
            this.lbUserId.Text = "UserID:";
            // 
            // llLoginInformation
            // 
            this.llLoginInformation.AutoSize = true;
            this.llLoginInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLoginInformation.Location = new System.Drawing.Point(24, 19);
            this.llLoginInformation.Name = "llLoginInformation";
            this.llLoginInformation.Size = new System.Drawing.Size(138, 20);
            this.llLoginInformation.TabIndex = 6;
            this.llLoginInformation.Text = "LoginIn formation";
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.llLoginInformation);
            this.Controls.Add(this.laUserID);
            this.Controls.Add(this.laIsActive);
            this.Controls.Add(this.lbUserId);
            this.Controls.Add(this.laUserName);
            this.Controls.Add(this.lbIsActive);
            this.Controls.Add(this.lbUserName);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(774, 188);
            this.Load += new System.EventHandler(this.ctrlUserCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.Label laIsActive;
        private System.Windows.Forms.Label laUserName;
        private System.Windows.Forms.Label laUserID;
        private System.Windows.Forms.Label llLoginInformation;
    }
}
