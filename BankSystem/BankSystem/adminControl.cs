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
            displayAllMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayMenu(panel3);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void adminControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayMenu(panel2);
        }

        public void displayMenu(Panel panel)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            flowLayoutPanel1.Visible = false;
            panel.Visible = true;
        }

        private void displayAllMenu()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            flowLayoutPanel1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayMenu(flowLayoutPanel1);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
