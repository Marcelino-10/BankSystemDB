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
    public partial class ViewAccount : UserControl
    {
        public ViewAccount()
        {
            InitializeComponent();
        }

        private void ViewAccount_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "View Account";
        }
    }
}
