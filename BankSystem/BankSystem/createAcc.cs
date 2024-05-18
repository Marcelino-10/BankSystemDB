﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BankSystem
{
    public partial class createAcc : UserControl
    {
        public createAcc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SSN = textBox1.Text;
            string acc_no = textBox6.Text;
            string branchNO = textBox2.Text;
            string interestRate = textBox5.Text;
            string openDate = dateTimePicker1.Text;
            string balance = textBox4.Text;
            string type = comboBox1.Text;

            DateTime d;
            DateTime.TryParse(openDate, out d);
            if (SSN == "" || branchNO == "" || interestRate == "" || openDate == "" || type=="" ||balance=="" || acc_no=="")
            {
                MessageBox.Show("Please fill all fileds!", "Bank System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";
            SqlDataReader reader;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "insert into ACCOUNT values('"+ acc_no +"','" + branchNO + "', '" + SSN + "','" + balance + "', '" + d + "', '" + type + "','" + interestRate + "');";
            reader = command.ExecuteReader();
            MessageBox.Show("Account Added Successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
    }
}