﻿namespace BankSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(412, 496);
            button1.Name = "button1";
            button1.Size = new Size(196, 74);
            button1.TabIndex = 11;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(537, 370);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 27);
            textBox2.TabIndex = 10;
            textBox2.UseSystemPasswordChar = true;

            // 
            // textBox1
            // 
            textBox1.Location = new Point(537, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 9;
           
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 362);
            label3.Name = "label3";
            label3.Size = new Size(179, 35);
            label3.TabIndex = 8;
            label3.Text = "Password";
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 267);
            label2.Name = "label2";
            label2.Size = new Size(48, 35);
            label2.TabIndex = 7;
            label2.Text = "ID";
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 102);
            label1.Name = "label1";
            label1.Size = new Size(209, 72);
            label1.TabIndex = 6;
            label1.Text = "Welcome";
         
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bank App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private mainPage main;
    }
}
