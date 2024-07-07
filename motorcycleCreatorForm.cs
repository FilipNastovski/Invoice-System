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
    public partial class motorcycleCreatorForm : Form
    {
        public Motorcycle newMotorcycle = null;
        private bool changeMotorcycle = false;
        public motorcycleCreatorForm()
        {
            InitializeComponent();
        }

        public motorcycleCreatorForm(Motorcycle toChange)
        {
            InitializeComponent();
            this.newMotorcycle = toChange;
            this.changeMotorcycle = true;
            motorcycleModelTB.Text = toChange.Model;
            motorcycleYearNud.Value = toChange.Year;
            motorcycleKmNud.Value = toChange.Kilometers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (changeMotorcycle)
            {
                this.newMotorcycle.Model = motorcycleModelTB.Text;
                this.newMotorcycle.Year = Convert.ToInt32(motorcycleYearNud.Value);
                this.newMotorcycle.Kilometers = Convert.ToInt32(motorcycleKmNud.Value);
                this.DialogResult = DialogResult.Continue;
            }
            newMotorcycle = new Motorcycle(motorcycleModelTB.Text, Convert.ToInt32(motorcycleYearNud.Value), Convert.ToInt32(motorcycleKmNud.Value));
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
