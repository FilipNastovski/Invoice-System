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
    public partial class clientForm : Form
    {
        public List<Customer> customerList;
        public clientForm(List<Customer> customerList)
        {
            InitializeComponent();
            this.customerList = customerList;
        }

        private void newClientBtn_Click(object sender, EventArgs e)
        {
            clientCreatorForm clientCreatorForm = new clientCreatorForm();
            clientCreatorForm.ShowDialog();
            if (clientCreatorForm.DialogResult == DialogResult.OK)
            {

                customerList.Add(clientCreatorForm.newClient);
                reloadCustomerList();
            }
        }

        private void newMotoBtn_Click(object sender, EventArgs e)
        {
            Customer client = (Customer)clientsListLB.SelectedItem;
            if (client == null)
            {
                MessageBox.Show("Селектирајте клиент");
                return;
            }

            motorcycleCreatorForm motorcycleCreatorForm = new motorcycleCreatorForm();
            motorcycleCreatorForm.ShowDialog();
            if (motorcycleCreatorForm.DialogResult == DialogResult.OK)
            {
                client.addMotorcycle(motorcycleCreatorForm.newMotorcycle);
                reloadMotorcycleList();
            }
        }

        private void newServiceBtn_Click(object sender, EventArgs e)
        {
            Customer selectedClient = (Customer)clientsListLB.SelectedItem;
            if (selectedClient == null)
            {
                MessageBox.Show("Селектирајте клиент");
                return;
            }

            Motorcycle selectedMotorcycle = (Motorcycle)motorcycleListLB.SelectedItem;
            if (selectedMotorcycle == null)
            {
                MessageBox.Show("Селектирајте мотор");
                return;
            }

            serviceCreatorForm serviceCreatorForm = new serviceCreatorForm();
            serviceCreatorForm.ShowDialog();
            if (serviceCreatorForm.DialogResult == DialogResult.OK)
            {
                selectedMotorcycle.ServiceHistory.Add(serviceCreatorForm.createdService);
            }
            reloadServiceList();
        }

        private void reloadServiceList()
        {
            Motorcycle selectedMotorcycle = (Motorcycle)motorcycleListLB.SelectedItem;
            BindingSource serviceBindingSource = new BindingSource();
            serviceBindingSource.DataSource = null;
            if (selectedMotorcycle != null)
            {
                serviceBindingSource.DataSource = selectedMotorcycle.ServiceHistory;
            }
            serviceListLb.DataSource = serviceBindingSource;

        }
        private void reloadCustomerList()
        {
            BindingSource customerBindingSource = new BindingSource();
            customerBindingSource.DataSource = this.customerList;
            clientsListLB.DataSource = customerBindingSource;
            reloadMotorcycleList();
        }

        private void reloadMotorcycleList()
        {
            if (clientsListLB.SelectedItem == null)
            {
                BindingSource motorcycleBindSource = new BindingSource();
                motorcycleListLB.DataSource = motorcycleBindSource;
                return;
            }
            Customer selectedCustomer = (Customer)clientsListLB.SelectedItem;
            BindingSource motorcycleBindingSource = new BindingSource();
            motorcycleBindingSource.DataSource = selectedCustomer.Motorcycles;
            motorcycleListLB.DataSource = motorcycleBindingSource;
            reloadServiceList();
        }

        private void clientForm_Load(object sender, EventArgs e)
        {
            reloadCustomerList();
        }

        private void deleteClientBtn_Click(object sender, EventArgs e)
        {
            if (clientsListLB.SelectedItem != null)
            {
                this.customerList.Remove((Customer)clientsListLB.SelectedItem);
                reloadCustomerList();
                reloadMotorcycleList();
            }
        }

        private void changeClientBtn_Click(object sender, EventArgs e)
        {
            if (clientsListLB.SelectedItem == null) return;
            clientCreatorForm clientCreatorForm = new clientCreatorForm((Customer)clientsListLB.SelectedItem);
            clientCreatorForm.ShowDialog();
            reloadCustomerList();

        }

        private void clientsListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadMotorcycleList();
        }

        private void deleteMotoBtn_Click(object sender, EventArgs e)
        {
            Customer client = (Customer)clientsListLB.SelectedItem;
            if (client == null)
            {
                MessageBox.Show("Селектирајте клиент");
                return;
            }

            Motorcycle motoToDelete = (Motorcycle)motorcycleListLB.SelectedItem;
            if (motoToDelete == null)
            {
                MessageBox.Show("Селектирајте мотор");
                return;
            }

            client.Motorcycles.Remove(motoToDelete);
            reloadMotorcycleList();

        }

        private void changeMotoBtn_Click(object sender, EventArgs e)
        {
            if (motorcycleListLB.SelectedItem == null) return;
            Customer selectedClient = (Customer)clientsListLB.SelectedItem;
            if (selectedClient == null)
            {
                MessageBox.Show("Селектирајте клиент");
                return;
            }

            Motorcycle selectedMotorcycle = (Motorcycle)motorcycleListLB.SelectedItem;
            if (selectedMotorcycle == null)
            {
                MessageBox.Show("Селектирајте моторцикл");
                return;
            }

            motorcycleCreatorForm motorcycleCreatorForm = new motorcycleCreatorForm(selectedMotorcycle);
            motorcycleCreatorForm.ShowDialog();
            reloadMotorcycleList();
        }

        private void deleteServiceBtn_Click(object sender, EventArgs e)
        {
            Customer selectedClient = (Customer)clientsListLB.SelectedItem;
            if (selectedClient == null)
            {
                MessageBox.Show("Селектирајте клиент");
                return;
            }

            Motorcycle selectedMotorcycle = (Motorcycle)motorcycleListLB.SelectedItem;
            if (selectedMotorcycle == null)
            {
                MessageBox.Show("Селектирајте мотор");
                return;
            }

            Service selectedService = (Service)serviceListLb.SelectedItem;
            if (selectedService == null)
            {
                MessageBox.Show("Селектирајте сервис");
                return;
            }

            selectedMotorcycle.ServiceHistory.Remove(selectedService);
            reloadServiceList();
        }

        private void motorcycleListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadServiceList();
        }
    }
}
