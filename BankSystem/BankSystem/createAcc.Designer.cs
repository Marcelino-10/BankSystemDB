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
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(306, 178);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(243, 30);
            textBox4.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 96);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 30);
            textBox1.TabIndex = 30;
            // 
            // button1
            // 
            button1.Font = new Font("Franklin Gothic Heavy", 18F);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(347, 398);
            button1.Name = "button1";
            button1.Size = new Size(161, 57);
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
            label4.Location = new Point(52, 178);
            label4.Name = "label4";
            label4.Size = new Size(104, 30);
            label4.TabIndex = 27;
            label4.Text = "Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Heavy", 18F);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(52, 131);
            label3.Name = "label3";
            label3.Size = new Size(64, 30);
            label3.TabIndex = 26;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Heavy", 18F);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(52, 96);
            label2.Name = "label2";
            label2.Size = new Size(59, 30);
            label2.TabIndex = 25;
            label2.Text = "SSN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Franklin Gothic Heavy", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(59, 12);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 24;
            label1.Text = "Create Account";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Salary Account", "Saving Account", "checking Account", "Certificate of deposit accounts", "" });
            comboBox1.Location = new Point(306, 137);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(243, 25);
            comboBox1.TabIndex = 35;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(140, 261);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(0, 23);
            comboBox2.TabIndex = 36;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(306, 307);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 30);
            textBox2.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Heavy", 18F);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(52, 307);
            label5.Name = "label5";
            label5.Size = new Size(186, 30);
            label5.TabIndex = 37;
            label5.Text = "Branch Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Heavy", 18F);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(52, 223);
            label6.Name = "label6";
            label6.Size = new Size(129, 30);
            label6.TabIndex = 39;
            label6.Text = "Open date";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(306, 356);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(243, 30);
            textBox5.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Heavy", 18F);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(52, 356);
            label7.Name = "label7";
            label7.Size = new Size(163, 30);
            label7.TabIndex = 41;
            label7.Text = "Interest Rate";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(306, 261);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(243, 30);
            textBox6.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Franklin Gothic Heavy", 18F);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(52, 261);
            label8.Name = "label8";
            label8.Size = new Size(199, 30);
            label8.TabIndex = 43;
            label8.Text = "Account Number";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(306, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 23);
            dateTimePicker1.TabIndex = 45;
            // 
            // createAcc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox2);
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
            Name = "createAcc";
            Size = new Size(661, 502);
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
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private DateTimePicker dateTimePicker1;
    }
}
