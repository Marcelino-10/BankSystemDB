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
    public partial class queryControl : UserControl
    {
        public queryControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a query");

            }
            else
            {

                string selected = comboBox1.SelectedItem.ToString();

                string _path = AppDomain.CurrentDomain.BaseDirectory;
                string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;


                if (selected == "Customers with Loans")
                {
                    dataGridView3.Show();
                    dataGridView2.Hide();
                    dataGridView1.Hide();
                    dataGridView4.Hide();
                    label1.Hide();
                    command.CommandText = "select CUSTOMER.NAME, CUSTOMER.EMAIL, CUSTOMER.ADDRESS, CUSTOMER.SSN\r\nFROM CUSTOMER , LOAN\r\nWHERE CUSTOMER.SSN = LOAN.CUSTOMERSSN";
                    SqlDataReader reader = command.ExecuteReader();

                    for (int j = 0; reader.Read(); j++)
                    {
                        dataGridView3.Rows.Add();
                        for (int i = 0; i < 4; i++)
                        {
                            dataGridView3.Rows[j].Cells[i].Value = reader.GetValue(i).ToString();
                        }
                    }
                    con.Close();
                }
                else if (selected == "Employee in Every Branch")
                {
                    dataGridView1.Show();
                    dataGridView2.Hide();
                    dataGridView3.Hide();
                    dataGridView4.Hide();
                    label1.Hide();
                    command.CommandText = "select count(EMPLOYEE.EMPLOYEEID) AS 'NUM OF EMPLOYEES' , BRANCH.BRANCHNO\r\nFROM EMPLOYEE , BRANCH\r\nWHERE EMPLOYEE.BRANCHNO = BRANCH.BRANCHNO\r\nGROUP BY BRANCH.BRANCHNO";
                    SqlDataReader reader = command.ExecuteReader();

                    for (int j = 0; reader.Read(); j++)
                    {
                        dataGridView1.Rows.Add();
                        for (int i = 0; i < 2; i++)
                        {
                            dataGridView1.Rows[j].Cells[i].Value = reader.GetValue(i).ToString();
                        }
                    }
                    con.Close();
                }
                else if (selected == "Accounts in Every Branch")
                {
                    dataGridView2.Show();
                    dataGridView3.Hide();
                    dataGridView1.Hide();
                    dataGridView4.Hide();
                    label1.Hide();
                    command.CommandText = "select count(ACCOUNT.ACCOUNTNO_) AS 'NUM OF ACCOUNTS' , BRANCH.BRANCHNO\r\nFROM ACCOUNT , BRANCH\r\nWHERE ACCOUNT.BRANCHNO = BRANCH.BRANCHNO\r\nGROUP BY BRANCH.BRANCHNO";
                    SqlDataReader reader = command.ExecuteReader();

                    for (int j = 0; reader.Read(); j++)
                    {
                        dataGridView2.Rows.Add();
                        for (int i = 0; i < 2; i++)
                        {
                            dataGridView2.Rows[j].Cells[i].Value = reader.GetValue(i).ToString();
                        }
                    }
                    con.Close();
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void queryControl_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Quereis";
            label1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView4.Show();
            dataGridView2.Hide();
            dataGridView1.Hide();
            dataGridView3.Hide(); 
            label1.Show();

            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            command.CommandText = "SELECT ACCOUNT.ACCOUNTNO_ , SUM([TRANSACTION].AMOUNT) AS 'AMOUNT'\r\nFROM [TRANSACTION], ACCOUNT\r\nWHERE [TRANSACTION].ACCOUNTNO_ = ACCOUNT.ACCOUNTNO_\r\nGROUP BY ACCOUNT.ACCOUNTNO_\r\nHAVING  SUM([TRANSACTION].AMOUNT) > 1000\r\nORDER BY SUM([TRANSACTION].AMOUNT) DESC";
            SqlDataReader reader = command.ExecuteReader();

            for (int j = 0; reader.Read(); j++)
            {
                dataGridView4.Rows.Add();
                for (int i = 0; i < 2; i++)
                {
                    dataGridView4.Rows[j].Cells[i].Value = reader.GetValue(i).ToString();
                }
            }
            con.Close();

        }
    }
}
