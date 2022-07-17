
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QurilishKompaniyasi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Products_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            //AddProductForm3 form3= new AddProductForm3();
            //form3.Show();
        }

        private void AddCategorybutton_Click(object sender, EventArgs e)
        {
            AddCategoryForm3 form3 = new AddCategoryForm3();
            form3.Show();
        }

        private void AddCustomerbutton_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            AllEmployees form4 = new AllEmployees();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            AllEmployees form4 = new AllEmployees();
            form4.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            AddCategoryForm3 form3 = new AddCategoryForm3();
            form3.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            //qoshimcha ish qilish uchun oyna
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
