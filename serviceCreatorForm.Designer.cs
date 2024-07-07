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
            serviceItemsLb = new ListBox();
            saveBtn = new Button();
            panel1 = new Panel();
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
            serviceItemsLb.Size = new Size(476, 244);
            serviceItemsLb.TabIndex = 0;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(595, 63);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Зачувај";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(addItemBtn);
            panel1.Controls.Add(ItemTaxSelect);
            panel1.Controls.Add(itemLaborCostNud);
            panel1.Controls.Add(pricePerUnitItemNud);
            panel1.Controls.Add(itemQtyNud);
            panel1.Controls.Add(itemUnitSelect);
            panel1.Controls.Add(itemDescriptionTb);
            panel1.Location = new Point(63, 347);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 193);
            panel1.TabIndex = 2;
            // 
            // addItemBtn
            // 
            addItemBtn.Location = new Point(346, 87);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new Size(111, 66);
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
            ItemTaxSelect.Location = new Point(826, 17);
            ItemTaxSelect.Name = "ItemTaxSelect";
            ItemTaxSelect.Size = new Size(88, 28);
            ItemTaxSelect.TabIndex = 5;
            // 
            // itemLaborCostNud
            // 
            itemLaborCostNud.DecimalPlaces = 2;
            itemLaborCostNud.Location = new Point(705, 18);
            itemLaborCostNud.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            itemLaborCostNud.Name = "itemLaborCostNud";
            itemLaborCostNud.Size = new Size(97, 27);
            itemLaborCostNud.TabIndex = 4;
            itemLaborCostNud.ThousandsSeparator = true;
            // 
            // pricePerUnitItemNud
            // 
            pricePerUnitItemNud.DecimalPlaces = 2;
            pricePerUnitItemNud.Location = new Point(573, 18);
            pricePerUnitItemNud.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            pricePerUnitItemNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            pricePerUnitItemNud.Name = "pricePerUnitItemNud";
            pricePerUnitItemNud.Size = new Size(104, 27);
            pricePerUnitItemNud.TabIndex = 3;
            pricePerUnitItemNud.ThousandsSeparator = true;
            pricePerUnitItemNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // itemQtyNud
            // 
            itemQtyNud.DecimalPlaces = 2;
            itemQtyNud.Location = new Point(459, 18);
            itemQtyNud.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            itemQtyNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            itemQtyNud.Name = "itemQtyNud";
            itemQtyNud.Size = new Size(95, 27);
            itemQtyNud.TabIndex = 2;
            itemQtyNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // itemUnitSelect
            // 
            itemUnitSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            itemUnitSelect.FormattingEnabled = true;
            itemUnitSelect.Items.AddRange(new object[] { "Парче", "Кг", "г", "Л", "Мл" });
            itemUnitSelect.Location = new Point(346, 18);
            itemUnitSelect.Name = "itemUnitSelect";
            itemUnitSelect.Size = new Size(90, 28);
            itemUnitSelect.TabIndex = 1;
            // 
            // itemDescriptionTb
            // 
            itemDescriptionTb.Location = new Point(23, 18);
            itemDescriptionTb.Multiline = true;
            itemDescriptionTb.Name = "itemDescriptionTb";
            itemDescriptionTb.PlaceholderText = "Опис";
            itemDescriptionTb.ScrollBars = ScrollBars.Vertical;
            itemDescriptionTb.Size = new Size(300, 150);
            itemDescriptionTb.TabIndex = 0;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(595, 250);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Откажи";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // printBtn
            // 
            printBtn.Location = new Point(595, 192);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(94, 29);
            printBtn.TabIndex = 4;
            printBtn.Text = "Печати";
            printBtn.UseVisualStyleBackColor = true;
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
            label1.Location = new Point(63, 310);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 9;
            label1.Text = "Вкупна цена";
            // 
            // serviceTotPriceLbl
            // 
            serviceTotPriceLbl.AutoSize = true;
            serviceTotPriceLbl.Location = new Point(165, 310);
            serviceTotPriceLbl.Name = "serviceTotPriceLbl";
            serviceTotPriceLbl.Size = new Size(60, 20);
            serviceTotPriceLbl.TabIndex = 11;
            serviceTotPriceLbl.Text = "0.0 Мкд";
            serviceTotPriceLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // deleteItemBtn
            // 
            deleteItemBtn.Location = new Point(595, 127);
            deleteItemBtn.Name = "deleteItemBtn";
            deleteItemBtn.Size = new Size(94, 29);
            deleteItemBtn.TabIndex = 12;
            deleteItemBtn.Text = "Избриши";
            deleteItemBtn.UseVisualStyleBackColor = true;
            deleteItemBtn.Click += button1_Click;
            // 
            // serviceCreatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 566);
            Controls.Add(deleteItemBtn);
            Controls.Add(serviceTotPriceLbl);
            Controls.Add(label1);
            Controls.Add(serviceDateDtp);
            Controls.Add(printBtn);
            Controls.Add(cancelBtn);
            Controls.Add(panel1);
            Controls.Add(saveBtn);
            Controls.Add(serviceItemsLb);
            Name = "serviceCreatorForm";
            Text = "serviceCreatorForm";
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
    }
}