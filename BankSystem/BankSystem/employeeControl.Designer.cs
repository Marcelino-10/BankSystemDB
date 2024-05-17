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
            button1 = new Button();
            btn_payLoan = new Button();
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_payLoan);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 673);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(32, 101);
            button1.Name = "button1";
            button1.Size = new Size(234, 53);
            button1.TabIndex = 1;
            button1.Text = "Add Customer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_payLoan
            // 
            btn_payLoan.BackColor = SystemColors.ControlLightLight;
            btn_payLoan.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btn_payLoan.ForeColor = Color.DarkSlateGray;
            btn_payLoan.Location = new Point(31, 23);
            btn_payLoan.Name = "btn_payLoan";
            btn_payLoan.Size = new Size(234, 53);
            btn_payLoan.TabIndex = 0;
            btn_payLoan.Text = "Pay Loan";
            btn_payLoan.UseVisualStyleBackColor = false;
            btn_payLoan.Click += btn_payLoan_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(304, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(754, 673);
            panel2.TabIndex = 2;
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
        private Button btn_payLoan;
        private Button button1;
        private Panel panel2;
    }
}
