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
    public partial class signAdmin : UserControl
    {
        public signAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pass = textBox8.Text;
            string name = textBox2.Text;


            if (id == "" || pass == "" || name == "")
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
            command.CommandText = "select* from ADMIN WHERE ID = '" + id + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("This Admin already Exists", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            reader.Close();
            command.CommandText = "insert into ADMIN(ID, PASSWORD, NAME) values(" + id + ", " + pass + ", "+name+");";
            reader = command.ExecuteReader();
            MessageBox.Show("Admin signed successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void signAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
