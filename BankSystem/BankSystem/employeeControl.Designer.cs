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
            btn_payLoan = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(469, 265);
            label1.Name = "label1";
            label1.Size = new Size(479, 36);
            label1.TabIndex = 0;
            label1.Text = "Welcome in Employee Page";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btn_payLoan);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 669);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btn_payLoan
            // 
            btn_payLoan.BackColor = SystemColors.ControlLightLight;
            btn_payLoan.Font = new Font("Verdana", 10F, FontStyle.Bold);
            btn_payLoan.ForeColor = Color.DarkSlateGray;
            btn_payLoan.Location = new Point(25, 23);
            btn_payLoan.Name = "btn_payLoan";
            btn_payLoan.Size = new Size(234, 54);
            btn_payLoan.TabIndex = 0;
            btn_payLoan.Text = "Pay Loan";
            btn_payLoan.UseVisualStyleBackColor = false;
            btn_payLoan.Click += btn_payLoan_Click;
            // 
            // employeeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "employeeControl";
            Size = new Size(1058, 669);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btn_payLoan;
    }
}
