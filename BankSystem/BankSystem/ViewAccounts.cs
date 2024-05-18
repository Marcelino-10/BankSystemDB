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
    public partial class ViewAccounts : UserControl
    {
        public ViewAccounts()
        {
            InitializeComponent();
        }

        private void ViewAccounts_Load(object sender, EventArgs e)
        {
            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select* from Account where customerSSN = '"+ Program.customerID +"'";
            SqlDataReader reader = command.ExecuteReader();

            for (int j = 0; reader.Read(); j++)
            {
                dataGridView1.Rows.Add();
                for (int i = 0; i < 7; i++)
                {
                    if (i == 2 || i == 6)
                        continue;
                    else if (i > 2)
                    {
                        dataGridView1.Rows[j].Cells[i - 1].Value = reader.GetValue(i).ToString();
                    }
                    else
                    {
                        dataGridView1.Rows[j].Cells[i].Value = reader.GetValue(i).ToString();
                    }
                }
            }
            con.Close();
        }
    }
}
