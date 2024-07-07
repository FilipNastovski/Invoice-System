using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_System
{
    public partial class serviceForm : Form
    {
        public List<Service> allServicesList;
        public List<Customer> allCustomersList;
        public List<Service> filteredSericesList;
        public serviceForm(List<Customer> allCustomerList)
        {
            InitializeComponent();

            this.allCustomersList = allCustomerList;
            fetchAllServices();

            BindingSource allServicesBindingSource = new BindingSource();
            allServicesBindingSource.DataSource = allServicesList;
            allServicesLb.DataSource = allServicesBindingSource;
        }

        private void reloadServices()
        {
            BindingSource allServicesBindingSource = new BindingSource();
            fetchAllServices();
            allServicesBindingSource.DataSource = allServicesList;
            allServicesLb.DataSource = allServicesBindingSource;
        }

        private void serviceForm_Load(object sender, EventArgs e)
        {
            reloadServices();
        }

        private void fetchAllServices()
        {
            this.allServicesList = new List<Service>();
            foreach (Customer selCustomer in allCustomersList)
            {
                foreach (Motorcycle selMotorcycle in selCustomer.Motorcycles)
                {
                    foreach (Service selService in selMotorcycle.ServiceHistory)
                    {
                        this.allServicesList.Add(selService);
                    }
                }
            }
        }

        private void fliterTb_TextChanged(object sender, EventArgs e)
        {
            BindingSource filteredServicesBindingSource = new BindingSource();
            if (fliterTb.Text != null && fliterTb.Text.Length == 0)
            {
                filteredServicesBindingSource.DataSource = null;
                filteredServicesLb.DataSource = filteredServicesBindingSource;
                return;

            }
            filteredSericesList = new List<Service>();
            string name = fliterTb.Text;
            foreach (Customer selCustomer in allCustomersList)
            {
                if (selCustomer.Name.StartsWith(name))
                {
                    foreach (Motorcycle selMotorcycle in selCustomer.Motorcycles)
                    {
                        foreach (Service selService in selMotorcycle.ServiceHistory)
                        {
                            this.filteredSericesList.Add(selService);
                        }
                    }
                }
            }
            filteredServicesBindingSource.DataSource = filteredSericesList;
            filteredServicesLb.DataSource = filteredServicesBindingSource;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (filteredServicesLb.SelectedIndex == -1)
            {
                Service selectedService = allServicesLb.SelectedItem as Service;
                if (selectedService != null)
                {
                    printLayoutForm printLayoutForm = new printLayoutForm(selectedService);
                    printLayoutForm.ShowDialog();
                }
            }
            else
            {
                Service selectedService = filteredServicesLb.SelectedItem as Service;
                if (selectedService != null)
                {
                    printLayoutForm printLayoutForm = new printLayoutForm(selectedService);
                    printLayoutForm.ShowDialog();
                }
            }
            
        }
    }
}
