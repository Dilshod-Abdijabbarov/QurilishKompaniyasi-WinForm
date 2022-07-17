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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm4 form4 = new AddCustomerForm4();
            form4.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From Customers", connection);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom; Integrated Security = True;");
            connection.Open();
            string matn = "select  *  from dbo.Customers as c where c.CustomerName like '%" + CustomerSearch.Text + "%'";
            SqlCommand command = new SqlCommand(matn, connection);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom; Integrated Security = True;");
            connection.Open();
            SqlCommand command = new SqlCommand("Delete dbo.Customers where Customerid=@Customerid", connection);
            command.Parameters.AddWithValue("@Customerid", int.Parse(DeletetextBox.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Customer o'chirildi!");
            command.Cancel();
            SqlCommand sqlCommand = new SqlCommand("Select * From  dbo.Customers", connection);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
    }
}
