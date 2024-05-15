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

    
    public partial class mainPage : Form
    {
        adminControl adminControl = new adminControl();
        employeeControl employeeControl = new employeeControl();
        customerControl customerControl = new customerControl();
        public mainPage()
        {
            InitializeComponent();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void openAdmin(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(adminControl);
        }

        public void openCustomer(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(customerControl);
        }

        public void openEmployee(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(employeeControl);
        }

        private void mainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
