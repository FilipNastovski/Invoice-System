namespace Invoice_System
{
    partial class motorcycleCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(motorcycleCreatorForm));
            motorcycleModelTB = new TextBox();
            motorcycleYearNud = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            motorcycleKmNud = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)motorcycleYearNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)motorcycleKmNud).BeginInit();
            SuspendLayout();
            // 
            // motorcycleModelTB
            // 
            motorcycleModelTB.Location = new Point(67, 35);
            motorcycleModelTB.Name = "motorcycleModelTB";
            motorcycleModelTB.Size = new Size(214, 27);
            motorcycleModelTB.TabIndex = 0;
            // 
            // motorcycleYearNud
            // 
            motorcycleYearNud.Location = new Point(67, 97);
            motorcycleYearNud.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            motorcycleYearNud.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            motorcycleYearNud.Name = "motorcycleYearNud";
            motorcycleYearNud.Size = new Size(214, 27);
            motorcycleYearNud.TabIndex = 1;
            motorcycleYearNud.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(67, 196);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Зачувај";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(187, 196);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Откажи";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // motorcycleKmNud
            // 
            motorcycleKmNud.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            motorcycleKmNud.Location = new Point(67, 151);
            motorcycleKmNud.Maximum = new decimal(new int[] { 3000000, 0, 0, 0 });
            motorcycleKmNud.Name = "motorcycleKmNud";
            motorcycleKmNud.Size = new Size(214, 27);
            motorcycleKmNud.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 12);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 5;
            label1.Text = "Модел на мотор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 75);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 6;
            label2.Text = "Година на мотор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 128);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 7;
            label3.Text = "Километри изминати";
            // 
            // motorcycleCreatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 255);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(motorcycleKmNud);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(motorcycleYearNud);
            Controls.Add(motorcycleModelTB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "motorcycleCreatorForm";
            Text = "Креирај нов мотор";
            ((System.ComponentModel.ISupportInitialize)motorcycleYearNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)motorcycleKmNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox motorcycleModelTB;
        private NumericUpDown motorcycleYearNud;
        private Button button1;
        private Button button2;
        private NumericUpDown motorcycleKmNud;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}