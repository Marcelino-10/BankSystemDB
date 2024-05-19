namespace BankSystem
{
    partial class UpdateAdmin
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
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(425, 262);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 30);
            textBox2.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Heavy", 18F);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(258, 254);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 44;
            label3.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(425, 158);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 30);
            textBox1.TabIndex = 41;
            // 
            // button1
            // 
            button1.Font = new Font("Franklin Gothic Heavy", 18F);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(322, 358);
            button1.Name = "button1";
            button1.Size = new Size(205, 63);
            button1.TabIndex = 40;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Heavy", 18F);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(258, 158);
            label2.Name = "label2";
            label2.Size = new Size(37, 30);
            label2.TabIndex = 39;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Franklin Gothic Heavy", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(323, 52);
            label1.Name = "label1";
            label1.Size = new Size(229, 37);
            label1.TabIndex = 38;
            label1.Text = "Update Admin";
            // 
            // UpdateAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UpdateAdmin";
            Size = new Size(926, 517);
            Load += UpdateAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}
