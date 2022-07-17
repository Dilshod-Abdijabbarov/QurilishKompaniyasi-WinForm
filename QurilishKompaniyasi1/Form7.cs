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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DbQurilishKom; Integrated Security = True;");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from dbo.Products as p where p.Quantity<100", connection);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            
        
        }
    }
}
