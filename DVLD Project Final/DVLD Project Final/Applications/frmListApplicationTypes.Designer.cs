namespace DVLD_Project_Final
{
    partial class frmListApplicationTypes
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvApplicationTypes = new System.Windows.Forms.DataGridView();
            this.coEditApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edtApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            this.coEditApplicationTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(286, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Application Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project_Final.Properties.Resources.Application_Types_5121;
            this.pictureBox1.Location = new System.Drawing.Point(323, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Project_Final.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(563, 492);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 49);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
            this.dgvApplicationTypes.AllowUserToAddRows = false;
            this.dgvApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvApplicationTypes.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationTypes.ContextMenuStrip = this.coEditApplicationTypes;
            this.dgvApplicationTypes.Location = new System.Drawing.Point(55, 183);
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.ReadOnly = true;
            this.dgvApplicationTypes.RowHeadersWidth = 51;
            this.dgvApplicationTypes.RowTemplate.Height = 24;
            this.dgvApplicationTypes.Size = new System.Drawing.Size(738, 303);
            this.dgvApplicationTypes.TabIndex = 3;
            // 
            // coEditApplicationTypes
            // 
            this.coEditApplicationTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.coEditApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edtApplicationTypesToolStripMenuItem});
            this.coEditApplicationTypes.Name = "coEditApplicationTypes";
            this.coEditApplicationTypes.Size = new System.Drawing.Size(231, 28);
            // 
            // edtApplicationTypesToolStripMenuItem
            // 
            this.edtApplicationTypesToolStripMenuItem.Name = "edtApplicationTypesToolStripMenuItem";
            this.edtApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.edtApplicationTypesToolStripMenuItem.Text = "Edte Application Types";
            this.edtApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.editApplicationTypesToolStripMenuItem_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(75, 508);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(30, 22);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "??";
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 553);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvApplicationTypes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmManageApplicationTypes";
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            this.coEditApplicationTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvApplicationTypes;
        private System.Windows.Forms.ContextMenuStrip coEditApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem edtApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.Label lblCount;
    }
}