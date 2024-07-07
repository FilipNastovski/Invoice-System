using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Invoice_System
{
    public partial class serviceCreatorForm : Form
    {
        public Service createdService;
        public serviceCreatorForm()
        {
            InitializeComponent();
            createdService = new Service(DateOnly.FromDateTime(serviceDateDtp.Value));
        }

        private void serviceCreatorForm_Load(object sender, EventArgs e)
        {
            ItemTaxSelect.SelectedItem = ItemTaxSelect.Items[0];
            itemUnitSelect.SelectedItem = itemUnitSelect.Items[0];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            ServiceItem createdServiceItem = new ServiceItem(itemDescriptionTb.Text, itemUnitSelect.Text, Convert.ToInt32(itemQtyNud.Value), pricePerUnitItemNud.Value, itemLaborCostNud.Value, ItemTaxSelect.Text);
            createdService.addServiceItem(createdServiceItem);
            reloadItemsList();
        }

        private void reloadItemsList()
        {
            BindingSource serviceItemsBindingSource = new BindingSource();
            serviceItemsBindingSource.DataSource = createdService.ServiceItems;
            serviceItemsLb.DataSource = serviceItemsBindingSource;

            serviceTotPriceLbl.Text = createdService.serviceTotalPrice.ToString() + " Мкд";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceItem selectedItem = (ServiceItem)serviceItemsLb.SelectedItem;
            if (selectedItem != null)
            {
                createdService.ServiceItems.Remove(selectedItem);
                reloadItemsList();
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void serviceDateDtp_ValueChanged(object sender, EventArgs e)
        {
            createdService.DateOfService = DateOnly.FromDateTime(serviceDateDtp.Value);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (createdService != null)
            {
                printLayoutForm printLayoutForm = new printLayoutForm(createdService);
                printLayoutForm.ShowDialog();
            }
        }
    }
}
