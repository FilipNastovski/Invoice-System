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
            nameTB = new TextBox();
            lastNameTb = new TextBox();
            saveBtn = new Button();
            cancelBtn = new Button();
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
            // clientCreatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 242);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(lastNameTb);
            Controls.Add(nameTB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "clientCreatorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "clientCreatorForm";
            Load += clientCreatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTB;
        private TextBox lastNameTb;
        private Button saveBtn;
        private Button cancelBtn;
    }
}