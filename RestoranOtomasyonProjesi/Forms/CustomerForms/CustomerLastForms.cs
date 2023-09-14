using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestoranOtomasyonProjesi.Forms;
using RestoranOtomasyonProjesi.Forms.CustomerForms;

namespace RestoranOtomasyonProjesi.Forms.CustomerForms
{
    public partial class CustomerLastForms : Form
    {
        private string siparisSuresi;

        public CustomerLastForms()
        {
        }

        public CustomerLastForms(string siparisSuresi)
        {
            InitializeComponent();
            this.siparisSuresi = siparisSuresi;
        }

        private void btnTekrarSiparişOluştur_Click(object sender, EventArgs e)
        {
            SiparişOluşturmaForms siparişOluşturmaForms = new SiparişOluşturmaForms();
            siparişOluşturmaForms.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommentsForms commentsForms = new CommentsForms();
            commentsForms.Show();
            this.Hide();


        }

        private void CustomerLastForms_Load(object sender, EventArgs e)
        {
            textBox7.Text = siparisSuresi;
        }
    }
}
