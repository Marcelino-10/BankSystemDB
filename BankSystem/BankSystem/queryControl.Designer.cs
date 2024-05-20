namespace BankSystem
{
    partial class queryControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            comboBox1 = new ComboBox();
            dataGridView2 = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            dataGridView4 = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView5 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(104, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(825, 300);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Number of Employee";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 400;
            // 
            // Column2
            // 
            Column2.HeaderText = "Branch Code";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 400;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(451, 510);
            button1.Name = "button1";
            button1.Size = new Size(152, 64);
            button1.TabIndex = 1;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Customers with Loans", "Employee in Every Branch", "Accounts in Every Branch" });
            comboBox1.Location = new Point(309, 456);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(461, 28);
            comboBox1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4 });
            dataGridView2.Location = new Point(104, 119);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(825, 300);
            dataGridView2.TabIndex = 3;
            // 
            // Column3
            // 
            Column3.HeaderText = "Number of Accounts";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 400;
            // 
            // Column4
            // 
            Column4.HeaderText = "Branch Number";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 400;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8 });
            dataGridView3.Location = new Point(104, 119);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(825, 300);
            dataGridView3.TabIndex = 4;
            // 
            // Column5
            // 
            Column5.HeaderText = "Name";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Email";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "Address";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 200;
            // 
            // Column8
            // 
            Column8.HeaderText = "SSN";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 200;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(396, 456);
            button2.Name = "button2";
            button2.Size = new Size(278, 64);
            button2.TabIndex = 13;
            button2.Text = "Generate Report";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { Column9, Column10 });
            dataGridView4.Location = new Point(104, 119);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(825, 300);
            dataGridView4.TabIndex = 12;
            // 
            // Column9
            // 
            Column9.HeaderText = "Account Number";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 372;
            // 
            // Column10
            // 
            Column10.HeaderText = "Total Transactions";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 400;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(125, 37);
            label1.Name = "label1";
            label1.Size = new Size(736, 36);
            label1.TabIndex = 11;
            label1.Text = "Accounts with Transactions above 1000L.E";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(309, 37);
            label2.Name = "label2";
            label2.Size = new Size(444, 36);
            label2.TabIndex = 14;
            label2.Text = "Accounts in Every Branch";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(298, 37);
            label3.Name = "label3";
            label3.Size = new Size(455, 36);
            label3.TabIndex = 15;
            label3.Text = "Employee in Every Branch";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(320, 37);
            label4.Name = "label4";
            label4.Size = new Size(371, 36);
            label4.TabIndex = 16;
            label4.Text = "Customers with Loan";
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(104, 119);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(825, 300);
            dataGridView5.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(452, 37);
            label5.Name = "label5";
            label5.Size = new Size(145, 36);
            label5.TabIndex = 18;
            label5.Text = "Queries";
            // 
            // queryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(label5);
            Controls.Add(dataGridView5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(dataGridView4);
            Controls.Add(label1);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "queryControl";
            Size = new Size(1058, 685);
            Load += queryControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button button2;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView5;
        private Label label5;
    }
}
