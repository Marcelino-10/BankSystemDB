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
            ViewAccounts viewAccounts = new ViewAccounts();
            panel2.Controls.Add(viewAccounts);


        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ViewRequestedLoans viewRequestedLoans = new ViewRequestedLoans();
            panel2.Controls.Add(viewRequestedLoans);


        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            EditAccount editAccount = new EditAccount();
            panel2.Controls.Add(editAccount);
        }



        private void customerControl_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Customer Page";
        }


    }
}
