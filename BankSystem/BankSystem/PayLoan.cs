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
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BankSystem
{
    public partial class PayLoan : UserControl
    {
        public PayLoan()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string loanNum = textBox1.Text;
            string status;
            if (radioButton1.Checked) { status = "Accepted"; }
            else if (radioButton2.Checked) { status = "Rejected"; }
            else { status = "test"; }
            if (loanNum == "")
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
            command.CommandText = "select* from LOAN WHERE LOANNO_ = '" + loanNum + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("This Loan isn't exist!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            reader.Close();
            command.CommandText = "select* from LOAN WHERE LOANNO_ = '" + loanNum + "' AND  STATUS ='Pending' ";
            reader = command.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("This Loan isn't Pending!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            reader.Close();
            command.CommandText = "UPDATE LOAN SET EMPLOYEEID =  '" + Program.employeeID + "', STATUS= '" + status + "'WHERE LOANNO_ = '" + loanNum + "';";
            reader = command.ExecuteReader();
            MessageBox.Show("Loan Request Updated  Successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reader.Close();
            con.Close();


        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PayLoan_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Verify Loan";
            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "SELECT* FROM LOAN ;";
            // "SELECT* FROM LOAN WHERE STATUS = 'Pending';";
            SqlDataReader reader = command.ExecuteReader();
            for (int j = 0; reader.Read(); j++)
            {
                dataGridView1.Rows.Add();
                for (int i = 0; i < 8; i++)
                {

                    dataGridView1.Rows[j].Cells[i].Value = reader.GetValue(i).ToString();
                }
            }
            con.Close();
        }
    }
}
