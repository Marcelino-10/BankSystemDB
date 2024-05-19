namespace BankSystem
{
    partial class createAcc
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
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(350, 298);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 39);
            textBox4.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 141);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 39);
            textBox1.TabIndex = 30;
            // 
            // button1
            // 
            button1.Font = new Font("Franklin Gothic Heavy", 18F);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(397, 531);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(184, 76);
            button1.TabIndex = 29;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Heavy", 18F);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(59, 298);
            label4.Name = "label4";
            label4.Size = new Size(133, 38);
            label4.TabIndex = 27;
            label4.Text = "Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Heavy", 18F);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(59, 217);
            label3.Name = "label3";
            label3.Size = new Size(82, 38);
            label3.TabIndex = 26;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Heavy", 18F);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(59, 141);
            label2.Name = "label2";
            label2.Size = new Size(219, 38);
            label2.TabIndex = 25;
            label2.Text = "Customer SSN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Franklin Gothic Heavy", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(67, 16);
            label1.Name = "label1";
            label1.Size = new Size(308, 47);
            label1.TabIndex = 24;
            label1.Text = "Create Account";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Salary Account", "Saving Account", "checking Account", "Certificate of deposit accounts" });
            comboBox1.Location = new Point(350, 225);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 31);
            comboBox1.TabIndex = 35;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(140, 273);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(0, 28);
            comboBox2.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Heavy", 18F);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(59, 451);
            label5.Name = "label5";
            label5.Size = new Size(237, 38);
            label5.TabIndex = 37;
            label5.Text = "Branch Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Heavy", 18F);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(59, 379);
            label6.Name = "label6";
            label6.Size = new Size(165, 38);
            label6.TabIndex = 39;
            label6.Text = "Open date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(350, 379);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(277, 27);
            dateTimePicker1.TabIndex = 45;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Font = new Font("Segoe UI", 10F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(350, 459);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(277, 31);
            comboBox3.TabIndex = 46;
            // 
            // createAcc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "createAcc";
            Size = new Size(755, 669);
            Load += createAcc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox4;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
    }
}
