using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace DVLD_Project_Final
{
    public partial class frmListPeople : Form
    {


        public frmListPeople()
        {
            InitializeComponent();

        }

        private void _RefreshContactsList()
        {
            dataGridView1.DataSource = clsPerson.GetPeople();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            _RefreshContactsList();
        }

      

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            //frm.MdiParent = this;
            Form frmAddEditContact = new frmAddUpdatePerson();
            frmAddEditContact.Show();
            _RefreshContactsList();

        }

        private void ctnsDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you sure Delete this ID " +
               (int)dataGridView1.CurrentRow.Cells[0].Value) == DialogResult.OK) ;
            {
                if (clsPerson.DelectePerson((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Successfully.");
                    _RefreshContactsList();
                }
                else
                {
                    MessageBox.Show("Contact Not Deleted Successfully.");
                    _RefreshContactsList();
                }
            }
        }

        private void ctmsShowDetails_Click(object sender, EventArgs e)
        {
            Form frm = new frmPersonInformation((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshContactsList();
        }

        private void ctnEdit_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshContactsList();
        }

        private void ctnsAddNewPerson_Click(object sender, EventArgs e)
        {
            Form frmAddEditContact = new frmAddUpdatePerson();
            frmAddEditContact.Show();
            _RefreshContactsList();
        }
    }
}
