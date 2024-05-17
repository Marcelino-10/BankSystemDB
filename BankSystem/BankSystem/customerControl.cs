using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class customerControl : UserControl
    {

        public customerControl()
        {
            InitializeComponent();

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            
            panel2.Controls.Clear();
            RequestLoan requestLoan = new RequestLoan();
            
            panel2.Controls.Add(requestLoan);


        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Transaction transaction = new Transaction();
            panel2.Controls.Add(transaction);


        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ViewAccount viewAccount = new ViewAccount();
            panel2.Controls.Add(viewAccount);


        }
        private void button4_Click(object sender, EventArgs e)
        {
           panel2.Controls.Clear();
            ViewRequestedLoans viewRequestedLoans = new ViewRequestedLoans();
            panel2.Controls.Add(viewRequestedLoans);


        }




        private void customerControl_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
