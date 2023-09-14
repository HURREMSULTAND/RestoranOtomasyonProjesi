namespace RestoranOtomasyonProjesi
{
    partial class CustomerLoginForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLoginForms));
            pictureBox1 = new PictureBox();
            btnBack1 = new Button();
            btnOrder = new Button();
            cmbMasaId = new ComboBox();
            txtMasaId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(626, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnBack1
            // 
            btnBack1.BackColor = Color.Silver;
            btnBack1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBack1.Location = new Point(12, 12);
            btnBack1.Name = "btnBack1";
            btnBack1.Size = new Size(116, 56);
            btnBack1.TabIndex = 6;
            btnBack1.Text = "GERİ DÖN";
            btnBack1.UseVisualStyleBackColor = false;
            btnBack1.Click += btnBack1_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.PeachPuff;
            btnOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.ForeColor = Color.FromArgb(255, 128, 128);
            btnOrder.Location = new Point(730, 662);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(259, 84);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "SİPARİŞ OLUŞTUR";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // cmbMasaId
            // 
            cmbMasaId.FormattingEnabled = true;
            cmbMasaId.Location = new Point(780, 407);
            cmbMasaId.Name = "cmbMasaId";
            cmbMasaId.Size = new Size(121, 23);
            cmbMasaId.TabIndex = 7;
            cmbMasaId.SelectedIndexChanged += cmbMasaId_SelectedIndexChanged;
            cmbMasaId.Click += cmbMasaId_Click;
            // 
            // txtMasaId
            // 
            txtMasaId.Location = new Point(766, 483);
            txtMasaId.Name = "txtMasaId";
            txtMasaId.Size = new Size(66, 23);
            txtMasaId.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(683, 351);
            label1.Name = "label1";
            label1.Size = new Size(306, 25);
            label1.TabIndex = 9;
            label1.Text = "Lütfen Masa Numaranızı Seçiniz..";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(838, 486);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 10;
            label2.Text = "Numaralı masayı seçtiniz.";
            // 
            // CustomerLoginForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1710, 1041);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMasaId);
            Controls.Add(cmbMasaId);
            Controls.Add(btnBack1);
            Controls.Add(btnOrder);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerLoginForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Misafir Login Ekranı";
            FormClosed += CustomerLoginForms_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnBack1;
        private Button btnOrder;
        private ComboBox cmbMasaId;
        private TextBox txtMasaId;
        private Label label1;
        private Label label2;
    }
}