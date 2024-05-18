namespace BankSystem
{
    partial class signCustomer
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
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(486, 252);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 18;
            // 
            // button1
            // 
            button1.Font = new Font("Franklin Gothic Heavy", 18F);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(403, 476);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(210, 70);
            button1.TabIndex = 17;
            button1.Text = "SIGN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Heavy", 18F);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(286, 252);
            label2.Name = "label2";
            label2.Size = new Size(74, 38);
            label2.TabIndex = 13;
            label2.Text = "SSN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Franklin Gothic Heavy", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(431, 110);
            label1.Name = "label1";
            label1.Size = new Size(149, 47);
            label1.TabIndex = 12;
            label1.Text = "Sign in";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(486, 346);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 27);
            textBox2.TabIndex = 33;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Heavy", 18F);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(286, 346);
            label6.Name = "label6";
            label6.Size = new Size(155, 38);
            label6.TabIndex = 32;
            label6.Text = "Password";
            // 
            // signCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signCustomer";
            Size = new Size(1058, 673);
            Load += signCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Label label6;
    }
}
