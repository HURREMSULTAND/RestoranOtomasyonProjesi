namespace RestoranOtomasyonProjesi.Forms
{
    partial class SiparişOluşturmaForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparişOluşturmaForms));
            dataGridView1 = new DataGridView();
            txtÜrünİsmi = new TextBox();
            txtÜrünFiyat = new TextBox();
            txtÜrünHazırlık = new TextBox();
            txtürünId = new TextBox();
            btnEkle = new Button();
            dataGridView2 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ÜrünAdı = new DataGridViewTextBoxColumn();
            ÜrünFiyatı = new DataGridViewTextBoxColumn();
            HazırlıkSüresi = new DataGridViewTextBoxColumn();
            MasaId = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSiparişBitir = new Button();
            btnAra = new Button();
            btnSalata = new Button();
            btnAna = new Button();
            btnÇorba = new Button();
            btnMenuİçecekler = new Button();
            btnMenuYemekler = new Button();
            btnMenuTatlılar = new Button();
            btnşŞerbetli = new Button();
            btnSütlü = new Button();
            btnçikolata = new Button();
            btnKahveler = new Button();
            btnHazırİçecekler = new Button();
            btnÇaylar = new Button();
            panel1 = new Panel();
            txtMasaIdd = new TextBox();
            label5 = new Label();
            ürünId = new DataGridViewTextBoxColumn();
            İsim = new DataGridViewTextBoxColumn();
            CookTime = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(41, 323);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(810, 522);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // txtÜrünİsmi
            // 
            txtÜrünİsmi.Location = new Point(899, 588);
            txtÜrünİsmi.Name = "txtÜrünİsmi";
            txtÜrünİsmi.Size = new Size(196, 23);
            txtÜrünİsmi.TabIndex = 1;
            // 
            // txtÜrünFiyat
            // 
            txtÜrünFiyat.Location = new Point(899, 647);
            txtÜrünFiyat.Name = "txtÜrünFiyat";
            txtÜrünFiyat.Size = new Size(72, 23);
            txtÜrünFiyat.TabIndex = 2;
            // 
            // txtÜrünHazırlık
            // 
            txtÜrünHazırlık.Location = new Point(899, 701);
            txtÜrünHazırlık.Name = "txtÜrünHazırlık";
            txtÜrünHazırlık.Size = new Size(108, 23);
            txtÜrünHazırlık.TabIndex = 3;
            // 
            // txtürünId
            // 
            txtürünId.Location = new Point(950, 525);
            txtürünId.Name = "txtürünId";
            txtürünId.Size = new Size(57, 23);
            txtürünId.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.SeaShell;
            btnEkle.Location = new Point(899, 787);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(86, 32);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Ürün Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.RosyBrown;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Id, ÜrünAdı, ÜrünFiyatı, HazırlıkSüresi, MasaId });
            dataGridView2.GridColor = Color.OldLace;
            dataGridView2.Location = new Point(898, 347);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(546, 158);
            dataGridView2.TabIndex = 8;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // ÜrünAdı
            // 
            ÜrünAdı.HeaderText = "ÜrünAdı";
            ÜrünAdı.Name = "ÜrünAdı";
            // 
            // ÜrünFiyatı
            // 
            ÜrünFiyatı.HeaderText = "Ürün Fiyatı";
            ÜrünFiyatı.Name = "ÜrünFiyatı";
            // 
            // HazırlıkSüresi
            // 
            HazırlıkSüresi.HeaderText = "Hazırlık Süresi";
            HazırlıkSüresi.Name = "HazırlıkSüresi";
            // 
            // MasaId
            // 
            MasaId.HeaderText = "Sipariş Oluşturulan Masa";
            MasaId.Name = "MasaId";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(898, 533);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 9;
            label1.Text = "Ürün Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(899, 570);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 10;
            label2.Text = "Ürün İsmi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(899, 629);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 11;
            label3.Text = "Ürün Fiyat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(899, 683);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 12;
            label4.Text = "Hazırlık Süresi";
            // 
            // btnSiparişBitir
            // 
            btnSiparişBitir.BackColor = Color.PeachPuff;
            btnSiparişBitir.Location = new Point(1166, 533);
            btnSiparişBitir.Name = "btnSiparişBitir";
            btnSiparişBitir.Size = new Size(168, 95);
            btnSiparişBitir.TabIndex = 13;
            btnSiparişBitir.Text = "Siparişi Bitir";
            btnSiparişBitir.UseVisualStyleBackColor = false;
            btnSiparişBitir.Click += btnSiparişBitir_Click_1;
            // 
            // btnAra
            // 
            btnAra.BackgroundImage = (Image)resources.GetObject("btnAra.BackgroundImage");
            btnAra.BackgroundImageLayout = ImageLayout.Stretch;
            btnAra.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAra.Location = new Point(61, 168);
            btnAra.Name = "btnAra";
            btnAra.Padding = new Padding(2, 0, 0, 0);
            btnAra.Size = new Size(184, 124);
            btnAra.TabIndex = 21;
            btnAra.Text = "ARA SICAKLAR";
            btnAra.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnSalata
            // 
            btnSalata.BackgroundImage = (Image)resources.GetObject("btnSalata.BackgroundImage");
            btnSalata.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalata.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalata.Location = new Point(251, 64);
            btnSalata.Name = "btnSalata";
            btnSalata.Padding = new Padding(2, 0, 0, 0);
            btnSalata.Size = new Size(184, 109);
            btnSalata.TabIndex = 22;
            btnSalata.Text = "SALATALAR";
            btnSalata.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalata.UseVisualStyleBackColor = true;
            btnSalata.Click += btnSalata_Click;
            // 
            // btnAna
            // 
            btnAna.BackgroundImage = (Image)resources.GetObject("btnAna.BackgroundImage");
            btnAna.BackgroundImageLayout = ImageLayout.Stretch;
            btnAna.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAna.Location = new Point(251, 179);
            btnAna.Name = "btnAna";
            btnAna.Padding = new Padding(7, 10, 0, 0);
            btnAna.Size = new Size(183, 113);
            btnAna.TabIndex = 23;
            btnAna.Text = "ANA YEMEKLER";
            btnAna.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAna.UseVisualStyleBackColor = true;
            btnAna.Click += btnAna_Click;
            // 
            // btnÇorba
            // 
            btnÇorba.BackgroundImage = (Image)resources.GetObject("btnÇorba.BackgroundImage");
            btnÇorba.BackgroundImageLayout = ImageLayout.Stretch;
            btnÇorba.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnÇorba.ForeColor = SystemColors.ActiveCaptionText;
            btnÇorba.Location = new Point(61, 57);
            btnÇorba.Name = "btnÇorba";
            btnÇorba.Padding = new Padding(0, 0, 0, 70);
            btnÇorba.Size = new Size(184, 109);
            btnÇorba.TabIndex = 24;
            btnÇorba.Text = "ÇORBALAR";
            btnÇorba.TextImageRelation = TextImageRelation.ImageAboveText;
            btnÇorba.UseVisualStyleBackColor = true;
            btnÇorba.Click += btnÇorba_Click;
            // 
            // btnMenuİçecekler
            // 
            btnMenuİçecekler.BackColor = Color.DarkOrange;
            btnMenuİçecekler.FlatStyle = FlatStyle.Popup;
            btnMenuİçecekler.Font = new Font("Gabriola", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMenuİçecekler.Location = new Point(1206, 3);
            btnMenuİçecekler.Name = "btnMenuİçecekler";
            btnMenuİçecekler.Size = new Size(444, 42);
            btnMenuİçecekler.TabIndex = 28;
            btnMenuİçecekler.Text = "İÇECEKLER";
            btnMenuİçecekler.UseVisualStyleBackColor = false;
            // 
            // btnMenuYemekler
            // 
            btnMenuYemekler.BackColor = Color.DarkOrange;
            btnMenuYemekler.FlatStyle = FlatStyle.Popup;
            btnMenuYemekler.Font = new Font("Gabriola", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMenuYemekler.Location = new Point(29, 3);
            btnMenuYemekler.Name = "btnMenuYemekler";
            btnMenuYemekler.Size = new Size(444, 42);
            btnMenuYemekler.TabIndex = 27;
            btnMenuYemekler.Text = "YEMEKLER";
            btnMenuYemekler.UseVisualStyleBackColor = false;
            // 
            // btnMenuTatlılar
            // 
            btnMenuTatlılar.BackColor = Color.DarkOrange;
            btnMenuTatlılar.FlatStyle = FlatStyle.Popup;
            btnMenuTatlılar.Font = new Font("Gabriola", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMenuTatlılar.Location = new Point(627, 3);
            btnMenuTatlılar.Name = "btnMenuTatlılar";
            btnMenuTatlılar.Size = new Size(444, 42);
            btnMenuTatlılar.TabIndex = 26;
            btnMenuTatlılar.Text = "TATLILAR";
            btnMenuTatlılar.UseVisualStyleBackColor = false;
            // 
            // btnşŞerbetli
            // 
            btnşŞerbetli.BackgroundImage = (Image)resources.GetObject("btnşŞerbetli.BackgroundImage");
            btnşŞerbetli.BackgroundImageLayout = ImageLayout.Stretch;
            btnşŞerbetli.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnşŞerbetli.ForeColor = Color.Black;
            btnşŞerbetli.Location = new Point(832, 65);
            btnşŞerbetli.Name = "btnşŞerbetli";
            btnşŞerbetli.Padding = new Padding(2, 0, 0, 30);
            btnşŞerbetli.Size = new Size(178, 110);
            btnşŞerbetli.TabIndex = 33;
            btnşŞerbetli.Text = "ŞERBETLİ TATLILAR";
            btnşŞerbetli.TextImageRelation = TextImageRelation.ImageAboveText;
            btnşŞerbetli.UseVisualStyleBackColor = true;
            btnşŞerbetli.Click += btnşŞerbetli_Click;
            // 
            // btnSütlü
            // 
            btnSütlü.BackgroundImage = (Image)resources.GetObject("btnSütlü.BackgroundImage");
            btnSütlü.BackgroundImageLayout = ImageLayout.Stretch;
            btnSütlü.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSütlü.ForeColor = Color.Tan;
            btnSütlü.Location = new Point(832, 175);
            btnSütlü.Name = "btnSütlü";
            btnSütlü.Padding = new Padding(7, 10, 0, 40);
            btnSütlü.Size = new Size(167, 92);
            btnSütlü.TabIndex = 34;
            btnSütlü.Text = "SÜTLÜ TATLILAR";
            btnSütlü.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSütlü.UseVisualStyleBackColor = true;
            btnSütlü.Click += btnSütlü_Click;
            // 
            // btnçikolata
            // 
            btnçikolata.BackgroundImage = (Image)resources.GetObject("btnçikolata.BackgroundImage");
            btnçikolata.BackgroundImageLayout = ImageLayout.Stretch;
            btnçikolata.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnçikolata.ForeColor = Color.Maroon;
            btnçikolata.Location = new Point(641, 64);
            btnçikolata.Name = "btnçikolata";
            btnçikolata.Padding = new Padding(0, 80, 0, 0);
            btnçikolata.Size = new Size(185, 146);
            btnçikolata.TabIndex = 35;
            btnçikolata.Text = "ÇİKOLATALI TATLILAR";
            btnçikolata.TextImageRelation = TextImageRelation.ImageAboveText;
            btnçikolata.UseVisualStyleBackColor = true;
            btnçikolata.Click += btnçikolata_Click;
            // 
            // btnKahveler
            // 
            btnKahveler.BackgroundImage = (Image)resources.GetObject("btnKahveler.BackgroundImage");
            btnKahveler.BackgroundImageLayout = ImageLayout.Stretch;
            btnKahveler.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnKahveler.ForeColor = Color.Black;
            btnKahveler.Location = new Point(1339, 196);
            btnKahveler.Name = "btnKahveler";
            btnKahveler.Padding = new Padding(2, 0, 0, 30);
            btnKahveler.Size = new Size(178, 105);
            btnKahveler.TabIndex = 40;
            btnKahveler.Text = "KAHVELER";
            btnKahveler.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKahveler.UseVisualStyleBackColor = true;
            btnKahveler.Click += btnKahveler_Click;
            // 
            // btnHazırİçecekler
            // 
            btnHazırİçecekler.BackgroundImage = (Image)resources.GetObject("btnHazırİçecekler.BackgroundImage");
            btnHazırİçecekler.BackgroundImageLayout = ImageLayout.Stretch;
            btnHazırİçecekler.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHazırİçecekler.ForeColor = Color.Black;
            btnHazırİçecekler.Location = new Point(1206, 62);
            btnHazırİçecekler.Name = "btnHazırİçecekler";
            btnHazırİçecekler.Padding = new Padding(7, 10, 0, 90);
            btnHazırİçecekler.Size = new Size(215, 132);
            btnHazırİçecekler.TabIndex = 41;
            btnHazırİçecekler.Text = "HAZIR İÇECEKLER";
            btnHazırİçecekler.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHazırİçecekler.UseVisualStyleBackColor = true;
            btnHazırİçecekler.Click += btnHazırİçecekler_Click;
            // 
            // btnÇaylar
            // 
            btnÇaylar.BackgroundImage = (Image)resources.GetObject("btnÇaylar.BackgroundImage");
            btnÇaylar.BackgroundImageLayout = ImageLayout.Stretch;
            btnÇaylar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnÇaylar.ForeColor = Color.Black;
            btnÇaylar.Location = new Point(1427, 66);
            btnÇaylar.Name = "btnÇaylar";
            btnÇaylar.Padding = new Padding(0, 90, 0, 0);
            btnÇaylar.Size = new Size(158, 124);
            btnÇaylar.TabIndex = 42;
            btnÇaylar.Text = "ÇAYLAR";
            btnÇaylar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnÇaylar.UseVisualStyleBackColor = true;
            btnÇaylar.Click += btnÇaylar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(btnMenuYemekler);
            panel1.Controls.Add(btnKahveler);
            panel1.Controls.Add(btnMenuTatlılar);
            panel1.Controls.Add(btnHazırİçecekler);
            panel1.Controls.Add(btnÇaylar);
            panel1.Controls.Add(btnMenuİçecekler);
            panel1.Controls.Add(btnÇorba);
            panel1.Controls.Add(btnşŞerbetli);
            panel1.Controls.Add(btnAna);
            panel1.Controls.Add(btnSütlü);
            panel1.Controls.Add(btnSalata);
            panel1.Controls.Add(btnçikolata);
            panel1.Controls.Add(btnAra);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1695, 305);
            panel1.TabIndex = 43;
            // 
            // txtMasaIdd
            // 
            txtMasaIdd.Location = new Point(898, 758);
            txtMasaIdd.Name = "txtMasaIdd";
            txtMasaIdd.Size = new Size(81, 23);
            txtMasaIdd.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(899, 740);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 45;
            label5.Text = "Masa Id";
            // 
            // ürünId
            // 
            ürünId.HeaderText = "ürünId";
            ürünId.Name = "ürünId";
            // 
            // İsim
            // 
            İsim.HeaderText = "İsim";
            İsim.Name = "İsim";
            // 
            // CookTime
            // 
            CookTime.HeaderText = "CookTime";
            CookTime.Name = "CookTime";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // SiparişOluşturmaForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1710, 1041);
            Controls.Add(label5);
            Controls.Add(txtMasaIdd);
            Controls.Add(panel1);
            Controls.Add(btnSiparişBitir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(btnEkle);
            Controls.Add(txtürünId);
            Controls.Add(txtÜrünHazırlık);
            Controls.Add(txtÜrünFiyat);
            Controls.Add(txtÜrünİsmi);
            Controls.Add(dataGridView1);
            Name = "SiparişOluşturmaForms";
            Text = "SiparişOluşturmaForms";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtÜrünİsmi;
        private TextBox txtÜrünFiyat;
        private TextBox txtÜrünHazırlık;
        private TextBox txtürünId;
        private Button btnEkle;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSiparişBitir;
        private Button btnAra;
        private Button btnSalata;
        private Button btnAna;
        private Button btnÇorba;
        private Button btnMenuİçecekler;
        private Button btnMenuYemekler;
        private Button btnMenuTatlılar;
        private Button btnşŞerbetli;
        private Button btnSütlü;
        private Button btnçikolata;
        private Button btnKahveler;
        private Button btnHazırİçecekler;
        private Button btnÇaylar;
        private Panel panel1;
        private TextBox txtCounter;
        private Label label5;
        private DataGridViewTextBoxColumn ürünId;
        private DataGridViewTextBoxColumn İsim;
        private DataGridViewTextBoxColumn CookTime;
        private DataGridViewTextBoxColumn Price;
        private TextBox txtMasaIdd;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ÜrünAdı;
        private DataGridViewTextBoxColumn ÜrünFiyatı;
        private DataGridViewTextBoxColumn HazırlıkSüresi;
        private DataGridViewTextBoxColumn MasaId;
    }
}