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
    public partial class ShowLoan : UserControl
    {
        public ShowLoan()
        {
            InitializeComponent();
        }
        public void showTable(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();
            if (checkBox1.Checked)
            {
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
                List<int> customerSSN = new List<int>();
                List<int> employeeId = new List<int>();

                string _path = AppDomain.CurrentDomain.BaseDirectory;
                string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "select distinct TYPE from loan";
                SqlDataReader reader = command.ExecuteReader();
                for (int j = 0; reader.Read(); j++)
                {
                    dataGridView2.Rows.Add();
                    for (int i = 0; i < 1; i++)
                    {
                        dataGridView2.Rows[j].Cells[i].Value = reader.GetValue(i).ToString();
                    }
                }


            }
            else
            {
                dataGridView2.Visible = false;
                dataGridView1.Visible = true;
                List<int> customerSSN = new List<int>();
                List<int> employeeId = new List<int>();

                string _path = AppDomain.CurrentDomain.BaseDirectory;
                string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "select* from loan";
                SqlDataReader reader = command.ExecuteReader();


                for (int j = 0; reader.Read(); j++)
                {
                    dataGridView1.Rows.Add();
                    for (int i = 0; i < 8; i++)
                    {
                        string temp = reader.GetValue(i).ToString();
                        if (i == 1)
                        {
                            customerSSN.Add(int.Parse(temp));
                        }
                        else if (i == 2)
                        {
                            if (temp == "")
                                employeeId.Add(0);
                            else
                                employeeId.Add(int.Parse(temp));
                        }
                        else
                        {
                            dataGridView1.Rows[j].Cells[i].Value = temp;
                        }
                    }
                }
                reader.Close();
                for (int j = 0; j < customerSSN.Count; j++)
                {
                    SqlCommand command2 = new SqlCommand();
                    command2.Connection = con;
                    command2.CommandText = "select * from customer where ssn = '" + customerSSN[j] + "'";
                    SqlDataReader reader2 = command2.ExecuteReader();
                    if (reader2.Read())
                    {
                        dataGridView1.Rows[j].Cells[1].Value = reader2.GetString(1);
                    }
                    reader2.Close();

                    command2.CommandText = "select * from employee where employeeid = '" + employeeId[j] + "'";
                    reader2 = command2.ExecuteReader();
                    if (reader2.Read())
                    {
                        dataGridView1.Rows[j].Cells[2].Value = reader2.GetValue(0).ToString();
                    }
                    reader2.Close();
                }
                con.Close();
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            showTable(sender, e);
        }

        private void ShowLoan_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Loans";
        }
    }
}
