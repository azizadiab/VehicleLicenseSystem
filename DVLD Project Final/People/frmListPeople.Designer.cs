namespace DVLD_Project_Final
{
    partial class frmListPeople
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmsShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctnsAddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.ctnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctnsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.ctnsSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.ctnsCallPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 411);
            this.dataGridView1.TabIndex = 0;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(340, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manager People";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmsShowDetails,
            this.toolStripMenuItem2,
            this.ctnsAddNewPerson,
            this.ctnEdit,
            this.ctnsDelete,
            this.toolStripMenuItem7,
            this.ctnsSendEmail,
            this.ctnsCallPhone});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 188);
            // 
            // ctmsShowDetails
            // 
            this.ctmsShowDetails.Name = "ctmsShowDetails";
            this.ctmsShowDetails.Size = new System.Drawing.Size(210, 24);
            this.ctmsShowDetails.Text = "Show Details";
            this.ctmsShowDetails.Click += new System.EventHandler(this.ctmsShowDetails_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 6);
            // 
            // ctnsAddNewPerson
            // 
            this.ctnsAddNewPerson.Name = "ctnsAddNewPerson";
            this.ctnsAddNewPerson.Size = new System.Drawing.Size(210, 24);
            this.ctnsAddNewPerson.Text = "Add New Person";
            this.ctnsAddNewPerson.Click += new System.EventHandler(this.ctnsAddNewPerson_Click);
            // 
            // ctnEdit
            // 
            this.ctnEdit.Name = "ctnEdit";
            this.ctnEdit.Size = new System.Drawing.Size(210, 24);
            this.ctnEdit.Text = "Edit";
            this.ctnEdit.Click += new System.EventHandler(this.ctnEdit_Click);
            // 
            // ctnsDelete
            // 
            this.ctnsDelete.Name = "ctnsDelete";
            this.ctnsDelete.Size = new System.Drawing.Size(210, 24);
            this.ctnsDelete.Text = "Delete";
            this.ctnsDelete.Click += new System.EventHandler(this.ctnsDelete_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(207, 6);
            // 
            // ctnsSendEmail
            // 
            this.ctnsSendEmail.Name = "ctnsSendEmail";
            this.ctnsSendEmail.Size = new System.Drawing.Size(210, 24);
            this.ctnsSendEmail.Text = "Send Email";
            // 
            // ctnsCallPhone
            // 
            this.ctnsCallPhone.Name = "ctnsCallPhone";
            this.ctnsCallPhone.Size = new System.Drawing.Size(210, 24);
            this.ctnsCallPhone.Text = "Call Phone";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddPerson.Image = global::DVLD_Project_Final.Properties.Resources.Add_Person_40;
            this.btnAddPerson.Location = new System.Drawing.Point(932, 161);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(117, 40);
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project_Final.Properties.Resources.People_64;
            this.pictureBox1.Location = new System.Drawing.Point(333, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 692);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListPeople";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctmsShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ctnsAddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem ctnEdit;
        private System.Windows.Forms.ToolStripMenuItem ctnsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem ctnsSendEmail;
        private System.Windows.Forms.ToolStripMenuItem ctnsCallPhone;
    }
}