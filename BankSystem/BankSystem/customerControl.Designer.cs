namespace BankSystem
{
    partial class customerControl
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 720);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(0, 64, 64);
            button4.Location = new Point(29, 341);
            button4.Name = "button4";
            button4.Size = new Size(234, 54);
            button4.TabIndex = 5;
            button4.Text = "View Loan";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(0, 64, 64);
            button3.Location = new Point(29, 240);
            button3.Name = "button3";
            button3.Size = new Size(234, 54);
            button3.TabIndex = 4;
            button3.Text = "View Account";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(0, 64, 64);
            button2.Location = new Point(29, 153);
            button2.Name = "button2";
            button2.Size = new Size(234, 54);
            button2.TabIndex = 3;
            button2.Text = "Transaction";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 64, 64);
            button1.Location = new Point(29, 59);
            button1.Name = "button1";
            button1.Size = new Size(234, 54);
            button1.TabIndex = 2;
            button1.Text = "Request Loan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(294, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(786, 720);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(144, 240);
            label1.Name = "label1";
            label1.Size = new Size(477, 36);
            label1.TabIndex = 8;
            label1.Text = "Welcome in Customer Page";
            // 
            // customerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "customerControl";
            Size = new Size(1080, 720);
            Load += customerControl_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private RequestLoan requestLoan;
        private Transaction transaction;
        private ViewAccount viewAccount;
        private ViewRequestedLoans viewRequestedLoans;
        private Panel panel2;
        private Label label1;
    }
}
