using RestoranOtomasyonProjesi.Entities;
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

namespace RestoranOtomasyonProjesi.Forms.ManagerForms
{
    public partial class GenelRaporForms : Form
    {
        public GenelRaporForms()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            List<CustomerOrder> customerOrders = new List<CustomerOrder>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from CustomerOrderss";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var customerOrder = new CustomerOrder();

                customerOrder.Id = Convert.ToInt32(dataReader["Id"]);
                customerOrder.WaiterId = Convert.ToInt32(dataReader["WaiterId"]);

                customerOrder.TableId = Convert.ToInt32(dataReader["TAbleId"]);
                customerOrder.TotalOrderPay = Convert.ToInt32(dataReader["TotalOrderPay"]);
                customerOrder.PaymentMethod = dataReader["PaymentMethod"].ToString();

                customerOrders.Add(customerOrder);
            }

            connection.Close();
          RapordataGrid.DataSource = customerOrders;
        }
        CustomerOrder selectedCustomerOrder = null;
    }
}

