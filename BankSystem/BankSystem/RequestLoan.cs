using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankSystem
{
    public partial class RequestLoan : UserControl
    {
        public RequestLoan()
        {
            InitializeComponent();
        }
        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBox1.SelectedItem.ToString();
            if (type == "Commercial") { label7.Text = "6.69%"; }
            else if (type == "Industry") { label7.Text = "7.59%"; }
            else if (type == "Personal") { label7.Text = "8.98%"; }
            else { label7.Text = "test"; }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string amount = textBox2.Text;
            string customerSSN = Program.customerID;
            string type = comboBox1.SelectedItem.ToString();
            string intrestRate = label7.Text;
            string paymentSchedule = comboBox2.SelectedIndex.ToString();
            string stat = "Pending";

            if (amount == "" || type == "" || paymentSchedule == "")
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

            command.CommandText = "INSERT INTO LOAN (CUSTOMERSSN, EMPLOYEEID, AMOUNT, INSERTRATE, TYPE,PAYMENTSCHEDULE,STATUS) VALUES('" + customerSSN + "', '" + Program.customerID + "', null,'" + amount + "', '" + intrestRate + "', '" + type + "', '" + paymentSchedule + "', '" + stat + "');";
            reader = command.ExecuteReader();
            MessageBox.Show("Loan Requested Successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();




        }

       
    }
}
