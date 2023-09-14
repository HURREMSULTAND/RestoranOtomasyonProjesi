using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranOtomasyonProjesi.LoginForms
{
    public partial class FirstLoginForms : Form
    {
        public FirstLoginForms()
        {
            InitializeComponent();
        }

        private void btnMüşteriGirişi_Click(object sender, EventArgs e)
        {
            CustomerLoginForms customerLoginForms = new CustomerLoginForms();
            customerLoginForms.Show();
            this.Hide();
        }

        private void btnUserGirişi_Click(object sender, EventArgs e)
        {
            ManagerLogins appUserLoginForms = new ManagerLogins();
            appUserLoginForms.Show();
            this.Hide();

        }
    }
}
