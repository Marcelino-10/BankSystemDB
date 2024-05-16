using System.Data.SqlTypes;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            main = new mainPage();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pass = textBox2.Text;

            if (id == "" || pass == "")
            {
                MessageBox.Show("Please fill in the data fields!!");
                return;
            }

            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";


            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select* from admin WHERE password = '" + pass + "' and id = '" + id + "'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                con.Close();
                main.Show();
                Hide();
                main.openAdmin(sender, e);
                Program.isAdmin = true;
                Program.adminID = id;
                return;
            }
            reader.Close();
            command.CommandText = "select* from customer WHERE password = '" + pass + "' and ssn = '" + id + "'";
            reader = command.ExecuteReader();
            if (reader.Read())
            {               
                con.Close();
                main.Show();
                Hide();
                main.openCustomer(sender, e);
                Program.isCustomer = true;
                Program.customerID = id;
                return;
            }
            reader.Close();
            command.CommandText = "select* from employee WHERE password = '" + pass + "' and employeeID = '" + id + "'";
            reader = command.ExecuteReader();
            if (reader.Read())
            {                
                con.Close();
                main.Show();
                Hide();
                main.openEmployee(sender, e);
                Program.isEmployee = true;
                Program.employeeID = id;
                return;
            }

            MessageBox.Show("NO matched id or passs!!");
            con.Close();
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
