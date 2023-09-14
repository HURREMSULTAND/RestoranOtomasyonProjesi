namespace RestoranOtomasyonProjesi.Forms
{
    partial class CommentsForms
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
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            CustomerId = new DataGridViewTextBoxColumn();
            OrderId = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            Değerlendirme = new DataGridViewTextBoxColumn();
            Yorum = new DataGridViewTextBoxColumn();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            CommentDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CommentDataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Surname, CustomerId, OrderId, DateTime, Değerlendirme, Yorum });
            dataGridView1.Location = new Point(1, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(846, 443);
            dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Surname
            // 
            Surname.HeaderText = "Surname";
            Surname.Name = "Surname";
            // 
            // CustomerId
            // 
            CustomerId.HeaderText = "CustomerId";
            CustomerId.Name = "CustomerId";
            // 
            // OrderId
            // 
            OrderId.HeaderText = "OrderId";
            OrderId.Name = "OrderId";
            // 
            // DateTime
            // 
            DateTime.HeaderText = "DateTime";
            DateTime.Name = "DateTime";
            // 
            // Değerlendirme
            // 
            Değerlendirme.HeaderText = "Değerlendirme";
            Değerlendirme.Name = "Değerlendirme";
            // 
            // Yorum
            // 
            Yorum.HeaderText = "Yorum";
            Yorum.Name = "Yorum";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(323, 551);
            button2.Name = "button2";
            button2.Size = new Size(251, 69);
            button2.TabIndex = 2;
            button2.Text = "Sende Yorum Yap";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(930, 319);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 354);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yorum Yap";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(65, 280);
            button3.Name = "button3";
            button3.Size = new Size(203, 51);
            button3.TabIndex = 6;
            button3.Text = "Yorum Gönder";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(128, 86);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(128, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 183);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 69);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 183);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 6;
            label5.Text = "Yorumunuz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 132);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 5;
            label3.Text = "Mail Adresiniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 86);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "soyisim:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 43);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "isim:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(636, 416);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 5;
            // 
            // CommentDataGrid
            // 
            CommentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CommentDataGrid.Location = new Point(45, 51);
            CommentDataGrid.Name = "CommentDataGrid";
            CommentDataGrid.RowTemplate.Height = 25;
            CommentDataGrid.Size = new Size(685, 298);
            CommentDataGrid.TabIndex = 6;
            // 
            // CommentsForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 846);
            Controls.Add(CommentDataGrid);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(button2);
           
            Text = "Comments Forms";
       
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CommentDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn DateTime;
        private DataGridViewTextBoxColumn Değerlendirme;
        private DataGridViewTextBoxColumn Yorum;
        private Button button2;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private DataGridView CommentDataGrid;
    }
}