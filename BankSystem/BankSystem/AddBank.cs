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
    public partial class AddBank : UserControl
    {
        public AddBank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text;  
            string name = textBox2.Text;
            string address = textBox3.Text;
            if (code == "" || name == "" || address == "")
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
            command.CommandText = "select* from bank WHERE code = '" + code + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("The bank code is already used!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            reader.Close();
            command.CommandText = "INSERT INTO Bank VALUES('" + code + "', '" + Program.adminID + "', '"+ name + "', '" + address + "');";
            reader = command.ExecuteReader();
            MessageBox.Show("Bank Added Successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
    }
}
