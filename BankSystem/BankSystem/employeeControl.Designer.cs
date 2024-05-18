namespace BankSystem
{
    partial class employeeControl
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(133, 309);
            label1.Name = "label1";
            label1.Size = new Size(479, 36);
            label1.TabIndex = 0;
            label1.Text = "Welcome in Employee Page";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 673);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button4.ForeColor = Color.DarkSlateGray;
            button4.Location = new Point(32, 357);
            button4.Name = "button4";
            button4.Size = new Size(251, 53);
            button4.TabIndex = 4;
            button4.Text = "Create Account";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(32, 275);
            button3.Name = "button3";
            button3.Size = new Size(251, 53);
            button3.TabIndex = 3;
            button3.Text = "Add Customer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(31, 185);
            button2.Name = "button2";
            button2.Size = new Size(253, 53);
            button2.TabIndex = 2;
            button2.Text = "Sign UP Customer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(32, 101);
            button1.Name = "button1";
            button1.Size = new Size(251, 56);
            button1.TabIndex = 1;
            button1.Text = "Update Customer Details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLightLight;
            button5.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button5.ForeColor = Color.DarkSlateGray;
            button5.Location = new Point(31, 23);
            button5.Name = "button5";
            button5.Size = new Size(253, 53);
            button5.TabIndex = 0;
            button5.Text = "Pay Loan";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(304, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(754, 673);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // employeeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "employeeControl";
            Size = new Size(1058, 673);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Label label1;
        private Panel panel1;
        private Button button5;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
