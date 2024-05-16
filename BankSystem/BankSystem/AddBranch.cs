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
    public partial class AddBranch : UserControl
    {
        public AddBranch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string branchNo = textBox1.Text;
            string bankCode = textBox2.Text;
            string zipCode = textBox3.Text;
            string city = textBox4.Text;
            string address = textBox5.Text;
            if (branchNo == "" || bankCode == "" || city == "" || address == "")
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
            command.CommandText = "select * from branch WHERE branchNo = '" + branchNo + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("The Branch Number is already used!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            reader.Close();
            command.CommandText = "select * from bank WHERE code = '" + bankCode + "'";
            reader = command.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("Invalid Bank Code!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            reader.Close();
            command.CommandText = "INSERT INTO branch VALUES('" + branchNo + "', '" + bankCode + "', '" + Program.adminID + "', '" + zipCode + "', '" + city + "', '" + address + "');";
            reader = command.ExecuteReader();
            MessageBox.Show("Branch Added Successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
    }
}
