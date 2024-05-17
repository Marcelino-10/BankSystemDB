namespace BankSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            controlBar = new Panel();
            buttonBox = new Panel();
            MaxButton = new Button();
            MinButton = new Button();
            CloseButton = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            controlBar.SuspendLayout();
            buttonBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(410, 520);
            button1.Name = "button1";
            button1.Size = new Size(209, 74);
            button1.TabIndex = 11;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(535, 394);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 27);
            textBox2.TabIndex = 10;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(535, 299);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 27);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(280, 386);
            label3.Name = "label3";
            label3.Size = new Size(179, 35);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(280, 291);
            label2.Name = "label2";
            label2.Size = new Size(48, 35);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 126);
            label1.Name = "label1";
            label1.Size = new Size(209, 72);
            label1.TabIndex = 6;
            label1.Text = "Welcome";
            // 
            // controlBar
            // 
            controlBar.BackColor = Color.FromArgb(0, 64, 64);
            controlBar.Controls.Add(pictureBox1);
            controlBar.Controls.Add(label4);
            controlBar.Controls.Add(buttonBox);
            controlBar.Dock = DockStyle.Top;
            controlBar.Location = new Point(0, 0);
            controlBar.Name = "controlBar";
            controlBar.Size = new Size(1062, 38);
            controlBar.TabIndex = 12;
            controlBar.MouseDown += OnMouseDown;
            // 
            // buttonBox
            // 
            buttonBox.Controls.Add(MaxButton);
            buttonBox.Controls.Add(MinButton);
            buttonBox.Controls.Add(CloseButton);
            buttonBox.Dock = DockStyle.Right;
            buttonBox.Location = new Point(916, 0);
            buttonBox.Name = "buttonBox";
            buttonBox.Size = new Size(146, 38);
            buttonBox.TabIndex = 0;
            // 
            // MaxButton
            // 
            MaxButton.BackgroundImage = (Image)resources.GetObject("MaxButton.BackgroundImage");
            MaxButton.BackgroundImageLayout = ImageLayout.Zoom;
            MaxButton.FlatAppearance.BorderSize = 0;
            MaxButton.FlatStyle = FlatStyle.Flat;
            MaxButton.Location = new Point(65, 1);
            MaxButton.Name = "MaxButton";
            MaxButton.Size = new Size(36, 36);
            MaxButton.TabIndex = 2;
            MaxButton.UseVisualStyleBackColor = true;
            MaxButton.Click += MaxButton_Click;
            // 
            // MinButton
            // 
            MinButton.BackgroundImage = (Image)resources.GetObject("MinButton.BackgroundImage");
            MinButton.BackgroundImageLayout = ImageLayout.Zoom;
            MinButton.FlatAppearance.BorderSize = 0;
            MinButton.FlatStyle = FlatStyle.Flat;
            MinButton.Location = new Point(21, 1);
            MinButton.Name = "MinButton";
            MinButton.Size = new Size(36, 36);
            MinButton.TabIndex = 1;
            MinButton.UseVisualStyleBackColor = true;
            MinButton.Click += MinButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Zoom;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(106, 1);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(36, 36);
            CloseButton.TabIndex = 0;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._360_F_436565405_6ZImJ3BbFk9O6Gs1C66Z7ltNWSheqxJm;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(4, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 27);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB", 11F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(42, 9);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 3;
            label4.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 720);
            Controls.Add(controlBar);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Bank App";
            controlBar.ResumeLayout(false);
            controlBar.PerformLayout();
            buttonBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public TextBox textBox2;
        public TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private mainPage main;
        private Panel controlBar;
        private Panel buttonBox;
        private Button MaxButton;
        private Button MinButton;
        private Button CloseButton;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
