namespace Invoice_System
{
    partial class clientCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientCreatorForm));
            nameTB = new TextBox();
            lastNameTb = new TextBox();
            saveBtn = new Button();
            cancelBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // nameTB
            // 
            nameTB.Location = new Point(59, 43);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(251, 27);
            nameTB.TabIndex = 0;
            // 
            // lastNameTb
            // 
            lastNameTb.Location = new Point(59, 106);
            lastNameTb.Name = "lastNameTb";
            lastNameTb.Size = new Size(251, 27);
            lastNameTb.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(59, 167);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Зачувај";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(216, 167);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Откажи";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 20);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 4;
            label1.Text = "Име на клиент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 83);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 5;
            label2.Text = "Презиме на клиент";
            // 
            // clientCreatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 225);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(lastNameTb);
            Controls.Add(nameTB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "clientCreatorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Креирај нов клиент";
            Load += clientCreatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTB;
        private TextBox lastNameTb;
        private Button saveBtn;
        private Button cancelBtn;
        private Label label1;
        private Label label2;
    }
}