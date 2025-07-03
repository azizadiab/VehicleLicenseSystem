namespace DVLD_Project_Final
{
    partial class frmUpdateUser
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
            this.lbPersonInfo = new System.Windows.Forms.Label();
            this.lbLoginInfo = new System.Windows.Forms.Label();
            this.ctrlPersonCardWithFilter1 = new DVLD_Project_Final.ctrlPersonCardWithFilter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(309, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update User";
            // 
            // lbPersonInfo
            // 
            this.lbPersonInfo.AutoSize = true;
            this.lbPersonInfo.Location = new System.Drawing.Point(13, 58);
            this.lbPersonInfo.Name = "lbPersonInfo";
            this.lbPersonInfo.Size = new System.Drawing.Size(74, 16);
            this.lbPersonInfo.TabIndex = 1;
            this.lbPersonInfo.Text = "Person Info";
            // 
            // lbLoginInfo
            // 
            this.lbLoginInfo.AutoSize = true;
            this.lbLoginInfo.Location = new System.Drawing.Point(110, 58);
            this.lbLoginInfo.Name = "lbLoginInfo";
            this.lbLoginInfo.Size = new System.Drawing.Size(64, 16);
            this.lbLoginInfo.TabIndex = 2;
            this.lbLoginInfo.Text = "Login Info";
            this.lbLoginInfo.Click += new System.EventHandler(this.lbLoginInfo_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(0, 90);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddNew = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(859, 488);
            this.ctrlPersonCardWithFilter1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(648, 585);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(747, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 613);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.lbLoginInfo);
            this.Controls.Add(this.lbPersonInfo);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateUser";
            this.Text = "Update User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPersonInfo;
        private System.Windows.Forms.Label lbLoginInfo;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}