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
    public partial class AddCustomerForm4 : Form
    {
        public AddCustomerForm4()
        {
            InitializeComponent();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into dbo.Customers values(@CustomerName,@Address,@PhoneNummer)", connection);
            sqlCommand.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text);       
            sqlCommand.Parameters.AddWithValue("@Address", CustomerAddressTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PhoneNummer", CustomerPhoneTextBox.Text);
           
            sqlCommand.ExecuteNonQuery();
            connection.Close();


            MessageBox.Show("Customer Bazaga qoshildi!");

        }

        private void AddCustomerForm4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update dbo.Customers Set CustomerName=@CustomerName,Address=@Address,PhoneNummer=@PhoneNummer where Customerid=@Customerid", connection);
            sqlCommand.Parameters.AddWithValue("@Customerid", int.Parse(UpdatetextBox.Text));
            sqlCommand.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Address", CustomerAddressTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PhoneNummer", CustomerPhoneTextBox.Text);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Customer malumotlari o'zgartirildi!");
        
        }
    }
}
