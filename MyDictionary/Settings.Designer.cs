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
            loginLb = new Label();
            changePasswordLb = new Label();
            panel3 = new Panel();
            newPasswordTb = new TextBox();
            panel2 = new Panel();
            changeBtn = new Button();
            bDayLb = new Label();
            changeBdayLb = new Label();
            oldPasswordTb = new TextBox();
            newBdayTb = new TextBox();
            panel4 = new Panel();
            changeBdayBtn = new Button();
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
            signOutLb.Location = new Point(673, 404);
            signOutLb.Name = "signOutLb";
            signOutLb.Size = new Size(115, 28);
            signOutLb.TabIndex = 0;
            signOutLb.Text = "Sign out";
            signOutLb.Click += signOutLb_Click;
            // 
            // loginLb
            // 
            loginLb.AutoSize = true;
            loginLb.BackColor = Color.White;
            loginLb.Font = new Font("Lucida Sans", 14.25F);
            loginLb.ForeColor = Color.Black;
            loginLb.Location = new Point(207, 72);
            loginLb.Name = "loginLb";
            loginLb.Size = new Size(120, 22);
            loginLb.TabIndex = 0;
            loginLb.Text = "Your login: ";
            // 
            // changePasswordLb
            // 
            changePasswordLb.AutoSize = true;
            changePasswordLb.BackColor = Color.White;
            changePasswordLb.Font = new Font("Lucida Sans", 14.25F);
            changePasswordLb.ForeColor = Color.Black;
            changePasswordLb.Location = new Point(207, 151);
            changePasswordLb.Name = "changePasswordLb";
            changePasswordLb.Size = new Size(184, 22);
            changePasswordLb.TabIndex = 0;
            changePasswordLb.Text = "Change Password: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(216, 228);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 3);
            panel3.TabIndex = 9;
            // 
            // newPasswordTb
            // 
            newPasswordTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newPasswordTb.BorderStyle = BorderStyle.None;
            newPasswordTb.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordTb.Location = new Point(484, 199);
            newPasswordTb.MaxLength = 20;
            newPasswordTb.Name = "newPasswordTb";
            newPasswordTb.PlaceholderText = "Enter new password";
            newPasswordTb.Size = new Size(250, 23);
            newPasswordTb.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(484, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 3);
            panel2.TabIndex = 9;
            // 
            // changeBtn
            // 
            changeBtn.Cursor = Cursors.Hand;
            changeBtn.FlatStyle = FlatStyle.Flat;
            changeBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeBtn.ForeColor = Color.Black;
            changeBtn.Location = new Point(430, 246);
            changeBtn.Name = "changeBtn";
            changeBtn.Size = new Size(85, 29);
            changeBtn.TabIndex = 10;
            changeBtn.Text = "Change";
            changeBtn.UseVisualStyleBackColor = true;
            changeBtn.Click += changeBtn_Click;
            // 
            // bDayLb
            // 
            bDayLb.AutoSize = true;
            bDayLb.BackColor = Color.White;
            bDayLb.Font = new Font("Lucida Sans", 14.25F);
            bDayLb.ForeColor = Color.Black;
            bDayLb.Location = new Point(207, 108);
            bDayLb.Name = "bDayLb";
            bDayLb.Size = new Size(183, 22);
            bDayLb.TabIndex = 0;
            bDayLb.Text = "Your date of birth:";
            // 
            // changeBdayLb
            // 
            changeBdayLb.AutoSize = true;
            changeBdayLb.BackColor = Color.White;
            changeBdayLb.Font = new Font("Lucida Sans", 14.25F);
            changeBdayLb.ForeColor = Color.Black;
            changeBdayLb.Location = new Point(207, 283);
            changeBdayLb.Name = "changeBdayLb";
            changeBdayLb.Size = new Size(214, 22);
            changeBdayLb.TabIndex = 0;
            changeBdayLb.Text = "Change date of birth: ";
            // 
            // oldPasswordTb
            // 
            oldPasswordTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            oldPasswordTb.BorderStyle = BorderStyle.None;
            oldPasswordTb.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oldPasswordTb.Location = new Point(216, 199);
            oldPasswordTb.MaxLength = 20;
            oldPasswordTb.Name = "oldPasswordTb";
            oldPasswordTb.PlaceholderText = "Enter old password";
            oldPasswordTb.Size = new Size(250, 23);
            oldPasswordTb.TabIndex = 8;
            // 
            // newBdayTb
            // 
            newBdayTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newBdayTb.BorderStyle = BorderStyle.None;
            newBdayTb.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newBdayTb.Location = new Point(216, 322);
            newBdayTb.MaxLength = 20;
            newBdayTb.Name = "newBdayTb";
            newBdayTb.PlaceholderText = "Enter new date";
            newBdayTb.Size = new Size(250, 23);
            newBdayTb.TabIndex = 31;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(216, 351);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 3);
            panel4.TabIndex = 32;
            // 
            // changeBdayBtn
            // 
            changeBdayBtn.Cursor = Cursors.Hand;
            changeBdayBtn.FlatStyle = FlatStyle.Flat;
            changeBdayBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeBdayBtn.ForeColor = Color.Black;
            changeBdayBtn.Location = new Point(425, 363);
            changeBdayBtn.Name = "changeBdayBtn";
            changeBdayBtn.Size = new Size(90, 31);
            changeBdayBtn.TabIndex = 10;
            changeBdayBtn.Text = "Change";
            changeBdayBtn.UseVisualStyleBackColor = true;
            changeBdayBtn.Click += changeBdayBtn_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(newBdayTb);
            Controls.Add(panel4);
            Controls.Add(bDayLb);
            Controls.Add(changeBdayLb);
            Controls.Add(loginLb);
            Controls.Add(panel1);
            Controls.Add(changeBdayBtn);
            Controls.Add(changeBtn);
            Controls.Add(oldPasswordTb);
            Controls.Add(newPasswordTb);
            Controls.Add(changePasswordLb);
            Controls.Add(panel2);
            Controls.Add(signOutLb);
            Controls.Add(settingsLbH);
            Controls.Add(panel3);
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
        private Label loginLb;
        private Label changePasswordLb;
        private Panel panel3;
        private TextBox newPasswordTb;
        private Panel panel2;
        private Button changeBtn;
        private Label bDayLb;
        private Label changeBdayLb;
        private TextBox oldPasswordTb;
        private TextBox newBdayTb;
        private Panel panel4;
        private Button changeBdayBtn;
    }
}