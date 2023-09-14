using RestoranOtomasyonProjesi.Entities;
using RestoranOtomasyonProjesi.Forms.CustomerForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System;
using System.IO;


namespace RestoranOtomasyonProjesi.Forms
{
    public partial class SiparişOluşturmaForms : Form

    {
        Product selectedProduct;
        WaiterOrder waiterOrder;
        MasaId selectedMasa;
        private string selectedMasaId;





        public SiparişOluşturmaForms(string selectedMasaId)
        {
            InitializeComponent();


            this.selectedMasaId = selectedMasaId;

        }

        public SiparişOluşturmaForms()
        {
        }
        private void GetÇorba()
        {
            List<Product> Çorbas = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "  select * from Menus where ProductCategory = 1 ";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var Çorba = new Product();

                Çorba.Id = Convert.ToInt32(dataReader["Id"]);
                Çorba.Name = dataReader["ProductName"].ToString();

                Çorba.Price = dataReader["ProductPrice"].ToString();
                Çorba.CookTime = dataReader["PreparationTime"].ToString();
                Çorba.Category = Convert.ToInt32(dataReader["ProductCategory"]);

                Çorbas.Add(Çorba);
            }

            connection.Close();
            dataGridView1.DataSource = Çorbas;


        }



        private void GetSalata()
        {
            List<Product> salatas = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "  select * from Menus where ProductCategory = 4 ";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var salata = new Product();

                salata.Id = Convert.ToInt32(dataReader["Id"]);
                salata.Name = dataReader["ProductName"].ToString();

                salata.Price = dataReader["ProductPrice"].ToString();
                salata.CookTime = dataReader["PreparationTime"].ToString();
                salata.Category = Convert.ToInt32(dataReader["ProductCategory"]);

                salatas.Add(salata);
            }

            connection.Close();
            dataGridView1.DataSource = salatas;


        }


        private void GetAra()
        {
            List<Product> aras = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "  select * from Menus where ProductCategory = 3 ";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var ara = new Product();

                ara.Id = Convert.ToInt32(dataReader["Id"]);
                ara.Name = dataReader["ProductName"].ToString();
                ara.Price = dataReader["ProductPrice"].ToString();

                ara.CookTime = dataReader["PreparationTime"].ToString();
                ara.Category = Convert.ToInt32(dataReader["ProductCategory"]);

                aras.Add(ara);
            }

            connection.Close();
            dataGridView1.DataSource = aras;


        }


        private void GetÇik()
        {
            List<Product> çiks = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "  select * from Menus where ProductCategory = 5 ";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var çik = new Product();

                çik.Id = Convert.ToInt32(dataReader["Id"]);
                çik.Name = dataReader["ProductName"].ToString();
                çik.Price = dataReader["ProductPrice"].ToString();

                çik.CookTime = dataReader["PreparationTime"].ToString();
                çik.Category = Convert.ToInt32(dataReader["ProductCategory"]);

                çiks.Add(çik);
            }

            connection.Close();
            dataGridView1.DataSource = çiks;


        }


        private void GetAna()
        {
            List<Product> anas = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "  select * from Menus where ProductCategory = 2 ";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var ana = new Product();

                ana.Id = Convert.ToInt32(dataReader["Id"]);
                ana.Name = dataReader["ProductName"].ToString();
                ana.Price = dataReader["ProductPrice"].ToString();

                ana.CookTime = dataReader["PreparationTime"].ToString();
                ana.Category = Convert.ToInt32(dataReader["ProductCategory"]);

                anas.Add(ana);
            }

            connection.Close();
            dataGridView1.DataSource = anas;


        }


        private void GetŞer()
        {
            List<Product> şers = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "  select * from Menus where ProductCategory = 6 ";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var şer = new Product();

                şer.Id = Convert.ToInt32(dataReader["Id"]);
                şer.Name = dataReader["ProductName"].ToString();
                şer.Price = dataReader["ProductPrice"].ToString();

                şer.CookTime = dataReader["PreparationTime"].ToString();
                şer.Category = Convert.ToInt32(dataReader["ProductCategory"]);

                şers.Add(şer);
            }

            connection.Close();
            dataGridView1.DataSource = şers;


        }


        private void GetSüt()
        {
            List<Product> süts = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "  select * from Menus where ProductCategory = 7 ";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var süt = new Product();

                süt.Id = Convert.ToInt32(dataReader["Id"]);
                süt.Name = dataReader["ProductName"].ToString();
                süt.Price = dataReader["ProductPrice"].ToString();

                süt.CookTime = dataReader["PreparationTime"].ToString();
                süt.Category = Convert.ToInt32(dataReader["ProductCategory"]);

                süts.Add(süt);
            }

            connection.Close();
            dataGridView1.DataSource = süts;


        }


        private void GetHazır()
        {
            List<Product> hazırs = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "  select * from Menus where ProductCategory = 10 ";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var hazır = new Product();

                hazır.Id = Convert.ToInt32(dataReader["Id"]);
                hazır.Name = dataReader["ProductName"].ToString();
                hazır.Price = dataReader["ProductPrice"].ToString();

                hazır.CookTime = dataReader["PreparationTime"].ToString();
                hazır.Category = Convert.ToInt32(dataReader["ProductCategory"]);

                hazırs.Add(hazır);
            }

            connection.Close();
            dataGridView1.DataSource = hazırs;


        }


        private void GetÇay()
        {
            List<Product> çays = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "  select * from Menus where ProductCategory = 8 ";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var çay = new Product();

                çay.Id = Convert.ToInt32(dataReader["Id"]);
                çay.Name = dataReader["ProductName"].ToString();
                çay.Price = dataReader["ProductPrice"].ToString();

                çay.CookTime = dataReader["PreparationTime"].ToString();
                çay.Category = Convert.ToInt32(dataReader["ProductCategory"]);

                çays.Add(çay);
            }

            connection.Close();
            dataGridView1.DataSource = çays;


        }


        private void GetKahve()
        {
            List<Product> kahves = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "  select * from Menus where ProductCategory = 9 ";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var kahve = new Product();

                kahve.Id = Convert.ToInt32(dataReader["Id"]);
                kahve.Name = dataReader["ProductName"].ToString();
                kahve.Price = dataReader["ProductPrice"].ToString();

                kahve.CookTime = dataReader["PreparationTime"].ToString();
                kahve.Category = Convert.ToInt32(dataReader["ProductCategory"]);

                kahves.Add(kahve);
            }

            connection.Close();
            dataGridView1.DataSource = kahves;


        }
        private void GetList()
        {
            List<Product> products = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from Menus";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var product = new Product();

                product.Id = Convert.ToInt32(dataReader["Id"]);
                product.Name = dataReader["ProductName"].ToString();

                product.Price = dataReader["ProductPrice"].ToString();
                product.CookTime = dataReader["PreparationTime"].ToString();
                product.Category = Convert.ToInt32(dataReader["ProductCategory"]);

                products.Add(product);
            }

            connection.Close();
            dataGridView1.DataSource = products;
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                if (row != null)
                {
                    selectedProduct = new Product();
                    selectedProduct.Id = (int)(row.Cells[0].Value);
                    selectedProduct.Name = row.Cells[1].Value.ToString();
                    selectedProduct.CookTime = row.Cells[2].Value.ToString();
                    selectedProduct.Price = row.Cells[3].Value.ToString();
                    selectedProduct.Category = (int)(row.Cells[4].Value);


                    txtürünId.Text = selectedProduct.Id.ToString();
                    txtÜrünİsmi.Text = selectedProduct.Name;
                    txtÜrünFiyat.Text = selectedProduct.Price;
                    txtÜrünHazırlık.Text = selectedProduct.CookTime;
                    txtMasaIdd.Text = selectedMasaId.ToString();


                }

            }
        }

        private void GoDatabase()
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");
            connection.Open();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow) // Yeni eklenen satırı atlayın
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "INSERT INTO WaiterOrders ( ProductName, PreparationTime, ProductPrice,MasaId) " +
                        "VALUES ( @Name, @CookTime, @Price,@MasaId)";

                    // command.Parameters.AddWithValue("@Id", Convert.ToInt32(row.Cells[0].Value));
                    command.Parameters.AddWithValue("@Name", row.Cells[1].Value.ToString());
                    command.Parameters.AddWithValue("@CookTime", row.Cells[2].Value.ToString());
                    command.Parameters.AddWithValue("@Price", row.Cells[3].Value.ToString());
                    command.Parameters.AddWithValue("@MasaId", Convert.ToInt32(row.Cells[4].Value));


                    int effectedRows = command.ExecuteNonQuery();
                }
            }

            connection.Close();
            MessageBox.Show("Tüm veriler başarıyla eklenmiştir.");



        }




        private void btnEkle_Click(object sender, EventArgs e)
        {


            dataGridView2.Rows.Add(txtürünId.Text, txtÜrünİsmi.Text, txtÜrünFiyat.Text, txtÜrünHazırlık.Text, txtMasaIdd.Text);




        }


        private void btnSiparişBitir_Click_1(object sender, EventArgs e)
        {
            GoDatabase();

            CustomerLastForms customerLastForms = new CustomerLastForms();
            customerLastForms.Show();
            this.Hide();

        }

        private void btnÇorba_Click(object sender, EventArgs e)
        {
            GetÇorba();
        }

        private void btnSalata_Click(object sender, EventArgs e)
        {
            GetSalata();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            GetAra();
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            GetAna();
        }

        private void btnçikolata_Click(object sender, EventArgs e)
        {
            GetÇik();
        }

        private void btnşŞerbetli_Click(object sender, EventArgs e)
        {
            GetŞer();
        }

        private void btnSütlü_Click(object sender, EventArgs e)
        {
            GetSüt();
        }

        private void btnHazırİçecekler_Click(object sender, EventArgs e)
        {
            GetHazır();
        }

        private void btnÇaylar_Click(object sender, EventArgs e)
        {
            GetÇay();
        }

        private void btnKahveler_Click(object sender, EventArgs e)
        {
            GetKahve();
        }
    }
}








