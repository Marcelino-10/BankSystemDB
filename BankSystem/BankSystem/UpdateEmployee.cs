using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace BankSystem
{
    public partial class UpdateEmployee : UserControl
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void reset()
        {
            textBox2.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox8.Clear();
            textBox6.Clear();
            textBox3.Clear();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Update Employee";
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SSN = textBox1.Text;
            string name = textBox5.Text;
            string email = textBox4.Text;
            string address = textBox2.Text;
            string title = textBox8.Text;
            string phone = textBox3.Text;
            string branch = textBox6.Text;

            if (SSN == "" || name == "" || email == "" || address == "" || title == "" || phone == "" || branch == "")
            {
                MessageBox.Show("Please fill all fileds!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (phone.Length > 11)
            {
                MessageBox.Show("Invalid Phone number!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select* from EMPLOYEE WHERE EMPLOYEEID = '" + SSN + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("This Employee isn't exist!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            reader.Close();

            command.CommandText = "select* from branch WHERE branchno = '" + branch + "'";
            reader = command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("Invalid Branch number!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reader.Close();
            command.CommandText = "UPDATE EMPLOYEE SET NAME =  '" + name + "', EMAIL = '" + email + "', ADDRESS = '" + address + "', TITLE = '" + title + "', BRANCHNO = '" + branch + "', PHONENUM = '" + phone + "' where EMPLOYEEID = '" + SSN + "';";
            reader = command.ExecuteReader();
            MessageBox.Show("Employee Updated Successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SSN = textBox1.Text;

            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select* from employee WHERE employeeid = '" + SSN + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("This Employee doesn't exist!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                textBox5.Text = reader["name"].ToString();
                textBox4.Text = reader["email"].ToString();
                textBox2.Text = reader["address"].ToString();
                textBox8.Text = reader["title"].ToString();
                textBox3.Text = reader["phonenum"].ToString();
                textBox6.Text = reader["branchno"].ToString();
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox8.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox3.ReadOnly = false;
            }
            reader.Close();
            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            reset();
        }
    }
}
