namespace BankSystem
{
    partial class AddBranch
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
            label4 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 12F);
            label4.Location = new Point(268, 274);
            label4.Name = "label4";
            label4.Size = new Size(96, 24);
            label4.TabIndex = 23;
            label4.Text = "Zip Code";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(468, 381);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(255, 27);
            textBox5.TabIndex = 22;
            // 
            // button1
            // 
            button1.Font = new Font("Noto Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(444, 452);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 21;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F);
            label3.Location = new Point(268, 382);
            label3.Name = "label3";
            label3.Size = new Size(96, 24);
            label3.TabIndex = 20;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F);
            label2.Location = new Point(268, 214);
            label2.Name = "label2";
            label2.Size = new Size(118, 24);
            label2.TabIndex = 19;
            label2.Text = "Bank Code";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(468, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 27);
            textBox3.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(468, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 27);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(370, 64);
            label1.Name = "label1";
            label1.Size = new Size(280, 48);
            label1.TabIndex = 16;
            label1.Text = "Add Branch";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 12F);
            label5.Location = new Point(268, 156);
            label5.Name = "label5";
            label5.Size = new Size(176, 24);
            label5.TabIndex = 25;
            label5.Text = "Branch Number";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(468, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 27);
            textBox2.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 12F);
            label6.Location = new Point(268, 326);
            label6.Name = "label6";
            label6.Size = new Size(54, 24);
            label6.TabIndex = 27;
            label6.Text = "City";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(468, 323);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(255, 27);
            textBox4.TabIndex = 26;
            // 
            // AddBranch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddBranch";
            Size = new Size(1058, 689);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox5;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox4;
    }
}
