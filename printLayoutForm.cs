using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_System
{
    public partial class printLayoutForm : Form
    {
        private Service service;
        private Bitmap memoryImg;

        public printLayoutForm(Service service)
        {
            InitializeComponent();
            this.service = service;
            fullTotalPriceTb.Text = service.getTotalPrice().ToString();
            dateTb.Text = DateTime.Now.ToShortDateString();

            numLbl1.Text = "1)";
            descLbl1.Text ="";
            emLbl1.Text ="";
            countLbl1.Text ="";
            individualCostLbl1.Text ="";
            workCostLbl1.Text ="";
            taxLbl1.Text ="";
            totPriceLbl1.Text ="";

            numLbl2.Text = "2)";
            descLbl2.Text = "";
            emLbl2.Text = "";
            countLbl2.Text = "";
            individualCostLbl2.Text = "";
            workCostLbl2.Text = "";
            taxLbl2.Text = "";
            totPriceLbl2.Text = "";

            numLbl3.Text = "3)";
            descLbl3.Text = "";
            emLbl3.Text = "";
            countLbl3.Text = "";
            individualCostLbl3.Text = "";
            workCostLbl3.Text = "";
            taxLbl3.Text = "";
            totPriceLbl3.Text = "";

            numLbl4.Text = "4)";
            descLbl4.Text = "";
            emLbl4.Text = "";
            countLbl4.Text = "";
            individualCostLbl4.Text = "";
            workCostLbl4.Text = "";
            taxLbl4.Text = "";
            totPriceLbl4.Text = "";

            numLbl5.Text = "5)";
            descLbl5.Text = "";
            emLbl5.Text = "";
            countLbl5.Text = "";
            individualCostLbl5.Text = "";
            workCostLbl5.Text = "";
            taxLbl5.Text = "";
            totPriceLbl5.Text = "";

            numLbl6.Text = "6)";
            descLbl6.Text = "";
            emLbl6.Text = "";
            countLbl6.Text = "";
            individualCostLbl6.Text = "";
            workCostLbl6.Text = "";
            taxLbl6.Text = "";
            totPriceLbl6.Text = "";

            numLbl7.Text = "7)";
            descLbl7.Text = "";
            emLbl7.Text = "";
            countLbl7.Text = "";
            individualCostLbl7.Text = "";
            workCostLbl7.Text = "";
            taxLbl7.Text = "";
            totPriceLbl7.Text = "";

            numLbl8.Text = "8)";
            descLbl8.Text = "";
            emLbl8.Text = "";
            countLbl8.Text = "";
            individualCostLbl8.Text = "";
            workCostLbl8.Text = "";
            taxLbl8.Text = "";
            totPriceLbl8.Text = "";


            if (service != null && service.ServiceItems != null)
            {
                int count = service.ServiceItems.Count;

                if (count > 0)
                {
                    descLbl1.Text = service.ServiceItems[0].Description;
                    emLbl1.Text = service.ServiceItems[0].MeasurementUnit;
                    countLbl1.Text = service.ServiceItems[0].Quantity.ToString();
                    individualCostLbl1.Text = service.ServiceItems[0].PricePerUnit.ToString();
                    workCostLbl1.Text = service.ServiceItems[0].LaborCost.ToString();
                    taxLbl1.Text = service.ServiceItems[0].Tax;
                    totPriceLbl1.Text = service.ServiceItems[0].TotalPrice.ToString();
                }
                if (count > 1)
                {
                    descLbl2.Text = service.ServiceItems[1].Description;
                    emLbl2.Text = service.ServiceItems[1].MeasurementUnit;
                    countLbl2.Text = service.ServiceItems[1].Quantity.ToString();
                    individualCostLbl2.Text = service.ServiceItems[1].PricePerUnit.ToString();
                    workCostLbl2.Text = service.ServiceItems[1].LaborCost.ToString();
                    taxLbl2.Text = service.ServiceItems[1].Tax;
                    totPriceLbl2.Text = service.ServiceItems[1].TotalPrice.ToString();
                }
                if (count > 2)
                {
                    descLbl3.Text = service.ServiceItems[2].Description;
                    emLbl3.Text = service.ServiceItems[2].MeasurementUnit;
                    countLbl3.Text = service.ServiceItems[2].Quantity.ToString();
                    individualCostLbl3.Text = service.ServiceItems[2].PricePerUnit.ToString();
                    workCostLbl3.Text = service.ServiceItems[2].LaborCost.ToString();
                    taxLbl3.Text = service.ServiceItems[2].Tax;
                    totPriceLbl3.Text = service.ServiceItems[2].TotalPrice.ToString();
                }
                if (count > 3)
                {
                    descLbl4.Text = service.ServiceItems[3].Description;
                    emLbl4.Text = service.ServiceItems[3].MeasurementUnit;
                    countLbl4.Text = service.ServiceItems[3].Quantity.ToString();
                    individualCostLbl4.Text = service.ServiceItems[3].PricePerUnit.ToString();
                    workCostLbl4.Text = service.ServiceItems[3].LaborCost.ToString();
                    taxLbl4.Text = service.ServiceItems[3].Tax;
                    totPriceLbl4.Text = service.ServiceItems[3].TotalPrice.ToString();
                }
                if (count > 4)
                {
                    descLbl5.Text = service.ServiceItems[4].Description;
                    emLbl5.Text = service.ServiceItems[4].MeasurementUnit;
                    countLbl5.Text = service.ServiceItems[4].Quantity.ToString();
                    individualCostLbl5.Text = service.ServiceItems[4].PricePerUnit.ToString();
                    workCostLbl5.Text = service.ServiceItems[4].LaborCost.ToString();
                    taxLbl5.Text = service.ServiceItems[4].Tax;
                    totPriceLbl5.Text = service.ServiceItems[4].TotalPrice.ToString();
                }
                if (count > 5)
                {
                    descLbl6.Text = service.ServiceItems[5].Description;
                    emLbl6.Text = service.ServiceItems[5].MeasurementUnit;
                    countLbl6.Text = service.ServiceItems[5].Quantity.ToString();
                    individualCostLbl6.Text = service.ServiceItems[5].PricePerUnit.ToString();
                    workCostLbl6.Text = service.ServiceItems[5].LaborCost.ToString();
                    taxLbl6.Text = service.ServiceItems[5].Tax;
                    totPriceLbl6.Text = service.ServiceItems[5].TotalPrice.ToString();
                }
                if (count > 6)
                {
                    descLbl7.Text = service.ServiceItems[6].Description;
                    emLbl7.Text = service.ServiceItems[6].MeasurementUnit;
                    countLbl7.Text = service.ServiceItems[6].Quantity.ToString();
                    individualCostLbl7.Text = service.ServiceItems[6].PricePerUnit.ToString();
                    workCostLbl7.Text = service.ServiceItems[6].LaborCost.ToString();
                    taxLbl7.Text = service.ServiceItems[6].Tax;
                    totPriceLbl7.Text = service.ServiceItems[6].TotalPrice.ToString();
                }
                if (count > 7)
                {
                    descLbl8.Text = service.ServiceItems[7].Description;
                    emLbl8.Text = service.ServiceItems[7].MeasurementUnit;
                    countLbl8.Text = service.ServiceItems[7].Quantity.ToString();
                    individualCostLbl8.Text = service.ServiceItems[7].PricePerUnit.ToString();
                    workCostLbl8.Text = service.ServiceItems[7].LaborCost.ToString();
                    taxLbl8.Text = service.ServiceItems[7].Tax;
                    totPriceLbl8.Text = service.ServiceItems[7].TotalPrice.ToString();
                }

            }
        }



        private void print(Panel panel1)
        {
            PrinterSettings ps = new PrinterSettings();
            printPanel = panel1;
            getPrintArea(printPanel);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }

        private void getPrintArea(Panel panel1)
        {
            memoryImg = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(memoryImg, new Rectangle(0, 0, panel1.Width, panel1.Height));
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memoryImg, (pageArea.Width / 2) - (this.printPanel.Width / 2), this.printPanel.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveAndPrintBtn.Visible = false;
            this.TopMost = false;
            print(this.printPanel);
            this.Close();
        }









        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void workCostLbl6_Click(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void printPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
