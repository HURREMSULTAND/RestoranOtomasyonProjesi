namespace RestoranOtomasyonProjesi.Forms.CustomerForms
{
    partial class CustomerLastForms
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
            label13 = new Label();
            button2 = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(727, 429);
            label13.Name = "label13";
            label13.Size = new Size(260, 17);
            label13.TabIndex = 54;
            label13.Text = "Beklerken Yorumlara Göz Atmak İster Misiniz?";
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(767, 465);
            button2.Name = "button2";
            button2.Size = new Size(174, 78);
            button2.TabIndex = 53;
            button2.Text = "Yorumlara Göz At";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.MediumSpringGreen;
            label11.Location = new Point(612, 259);
            label11.Name = "label11";
            label11.Size = new Size(502, 65);
            label11.TabIndex = 50;
            label11.Text = "Siparişiniz Onaylandı";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(911, 388);
            label10.Name = "label10";
            label10.Size = new Size(82, 17);
            label10.TabIndex = 52;
            label10.Text = "sonra hazırdır.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(727, 388);
            label9.Name = "label9";
            label9.Size = new Size(65, 17);
            label9.TabIndex = 51;
            label9.Text = "Siparişiniz ";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(808, 382);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(97, 23);
            textBox7.TabIndex = 49;
            // 
            // CustomerLastForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1710, 1041);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Name = "CustomerLastForms";
            Text = "CustomerLastForms";
            Load += CustomerLastForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private Button button2;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox textBox7;
        private Button btnTekrarSiparişOluştur;
        private Label label12;
        private Label label1;
    }
}