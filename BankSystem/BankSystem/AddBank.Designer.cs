namespace BankSystem
{
    partial class AddBank
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(406, 83);
            label1.Name = "label1";
            label1.Size = new Size(234, 48);
            label1.TabIndex = 8;
            label1.Text = "Add Bank";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(427, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(427, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 27);
            textBox2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F);
            label2.Location = new Point(323, 196);
            label2.Name = "label2";
            label2.Size = new Size(60, 24);
            label2.TabIndex = 11;
            label2.Text = "Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F);
            label3.Location = new Point(307, 322);
            label3.Name = "label3";
            label3.Size = new Size(96, 24);
            label3.TabIndex = 12;
            label3.Text = "Address";
            // 
            // button1
            // 
            button1.Font = new Font("Noto Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(450, 399);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F);
            label4.Location = new Point(323, 259);
            label4.Name = "label4";
            label4.Size = new Size(63, 24);
            label4.TabIndex = 15;
            label4.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(427, 321);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 27);
            textBox3.TabIndex = 14;
            // 
            // AddBank
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddBank";
            Size = new Size(1058, 689);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox textBox3;
    }
}
