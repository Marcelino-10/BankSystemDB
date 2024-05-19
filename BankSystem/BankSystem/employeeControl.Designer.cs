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
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            button6 = new Button();
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
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
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
            button2.Location = new Point(29, 281);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(220, 40);
            button2.TabIndex = 5;
            button2.Text = "Delete Account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button4.ForeColor = Color.DarkSlateGray;
            button4.Location = new Point(28, 216);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(220, 40);
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
            button3.Location = new Point(28, 154);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(220, 40);
            button3.TabIndex = 3;
            button3.Text = "Add Customer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(28, 82);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(220, 42);
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
            button5.Location = new Point(27, 17);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(221, 40);
            button5.TabIndex = 0;
            button5.Text = "Verify Loan";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
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
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.Font = new Font("Verdana", 10F, FontStyle.Bold);
            button6.ForeColor = Color.DarkSlateGray;
            button6.Location = new Point(27, 348);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(220, 40);
            button6.TabIndex = 6;
            button6.Text = "Delete Loan";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
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
            Load += employeeControl_Load;
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
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button6;
    }
}
