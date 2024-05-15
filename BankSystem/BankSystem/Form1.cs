using System.Data.SqlTypes;
using System.Data.SqlClient;

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
            string connectionString = "Data Source=.;Initial Catalog=Banks;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            if(id == "" || pass == "")
            {
                MessageBox.Show("Please fill in the data fields!!");
            }
            con.Close();
        }
    }
}
