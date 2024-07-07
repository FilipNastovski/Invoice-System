using System.Runtime.Serialization.Formatters.Binary;

namespace Invoice_System
{
    public partial class Form1 : Form
    {
        public List<Customer> customerList = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
            Stream stream = File.Open("MainData.dat", FileMode.Open);
#pragma warning disable SYSLIB0011 // Type or member is obsolete
            BinaryFormatter bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
            customerList = (List<Customer>)bf.Deserialize(stream);
            stream.Close();
            loadForm(new clientForm(customerList));
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
            loadForm(new serviceForm());
        }

        private void clientsFormBtn_Click(object sender, EventArgs e)
        {
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
    }
}
