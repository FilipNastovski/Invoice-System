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
            motorcycleModelTB = new TextBox();
            motorcycleYearNud = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            motorcycleKmNud = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)motorcycleYearNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)motorcycleKmNud).BeginInit();
            SuspendLayout();
            // 
            // motorcycleModelTB
            // 
            motorcycleModelTB.Location = new Point(78, 34);
            motorcycleModelTB.Name = "motorcycleModelTB";
            motorcycleModelTB.Size = new Size(214, 27);
            motorcycleModelTB.TabIndex = 0;
            // 
            // motorcycleYearNud
            // 
            motorcycleYearNud.Location = new Point(78, 86);
            motorcycleYearNud.Name = "motorcycleYearNud";
            motorcycleYearNud.Size = new Size(214, 27);
            motorcycleYearNud.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(78, 184);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Зачувај";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(198, 184);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Откажи";
            button2.UseVisualStyleBackColor = true;
            // 
            // motorcycleKmNud
            // 
            motorcycleKmNud.Location = new Point(78, 137);
            motorcycleKmNud.Name = "motorcycleKmNud";
            motorcycleKmNud.Size = new Size(214, 27);
            motorcycleKmNud.TabIndex = 4;
            // 
            // motorcycleCreatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 255);
            Controls.Add(motorcycleKmNud);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(motorcycleYearNud);
            Controls.Add(motorcycleModelTB);
            Name = "motorcycleCreatorForm";
            Text = "motorcycleCreatorForm";
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
    }
}