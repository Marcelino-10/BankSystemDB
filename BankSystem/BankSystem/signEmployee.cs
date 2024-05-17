using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
            string name = textBox5.Text;
            string pass = textBox8.Text;
            string email = textBox4.Text;
            string address = textBox2.Text;
            string phone = textBox3.Text;
            string title = textBox7.Text;
            string branchNo = textBox6.Text;

            if(id == "" || name == "" || pass == "" || email == "" || address == "" || phone == "" || title == "" || branchNo  == "")
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
            command.CommandText = "select* from EMPLOYEE WHERE SSN = '" + id + "'";
            SqlDataReader reader = command.ExecuteReader();

            if(reader.Read())
            {
                MessageBox.Show("This Employee already Exists", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close(); 
                return;
            }

            reader.Close();
            command.CommandText = "insert into EMPLOYEE values("+id+", "+branchNo+", "+name+", "+name+", "+address+", "+phone+", "+title+", "+email+", "+pass+");";
            reader = command.ExecuteReader();
            MessageBox.Show("Employee signed successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
    }
}
