using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class employeeControl : UserControl
    {

        public employeeControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            PayLoan payLoan = new PayLoan();
            panel2.Controls.Add(payLoan);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            UpdateCustomer addCusto = new UpdateCustomer();
            panel2.Controls.Add(addCusto);
        }
        public void Hide()
        {
            panel2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            signCustomer signCustomer = new signCustomer();
            panel2.Controls.Add(signCustomer);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            addCustomer add_Customer = new addCustomer();
            panel2.Controls.Add(add_Customer);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            createAcc createacc = new createAcc();
            panel2.Controls.Add(createacc);
        }

        private void employeeControl_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Employee Page";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DeleteAccount deleteAccount = new DeleteAccount();
            panel2.Controls.Add(deleteAccount);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            deleteLoan deleteloan = new deleteLoan();
            panel2.Controls.Add(deleteloan);
        }
    }
}
