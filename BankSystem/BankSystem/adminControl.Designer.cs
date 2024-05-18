namespace BankSystem
{
    partial class adminControl
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
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            button10 = new Button();
            button9 = new Button();
            button5 = new Button();
            button4 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button16 = new Button();
            button11 = new Button();
            button12 = new Button();
            button15 = new Button();
            button13 = new Button();
            button14 = new Button();
            addBank = new AddBank();
            addBranch = new AddBranch();
            showAdmin = new ShowAdmin();
            showCustomer = new ShowCustomer();
            showBranch = new ShowBranch();
            showEmployee = new ShowEmployee();
            showBank = new ShowBank();
            showLoan = new ShowLoan();
            signemployee = new signEmployee();
            signadmin = new signAdmin();
            updateadmin = new UpdateAdmin();
            updateemployee = new UpdateEmployee();
            queryControl = new queryControl();
            panel4 = new Panel();
            button7 = new Button();
            button1 = new Button();
            button6 = new Button();
            button8 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(7, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 81);
            panel2.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(2, 42);
            button3.Name = "button3";
            button3.Size = new Size(247, 29);
            button3.TabIndex = 1;
            button3.Text = "Branch";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(2, 4);
            button2.Name = "button2";
            button2.Size = new Size(247, 29);
            button2.TabIndex = 0;
            button2.Text = "Bank";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(9, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 685);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(242, 265);
            label1.Name = "label1";
            label1.Size = new Size(566, 48);
            label1.TabIndex = 7;
            label1.Text = "Welcome in Admin Page";
            // 
            // panel3
            // 
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(273, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 143);
            panel3.TabIndex = 5;
            // 
            // button10
            // 
            button10.Location = new Point(2, 108);
            button10.Name = "button10";
            button10.Size = new Size(247, 29);
            button10.TabIndex = 9;
            button10.Text = "Update Employee";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(2, 73);
            button9.Name = "button9";
            button9.Size = new Size(247, 29);
            button9.TabIndex = 8;
            button9.Text = "Sign Employee";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button5
            // 
            button5.Location = new Point(2, 38);
            button5.Name = "button5";
            button5.Size = new Size(247, 29);
            button5.TabIndex = 7;
            button5.Text = "Update Admin";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(2, 3);
            button4.Name = "button4";
            button4.Size = new Size(247, 29);
            button4.TabIndex = 6;
            button4.Text = "Sign Admin";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button16);
            flowLayoutPanel1.Controls.Add(button11);
            flowLayoutPanel1.Controls.Add(button12);
            flowLayoutPanel1.Controls.Add(button15);
            flowLayoutPanel1.Controls.Add(button13);
            flowLayoutPanel1.Controls.Add(button14);
            flowLayoutPanel1.Location = new Point(536, 71);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 208);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // button16
            // 
            button16.Location = new Point(3, 3);
            button16.Name = "button16";
            button16.Size = new Size(247, 29);
            button16.TabIndex = 5;
            button16.Text = "Admins";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button11
            // 
            button11.Location = new Point(3, 38);
            button11.Name = "button11";
            button11.Size = new Size(247, 29);
            button11.TabIndex = 0;
            button11.Text = "Banks";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(3, 73);
            button12.Name = "button12";
            button12.Size = new Size(247, 29);
            button12.TabIndex = 1;
            button12.Text = "Branch";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button15
            // 
            button15.Location = new Point(3, 108);
            button15.Name = "button15";
            button15.Size = new Size(247, 29);
            button15.TabIndex = 4;
            button15.Text = "Customers";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button13
            // 
            button13.Location = new Point(3, 143);
            button13.Name = "button13";
            button13.Size = new Size(247, 29);
            button13.TabIndex = 2;
            button13.Text = "Employees";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(3, 178);
            button14.Name = "button14";
            button14.Size = new Size(247, 29);
            button14.TabIndex = 3;
            button14.Text = "Loans";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // addBank
            // 
            addBank.Location = new Point(0, 0);
            addBank.Name = "addBank";
            addBank.Size = new Size(1058, 694);
            addBank.TabIndex = 0;
            // 
            // addBranch
            // 
            addBranch.Location = new Point(0, 0);
            addBranch.Name = "addBranch";
            addBranch.Size = new Size(1058, 694);
            addBranch.TabIndex = 0;
            // 
            // showAdmin
            // 
            showAdmin.Location = new Point(0, 0);
            showAdmin.Name = "showAdmin";
            showAdmin.Size = new Size(1058, 689);
            showAdmin.TabIndex = 0;
            // 
            // showCustomer
            // 
            showCustomer.Location = new Point(0, 0);
            showCustomer.Name = "showCustomer";
            showCustomer.Size = new Size(1058, 689);
            showCustomer.TabIndex = 0;
            // 
            // showBranch
            // 
            showBranch.Location = new Point(0, 0);
            showBranch.Name = "showBranch";
            showBranch.Size = new Size(1058, 689);
            showBranch.TabIndex = 0;
            // 
            // showEmployee
            // 
            showEmployee.Location = new Point(0, 0);
            showEmployee.Name = "showEmployee";
            showEmployee.Size = new Size(1058, 689);
            showEmployee.TabIndex = 0;
            // 
            // showBank
            // 
            showBank.Location = new Point(0, 0);
            showBank.Name = "showBank";
            showBank.Size = new Size(1058, 689);
            showBank.TabIndex = 0;
            // 
            // showLoan
            // 
            showLoan.Location = new Point(0, 0);
            showLoan.Name = "showLoan";
            showLoan.Size = new Size(1058, 689);
            showLoan.TabIndex = 0;
            // 
            // signemployee
            // 
            signemployee.Location = new Point(0, 0);
            signemployee.Name = "signemployee";
            signemployee.Size = new Size(1058, 685);
            signemployee.TabIndex = 0;
            // 
            // signadmin
            // 
            signadmin.BackColor = SystemColors.ControlLightLight;
            signadmin.Location = new Point(0, 0);
            signadmin.Name = "signadmin";
            signadmin.Size = new Size(1058, 685);
            signadmin.TabIndex = 0;
            // 
            // updateadmin
            // 
            updateadmin.BackColor = SystemColors.ControlLightLight;
            updateadmin.Location = new Point(0, 0);
            updateadmin.Name = "updateadmin";
            updateadmin.Size = new Size(1058, 689);
            updateadmin.TabIndex = 0;
            // 
            // updateemployee
            // 
            updateemployee.BackColor = SystemColors.ControlLightLight;
            updateemployee.Location = new Point(0, 0);
            updateemployee.Name = "updateemployee";
            updateemployee.Size = new Size(1058, 689);
            updateemployee.TabIndex = 0;
            // 
            // queryControl
            // 
            queryControl.BackColor = SystemColors.ControlLightLight;
            queryControl.Location = new Point(0, 0);
            queryControl.Name = "queryControl";
            queryControl.Size = new Size(1058, 685);
            queryControl.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button8);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1058, 72);
            panel4.TabIndex = 8;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 64, 64);
            button7.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(795, 3);
            button7.Name = "button7";
            button7.Size = new Size(257, 65);
            button7.TabIndex = 10;
            button7.Text = "Queries";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 64);
            button1.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(5, 3);
            button1.Name = "button1";
            button1.Size = new Size(257, 65);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 64, 64);
            button6.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.Menu;
            button6.Location = new Point(532, 3);
            button6.Name = "button6";
            button6.Size = new Size(257, 65);
            button6.TabIndex = 9;
            button6.Text = "Show";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 64, 64);
            button8.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(268, 3);
            button8.Name = "button8";
            button8.Size = new Size(257, 65);
            button8.TabIndex = 11;
            button8.Text = "SignUp";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // adminControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "adminControl";
            Size = new Size(1058, 762);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Panel panel3;
        private Button button10;
        private Button button9;
        private Button button5;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button15;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button14;
        private Button button16;
        private Panel panel1;
        private Label label1;
        private AddBank addBank;
        private AddBranch addBranch;
        private ShowAdmin showAdmin;
        private ShowCustomer showCustomer;
        private ShowBranch showBranch;
        private ShowEmployee showEmployee;
        private ShowBank showBank;
        private ShowLoan showLoan;
        private signEmployee signemployee;
        private UpdateAdmin updateadmin;
        private UpdateEmployee updateemployee;
        private signAdmin signadmin;
        private queryControl queryControl;
        private Panel panel4;
        private Button button7;
        private Button button1;
        private Button button6;
        private Button button8;
    }
}
