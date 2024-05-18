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
    public partial class ViewRequestedLoans : UserControl
    {
        public ViewRequestedLoans()
        {
            InitializeComponent();
        }

        private void ViewRequestedLoans_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "View Requested Loans";
        }
    }
}
