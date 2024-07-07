namespace Invoice_System
{
    partial class clientForm
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
            searchClientTB = new TextBox();
            clientsListLB = new ListBox();
            newClientBtn = new Button();
            changeClientBtn = new Button();
            deleteClientBtn = new Button();
            motorcycleListLB = new ListBox();
            newMotoBtn = new Button();
            changeMotoBtn = new Button();
            deleteMotoBtn = new Button();
            serviceListLb = new ListBox();
            newServiceBtn = new Button();
            deleteServiceBtn = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // searchClientTB
            // 
            searchClientTB.Location = new Point(96, 118);
            searchClientTB.Name = "searchClientTB";
            searchClientTB.PlaceholderText = "Пребарај Клиент";
            searchClientTB.Size = new Size(294, 27);
            searchClientTB.TabIndex = 0;
            // 
            // clientsListLB
            // 
            clientsListLB.FormattingEnabled = true;
            clientsListLB.Location = new Point(95, 179);
            clientsListLB.Name = "clientsListLB";
            clientsListLB.Size = new Size(295, 284);
            clientsListLB.TabIndex = 1;
            clientsListLB.SelectedIndexChanged += clientsListLB_SelectedIndexChanged;
            // 
            // newClientBtn
            // 
            newClientBtn.Location = new Point(95, 492);
            newClientBtn.Name = "newClientBtn";
            newClientBtn.Size = new Size(94, 55);
            newClientBtn.TabIndex = 2;
            newClientBtn.Text = "Нов клиент";
            newClientBtn.UseVisualStyleBackColor = true;
            newClientBtn.Click += newClientBtn_Click;
            // 
            // changeClientBtn
            // 
            changeClientBtn.Location = new Point(195, 492);
            changeClientBtn.Name = "changeClientBtn";
            changeClientBtn.Size = new Size(94, 29);
            changeClientBtn.TabIndex = 3;
            changeClientBtn.Text = "Измени";
            changeClientBtn.UseVisualStyleBackColor = true;
            changeClientBtn.Click += changeClientBtn_Click;
            // 
            // deleteClientBtn
            // 
            deleteClientBtn.Location = new Point(296, 492);
            deleteClientBtn.Name = "deleteClientBtn";
            deleteClientBtn.Size = new Size(94, 29);
            deleteClientBtn.TabIndex = 4;
            deleteClientBtn.Text = "Избриши";
            deleteClientBtn.UseVisualStyleBackColor = true;
            deleteClientBtn.Click += deleteClientBtn_Click;
            // 
            // motorcycleListLB
            // 
            motorcycleListLB.FormattingEnabled = true;
            motorcycleListLB.Location = new Point(514, 118);
            motorcycleListLB.Name = "motorcycleListLB";
            motorcycleListLB.Size = new Size(305, 144);
            motorcycleListLB.TabIndex = 5;
            motorcycleListLB.SelectedIndexChanged += motorcycleListLB_SelectedIndexChanged;
            // 
            // newMotoBtn
            // 
            newMotoBtn.Location = new Point(514, 291);
            newMotoBtn.Name = "newMotoBtn";
            newMotoBtn.Size = new Size(94, 29);
            newMotoBtn.TabIndex = 6;
            newMotoBtn.Text = "Нов Мотор";
            newMotoBtn.UseVisualStyleBackColor = true;
            newMotoBtn.Click += newMotoBtn_Click;
            // 
            // changeMotoBtn
            // 
            changeMotoBtn.Location = new Point(614, 291);
            changeMotoBtn.Name = "changeMotoBtn";
            changeMotoBtn.Size = new Size(94, 29);
            changeMotoBtn.TabIndex = 7;
            changeMotoBtn.Text = "Измени";
            changeMotoBtn.UseVisualStyleBackColor = true;
            changeMotoBtn.Click += changeMotoBtn_Click;
            // 
            // deleteMotoBtn
            // 
            deleteMotoBtn.Location = new Point(725, 291);
            deleteMotoBtn.Name = "deleteMotoBtn";
            deleteMotoBtn.Size = new Size(94, 29);
            deleteMotoBtn.TabIndex = 8;
            deleteMotoBtn.Text = "Избриши";
            deleteMotoBtn.UseVisualStyleBackColor = true;
            deleteMotoBtn.Click += deleteMotoBtn_Click;
            // 
            // serviceListLb
            // 
            serviceListLb.FormattingEnabled = true;
            serviceListLb.Location = new Point(514, 380);
            serviceListLb.Name = "serviceListLb";
            serviceListLb.Size = new Size(289, 104);
            serviceListLb.TabIndex = 9;
            // 
            // newServiceBtn
            // 
            newServiceBtn.Location = new Point(514, 507);
            newServiceBtn.Name = "newServiceBtn";
            newServiceBtn.Size = new Size(94, 29);
            newServiceBtn.TabIndex = 10;
            newServiceBtn.Text = "Нов Сервис";
            newServiceBtn.UseVisualStyleBackColor = true;
            newServiceBtn.Click += newServiceBtn_Click;
            // 
            // deleteServiceBtn
            // 
            deleteServiceBtn.Location = new Point(714, 507);
            deleteServiceBtn.Name = "deleteServiceBtn";
            deleteServiceBtn.Size = new Size(94, 29);
            deleteServiceBtn.TabIndex = 12;
            deleteServiceBtn.Text = "Избриши";
            deleteServiceBtn.UseVisualStyleBackColor = true;
            deleteServiceBtn.Click += deleteServiceBtn_Click;
            // 
            // button10
            // 
            button10.Location = new Point(514, 579);
            button10.Name = "button10";
            button10.Size = new Size(289, 29);
            button10.TabIndex = 13;
            button10.Text = "Печати Сервис";
            button10.UseVisualStyleBackColor = true;
            // 
            // clientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 660);
            Controls.Add(button10);
            Controls.Add(deleteServiceBtn);
            Controls.Add(newServiceBtn);
            Controls.Add(serviceListLb);
            Controls.Add(deleteMotoBtn);
            Controls.Add(changeMotoBtn);
            Controls.Add(newMotoBtn);
            Controls.Add(motorcycleListLB);
            Controls.Add(deleteClientBtn);
            Controls.Add(changeClientBtn);
            Controls.Add(newClientBtn);
            Controls.Add(clientsListLB);
            Controls.Add(searchClientTB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "clientForm";
            Text = "clientForm";
            Load += clientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchClientTB;
        private ListBox clientsListLB;
        private Button newClientBtn;
        private Button changeClientBtn;
        private Button deleteClientBtn;
        private ListBox motorcycleListLB;
        private Button newMotoBtn;
        private Button changeMotoBtn;
        private Button deleteMotoBtn;
        private ListBox serviceListLb;
        private Button newServiceBtn;
        private Button deleteServiceBtn;
        private Button button10;
    }
}