namespace BankSystem
{
    partial class Transaction
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(34, 60);
            label1.Name = "label1";
            label1.Size = new Size(286, 48);
            label1.TabIndex = 9;
            label1.Text = "Transaction";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Heavy", 18F);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(78, 243);
            label2.Name = "label2";
            label2.Size = new Size(175, 38);
            label2.TabIndex = 26;
            label2.Text = "Source Acc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Heavy", 18F);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(78, 324);
            label3.Name = "label3";
            label3.Size = new Size(141, 38);
            label3.TabIndex = 27;
            label3.Text = "Dest Acc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Heavy", 18F);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(78, 413);
            label4.Name = "label4";
            label4.Size = new Size(127, 38);
            label4.TabIndex = 28;
            label4.Text = "Amount";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 64, 64);
            button1.Location = new Point(297, 539);
            button1.Name = "button1";
            button1.Size = new Size(163, 67);
            button1.TabIndex = 29;
            button1.Text = "Transfer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(310, 253);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(333, 28);
            comboBox1.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(310, 324);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 27);
            textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(310, 413);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(333, 27);
            textBox2.TabIndex = 32;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Transaction";
            Size = new Size(783, 717);
            Load += Transaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
