namespace RestoranOtomasyonProjesi.Forms
{
    partial class OrderOnayForms
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label8 = new Label();
            txtPAymentMet = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            txtTotalPay = new TextBox();
            label4 = new Label();
            txtTableId = new TextBox();
            label3 = new Label();
            txtWaiterId = new TextBox();
            WaiterDataGrid = new DataGridView();
            btnCustomerOrdersEkle = new Button();
            CustomerDataGrid = new DataGridView();
            btnOnayVer = new Button();
            label1 = new Label();
            txtSiparişSüresi = new TextBox();
            label5 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WaiterDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGrid).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.NavajoWhite;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPAymentMet);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTotalPay);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTableId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtWaiterId);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(888, 312);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 213);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order Fişi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(132, 45);
            label2.Name = "label2";
            label2.Size = new Size(20, 17);
            label2.TabIndex = 45;
            label2.Text = "Id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(50, 149);
            label8.Name = "label8";
            label8.Size = new Size(111, 17);
            label8.TabIndex = 43;
            label8.Text = "Ödeme Yöntemi:";
            // 
            // txtPAymentMet
            // 
            txtPAymentMet.Location = new Point(171, 138);
            txtPAymentMet.Name = "txtPAymentMet";
            txtPAymentMet.Size = new Size(100, 29);
            txtPAymentMet.TabIndex = 42;
            // 
            // txtId
            // 
            txtId.Location = new Point(168, 39);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 29);
            txtId.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(50, 184);
            label6.Name = "label6";
            label6.Size = new Size(95, 17);
            label6.TabIndex = 39;
            label6.Text = "Toplam Tutar:";
            // 
            // txtTotalPay
            // 
            txtTotalPay.Location = new Point(171, 178);
            txtTotalPay.Name = "txtTotalPay";
            txtTotalPay.Size = new Size(100, 29);
            txtTotalPay.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(96, 114);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 35;
            label4.Text = "Masa Id";
            // 
            // txtTableId
            // 
            txtTableId.Location = new Point(171, 103);
            txtTableId.Name = "txtTableId";
            txtTableId.Size = new Size(100, 29);
            txtTableId.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(96, 79);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 33;
            label3.Text = "Garson Id";
            // 
            // txtWaiterId
            // 
            txtWaiterId.Location = new Point(171, 68);
            txtWaiterId.Name = "txtWaiterId";
            txtWaiterId.Size = new Size(100, 29);
            txtWaiterId.TabIndex = 32;
            // 
            // WaiterDataGrid
            // 
            WaiterDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WaiterDataGrid.Location = new Point(50, 12);
            WaiterDataGrid.Name = "WaiterDataGrid";
            WaiterDataGrid.RowTemplate.Height = 25;
            WaiterDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WaiterDataGrid.Size = new Size(781, 276);
            WaiterDataGrid.TabIndex = 50;
            WaiterDataGrid.CellClick += WaiterDataGrid_CellClick;
            // 
            // btnCustomerOrdersEkle
            // 
            btnCustomerOrdersEkle.BackColor = Color.OrangeRed;
            btnCustomerOrdersEkle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomerOrdersEkle.Location = new Point(1006, 559);
            btnCustomerOrdersEkle.Name = "btnCustomerOrdersEkle";
            btnCustomerOrdersEkle.Size = new Size(150, 88);
            btnCustomerOrdersEkle.TabIndex = 51;
            btnCustomerOrdersEkle.Text = "Ekle";
            btnCustomerOrdersEkle.UseVisualStyleBackColor = false;
            btnCustomerOrdersEkle.Click += btnCustomerOrdersEkle_Click;
            // 
            // CustomerDataGrid
            // 
            CustomerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGrid.Location = new Point(77, 399);
            CustomerDataGrid.Name = "CustomerDataGrid";
            CustomerDataGrid.RowTemplate.Height = 25;
            CustomerDataGrid.Size = new Size(658, 272);
            CustomerDataGrid.TabIndex = 52;
            CustomerDataGrid.CellClick += CustomerDataGrid_CellClick;
            // 
            // btnOnayVer
            // 
            btnOnayVer.BackColor = Color.ForestGreen;
            btnOnayVer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnayVer.Location = new Point(1004, 98);
            btnOnayVer.Name = "btnOnayVer";
            btnOnayVer.Size = new Size(148, 74);
            btnOnayVer.TabIndex = 53;
            btnOnayVer.Text = "Onay Ver";
            btnOnayVer.UseVisualStyleBackColor = false;
            btnOnayVer.Click += btnOnayVer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(851, 44);
            label1.Name = "label1";
            label1.Size = new Size(467, 21);
            label1.TabIndex = 54;
            label1.Text = "Onaylanacak Alanları İşaretleyip Onay Ver Butonuna Basınız";
            // 
            // txtSiparişSüresi
            // 
            txtSiparişSüresi.Location = new Point(1131, 712);
            txtSiparişSüresi.Name = "txtSiparişSüresi";
            txtSiparişSüresi.Size = new Size(100, 23);
            txtSiparişSüresi.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(925, 720);
            label5.Name = "label5";
            label5.Size = new Size(187, 15);
            label5.TabIndex = 56;
            label5.Text = "Sipariş Hazırlanma Süresi Giriniz:";
            // 
            // button1
            // 
            button1.Location = new Point(1110, 758);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 57;
            button1.Text = "Onayla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OrderOnayForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1322, 846);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtSiparişSüresi);
            Controls.Add(label1);
            Controls.Add(btnOnayVer);
            Controls.Add(CustomerDataGrid);
            Controls.Add(btnCustomerOrdersEkle);
            Controls.Add(WaiterDataGrid);
            Controls.Add(groupBox1);
            Name = "OrderOnayForms";
            Text = "OrderOnayForms";
            Load += OrderOnayForms_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WaiterDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox5;
        private Label label56;
        private Label label57;
        private Label label55;
        private Button btnDevamEt;
        private Label label53;
        private Label label52;
        private Label label51;
        private Label label54;
        private Label lblMasaId3;
        private Label label50;
        private Label label1;
        private TextBox txtPay14;
        private TextBox txtPay22;
        private TextBox txtPay7;
        private TextBox txtPay10;
        private TextBox txtPay18;
        private TextBox txtPay3;
        private TextBox txtPay12;
        private TextBox txtPay20;
        private TextBox txtPay5;
        private TextBox txtPay9;
        private TextBox txtPay16;
        private TextBox txtPay1;
        private TextBox txtAdet14;
        private TextBox txtAdet22;
        private TextBox txtAdet7;
        private TextBox txtAdet10;
        private TextBox txtAdet18;
        private TextBox txtAdet3;
        private TextBox txtPay13;
        private TextBox txtPay21;
        private TextBox txtPay6;
        private TextBox txtPay17;
        private TextBox txtPay2;
        private TextBox txtAdet12;
        private TextBox txtAdet20;
        private TextBox txtAdet5;
        private TextBox txtToplamTutar;
        private TextBox txtToplamAdet;
        private TextBox txtAdet9;
        private TextBox txtAdet16;
        private TextBox txtAdet1;
        private TextBox txtAdet13;
        private TextBox txtAdet21;
        private TextBox txtAdet6;
        private TextBox txtAdet17;
        private TextBox txtAdet2;
        private TextBox txtPay11;
        private TextBox txtPay19;
        private TextBox txtPay4;
        private TextBox txtPay23;
        private TextBox txtPay8;
        private TextBox txtPay15;
        private TextBox txtboxProduct14;
        private TextBox txtboxProduct22;
        private TextBox txtboxProduct7;
        private TextBox txtboxProduct10;
        private TextBox txtboxProduct18;
        private TextBox txtboxProduct3;
        private TextBox txtAdet11;
        private TextBox txtAdet19;
        private TextBox txtAdet4;
        private TextBox txtboxProduct13;
        private TextBox txtboxProduct21;
        private TextBox txtboxProduct6;
        private TextBox txtAdet23;
        private TextBox txtAdet8;
        private TextBox txtboxProduct12;
        private TextBox txtAdet15;
        private TextBox txtboxProduct20;
        private TextBox txtboxProduct5;
        private TextBox txtboxProduct17;
        private TextBox txtboxProduct11;
        private TextBox txtboxProduct2;
        private TextBox txtboxProduct19;
        private TextBox txtboxProduct9;
        private TextBox txtboxProduct23;
        private TextBox txtboxProduct4;
        private TextBox txtboxProduct16;
        private TextBox txtboxProduct8;
        private TextBox txtboxProduct15;
        private TextBox txtboxProduct1;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txtPAymentMet;
        private Label label6;
        private TextBox txtTotalPay;
        private Label label4;
        private TextBox txtTableId;
        private Label label3;
        private TextBox txtWaiterId;
        private DataGridView WaiterDataGrid;
        private Button btnCustomerOrdersEkle;
        private DataGridView CustomerDataGrid;
        private Button btnOnayVer;
        private Label label2;
        private TextBox txtId;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn WaiterId;
        private DataGridViewTextBoxColumn TableId;
        private DataGridViewTextBoxColumn TotalOrderPay;
        private DataGridViewTextBoxColumn PaymentMethod;
        private TextBox txtSiparişSüresi;
        private Label label5;
        private Button button1;
    }
}