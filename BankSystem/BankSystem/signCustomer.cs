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
    public partial class signCustomer : UserControl
    {
        public signCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox8.Text;
            string email = textBox2.Text;
            string pass = textBox5.Text;
            string birth = textBox4.Text;
            string address = textBox3.Text; 

            if (id == "" || pass == "" || name == "" || email == "" || birth == "" || address == "")
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
            command.CommandText = "select* from CUSTOMER WHERE SSN = '" + id + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("This Customer already Exists", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            reader.Close();
            command.CommandText = "insert into CUSTOMER(SSN, PASSWORD, ADDRESS, DATEBIRTH, EMAIL, NAME) values('" + id + "', '" + pass + "', '"+address+"', '"+birth+"', '"+email+"', '"+name+"');";
            reader = command.ExecuteReader();
            MessageBox.Show("Customer signed successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void signCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
