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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom; Integrated Security = True;");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into dbo.ProductOrders values(@Orderid,@id)", connection);
            command.Parameters.AddWithValue("@Orderid", int.Parse(OrderidTextBox.Text));
            command.Parameters.AddWithValue("@id", int.Parse(ProductTextBox.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Buyurtma qabul qilindi!");
        }
    }
}
