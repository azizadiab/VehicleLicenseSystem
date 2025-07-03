namespace DVLD_Project_Final
{
    partial class frmUserHnfo
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
            this.lbUserDetails = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlUserCard1 = new DVLD_Project_Final.ctrlUserCard();
            this.ctrlPersonCard1 = new DVLD_Project_Final.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // lbUserDetails
            // 
            this.lbUserDetails.AutoSize = true;
            this.lbUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUserDetails.Location = new System.Drawing.Point(331, 32);
            this.lbUserDetails.Name = "lbUserDetails";
            this.lbUserDetails.Size = new System.Drawing.Size(144, 29);
            this.lbUserDetails.TabIndex = 0;
            this.lbUserDetails.Text = "User Details";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(683, 628);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.Location = new System.Drawing.Point(12, 435);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(774, 176);
            this.ctrlUserCard1.TabIndex = 4;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.AccessibleDescription = "";
            this.ctrlPersonCard1.AccessibleName = "";
            this.ctrlPersonCard1.Location = new System.Drawing.Point(9, 65);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(809, 295);
            this.ctrlPersonCard1.TabIndex = 3;
            // 
            // frmUserHnfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 695);
            this.Controls.Add(this.ctrlUserCard1);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbUserDetails);
            this.Name = "frmUserHnfo";
            this.Text = "frmUserInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserDetails;
        private System.Windows.Forms.Button btnClose;
        private ctrlPersonCard ctrlPersonCard1;
        private ctrlUserCard ctrlUserCard1;
    }
}