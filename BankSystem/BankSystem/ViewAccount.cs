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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankSystem
{
    public partial class ViewAccount : UserControl
    {
        public ViewAccount()
        {
            InitializeComponent();
        }

        private void ViewAccount_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "View Account";
            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select* from CUSTOMER WHERE SSN = '" + Program.customerID + "'";
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            textBox5.Text = reader.GetValue(1).ToString();
            textBox4.Text = reader.GetValue(3).ToString();
            textBox2.Text = reader.GetValue(4).ToString();
            textBox3.Text = reader.GetValue(5).ToString();

            reader.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            string email = textBox4.Text;
            string address = textBox2.Text;

            if (name == "" || email == "")
            {
                MessageBox.Show("Please fill all fileds!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select* from CUSTOMER WHERE SSN = '" + Program.customerID + "'";
            SqlDataReader reader = command.ExecuteReader();



            reader.Close();
            command.CommandText = "UPDATE CUSTOMER SET NAME =  '" + name + "', EMAIL = '" + email + "', ADDRESS = '" + address + "' where SSN = '" + Program.customerID + "';";
            reader = command.ExecuteReader();
            MessageBox.Show("Customer Updated Successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
    }
}
