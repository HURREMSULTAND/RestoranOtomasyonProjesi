using RestoranOtomasyonProjesi.Entities;
using RestoranOtomasyonProjesi.Forms.CustomerForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestoranOtomasyonProjesi.Forms
{
    public partial class OrderOnayForms : Form
    {
        Orders selectedOrders;
        WaiterOrder waiterOrder;
        CustomerOrder customerOrder;

        public static string SiparisSuresi { get; set; }
        public OrderOnayForms()
        {
            InitializeComponent();

            ListWaiterOrders();
        }


        private void ListWaiterOrders()
        {

            List<WaiterOrder> waiterOrders = new List<WaiterOrder>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from WaiterOrders ";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var waiterOrder = new WaiterOrder();

                waiterOrder.Id = Convert.ToInt32(dataReader["Id"]);
                waiterOrder.Name = dataReader["ProductName"].ToString();

                waiterOrder.Price = dataReader["ProductPrice"].ToString();
                waiterOrder.CookTime = dataReader["PreparationTime"].ToString();
                waiterOrder.MasaId = Convert.ToInt32(dataReader["MasaId"]);
                waiterOrder.Onay = dataReader["Onay"].ToString();


                waiterOrders.Add(waiterOrder);
            }

            connection.Close();
            WaiterDataGrid.DataSource = waiterOrders;





        }
        private void OrderOnayForms_Load(object sender, EventArgs e)
        {

            WaiterDataGrid.DefaultCellStyle.BackColor = Color.Beige;

            // GetCustomerOrders();
        }

        private void WaiterDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                var row = WaiterDataGrid.Rows[e.RowIndex];
                if (row != null)
                {
                    waiterOrder = new WaiterOrder();
                    waiterOrder.Id = (int)row.Cells[0].Value;
                    waiterOrder.Onay = row.Cells[5].Value.ToString();
                    //selectedOrders. = (int)(row.Cells[1].Value);
                    //selectedOrders.TableId = (int)(row.Cells[2].Value);
                    //selectedOrders.TotalOrderPay = (int)(row.Cells[3].Value);
                    //selectedOrders.PaymentMethod = row.Cells[4].Value.ToString();
                    //selectedOrders.Onay = row.Cells[4].Value.ToString();



                    //txtWaiterId.Text = selectedOrders.WaiterId.ToString();
                    //txtTableId.Text = selectedOrders.TableId.ToString();
                    //txtTotalPay.Text = selectedOrders.TotalOrderPay.ToString();
                    //txtPAymentMet.Text = selectedOrders.PaymentMethod.ToString();
                }
            }
        }

        private List<int> onaylananSatirlar = new List<int>();
        private void btnOnayVer_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in WaiterDataGrid.SelectedRows)
            {
                int orderId = Convert.ToInt32(row.Cells[0].Value);
                string yeniOnay = "Onaylandı";


                UpdateWaiterOrderOnay(orderId, yeniOnay);
                onaylananSatirlar.Add(orderId);
            }


            ListWaiterOrders();
            foreach (DataGridViewRow row in WaiterDataGrid.Rows)
            {
                int orderId = Convert.ToInt32(row.Cells[0].Value);
                if (onaylananSatirlar.Contains(orderId))
                {
                    row.DefaultCellStyle.BackColor = Color.Green;

                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Beige;
                }
            }
        }

        private void UpdateWaiterOrderOnay(int orderId, string yeniOnay)
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE WaiterOrders SET Onay = @YeniOnay WHERE Id = @OrderId";

            command.Parameters.AddWithValue("@YeniOnay", yeniOnay);
            command.Parameters.AddWithValue("@OrderId", orderId);

            int effectedRows = command.ExecuteNonQuery();

            connection.Close();

            if (effectedRows > 0)
            {
                foreach (DataGridViewRow row in WaiterDataGrid.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == orderId)
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                        break;

                    }
                    GetCustomerOrderss();
                }
            }
            else
            {
                MessageBox.Show("Onay güncellenirken bir hata oluştu.");
            }


        }
        private void GetCustomerOrderss()
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
            CustomerDataGrid.DataSource = customerOrders;
        }
        CustomerOrder selectedCustomerOrder = null;

        private void CustomerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = WaiterDataGrid.Rows[e.RowIndex];
                if (row != null)
                {
                    customerOrder = new CustomerOrder();
                    customerOrder.Id = (int)row.Cells[0].Value;
                    customerOrder.WaiterId = (int)row.Cells[1].Value;
                    customerOrder.TableId = (int)row.Cells[2].Value;
                    customerOrder.TotalOrderPay = (int)row.Cells[3].Value;
                    customerOrder.PaymentMethod = row.Cells[4].Value.ToString();



                    txtId.Text = selectedCustomerOrder.WaiterId.ToString();
                    txtWaiterId.Text = selectedCustomerOrder.WaiterId.ToString();
                    txtTableId.Text = selectedCustomerOrder.TableId.ToString();
                    txtTotalPay.Text = selectedCustomerOrder.ToString();
                    txtPAymentMet.Text = selectedCustomerOrder.PaymentMethod.ToString();

                }

            }


        }
        private void btnCustomerOrdersEkle_Click(object sender, EventArgs e)
        {
            int Id = (int)Convert.ToUInt32(txtId.Text);
            int waiterId = Convert.ToInt32(txtWaiterId.Text);
            int tableId = Convert.ToInt32(txtTableId.Text);
            int totalOrderPay = Convert.ToInt32(txtTotalPay.Text);
            string paymentMethod = txtPAymentMet.Text;


            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");
            connection.Open();

            
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;

   
            command.CommandText = "INSERT INTO CustomerOrderss (Id,WaiterId, TableId, TotalOrderPay, PaymentMethod) " +
                "VALUES (@Id,@WaiterId, @TableId, @TotalOrderPay, @PaymentMethod)";

            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@WaiterId", waiterId);
            command.Parameters.AddWithValue("@TableId", tableId);
            command.Parameters.AddWithValue("@TotalOrderPay", totalOrderPay);
            command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

            
            int effectedRows = command.ExecuteNonQuery();

            
            connection.Close();

       
            if (effectedRows > 0)
            {
                MessageBox.Show("Veri başarıyla eklendi.");


               
                GetCustomerOrderss();


            }
            else
            {
                MessageBox.Show("Veri eklenirken bir hata oluştu.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string siparisSuresi = Program.SiparisSuresi;
            siparisSuresi = txtSiparişSüresi.Text;
            if (!string.IsNullOrEmpty(siparisSuresi))
            {
                // Sipariş süresi değeri doluysa onaylama işlemi yapılabilir
                // Örnek olarak MessageBox ile onaylama yapabilirsiniz
                MessageBox.Show("Sipariş süresi onaylandı: " + siparisSuresi);
            }
            else
            {
                // Sipariş süresi değeri boşsa hata mesajı gösterilebilir
                MessageBox.Show("Sipariş süresi boş. Lütfen bir süre girin.");
            }
            CustomerLastForms customerLastForm = new CustomerLastForms(siparisSuresi);
           
            customerLastForm.Show();
            this.Hide();
        }
    }

}














