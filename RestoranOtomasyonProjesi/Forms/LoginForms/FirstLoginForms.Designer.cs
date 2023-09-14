namespace RestoranOtomasyonProjesi.LoginForms
{
    partial class FirstLoginForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstLoginForms));
            btnMüşteriGirişi = new Button();
            btnUserGirişi = new Button();
            SuspendLayout();
            // 
            // btnMüşteriGirişi
            // 
            btnMüşteriGirişi.BackColor = SystemColors.ActiveCaption;
            btnMüşteriGirişi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMüşteriGirişi.Location = new Point(103, 290);
            btnMüşteriGirişi.Name = "btnMüşteriGirişi";
            btnMüşteriGirişi.Size = new Size(622, 81);
            btnMüşteriGirişi.TabIndex = 0;
            btnMüşteriGirişi.Text = "SAYIN MİSAFİRİMİZ HOŞGELDİNİZ..";
            btnMüşteriGirişi.UseVisualStyleBackColor = false;
            btnMüşteriGirişi.Click += btnMüşteriGirişi_Click;
            // 
            // btnUserGirişi
            // 
            btnUserGirişi.BackColor = Color.PowderBlue;
            btnUserGirişi.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUserGirişi.Location = new Point(273, 411);
            btnUserGirişi.Name = "btnUserGirişi";
            btnUserGirişi.Size = new Size(635, 89);
            btnUserGirişi.TabIndex = 1;
            btnUserGirişi.Text = "SEVGİLİ PERSONELİMİZ HOŞGELDİNİZ...";
            btnUserGirişi.UseVisualStyleBackColor = false;
            btnUserGirişi.Click += btnUserGirişi_Click;
            // 
            // FirstLoginForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1710, 1041);
            Controls.Add(btnUserGirişi);
            Controls.Add(btnMüşteriGirişi);
            Name = "FirstLoginForms";
            Text = "FirstLoginForms";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMüşteriGirişi;
        private Button btnUserGirişi;
    }
}