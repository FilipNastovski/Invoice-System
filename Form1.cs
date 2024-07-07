using System.Runtime.Serialization.Formatters.Binary;

namespace Invoice_System
{
    public partial class Form1 : Form
    {
        public List<Customer> customerList = new List<Customer>();
        public List<Invoice> invoiceList = new List<Invoice>();
        public Form1()
        {
            InitializeComponent();
            Stream stream = File.Open("MainData.dat", FileMode.OpenOrCreate);
#pragma warning disable SYSLIB0011 // Type or member is obsolete
            BinaryFormatter bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
            if (stream.Length < 10)
            {
                customerList = new List<Customer>();
            }
            else
            {
            customerList = (List<Customer>)bf.Deserialize(stream);
            }
            loadForm(new clientForm(customerList));
            stream.Close();
        }

        public void loadForm(object form)
        {
            if (this.mainPanel.Controls.Count > 0) this.mainPanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serviceFormBtn.BackColor = Color.FromArgb(25, 20, 45);
            clientsFormBtn.BackColor = Color.FromArgb(29, 35, 59);
            invoiceFormBtn.BackColor = Color.FromArgb(29, 35, 59);
            loadForm(new serviceForm(customerList));
        }

        private void clientsFormBtn_Click(object sender, EventArgs e)
        {
            clientsFormBtn.BackColor = Color.FromArgb(25, 20, 45);
            serviceFormBtn.BackColor = Color.FromArgb(29, 35, 59);
            invoiceFormBtn.BackColor = Color.FromArgb(29, 35, 59);
            loadForm(new clientForm(customerList));
        }

        private void invoiceFormBtn_Click(object sender, EventArgs e)
        {
            loadForm(new invoiceForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveBtn.PerformClick();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Stream stream = File.Open("MainData.dat", FileMode.OpenOrCreate);
#pragma warning disable SYSLIB0011 // Type or member is obsolete
            BinaryFormatter bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
            bf.Serialize(stream, customerList);
            stream.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            invoiceFormBtn.BackColor = Color.FromArgb(25, 20, 45);
            clientsFormBtn.BackColor = Color.FromArgb(29, 35, 59);
            serviceFormBtn.BackColor = Color.FromArgb(29, 35, 59);
            loadForm(new invoiceForm());
        }
    }
}
