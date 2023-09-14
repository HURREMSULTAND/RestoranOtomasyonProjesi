namespace RestoranOtomasyonProjesi.Forms.ManagerForms
{
    partial class RaportsForms
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
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(997, 9);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 1;
            label2.Text = "Giriş Yapan Yönetici:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1171, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(431, 339);
            button1.Name = "button1";
            button1.Size = new Size(180, 90);
            button1.TabIndex = 3;
            button1.Text = "Raporlar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(653, 339);
            button2.Name = "button2";
            button2.Size = new Size(180, 90);
            button2.TabIndex = 4;
            button2.Text = "Müşteri Memnuniyeti";
            button2.UseVisualStyleBackColor = true;
            // 
            // RaportsForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 846);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "RaportsForms";
            Text = "RaportsForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}