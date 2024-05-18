﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class queryControl : UserControl
    {
        public queryControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string selected = comboBox1.SelectedItem.ToString();

            string _path = AppDomain.CurrentDomain.BaseDirectory;
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(_path).FullName).FullName).FullName).FullName + "\\DB\\LocalDB.mdf";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = con;


            if (selected == "Customers with Loans")
            {

            }
            else if (selected == "Employee in Every Branch")
            {
                command.CommandText = "select count(EMPLOYEE.EMPLOYEEID) AS 'NUM OF EMPLOYEES' , BRANCH.BRANCHNO\r\nFROM EMPLOYEE , BRANCH\r\nWHERE EMPLOYEE.BRANCHNO = BRANCH.BRANCHNO\r\nGROUP BY BRANCH.BRANCHNO";
                SqlDataReader reader = command.ExecuteReader();

                for (int j = 0; reader.Read(); j++)
                {
                    dataGridView1.Rows.Add();
                    for (int i = 0; i < 2; i++)
                    {
                        dataGridView1.Rows[j].Cells[i].Value = reader.GetValue(i).ToString();
                    }
                }
                con.Close();
            }
            else if (selected == "Accounts in Every Branch")
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void queryControl_Load(object sender, EventArgs e)
        {
            Program.main.label1.Text = "Quereis";
        }
    }
}