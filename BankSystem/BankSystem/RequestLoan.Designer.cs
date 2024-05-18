namespace BankSystem
{
    partial class RequestLoan
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
            label1 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(61, 69);
            label1.Name = "label1";
            label1.Size = new Size(278, 41);
            label1.TabIndex = 9;
            label1.Text = "Request Loan";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(193, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 27);
            textBox2.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(95, 312);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 27;
            label4.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(61, 237);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 26;
            label2.Text = "Amount";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Commercial", "Industry", "Personal" });
            comboBox1.Location = new Point(193, 306);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 31);
            comboBox1.TabIndex = 29;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(670, 309);
            label7.Name = "label7";
            label7.Size = new Size(44, 28);
            label7.TabIndex = 33;
            label7.Text = "........";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 64, 64);
            label6.Location = new Point(498, 312);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 34;
            label6.Text = "Interest Rate";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 10F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(0, 64, 64);
            label8.Location = new Point(3, 378);
            label8.Name = "label8";
            label8.Size = new Size(184, 20);
            label8.TabIndex = 35;
            label8.Text = "Payment Schedule";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 10F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "6   months , Monthly", "12 months , Monthly", "18 months , Monthly", "3   years     , Monthly", "6   years     , Monthly", "9   years     , Monthly", "3   years     , Annual", "6   years     , Annual", "9   years     , Annual", "", "" });
            comboBox2.Location = new Point(193, 374);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(255, 31);
            comboBox2.TabIndex = 36;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 64, 64);
            button1.Location = new Point(330, 471);
            button1.Name = "button1";
            button1.Size = new Size(112, 47);
            button1.TabIndex = 37;
            button1.Text = "Request";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RequestLoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RequestLoan";
            Size = new Size(786, 720);
            Load += RequestLoan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox2;
        private Label label4;
        private Label label2;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Label label8;
        private ComboBox comboBox2;
        private Button button1;
    }
}
