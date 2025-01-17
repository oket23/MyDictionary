namespace MyDictionary
{
    partial class Register
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
            loginLb = new Label();
            registerBtn = new Button();
            panel1 = new Panel();
            registerLb = new Label();
            passwordPicture = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            loginTb = new TextBox();
            passwordTb = new TextBox();
            passwordKeyPicture = new PictureBox();
            loginPicrture = new PictureBox();
            panel4 = new Panel();
            passwordAgainTb = new TextBox();
            panel5 = new Panel();
            bDayPicture = new PictureBox();
            bDayDTP = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordKeyPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginPicrture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bDayPicture).BeginInit();
            SuspendLayout();
            // 
            // loginLb
            // 
            loginLb.AutoSize = true;
            loginLb.Cursor = Cursors.Hand;
            loginLb.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLb.Location = new Point(337, 394);
            loginLb.Name = "loginLb";
            loginLb.Size = new Size(66, 17);
            loginLb.TabIndex = 12;
            loginLb.Text = "or login";
            loginLb.Click += loginLb_Click;
            // 
            // registerBtn
            // 
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.Black;
            registerBtn.Location = new Point(299, 357);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(144, 34);
            registerBtn.TabIndex = 11;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(registerLb);
            panel1.Location = new Point(-4, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 130);
            panel1.TabIndex = 13;
            // 
            // registerLb
            // 
            registerLb.AutoSize = true;
            registerLb.BackColor = Color.Black;
            registerLb.Font = new Font("Lucida Sans", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLb.ForeColor = Color.White;
            registerLb.Location = new Point(287, 43);
            registerLb.Name = "registerLb";
            registerLb.Size = new Size(176, 42);
            registerLb.TabIndex = 10;
            registerLb.Text = "Register";
            registerLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordPicture
            // 
            passwordPicture.Cursor = Cursors.Hand;
            passwordPicture.Image = Properties.Resources.closePassword;
            passwordPicture.Location = new Point(680, 182);
            passwordPicture.Name = "passwordPicture";
            passwordPicture.Size = new Size(20, 20);
            passwordPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordPicture.TabIndex = 20;
            passwordPicture.TabStop = false;
            passwordPicture.Click += passwordPicture_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(399, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 3);
            panel3.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(54, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 3);
            panel2.TabIndex = 18;
            // 
            // loginTb
            // 
            loginTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginTb.BorderStyle = BorderStyle.None;
            loginTb.Font = new Font("Lucida Sans", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginTb.Location = new Point(54, 175);
            loginTb.MaxLength = 20;
            loginTb.Multiline = true;
            loginTb.Name = "loginTb";
            loginTb.PlaceholderText = "Enter login";
            loginTb.Size = new Size(275, 29);
            loginTb.TabIndex = 16;
            // 
            // passwordTb
            // 
            passwordTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordTb.BorderStyle = BorderStyle.None;
            passwordTb.Font = new Font("Lucida Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTb.Location = new Point(399, 178);
            passwordTb.MaxLength = 20;
            passwordTb.Multiline = true;
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.PlaceholderText = "Enter password";
            passwordTb.Size = new Size(282, 26);
            passwordTb.TabIndex = 17;
            // 
            // passwordKeyPicture
            // 
            passwordKeyPicture.Image = Properties.Resources.password;
            passwordKeyPicture.Location = new Point(358, 172);
            passwordKeyPicture.Name = "passwordKeyPicture";
            passwordKeyPicture.Size = new Size(32, 32);
            passwordKeyPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordKeyPicture.TabIndex = 14;
            passwordKeyPicture.TabStop = false;
            // 
            // loginPicrture
            // 
            loginPicrture.Image = Properties.Resources.login;
            loginPicrture.Location = new Point(16, 172);
            loginPicrture.Name = "loginPicrture";
            loginPicrture.Size = new Size(32, 32);
            loginPicrture.SizeMode = PictureBoxSizeMode.StretchImage;
            loginPicrture.TabIndex = 15;
            loginPicrture.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(399, 267);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 3);
            panel4.TabIndex = 23;
            // 
            // passwordAgainTb
            // 
            passwordAgainTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordAgainTb.BorderStyle = BorderStyle.None;
            passwordAgainTb.Font = new Font("Lucida Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordAgainTb.Location = new Point(399, 242);
            passwordAgainTb.MaxLength = 20;
            passwordAgainTb.Multiline = true;
            passwordAgainTb.Name = "passwordAgainTb";
            passwordAgainTb.PasswordChar = '*';
            passwordAgainTb.PlaceholderText = "Enter password again";
            passwordAgainTb.Size = new Size(282, 28);
            passwordAgainTb.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(54, 267);
            panel5.Name = "panel5";
            panel5.Size = new Size(275, 3);
            panel5.TabIndex = 26;
            // 
            // bDayPicture
            // 
            bDayPicture.Image = Properties.Resources.date;
            bDayPicture.Location = new Point(16, 236);
            bDayPicture.Name = "bDayPicture";
            bDayPicture.Size = new Size(32, 32);
            bDayPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            bDayPicture.TabIndex = 24;
            bDayPicture.TabStop = false;
            // 
            // bDayDTP
            // 
            bDayDTP.Cursor = Cursors.Hand;
            bDayDTP.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bDayDTP.Format = DateTimePickerFormat.Custom;
            bDayDTP.Location = new Point(57, 231);
            bDayDTP.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            bDayDTP.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            bDayDTP.Name = "bDayDTP";
            bDayDTP.Size = new Size(272, 29);
            bDayDTP.TabIndex = 27;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 425);
            Controls.Add(bDayDTP);
            Controls.Add(panel5);
            Controls.Add(bDayPicture);
            Controls.Add(panel4);
            Controls.Add(passwordAgainTb);
            Controls.Add(passwordPicture);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(loginTb);
            Controls.Add(passwordTb);
            Controls.Add(passwordKeyPicture);
            Controls.Add(loginPicrture);
            Controls.Add(panel1);
            Controls.Add(loginLb);
            Controls.Add(registerBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Register";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyDictionary";
            FormClosed += Register_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordKeyPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginPicrture).EndInit();
            ((System.ComponentModel.ISupportInitialize)bDayPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLb;
        private Button registerBtn;
        private Panel panel1;
        private Label registerLb;
        private PictureBox passwordPicture;
        private Panel panel3;
        private Panel panel2;
        private TextBox loginTb;
        private TextBox passwordTb;
        private PictureBox passwordKeyPicture;
        private PictureBox loginPicrture;
        private Panel panel4;
        private TextBox passwordAgainTb;
        private Panel panel5;
        private TextBox textBox2;
        private PictureBox bDayPicture;
        private DateTimePicker bDayDTP;
    }
}