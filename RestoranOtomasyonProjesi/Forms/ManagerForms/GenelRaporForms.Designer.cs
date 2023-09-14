namespace RestoranOtomasyonProjesi.Forms.ManagerForms
{
    partial class GenelRaporForms
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
            textBox4 = new TextBox();
            label10 = new Label();
            RapordataGrid = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)RapordataGrid).BeginInit();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1333, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(1159, 25);
            label10.Name = "label10";
            label10.Size = new Size(150, 20);
            label10.TabIndex = 19;
            label10.Text = "Giriş Yapan Yönetici:";
            // 
            // RapordataGrid
            // 
            RapordataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RapordataGrid.Location = new Point(222, 176);
            RapordataGrid.Name = "RapordataGrid";
            RapordataGrid.RowTemplate.Height = 25;
            RapordataGrid.Size = new Size(1046, 441);
            RapordataGrid.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(635, 55);
            button1.Name = "button1";
            button1.Size = new Size(213, 66);
            button1.TabIndex = 22;
            button1.Text = "Raporları Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GenelRaporForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1710, 1041);
            Controls.Add(button1);
            Controls.Add(RapordataGrid);
            Controls.Add(textBox4);
            Controls.Add(label10);
            Name = "GenelRaporForms";
            Text = "GenelRaporForms";
           
            ((System.ComponentModel.ISupportInitialize)RapordataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox4;
        private Label label10;
        private DataGridView RapordataGrid;
        private Button button1;
    }
}