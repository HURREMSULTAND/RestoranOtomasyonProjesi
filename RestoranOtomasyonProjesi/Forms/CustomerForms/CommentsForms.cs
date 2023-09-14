
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
using RestoranOtomasyonProjesi.Entities;
using RestoranOtomasyonProjesi.Forms.CustomerForms;

namespace RestoranOtomasyonProjesi.Forms
{
    public partial class CommentsForms : Form
    {
       

        private void GetComments()
        {
         
            List<Comment> comments = new List<Comment>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=RestaurantDb; integrated security=true;");



            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from CustomerComments";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var comment = new Comment();

                comment.Id = Convert.ToInt32(dataReader["Id"]);
                comment.Name = dataReader["Name"].ToString();

                comment.Surname = dataReader["Surname"].ToString();
                comment.OrderId = Convert.ToInt32(dataReader["OrderId"]);
                comment.Rating = Convert.ToInt32(dataReader["Rating"]);
                comment.Description = dataReader["Description"].ToString();

                comments.Add(comment);
            }

            connection.Close();
            dataGridView1.DataSource = comments;
        }

       
    }




}


