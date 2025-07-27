using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project_Final
{
    public partial class frmFindPerson : Form
    {
        //Declare Delegate
        public delegate void DataBackEventHandler(Object Snder, int Person);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBacke;
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Trigger the event to send data back to the caller form
            DataBacke?.Invoke(this, ctrlPersonCardWithFilter1.PersonID);
        }

        private void ctrlPersonCardWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
