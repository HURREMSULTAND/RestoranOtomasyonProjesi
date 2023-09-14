

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RestoranOtomasyonProjesi.Entities;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Data.SqlClient;
using RestoranOtomasyonProjesi.LoginForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RestoranOtomasyonProjesi
{
    public partial class ManagerLogins : Form
    {
        // private IUserWaiterRepository userWaiterRepository;
        public ManagerLogins()
        {
            InitializeComponent();

        }




        private void btnBack2_Click_1(object sender, EventArgs e)
        {
            FirstLoginForms firstLoginForms = new FirstLoginForms();
            firstLoginForms.Show();
            this.Hide();

        }


        private void UserwaiterLoginForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AppUserLoginForms_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}


















