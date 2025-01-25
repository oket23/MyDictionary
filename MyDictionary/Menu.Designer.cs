﻿namespace MyDictionary
{
    partial class Menu
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
            viewDictionariesLb = new Label();
            adminToolsLb = new Label();
            settingsLb = new Label();
            exitLb = new Label();
            viewDictionariesLbH = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(viewDictionariesLb);
            panel1.Controls.Add(adminToolsLb);
            panel1.Controls.Add(settingsLb);
            panel1.Controls.Add(exitLb);
            panel1.Location = new Point(0, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 465);
            panel1.TabIndex = 2;
            // 
            // viewDictionariesLb
            // 
            viewDictionariesLb.AutoSize = true;
            viewDictionariesLb.BackColor = Color.Black;
            viewDictionariesLb.Cursor = Cursors.Hand;
            viewDictionariesLb.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            viewDictionariesLb.ForeColor = Color.White;
            viewDictionariesLb.Location = new Point(12, 28);
            viewDictionariesLb.Name = "viewDictionariesLb";
            viewDictionariesLb.Size = new Size(162, 56);
            viewDictionariesLb.TabIndex = 0;
            viewDictionariesLb.Text = "View \r\nDictionaries";
            // 
            // adminToolsLb
            // 
            adminToolsLb.AutoSize = true;
            adminToolsLb.BackColor = Color.Black;
            adminToolsLb.Cursor = Cursors.Hand;
            adminToolsLb.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            adminToolsLb.ForeColor = SystemColors.Control;
            adminToolsLb.Location = new Point(12, 328);
            adminToolsLb.Name = "adminToolsLb";
            adminToolsLb.Size = new Size(169, 28);
            adminToolsLb.TabIndex = 0;
            adminToolsLb.Text = "Admin Tools";
            adminToolsLb.Click += adminToolsLb_Click;
            // 
            // settingsLb
            // 
            settingsLb.AutoSize = true;
            settingsLb.BackColor = Color.Black;
            settingsLb.Cursor = Cursors.Hand;
            settingsLb.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            settingsLb.ForeColor = SystemColors.Control;
            settingsLb.Location = new Point(12, 369);
            settingsLb.Name = "settingsLb";
            settingsLb.Size = new Size(113, 28);
            settingsLb.TabIndex = 0;
            settingsLb.Text = "Settings";
            settingsLb.Click += settingsLb_Click;
            // 
            // exitLb
            // 
            exitLb.AutoSize = true;
            exitLb.BackColor = Color.Black;
            exitLb.Cursor = Cursors.Hand;
            exitLb.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            exitLb.ForeColor = SystemColors.Control;
            exitLb.Location = new Point(12, 411);
            exitLb.Name = "exitLb";
            exitLb.Size = new Size(60, 28);
            exitLb.TabIndex = 0;
            exitLb.Text = "Exit";
            exitLb.Click += exitLb_Click;
            // 
            // viewDictionariesLbH
            // 
            viewDictionariesLbH.AutoSize = true;
            viewDictionariesLbH.BackColor = Color.White;
            viewDictionariesLbH.Cursor = Cursors.Hand;
            viewDictionariesLbH.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            viewDictionariesLbH.ForeColor = Color.Black;
            viewDictionariesLbH.Location = new Point(420, 19);
            viewDictionariesLbH.Name = "viewDictionariesLbH";
            viewDictionariesLbH.Size = new Size(162, 28);
            viewDictionariesLbH.TabIndex = 1;
            viewDictionariesLbH.Text = "Dictionaries";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewDictionariesLbH);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyDictionary";
            FormClosed += Menu_FormClosed;
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label exitLb;
        private Label settingsLb;
        private Label viewDictionariesLb;
        private Label viewDictionariesLbH;
        private Label adminToolsLb;
    }
}