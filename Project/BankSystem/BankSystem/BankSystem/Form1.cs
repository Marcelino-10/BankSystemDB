namespace BankSystem
{
    public partial class Form1 : Form
    {

        private bool isMainForm = true;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            loginPage.Show();
        }


    }
}
