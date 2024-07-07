namespace Invoice_System
{
    partial class serviceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            allServicesLb = new ListBox();
            fliterTb = new TextBox();
            filteredServicesLb = new ListBox();
            printBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // allServicesLb
            // 
            allServicesLb.FormattingEnabled = true;
            allServicesLb.Location = new Point(96, 158);
            allServicesLb.Name = "allServicesLb";
            allServicesLb.Size = new Size(306, 404);
            allServicesLb.TabIndex = 0;
            // 
            // fliterTb
            // 
            fliterTb.Location = new Point(493, 158);
            fliterTb.Name = "fliterTb";
            fliterTb.PlaceholderText = "Филтрирај по име";
            fliterTb.Size = new Size(286, 27);
            fliterTb.TabIndex = 1;
            fliterTb.TextChanged += fliterTb_TextChanged;
            // 
            // filteredServicesLb
            // 
            filteredServicesLb.FormattingEnabled = true;
            filteredServicesLb.Location = new Point(493, 204);
            filteredServicesLb.Name = "filteredServicesLb";
            filteredServicesLb.Size = new Size(286, 304);
            filteredServicesLb.TabIndex = 2;
            // 
            // printBtn
            // 
            printBtn.Location = new Point(493, 526);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(286, 36);
            printBtn.TabIndex = 3;
            printBtn.Text = "Печати";
            printBtn.UseVisualStyleBackColor = true;
            printBtn.Click += printBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(95, 53);
            label1.Name = "label1";
            label1.Size = new Size(153, 46);
            label1.TabIndex = 15;
            label1.Text = "Сервиси";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 135);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 16;
            label2.Text = "Приказ на сите сервиси";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 135);
            label3.Name = "label3";
            label3.Size = new Size(232, 20);
            label3.TabIndex = 17;
            label3.Text = "Приказ на филтрирани сервиси";
            // 
            // serviceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(940, 660);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(printBtn);
            Controls.Add(filteredServicesLb);
            Controls.Add(fliterTb);
            Controls.Add(allServicesLb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "serviceForm";
            Text = "serviceForm";
            Load += serviceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox allServicesLb;
        private TextBox fliterTb;
        private ListBox filteredServicesLb;
        private Button printBtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}