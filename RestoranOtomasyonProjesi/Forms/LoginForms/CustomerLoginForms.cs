using RestoranOtomasyonProjesi.Entities;
using RestoranOtomasyonProjesi.Forms;
using RestoranOtomasyonProjesi.LoginForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RestoranOtomasyonProjesi
{
    public partial class CustomerLoginForms : Form
    {
        private MasaId selectedMasa;
        private string selectedMasaId;

        public CustomerLoginForms()
        {
            InitializeComponent();
            selectedMasa = new MasaId();


        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            FirstLoginForms firstLoginForms = new FirstLoginForms();
            firstLoginForms.Show();
            this.Hide();

        }
        private void CustomerLoginForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (cmbMasaId.SelectedItem != null) 
            {
                SiparişOluşturmaForms siparişOluşturmaForms = new SiparişOluşturmaForms(selectedMasaId);
                siparişOluşturmaForms.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Lütfen önce masa numaranızı seçiniz!");
            }


        }
        private void GetMasaId()
        {
            List<MasaId> masaIds = new List<MasaId>();
            SqlConnection connection = new SqlConnection
               ("server=.\\SQLExpress; database=RestaurantDb; integrated security=true; ");
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from RestaurantTables";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                var masaId = new MasaId();

                masaId.Id = Convert.ToInt32(dataReader[0]);
                masaIds.Add(masaId);


            }
            connection.Close();
           

            cmbMasaId.DataSource = null;
            cmbMasaId.DataSource = masaIds;
            cmbMasaId.DisplayMember = "Id";





        }

        private void cmbMasaId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMasaId.SelectedItem != null)
            {
                selectedMasa = (MasaId)cmbMasaId.SelectedItem;
                selectedMasaId = selectedMasa.Id.ToString();

                txtMasaId.Text = selectedMasaId;
               
            }
          
        }
        
        private void cmbMasaId_Click(object sender, EventArgs e)
        {
            if (true)
            {
                GetMasaId();

            }
          
        }
    }
}


































