using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_System
{
    public partial class clientCreatorForm : Form
    {
        public Customer newClient = null;
        private bool changeCustomer = false;
        public clientCreatorForm()
        {
            InitializeComponent();
        }

        public clientCreatorForm(Customer customerToChange)
        {
            InitializeComponent();
            changeCustomer = true;
            newClient = customerToChange;
            nameTB.Text = customerToChange.Name;
            lastNameTb.Text = customerToChange.LastName;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (changeCustomer)
            {
                newClient.Name = nameTB.Text;
                newClient.LastName = lastNameTb.Text;
                this.DialogResult = DialogResult.Cancel;
            }
            newClient = new Customer(nameTB.Text, lastNameTb.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            newClient = null;
            this.DialogResult = DialogResult.Cancel;
        }

        private void clientCreatorForm_Load(object sender, EventArgs e)
        {
        }
    }
}
