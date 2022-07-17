using QurilishKompaniyasi1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QurilishKompaniyasi1.Models;
using System.Data.SqlClient;

namespace QurilishKompaniyasi1
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
           
        }


        
        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select p.id, p.ProductName,p.CompanyName,p.Quantity,p.Price,p.Categoryid,c.CategoryName From Products as p join Categories as c on p.Categoryid=c.Categoryid", connection);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            AddProductForm3 form3 = new AddProductForm3();
            form3.Show();                              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom; Integrated Security = True;");
            connection.Open();
            string matn= "select  p.id, p.ProductName,p.CompanyName,p.Quantity,p.Price,p.Categoryid  from dbo.Products as p where p.ProductName like '%"+ProductSearch.Text+"%'";
            SqlCommand command = new SqlCommand(matn, connection);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom; Integrated Security = True;");
            connection.Open();
            SqlCommand command = new SqlCommand("Delete dbo.Products where id=@id", connection);
            command.Parameters.AddWithValue("@id", int.Parse(DeletetextBox.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Product o'chirildi!");
            command.Cancel();
            SqlCommand sqlCommand = new SqlCommand("Select p.id, p.ProductName,p.CompanyName,p.Quantity,p.Price,p.Categoryid,c.CategoryName From Products as p join Categories as c on p.Categoryid=c.Categoryid", connection);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
