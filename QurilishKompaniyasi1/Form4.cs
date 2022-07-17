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
    public partial class AddEmployeForm4 : Form
    {
        public AddEmployeForm4()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into dbo.Employees values(@FirstName,@LastName,@Position,@Address,@PhoneNummer,@StartWorking)", connection);
            sqlCommand.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Position", PositionTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Address", AddressTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PhoneNummer", PhoneNummertextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Startworking",DateTime.Now);
            sqlCommand.ExecuteNonQuery();
            connection.Close();


            MessageBox.Show("Product Bazaga qoshildi!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllEmployees all =new  AllEmployees();
            all.Show();

        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateEmplbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom;Integrated Security=True;");
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update dbo.Employees Set FirstName=@FirstName,LastName=@LastName,Position=@Position,Address=@Address,PhoneNummer=@PhoneNummer,StartWorking=@StartWorking where Employeid=@Employeid", connection);
            sqlCommand.Parameters.AddWithValue("@Employeid", int.Parse(employeidtextBox.Text));
            sqlCommand.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Position", PositionTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Address", AddressTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PhoneNummer", PhoneNummertextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Startworking", StartDateTextBox.Text);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Employee malumotlari o'zgartirildi!");
        }
    }
}
