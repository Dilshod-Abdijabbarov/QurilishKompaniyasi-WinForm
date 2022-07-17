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
    public partial class AddProductForm3 : Form
    {
        public AddProductForm3()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand command = new SqlCommand("Select ProductName from dbo.Products",connection);
        
                SqlCommand sqlCommand = new SqlCommand("insert into dbo.Products values(@ProductName,@Price,@CompanyName,@Quantity,@Categoryid)", connection);
               // SqlCommand sqlCommand = new SqlCommand("insert into dbo.Products values(@ProductName,@Price,@CompanyName,@Quantity,@Categoryid)", connection);
                sqlCommand.Parameters.AddWithValue("@ProductName", ProductTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@Price", decimal.Parse((PriceTextBox.Text)));
                sqlCommand.Parameters.AddWithValue("@CompanyName", CompanyNameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@Quantity", int.Parse(QuantityTextBox.Text));
                sqlCommand.Parameters.AddWithValue("@Categoryid", int.Parse((CategoryTextBox.Text)));
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Product Bazaga qoshildi!");
            
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddProductForm3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update dbo.Products Set ProductName=@ProductName,Price=@Price,CompanyName=@CompanyName,Quantity=@Quantity,Categoryid=@Categoryid where id=@id", connection);
            sqlCommand.Parameters.AddWithValue("@id", int.Parse (ProductidtextBox.Text));
            sqlCommand.Parameters.AddWithValue("@ProductName", ProductTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Price", decimal.Parse((PriceTextBox.Text)));
            sqlCommand.Parameters.AddWithValue("@CompanyName", CompanyNameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Quantity", int.Parse(QuantityTextBox.Text));
            sqlCommand.Parameters.AddWithValue("@Categoryid", int.Parse((CategoryTextBox.Text)));
            sqlCommand.ExecuteNonQuery();
            connection.Close();


            MessageBox.Show("Product O'zgartirildi!");
        }
    }
}
