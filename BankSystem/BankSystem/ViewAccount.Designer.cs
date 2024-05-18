namespace BankSystem
{
    partial class ViewAccount
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
            textBox3 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(307, 462);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 55);
            textBox3.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Heavy", 18F);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(127, 462);
            label6.Name = "label6";
            label6.Size = new Size(155, 38);
            label6.TabIndex = 25;
            label6.Text = "Password";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(307, 151);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(277, 55);
            textBox5.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(307, 252);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(277, 55);
            textBox4.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(307, 350);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 55);
            textBox2.TabIndex = 22;
            // 
            // button1
            // 
            button1.Font = new Font("Franklin Gothic Heavy", 18F);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(298, 562);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(184, 76);
            button1.TabIndex = 20;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Heavy", 18F);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(127, 350);
            label5.Name = "label5";
            label5.Size = new Size(133, 38);
            label5.TabIndex = 19;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Heavy", 18F);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(127, 252);
            label4.Name = "label4";
            label4.Size = new Size(96, 38);
            label4.TabIndex = 18;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Heavy", 18F);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(127, 151);
            label3.Name = "label3";
            label3.Size = new Size(100, 38);
            label3.TabIndex = 17;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(23, 43);
            label2.Name = "label2";
            label2.Size = new Size(271, 41);
            label2.TabIndex = 27;
            label2.Text = "Your Account";
            // 
            // ViewAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "ViewAccount";
            Size = new Size(783, 717);
            Load += ViewAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
