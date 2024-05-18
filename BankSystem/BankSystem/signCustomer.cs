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
            string pass = textBox2.Text;

            if (id == "" || pass == "")
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

            if (!reader.Read())
            {
                MessageBox.Show("The entered SSN doesn't exist, you can make a new account by visiting the nearest branch!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            reader.Close();

            command.CommandText = "select password from CUSTOMER WHERE SSN = '" + id + "' and password is not null";
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                DialogResult result = MessageBox.Show("The entered SSN already have an account, you can login using the login page.", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            reader.Close();

            command.CommandText = "Update customer set password = '"+ pass +"' where ssn = '"+ id +"'";
            reader = command.ExecuteReader();


            MessageBox.Show("You have signed in successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void signCustomer_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Sign In";
            Program.main.LogoutButton.Text = "Login";
        }
    }
}
