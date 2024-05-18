using System;
using System.Runtime.InteropServices;
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

        public void signCustomer(object sender, EventArgs e)
        {
            signCustomer signCustomer = new signCustomer();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(signCustomer);
        }


        private void mainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Program.isCustomer = false;
            Program.isAdmin = false;
            Program.isEmployee = false;
            Hide();
            Program.obj.Show();
            Program.obj.textBox1.Clear();
            Program.obj.textBox2.Clear();
        }
    }
}
