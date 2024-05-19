using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class adminControl : UserControl
    {
        public adminControl()
        {
            InitializeComponent();
            disableAllMenu();
        }

        public void displayMenu(Panel panel)
        {
            bool displayed = panel.Visible;
            if (displayed)
            {
                panel.Visible = false;
            }
            else
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel5.Visible = false;
                flowLayoutPanel1.Visible = false;
                panel.Visible = true;
                panel.BringToFront();
            }
        }

        private void disableAllMenu()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible=false;
            flowLayoutPanel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayMenu(panel2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayMenu(panel3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayMenu(flowLayoutPanel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addBank = new AddBank();
            panel1.Controls.Clear();
            panel1.Controls.Add(addBank);
            disableAllMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addBranch = new AddBranch();
            panel1.Controls.Clear();
            panel1.Controls.Add(addBranch);
            disableAllMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            showAdmin = new ShowAdmin();
            panel1.Controls.Clear();
            panel1.Controls.Add(showAdmin);
            disableAllMenu();
            showAdmin.showTable(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            showCustomer = new ShowCustomer();
            panel1.Controls.Clear();
            panel1.Controls.Add(showCustomer);
            disableAllMenu();
            showCustomer.showTable(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showBranch = new ShowBranch();
            panel1.Controls.Clear();
            panel1.Controls.Add(showBranch);
            disableAllMenu();
            showBranch.showTable(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            showEmployee = new ShowEmployee();
            panel1.Controls.Clear();
            panel1.Controls.Add(showEmployee);
            disableAllMenu();
            showEmployee.showTable(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showBank = new ShowBank();
            panel1.Controls.Clear();
            panel1.Controls.Add(showBank);
            disableAllMenu();
            showBank.showTable(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            showLoan = new ShowLoan();
            panel1.Controls.Clear();
            panel1.Controls.Add(showLoan);
            disableAllMenu();
            showLoan.showTable(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            signemployee = new signEmployee();
            panel1.Controls.Clear();
            panel1.Controls.Add(signemployee);
            disableAllMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            signadmin = new signAdmin();
            panel1.Controls.Clear();
            panel1.Controls.Add(signadmin);
            disableAllMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateadmin = new UpdateAdmin();
            panel1.Controls.Clear();
            panel1.Controls.Add(updateadmin);
            disableAllMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            updateemployee = new UpdateEmployee();
            panel1.Controls.Clear();
            panel1.Controls.Add(updateemployee);
            disableAllMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayMenu(panel5);
        }

        private void adminControl_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Admin Page";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            queryControl = new queryControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(queryControl);
            disableAllMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            queryControl = new queryControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(queryControl);
            disableAllMenu();
            queryControl.report();
        }
    }
}
