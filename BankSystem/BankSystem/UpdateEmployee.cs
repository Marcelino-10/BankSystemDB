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
using System.Xml.Linq;

namespace BankSystem
{
    public partial class UpdateEmployee : UserControl
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }
        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Update Employee";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SSN = textBox1.Text;
            string name = textBox5.Text;
            string email = textBox4.Text;
            string address = textBox2.Text;
            string title = textBox8.Text;
            string phone = textBox3.Text;
            string branch = textBox6.Text;

            if (SSN == "" || name == "" || email == "" || address == "" || title == "" || phone == "" || branch == "")
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
            command.CommandText = "select* from EMPLOYEE WHERE EMPLOYEEID = '" + SSN + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("This Employee isn't exist!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            reader.Close();
            command.CommandText = "UPDATE EMPLOYEE SET NAME =  '" + name + "', EMAIL = '" + email + "', ADDRESS = '" + address + "', TITLE = '"+title+"', BRANCHNO = '"+branch+"', PHONENUM = '"+phone+"' where EMPLOYEEID = '" + SSN + "';";
            reader = command.ExecuteReader();
            MessageBox.Show("Employee Updated Successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
    }
}
