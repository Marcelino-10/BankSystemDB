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
    public partial class DeleteAccount : UserControl
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountNo = textBox1.Text;
            if (accountNo == "")
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
            SqlDataReader reader;
            command.CommandText = "select * from account where accountno_ = '" + accountNo + "'";
            reader = command.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("Invaild Account Number!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            reader.Close();
            command.CommandText = "delete from [transaction] where accountno_ = '" + accountNo + "'";
            reader = command.ExecuteReader();
            reader.Close();
            command.CommandText = "delete from account where accountno_ = '" + accountNo + "'";
            reader = command.ExecuteReader();
            reader.Close();
            con.Close();
            MessageBox.Show("Account Deleted Successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
