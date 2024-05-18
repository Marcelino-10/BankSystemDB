namespace BankSystem
{
    partial class mainPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            mainPanel = new Panel();
            controlBar = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonBox = new Panel();
            LogoutButton = new Button();
            MaxButton = new Button();
            MinButton = new Button();
            CloseButton = new Button();
            controlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            buttonBox.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(0, 38);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1058, 673);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // controlBar
            // 
            controlBar.BackColor = Color.FromArgb(0, 64, 64);
            controlBar.Controls.Add(pictureBox1);
            controlBar.Controls.Add(label1);
            controlBar.Controls.Add(buttonBox);
            controlBar.Dock = DockStyle.Top;
            controlBar.Location = new Point(0, 0);
            controlBar.Name = "controlBar";
            controlBar.Size = new Size(1062, 38);
            controlBar.TabIndex = 0;
            controlBar.MouseDown += OnMouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._360_F_436565405_6ZImJ3BbFk9O6Gs1C66Z7ltNWSheqxJm;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 27);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 11F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 1;
            label1.Text = "Main Page";
            // 
            // buttonBox
            // 
            buttonBox.Controls.Add(LogoutButton);
            buttonBox.Controls.Add(MaxButton);
            buttonBox.Controls.Add(MinButton);
            buttonBox.Controls.Add(CloseButton);
            buttonBox.Dock = DockStyle.Right;
            buttonBox.Location = new Point(829, 0);
            buttonBox.Name = "buttonBox";
            buttonBox.Size = new Size(233, 38);
            buttonBox.TabIndex = 0;
            // 
            // LogoutButton
            // 
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Berlin Sans FB", 11F);
            LogoutButton.ForeColor = SystemColors.Control;
            LogoutButton.Location = new Point(5, 0);
            LogoutButton.Margin = new Padding(0);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(88, 38);
            LogoutButton.TabIndex = 3;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // MaxButton
            // 
            MaxButton.BackgroundImage = (Image)resources.GetObject("MaxButton.BackgroundImage");
            MaxButton.BackgroundImageLayout = ImageLayout.Zoom;
            MaxButton.FlatAppearance.BorderSize = 0;
            MaxButton.FlatStyle = FlatStyle.Flat;
            MaxButton.Location = new Point(152, 2);
            MaxButton.Name = "MaxButton";
            MaxButton.Size = new Size(36, 36);
            MaxButton.TabIndex = 2;
            MaxButton.UseVisualStyleBackColor = true;
            MaxButton.Click += button3_Click;
            // 
            // MinButton
            // 
            MinButton.BackgroundImage = (Image)resources.GetObject("MinButton.BackgroundImage");
            MinButton.BackgroundImageLayout = ImageLayout.Zoom;
            MinButton.FlatAppearance.BorderSize = 0;
            MinButton.FlatStyle = FlatStyle.Flat;
            MinButton.Location = new Point(108, 2);
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
            CloseButton.Location = new Point(193, 2);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(36, 36);
            CloseButton.TabIndex = 0;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 711);
            Controls.Add(controlBar);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainPage";
            Text = "Main Page";
            FormClosing += mainPage_FormClosing;
            controlBar.ResumeLayout(false);
            controlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            buttonBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel controlBar;
        private Panel buttonBox;
        private Button MaxButton;
        private Button MinButton;
        private Button CloseButton;
        private PictureBox pictureBox1;
        public Button LogoutButton;
        public Label label1;
    }
}