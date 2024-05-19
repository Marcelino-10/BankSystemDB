namespace BankSystem
{
    partial class signAdmin
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
            textBox8 = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox8
            // 
            textBox8.Location = new Point(424, 248);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(243, 30);
            textBox8.TabIndex = 35;
            textBox8.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Heavy", 18F);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(257, 241);
            label9.Name = "label9";
            label9.Size = new Size(123, 30);
            label9.TabIndex = 34;
            label9.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(424, 164);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 30);
            textBox1.TabIndex = 33;
            // 
            // button1
            // 
            button1.Font = new Font("Franklin Gothic Heavy", 18F);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(333, 374);
            button1.Name = "button1";
            button1.Size = new Size(205, 63);
            button1.TabIndex = 32;
            button1.Text = "SIGN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Heavy", 18F);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(257, 157);
            label2.Name = "label2";
            label2.Size = new Size(37, 30);
            label2.TabIndex = 31;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Franklin Gothic Heavy", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(318, 76);
            label1.Name = "label1";
            label1.Size = new Size(186, 37);
            label1.TabIndex = 30;
            label1.Text = "Sign Admin";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(424, 325);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 30);
            textBox2.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Heavy", 18F);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(257, 317);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 36;
            label3.Text = "Name";
            // 
            // signAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "signAdmin";
            Size = new Size(926, 514);
            Load += signAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox8;
        private Label label9;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
    }
}
