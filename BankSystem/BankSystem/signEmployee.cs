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

namespace BankSystem
{
    public partial class signEmployee : UserControl
    {
        public signEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pass = textBox8.Text;
            string name = textBox3.Text;
            string title = textBox2.Text;
            string email = textBox5.Text;
            string phone = textBox6.Text;
            string address = textBox7.Text;
            string branch = textBox4.Text;


            if (id == "" || pass == "" || name == "" || title == "" || email == "" || phone == "" || address == "" || branch == "")
            {
                MessageBox.Show("Please Enter All fields", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select* from Employee WHERE EMPLOYEEID = '" + id + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("This Employee already Exists", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            reader.Close();
            command.CommandText = "insert into EMPLOYEE(EMPLOYEEID, PASSWORD, NAME, ADDRESS, PHONENUM, TITLE, EMAIL, BRANCHNO) values('" + id + "', '" + pass + "', '" + name + "', '" + address + "', '" + phone + "', '" + title + "', '" + email + "', '" + branch + "');";
            SqlDataReader sqlDataReader = command.ExecuteReader();
            reader = sqlDataReader;
            MessageBox.Show("Employee signed successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void signEmployee_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Sign Employee";
        }
    }
}
