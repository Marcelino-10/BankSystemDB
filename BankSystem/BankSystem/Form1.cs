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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pass = textBox2.Text;

            if(id == "" || pass == "")
            {
                MessageBox.Show("Please fill in the data fields!!");
            }

            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";


            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "select* from admin WHERE password = '"+pass+"' and id = '"+id+"'";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Matched id and pass");
                con.Close();
                return;
            }

            command.CommandText = "select* from customer WHERE password = '" + pass + "' and id = '" + id + "'";
            if (reader.Read())
            {
                MessageBox.Show("Matched id and pass");
                con.Close();
                return;
            }

            command.CommandText = "select* from employee WHERE password = '" + pass + "' and id = '" + id + "'";
            if (reader.Read())
            {
                MessageBox.Show("Matched id and pass");
                con.Close();
                return;
            }

            MessageBox.Show("NO matched id or passs!!");
            con.Close();
            return;
        }
    }
}
