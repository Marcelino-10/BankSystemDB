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
                flowLayoutPanel1.Visible = false;
                panel.Visible = true;
                panel.BringToFront();
            }
        }

        private void disableAllMenu()
        {
            panel2.Visible = false;
            panel3.Visible = false;
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
            panel1.Controls.Clear();
            panel1.Controls.Add(addBank);
            disableAllMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(addBranch);
            disableAllMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(showAdmin);
            disableAllMenu();
            showAdmin.showTable(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(showCustomer);
            disableAllMenu();
            showCustomer.showTable(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(showBranch);
            disableAllMenu();
            showBranch.showTable(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(showEmployee);
            disableAllMenu();
            showEmployee.showTable(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(showBank);
            disableAllMenu();
            showBank.showTable(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(showLoan);
            disableAllMenu();
            showLoan.showTable(sender, e);
        }
    }
}
