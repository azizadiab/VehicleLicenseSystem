namespace DVLD_Project_Final
{
    partial class frmPersonInformation
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
            this.button1 = new System.Windows.Forms.Button();
            this.ctPersonCard1 = new DVLD_Project_Final.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(528, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctPersonCard1
            // 
            this.ctPersonCard1.Location = new System.Drawing.Point(1, 35);
            this.ctPersonCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctPersonCard1.Name = "ctPersonCard1";
            this.ctPersonCard1.Size = new System.Drawing.Size(884, 375);
            this.ctPersonCard1.TabIndex = 1;
            this.ctPersonCard1.Load += new System.EventHandler(this.ctPersonCard1_Load_1);
            // 
            // frmPersonInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.ctPersonCard1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPersonInformation";
            this.Text = "Person Information";
            this.Load += new System.EventHandler(this.frmPersonInformation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ctrlPersonCard ctPersonCard1;
    }
}