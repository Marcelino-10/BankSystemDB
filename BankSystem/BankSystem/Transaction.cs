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
    public partial class Transaction : UserControl
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Transaction";
            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            SqlDataReader reader;
            command.CommandText = "Select accountno_ from account where customerssn = '" + Program.customerID + "'";
            reader = command.ExecuteReader();

            for (int i = 0; reader.Read(); i++)
            {
                comboBox1.Items.Add(reader.GetValue(i).ToString());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fileds!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int sourceNo = int.Parse(comboBox1.SelectedItem.ToString());
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill all fileds!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int destNo = int.Parse(textBox1.Text);
            
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please fill all fileds!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float amount = float.Parse(textBox2.Text);

            if (sourceNo == 0 || destNo == 0 || amount == 0)
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
            command.CommandText = "Select * from account where accountno_ = '" + destNo + "'";
            reader = command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("The destination account doesn't exist!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            reader.Close();

            command.CommandText = "Select * from account where accountno_ = '" + sourceNo + "' and balance >= '" + amount + "'";
            reader = command.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("Not enough balance!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            reader.Close();

            command.CommandText = "Update account set balance = balance - '"+ amount +"' where account.accountno_ = '" + sourceNo + "'";
            reader = command.ExecuteReader();
            reader.Close();
            command.CommandText = "Update account set balance = balance + '" + amount + "' where account.accountno_ = '" + destNo + "'";
            reader = command.ExecuteReader();
            reader.Close();
            MessageBox.Show("Transaction Succeeded!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
    }
}
