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
    public partial class AddCategoryForm3 : Form
    {
        public AddCategoryForm3()
        {
            InitializeComponent();
        }

        private void AddCategorybutton2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into dbo.Categories values(@CategoryName)", connection);
          //  sqlCommand.Parameters.AddWithValue("@id", int.Parse("1"));
            sqlCommand.Parameters.AddWithValue("@CategoryName", CategoryNameTextBox.Text);
           
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Cancel();
            SqlCommand Command = new SqlCommand("Select * From Categories", connection);
            SqlDataAdapter data = new SqlDataAdapter(Command);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();


            MessageBox.Show("Category Bazaga qoshildi!");
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom; Integrated Security = True;");
            connection.Open();
            string matn = "select  * from dbo.Categories as c where c.CategoryName like '%" + textBox1.Text + "%'";
            SqlCommand command = new SqlCommand(matn, connection);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update dbo.Categories Set CategoryName=@CategoryName where Categoryid=@Categoryid", connection);
            sqlCommand.Parameters.AddWithValue("@Categoryid", int.Parse(textBox2.Text));
            sqlCommand.Parameters.AddWithValue("@CategoryName", textBox4.Text);
          
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Cancel();
            SqlCommand Command = new SqlCommand("Select * From Categories", connection);
            SqlDataAdapter data = new SqlDataAdapter(Command);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
            MessageBox.Show("Category malumotlari o'zgartirildi!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom; Integrated Security = True;");
            connection.Open();
            SqlCommand command = new SqlCommand("Delete dbo.Categories where Categoryid=@Categoryid", connection);
            command.Parameters.AddWithValue("@Categoryid", int.Parse(textBox3.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Product o'chirildi!");
            command.Cancel();
            SqlCommand sqlCommand = new SqlCommand("Select * From Categories", connection);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
    }
}
