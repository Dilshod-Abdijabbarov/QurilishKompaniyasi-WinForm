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

namespace QurilishKompaniyasi1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into dbo.Orders values(@OrderDate,@Customerid,@Employeid)", connection);
            //SqlCommand sqlCommand = new SqlCommand("insert into dbo.Orders values(@OrderDate,@Customerid,@Employeid,@Orders.Products)", connection);
            sqlCommand.Parameters.AddWithValue("@OrderDate", OrderTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Customerid", int.Parse((CustomeridTextBox.Text)));
            sqlCommand.Parameters.AddWithValue("@Employeid", int.Parse(PositionTextBox.Text));
            //sqlCommand.Parameters.AddWithValue("@Orders.Products", 14);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Order Bazaga qoshildi!");
        }

        private void UpdateEmplbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand command = new SqlCommand("Update dbo.Orders Set OrderDate=@OrderDate,Customerid=@Customerid,@Employeid=@Employeid where Orderid=@Orderid",connection);
           
            command.Parameters.AddWithValue("@Orderid",int.Parse(OrderidtextBox.Text));
            command.Parameters.AddWithValue("@OrderDate", OrderTextBox.Text);
            command.Parameters.AddWithValue("@Customerid", int.Parse((CustomeridTextBox.Text)));
            command.Parameters.AddWithValue("@Employeid", int.Parse(PositionTextBox.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Order malumotlari o'rgartirildi!");

        }

        private void Quantitylabel_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void PositionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomeridTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
