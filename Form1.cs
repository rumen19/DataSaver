using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataSave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QSQGOK5;Initial Catalog=EmployeeDB;Integrated Security=True");
            string InsertQuey = "Insert into EmployeeTable(EmployeeName,EmployeeAge,EmployeeCity,EmployeeSalary,EmployeeAddress)Values('" + NameBox.Text + "','" + AgeBox.Text + "','" + CityBox.Text + "','" + SalaryBox.Text + "','" + AddressBox.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(InsertQuey, con);
            cmd.ExecuteNonQuery();
            con.Close();
           // Update;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDBDataSet1.EmployeeTable' table. You can move, or remove it, as needed.
            this.employeeTableTableAdapter1.Fill(this.employeeDBDataSet1.EmployeeTable);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
