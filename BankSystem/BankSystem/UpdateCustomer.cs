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
    public partial class UpdateCustomer : UserControl
    {
       
        
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SSN = textBox1.Text;
            string name = textBox5.Text;
            string email = textBox4.Text;
            string address = textBox2.Text;
            string phone = textBox3.Text;
            
            if (SSN == "" || name == "" || email == "" || address == "")
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
            command.CommandText = "select* from CUSTOMER WHERE SSN = '" + SSN + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("This customer isn't exist!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            reader.Close();
            command.CommandText = "UPDADTE CUSTOMER SET NAME =  '" + name + "', EMAIL = '" + email + "', ADDRESS = '" + address + "' where SSN = '"+SSN+"';";
            command.CommandText = "insert into CUSTOMERPHONE values('" + phone + "','" + SSN + "' );";
            reader = command.ExecuteReader();
            MessageBox.Show("Customer Updated Successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void addCustomer_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Update Customer";
        }
    }
}
