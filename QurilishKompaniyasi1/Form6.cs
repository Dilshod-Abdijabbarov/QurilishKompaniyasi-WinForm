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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select o.Orderid,o.OrderDate,o.Customerid,o.Employeid From Orders as o", connection);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom; Integrated Security = True;");
            connection.Open();
            string matn = "select  p.Orderid, p.OrderDate,p.Customerid,p.Employeid from dbo.Orders as p where p.OrderDate like '%" + ProductSearch.Text + "%'";
            SqlCommand command = new SqlCommand(matn, connection);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom; Integrated Security = True; ");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete dbo.Orders where Orderid=@Orderid",connection);
            sqlCommand.Parameters.AddWithValue("@Orderid", int.Parse(DeletetextBox.Text));
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Cancel();
            SqlCommand command = new SqlCommand("Select Orderid,OrderDate,Customerid,Employeid from dbo.Orders",connection);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
            


        }
    }
}
