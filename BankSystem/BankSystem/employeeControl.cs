﻿using System;
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

        private void btn_payLoan_Click(object sender, EventArgs e)
        {

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
    }
}
