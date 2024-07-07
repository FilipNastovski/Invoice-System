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
            sidePanel = new Panel();
            saveAndCloseBtn = new Button();
            invoiceFormBtn = new Button();
            serviceFormBtn = new Button();
            clientsFormBtn = new Button();
            mainPanel = new Panel();
            saveBtn = new Button();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.ActiveCaption;
            sidePanel.Controls.Add(saveBtn);
            sidePanel.Controls.Add(saveAndCloseBtn);
            sidePanel.Controls.Add(invoiceFormBtn);
            sidePanel.Controls.Add(serviceFormBtn);
            sidePanel.Controls.Add(clientsFormBtn);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(250, 660);
            sidePanel.TabIndex = 0;
            // 
            // saveAndCloseBtn
            // 
            saveAndCloseBtn.Location = new Point(58, 575);
            saveAndCloseBtn.Name = "saveAndCloseBtn";
            saveAndCloseBtn.Size = new Size(139, 29);
            saveAndCloseBtn.TabIndex = 3;
            saveAndCloseBtn.Text = "Зачувај и угаси";
            saveAndCloseBtn.UseVisualStyleBackColor = true;
            saveAndCloseBtn.Click += button3_Click;
            // 
            // invoiceFormBtn
            // 
            invoiceFormBtn.Location = new Point(72, 404);
            invoiceFormBtn.Name = "invoiceFormBtn";
            invoiceFormBtn.Size = new Size(94, 29);
            invoiceFormBtn.TabIndex = 2;
            invoiceFormBtn.Text = "Фактури";
            invoiceFormBtn.UseVisualStyleBackColor = true;
            invoiceFormBtn.Click += invoiceFormBtn_Click;
            // 
            // serviceFormBtn
            // 
            serviceFormBtn.Location = new Point(72, 257);
            serviceFormBtn.Name = "serviceFormBtn";
            serviceFormBtn.Size = new Size(94, 29);
            serviceFormBtn.TabIndex = 1;
            serviceFormBtn.Text = "Сервиси";
            serviceFormBtn.UseVisualStyleBackColor = true;
            serviceFormBtn.Click += button1_Click;
            // 
            // clientsFormBtn
            // 
            clientsFormBtn.Location = new Point(81, 127);
            clientsFormBtn.Name = "clientsFormBtn";
            clientsFormBtn.Size = new Size(94, 29);
            clientsFormBtn.TabIndex = 0;
            clientsFormBtn.Text = "Клиенти";
            clientsFormBtn.UseVisualStyleBackColor = true;
            clientsFormBtn.Click += clientsFormBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(250, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(940, 660);
            mainPanel.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(58, 540);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "button1";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 660);
            Controls.Add(mainPanel);
            Controls.Add(sidePanel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            sidePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Button saveAndCloseBtn;
        private Button invoiceFormBtn;
        private Button serviceFormBtn;
        private Button clientsFormBtn;
        private Panel mainPanel;
        private Button saveBtn;
    }
}
