namespace RestoranOtomasyonProjesi
{
    partial class ManagerLogins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerLogins));
            label1 = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            btnCancel = new Button();
            btnBack2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(633, 387);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtName
            // 
            txtName.Location = new Point(769, 385);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 23);
            txtName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(769, 432);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(283, 23);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(658, 430);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 192, 192);
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(678, 530);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(394, 68);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "GİRİŞ YAP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 192);
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(678, 617);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(394, 74);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "KAPAT";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnBack2
            // 
            btnBack2.BackColor = Color.FromArgb(255, 224, 192);
            btnBack2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBack2.Location = new Point(12, 3);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(99, 54);
            btnBack2.TabIndex = 5;
            btnBack2.Text = "GERİ DÖN";
            btnBack2.UseVisualStyleBackColor = false;
            btnBack2.Click += btnBack2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(690, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // AppUserLoginForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1710, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack2);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AppUserLoginForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Waiter Login Form";
            Load += AppUserLoginForms_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtPassword;
        private Label label2;
        private Button btnLogin;
        private Button btnCancel;
        private Button btnBack2;
        private PictureBox pictureBox1;
    }
}