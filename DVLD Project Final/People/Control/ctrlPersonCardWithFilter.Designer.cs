namespace DVLD_Project_Final
{
    partial class ctrlPersonCardWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lbFindBy = new System.Windows.Forms.Label();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCard1 = new DVLD_Project_Final.ctrlPersonCard();
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbFilterBy.Location = new System.Drawing.Point(95, 44);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(152, 24);
            this.cbFilterBy.TabIndex = 1;
           
            // 
            // lbFindBy
            // 
            this.lbFindBy.AutoSize = true;
            this.lbFindBy.Location = new System.Drawing.Point(6, 47);
            this.lbFindBy.Name = "lbFindBy";
            this.lbFindBy.Size = new System.Drawing.Size(52, 16);
            this.lbFindBy.TabIndex = 2;
            this.lbFindBy.Text = "Find By";
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.txtFilterValue);
            this.gbFilters.Controls.Add(this.btnAddNewPerson);
            this.gbFilters.Controls.Add(this.lbFindBy);
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.cbFilterBy);
            this.gbFilters.Location = new System.Drawing.Point(20, 20);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(781, 84);
            this.gbFilters.TabIndex = 7;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
           
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(284, 46);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(176, 22);
            this.txtFilterValue.TabIndex = 7;
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Image = global::DVLD_Project_Final.Properties.Resources.Add_Person_401;
            this.btnAddNewPerson.Location = new System.Drawing.Point(555, 34);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(41, 37);
            this.btnAddNewPerson.TabIndex = 5;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::DVLD_Project_Final.Properties.Resources.SearchPerson;
            this.btnFind.Location = new System.Drawing.Point(475, 34);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(48, 37);
            this.btnFind.TabIndex = 4;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.AccessibleDescription = "";
            this.ctrlPersonCard1.AccessibleName = "";
            this.ctrlPersonCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(20, 111);
            this.ctrlPersonCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(774, 298);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlPersonCardWithFilter";
            this.Size = new System.Drawing.Size(804, 431);
            this.Load += new System.EventHandler(this.ctrlPersonCardWithFilter_Load);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lbFindBy;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
