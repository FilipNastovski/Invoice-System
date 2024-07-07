namespace Invoice_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sidePanel = new Panel();
            pictureBox2 = new PictureBox();
            invoiceFormBtn = new Button();
            pictureBox1 = new PictureBox();
            serviceFormBtn = new Button();
            clientsFormBtn = new Button();
            saveBtn = new Button();
            mainPanel = new Panel();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(24, 30, 54);
            sidePanel.Controls.Add(pictureBox2);
            sidePanel.Controls.Add(invoiceFormBtn);
            sidePanel.Controls.Add(pictureBox1);
            sidePanel.Controls.Add(serviceFormBtn);
            sidePanel.Controls.Add(clientsFormBtn);
            sidePanel.Controls.Add(saveBtn);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(250, 660);
            sidePanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.saveIcon;
            pictureBox2.Location = new Point(188, 606);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(10);
            pictureBox2.Size = new Size(59, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // invoiceFormBtn
            // 
            invoiceFormBtn.BackColor = Color.FromArgb(29, 35, 59);
            invoiceFormBtn.BackgroundImageLayout = ImageLayout.None;
            invoiceFormBtn.FlatStyle = FlatStyle.Flat;
            invoiceFormBtn.Font = new Font("Segoe UI", 13F);
            invoiceFormBtn.ForeColor = Color.WhiteSmoke;
            invoiceFormBtn.Location = new Point(0, 448);
            invoiceFormBtn.Name = "invoiceFormBtn";
            invoiceFormBtn.Size = new Size(250, 75);
            invoiceFormBtn.TabIndex = 6;
            invoiceFormBtn.Text = "Фактури";
            invoiceFormBtn.UseVisualStyleBackColor = false;
            invoiceFormBtn.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(24, 30, 54);
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // serviceFormBtn
            // 
            serviceFormBtn.BackColor = Color.FromArgb(29, 35, 59);
            serviceFormBtn.BackgroundImageLayout = ImageLayout.None;
            serviceFormBtn.FlatStyle = FlatStyle.Flat;
            serviceFormBtn.Font = new Font("Segoe UI", 13F);
            serviceFormBtn.ForeColor = Color.WhiteSmoke;
            serviceFormBtn.Location = new Point(0, 331);
            serviceFormBtn.Name = "serviceFormBtn";
            serviceFormBtn.Size = new Size(250, 75);
            serviceFormBtn.TabIndex = 1;
            serviceFormBtn.Text = "Сервиси";
            serviceFormBtn.UseVisualStyleBackColor = false;
            serviceFormBtn.Click += button1_Click;
            // 
            // clientsFormBtn
            // 
            clientsFormBtn.BackColor = Color.FromArgb(29, 35, 59);
            clientsFormBtn.BackgroundImageLayout = ImageLayout.None;
            clientsFormBtn.FlatStyle = FlatStyle.Flat;
            clientsFormBtn.Font = new Font("Segoe UI", 13F);
            clientsFormBtn.ForeColor = Color.WhiteSmoke;
            clientsFormBtn.Location = new Point(0, 220);
            clientsFormBtn.Name = "clientsFormBtn";
            clientsFormBtn.Size = new Size(250, 75);
            clientsFormBtn.TabIndex = 0;
            clientsFormBtn.Text = "Клиенти";
            clientsFormBtn.UseVisualStyleBackColor = false;
            clientsFormBtn.Click += clientsFormBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(29, 35, 59);
            saveBtn.BackgroundImageLayout = ImageLayout.None;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.ForeColor = Color.WhiteSmoke;
            saveBtn.Location = new Point(0, 606);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(191, 54);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Зачувај";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(46, 51, 73);
            mainPanel.BackgroundImageLayout = ImageLayout.Center;
            mainPanel.Dock = DockStyle.Right;
            mainPanel.Location = new Point(250, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(940, 660);
            mainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 660);
            Controls.Add(mainPanel);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service system";
            Load += Form1_Load;
            sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Button serviceFormBtn;
        private Panel mainPanel;
        private Button saveBtn;
        private PictureBox pictureBox1;
        private Button clientsFormBtn;
        private Button invoiceFormBtn;
        private PictureBox pictureBox2;
    }
}
