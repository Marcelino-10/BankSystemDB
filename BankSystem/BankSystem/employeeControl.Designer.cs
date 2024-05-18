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
            button2 = new Button();
            button1 = new Button();
            btn_payLoan = new Button();
            panel2 = new Panel();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(116, 232);
            label1.Name = "label1";
            label1.Size = new Size(381, 29);
            label1.TabIndex = 0;
            label1.Text = "Welcome in Employee Page";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_payLoan);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 505);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(27, 139);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(205, 40);
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
            button1.Location = new Point(28, 76);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(205, 40);
            button1.TabIndex = 1;
            button1.Text = "Update Customer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_payLoan
            // 
            btn_payLoan.BackColor = SystemColors.ControlLightLight;
            btn_payLoan.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btn_payLoan.ForeColor = Color.DarkSlateGray;
            btn_payLoan.Location = new Point(27, 17);
            btn_payLoan.Margin = new Padding(3, 2, 3, 2);
            btn_payLoan.Name = "btn_payLoan";
            btn_payLoan.Size = new Size(205, 40);
            btn_payLoan.TabIndex = 0;
            btn_payLoan.Text = "Pay Loan";
            btn_payLoan.UseVisualStyleBackColor = false;
            btn_payLoan.Click += btn_payLoan_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(266, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 505);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button3.ForeColor = Color.DarkSlateGray;
            button3.Location = new Point(28, 206);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(205, 40);
            button3.TabIndex = 3;
            button3.Text = "Add Customer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // employeeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "employeeControl";
            Size = new Size(926, 505);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Label label1;
        private Panel panel1;
        private Button btn_payLoan;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Button button3;
    }
}
