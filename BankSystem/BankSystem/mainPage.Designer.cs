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
            mainPanel = new Panel();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1058, 669);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(mainPanel);
            Name = "mainPage";
            Text = "mainPage";
            ResumeLayout(false);
            this.FormClosing += mainPage_FormClosing;
        }

        #endregion

        private Panel mainPanel;
    }
}