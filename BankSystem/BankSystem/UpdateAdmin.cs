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

namespace BankSystem
{
    public partial class UpdateAdmin : UserControl
    {
        public UpdateAdmin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ssn = textBox1.Text;
            string name = textBox2.Text;

            if (ssn == "" || name == "")
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
            command.CommandText = "select* from ADMIN WHERE SSN = '" + ssn + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("This Admin isn't exist!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            reader.Close();
            command.CommandText = "UPDATE CUSTOMER SET NAME =  '" + name + "' where SSN = '" + ssn + "';";
            reader = command.ExecuteReader();
            MessageBox.Show("Admin Updated Successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
    }
}
