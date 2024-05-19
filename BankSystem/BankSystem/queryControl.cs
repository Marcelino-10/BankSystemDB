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

        private void hideAll()
        {
            comboBox1.Visible = false;
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
            dataGridView5.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            button1.Hide();
            button2.Hide();
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
                    hideAll();
                    label4.Show();
                    dataGridView3.Show();
                    button1.Show();
                    comboBox1.Visible = true;
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
                    hideAll();
                    dataGridView1.Show();
                    label3.Show();
                    button1.Show();
                    comboBox1.Visible = true;
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
                    hideAll();
                    dataGridView2.Show();
                    label2.Show();
                    button1.Show();
                    comboBox1.Visible = true;
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

        private void queryControl_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Quereis";
            hideAll();
            label5.Show();
            dataGridView5.Show();
            comboBox1.Visible = true;
            button1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

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


        public void report()
        {
            hideAll();
            label1.Show();
            dataGridView4.Show();
            button2.Show();

        }
    }
}
