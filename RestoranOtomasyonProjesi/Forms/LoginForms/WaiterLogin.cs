using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranOtomasyonProjesi.Forms.LoginForms
{
    public partial class WaiterLogin : Form
    {
        public WaiterLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtWad.Text;
            string password = txtWPas.Text;
            if (!string.IsNullOrEmpty(txtWad.Text) && !string.IsNullOrEmpty(txtWPas.Text)) ;

            string connectionString = "server=.\\SQLExpress; database=RestarantDB; integrated security=true;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Waiters WHERE UserName = @UserName AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                          
                            OrderOnayForms  orderOnay= new OrderOnayForms();
                           orderOnay.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış. Lütfen tekrar deneyin.");
                        }
                    }
                }
            }
        }
    }
}
