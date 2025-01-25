namespace MyDictionary
{
    partial class Settings
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
            panel1 = new Panel();
            adminToolsLb = new Label();
            viewDictionariesLb = new Label();
            settingsLb = new Label();
            exitLb = new Label();
            settingsLbH = new Label();
            signOutLb = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(adminToolsLb);
            panel1.Controls.Add(viewDictionariesLb);
            panel1.Controls.Add(settingsLb);
            panel1.Controls.Add(exitLb);
            panel1.Location = new Point(-4, -16);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 475);
            panel1.TabIndex = 3;
            // 
            // adminToolsLb
            // 
            adminToolsLb.AutoSize = true;
            adminToolsLb.BackColor = Color.Black;
            adminToolsLb.Cursor = Cursors.Hand;
            adminToolsLb.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            adminToolsLb.ForeColor = SystemColors.Control;
            adminToolsLb.Location = new Point(16, 336);
            adminToolsLb.Name = "adminToolsLb";
            adminToolsLb.Size = new Size(169, 28);
            adminToolsLb.TabIndex = 1;
            adminToolsLb.Text = "Admin Tools";
            adminToolsLb.Click += adminToolsLb_Click;
            // 
            // viewDictionariesLb
            // 
            viewDictionariesLb.AutoSize = true;
            viewDictionariesLb.BackColor = Color.Black;
            viewDictionariesLb.Cursor = Cursors.Hand;
            viewDictionariesLb.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            viewDictionariesLb.ForeColor = Color.White;
            viewDictionariesLb.Location = new Point(16, 35);
            viewDictionariesLb.Name = "viewDictionariesLb";
            viewDictionariesLb.Size = new Size(162, 56);
            viewDictionariesLb.TabIndex = 0;
            viewDictionariesLb.Text = "View \r\nDictionaries";
            viewDictionariesLb.Click += viewDictionariesLb_Click;
            // 
            // settingsLb
            // 
            settingsLb.AutoSize = true;
            settingsLb.BackColor = Color.Black;
            settingsLb.Cursor = Cursors.Hand;
            settingsLb.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            settingsLb.ForeColor = SystemColors.Control;
            settingsLb.Location = new Point(16, 377);
            settingsLb.Name = "settingsLb";
            settingsLb.Size = new Size(113, 28);
            settingsLb.TabIndex = 0;
            settingsLb.Text = "Settings";
            // 
            // exitLb
            // 
            exitLb.AutoSize = true;
            exitLb.BackColor = Color.Black;
            exitLb.Cursor = Cursors.Hand;
            exitLb.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            exitLb.ForeColor = SystemColors.Control;
            exitLb.Location = new Point(16, 420);
            exitLb.Name = "exitLb";
            exitLb.Size = new Size(60, 28);
            exitLb.TabIndex = 0;
            exitLb.Text = "Exit";
            exitLb.Click += exitLb_Click;
            // 
            // settingsLbH
            // 
            settingsLbH.AutoSize = true;
            settingsLbH.BackColor = Color.White;
            settingsLbH.Cursor = Cursors.Hand;
            settingsLbH.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            settingsLbH.ForeColor = Color.Black;
            settingsLbH.Location = new Point(449, 19);
            settingsLbH.Name = "settingsLbH";
            settingsLbH.Size = new Size(113, 28);
            settingsLbH.TabIndex = 0;
            settingsLbH.Text = "Settings";
            // 
            // signOutLb
            // 
            signOutLb.AutoSize = true;
            signOutLb.BackColor = Color.White;
            signOutLb.Cursor = Cursors.Hand;
            signOutLb.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            signOutLb.ForeColor = Color.Black;
            signOutLb.Location = new Point(673, 320);
            signOutLb.Name = "signOutLb";
            signOutLb.Size = new Size(115, 28);
            signOutLb.TabIndex = 0;
            signOutLb.Text = "Sign out";
            signOutLb.Click += signOutLb_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(signOutLb);
            Controls.Add(settingsLbH);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Settings";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyDictionary";
            FormClosed += Settings_FormClosed;
            Load += Settings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label viewDictionariesLb;
        private Label settingsLb;
        private Label exitLb;
        private Label settingsLbH;
        private Label adminToolsLb;
        private Label signOutLb;
    }
}