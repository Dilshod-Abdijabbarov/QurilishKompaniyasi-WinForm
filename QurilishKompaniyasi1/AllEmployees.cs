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
    public partial class AllEmployees : Form
    {
        public AllEmployees()
        {
            InitializeComponent();
        }

        private void AllEmployees_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From Employees", connection);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            data.Fill(table);
            connection.Close();
            dataGridView1.DataSource = table;

        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
                form1.Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddEmployeForm4 form4 = new AddEmployeForm4();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom; Integrated Security = True;");
            connection.Open();
            string matn = "select *  from dbo.Employees as p where p.FirstName like '%" + EmployeeSearch.Text + "%'";
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
            SqlCommand command = new SqlCommand("Delete dbo.Employees where Employeid=@Employeid", connection);
            command.Parameters.AddWithValue("@Employeid", int.Parse(DeletetextBox1.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Employee o'chirildi!");
            command.Cancel();
            SqlCommand sqlCommand = new SqlCommand("Select * From dbo.Employees", connection);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
    }
}
