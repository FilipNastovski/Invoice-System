namespace Invoice_System
{
    partial class serviceCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serviceCreatorForm));
            serviceItemsLb = new ListBox();
            saveBtn = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            addItemBtn = new Button();
            ItemTaxSelect = new ComboBox();
            itemLaborCostNud = new NumericUpDown();
            pricePerUnitItemNud = new NumericUpDown();
            itemQtyNud = new NumericUpDown();
            itemUnitSelect = new ComboBox();
            itemDescriptionTb = new TextBox();
            cancelBtn = new Button();
            printBtn = new Button();
            serviceDateDtp = new DateTimePicker();
            label1 = new Label();
            serviceTotPriceLbl = new Label();
            deleteItemBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemLaborCostNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pricePerUnitItemNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemQtyNud).BeginInit();
            SuspendLayout();
            // 
            // serviceItemsLb
            // 
            serviceItemsLb.FormattingEnabled = true;
            serviceItemsLb.Location = new Point(63, 63);
            serviceItemsLb.Name = "serviceItemsLb";
            serviceItemsLb.Size = new Size(942, 224);
            serviceItemsLb.TabIndex = 0;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(654, 304);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(149, 29);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Зачувај";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addItemBtn);
            panel1.Controls.Add(ItemTaxSelect);
            panel1.Controls.Add(itemLaborCostNud);
            panel1.Controls.Add(pricePerUnitItemNud);
            panel1.Controls.Add(itemQtyNud);
            panel1.Controls.Add(itemUnitSelect);
            panel1.Controls.Add(itemDescriptionTb);
            panel1.Location = new Point(63, 405);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 164);
            panel1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(823, 13);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 13;
            label7.Text = "Данок";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(692, 13);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 12;
            label6.Text = "Рабат";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(574, 13);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 11;
            label5.Text = "Цена по ЕМ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 13);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 10;
            label4.Text = "Количина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 11);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 9;
            label3.Text = "Единица мерка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 11);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 8;
            label2.Text = "Опис";
            // 
            // addItemBtn
            // 
            addItemBtn.Location = new Point(692, 102);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new Size(219, 44);
            addItemBtn.TabIndex = 7;
            addItemBtn.Text = "Додај";
            addItemBtn.UseVisualStyleBackColor = true;
            addItemBtn.Click += addItemBtn_Click;
            // 
            // ItemTaxSelect
            // 
            ItemTaxSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemTaxSelect.FormattingEnabled = true;
            ItemTaxSelect.Items.AddRange(new object[] { "18%", "10%", "5%", "0%" });
            ItemTaxSelect.Location = new Point(823, 36);
            ItemTaxSelect.Name = "ItemTaxSelect";
            ItemTaxSelect.Size = new Size(88, 28);
            ItemTaxSelect.TabIndex = 5;
            // 
            // itemLaborCostNud
            // 
            itemLaborCostNud.DecimalPlaces = 2;
            itemLaborCostNud.Location = new Point(692, 34);
            itemLaborCostNud.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            itemLaborCostNud.Name = "itemLaborCostNud";
            itemLaborCostNud.Size = new Size(102, 27);
            itemLaborCostNud.TabIndex = 4;
            itemLaborCostNud.ThousandsSeparator = true;
            // 
            // pricePerUnitItemNud
            // 
            pricePerUnitItemNud.DecimalPlaces = 2;
            pricePerUnitItemNud.Location = new Point(574, 34);
            pricePerUnitItemNud.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            pricePerUnitItemNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            pricePerUnitItemNud.Name = "pricePerUnitItemNud";
            pricePerUnitItemNud.Size = new Size(92, 27);
            pricePerUnitItemNud.TabIndex = 3;
            pricePerUnitItemNud.ThousandsSeparator = true;
            pricePerUnitItemNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // itemQtyNud
            // 
            itemQtyNud.DecimalPlaces = 2;
            itemQtyNud.Location = new Point(473, 36);
            itemQtyNud.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            itemQtyNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            itemQtyNud.Name = "itemQtyNud";
            itemQtyNud.Size = new Size(78, 27);
            itemQtyNud.TabIndex = 2;
            itemQtyNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // itemUnitSelect
            // 
            itemUnitSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            itemUnitSelect.FormattingEnabled = true;
            itemUnitSelect.Items.AddRange(new object[] { "Парче", "Кг", "г", "Л", "Мл" });
            itemUnitSelect.Location = new Point(344, 34);
            itemUnitSelect.Name = "itemUnitSelect";
            itemUnitSelect.Size = new Size(106, 28);
            itemUnitSelect.TabIndex = 1;
            // 
            // itemDescriptionTb
            // 
            itemDescriptionTb.Location = new Point(19, 34);
            itemDescriptionTb.Multiline = true;
            itemDescriptionTb.Name = "itemDescriptionTb";
            itemDescriptionTb.PlaceholderText = "Опис";
            itemDescriptionTb.ScrollBars = ScrollBars.Vertical;
            itemDescriptionTb.Size = new Size(300, 112);
            itemDescriptionTb.TabIndex = 0;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(82, 304);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(149, 29);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Откажи";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // printBtn
            // 
            printBtn.Location = new Point(487, 304);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(149, 29);
            printBtn.TabIndex = 4;
            printBtn.Text = "Печати";
            printBtn.UseVisualStyleBackColor = true;
            printBtn.Click += printBtn_Click;
            // 
            // serviceDateDtp
            // 
            serviceDateDtp.Location = new Point(63, 30);
            serviceDateDtp.Name = "serviceDateDtp";
            serviceDateDtp.Size = new Size(250, 27);
            serviceDateDtp.TabIndex = 8;
            serviceDateDtp.ValueChanged += serviceDateDtp_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(843, 313);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 9;
            label1.Text = "Вкупна цена";
            // 
            // serviceTotPriceLbl
            // 
            serviceTotPriceLbl.AutoSize = true;
            serviceTotPriceLbl.Location = new Point(945, 313);
            serviceTotPriceLbl.Name = "serviceTotPriceLbl";
            serviceTotPriceLbl.Size = new Size(60, 20);
            serviceTotPriceLbl.TabIndex = 11;
            serviceTotPriceLbl.Text = "0.0 Мкд";
            serviceTotPriceLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deleteItemBtn
            // 
            deleteItemBtn.Location = new Point(256, 304);
            deleteItemBtn.Name = "deleteItemBtn";
            deleteItemBtn.Size = new Size(149, 29);
            deleteItemBtn.TabIndex = 12;
            deleteItemBtn.Text = "Избриши";
            deleteItemBtn.UseVisualStyleBackColor = true;
            deleteItemBtn.Click += button1_Click;
            // 
            // serviceCreatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 612);
            Controls.Add(deleteItemBtn);
            Controls.Add(serviceTotPriceLbl);
            Controls.Add(label1);
            Controls.Add(serviceDateDtp);
            Controls.Add(printBtn);
            Controls.Add(cancelBtn);
            Controls.Add(panel1);
            Controls.Add(saveBtn);
            Controls.Add(serviceItemsLb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "serviceCreatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Креирај нов сервис";
            Load += serviceCreatorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemLaborCostNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)pricePerUnitItemNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemQtyNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox serviceItemsLb;
        private Button saveBtn;
        private Panel panel1;
        private ComboBox itemUnitSelect;
        private NumericUpDown itemQtyNud;
        private NumericUpDown pricePerUnitItemNud;
        private NumericUpDown itemLaborCostNud;
        private ComboBox ItemTaxSelect;
        private Button cancelBtn;
        private Button printBtn;
        private Button addItemBtn;
        private TextBox itemDescriptionTb;
        private DateTimePicker serviceDateDtp;
        private Label label1;
        private Label serviceTotPriceLbl;
        private Button deleteItemBtn;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
    }
}