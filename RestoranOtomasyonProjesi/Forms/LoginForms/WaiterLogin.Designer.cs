﻿namespace RestoranOtomasyonProjesi.Forms.LoginForms
{
    partial class WaiterLogin
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
            button1 = new Button();
            txtWad = new TextBox();
            txtWPas = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(427, 258);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtWad
            // 
            txtWad.Location = new Point(451, 92);
            txtWad.Name = "txtWad";
            txtWad.Size = new Size(100, 23);
            txtWad.TabIndex = 1;
            // 
            // txtWPas
            // 
            txtWPas.Location = new Point(451, 147);
            txtWPas.Name = "txtWPas";
            txtWPas.Size = new Size(100, 23);
            txtWPas.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 76);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "ad soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 155);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "password:";
            // 
            // WaiterLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWPas);
            Controls.Add(txtWad);
            Controls.Add(button1);
            Name = "WaiterLogin";
            Text = "WaiterLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtWad;
        private TextBox txtWPas;
        private Label label1;
        private Label label2;
    }
}