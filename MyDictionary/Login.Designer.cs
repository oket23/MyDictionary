namespace MyDictionary
{
    partial class Login
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
            loginLb = new Label();
            loginPicrture = new PictureBox();
            passwordKeyPicture = new PictureBox();
            passwordTb = new TextBox();
            loginBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            loginTb = new TextBox();
            passwordPicture = new PictureBox();
            forgotLb = new Label();
            registerLb = new Label();
            ((System.ComponentModel.ISupportInitialize)loginPicrture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordKeyPicture).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordPicture).BeginInit();
            SuspendLayout();
            // 
            // loginLb
            // 
            loginLb.AutoSize = true;
            loginLb.BackColor = Color.Black;
            loginLb.Font = new Font("Gill Sans MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLb.ForeColor = Color.White;
            loginLb.Location = new Point(156, 38);
            loginLb.Name = "loginLb";
            loginLb.Size = new Size(119, 52);
            loginLb.TabIndex = 10;
            loginLb.Text = "Login";
            // 
            // loginPicrture
            // 
            loginPicrture.Image = Properties.Resources.login;
            loginPicrture.Location = new Point(55, 169);
            loginPicrture.Name = "loginPicrture";
            loginPicrture.Size = new Size(32, 32);
            loginPicrture.SizeMode = PictureBoxSizeMode.StretchImage;
            loginPicrture.TabIndex = 1;
            loginPicrture.TabStop = false;
            // 
            // passwordKeyPicture
            // 
            passwordKeyPicture.Image = Properties.Resources.password;
            passwordKeyPicture.Location = new Point(55, 252);
            passwordKeyPicture.Name = "passwordKeyPicture";
            passwordKeyPicture.Size = new Size(32, 32);
            passwordKeyPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordKeyPicture.TabIndex = 1;
            passwordKeyPicture.TabStop = false;
            // 
            // passwordTb
            // 
            passwordTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordTb.BorderStyle = BorderStyle.None;
            passwordTb.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTb.Location = new Point(93, 252);
            passwordTb.MaxLength = 20;
            passwordTb.Multiline = true;
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.PlaceholderText = "Enter password";
            passwordTb.Size = new Size(242, 35);
            passwordTb.TabIndex = 2;
            // 
            // loginBtn
            // 
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginBtn.ForeColor = Color.Black;
            loginBtn.Location = new Point(137, 318);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(144, 34);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(loginLb);
            panel1.Location = new Point(-3, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 128);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(90, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 3);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(90, 287);
            panel3.Name = "panel3";
            panel3.Size = new Size(275, 3);
            panel3.TabIndex = 7;
            // 
            // loginTb
            // 
            loginTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginTb.BorderStyle = BorderStyle.None;
            loginTb.Font = new Font("SimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginTb.Location = new Point(93, 169);
            loginTb.MaxLength = 20;
            loginTb.Multiline = true;
            loginTb.Name = "loginTb";
            loginTb.PlaceholderText = "Enter login";
            loginTb.Size = new Size(242, 32);
            loginTb.TabIndex = 2;
            // 
            // passwordPicture
            // 
            passwordPicture.Cursor = Cursors.Hand;
            passwordPicture.Image = Properties.Resources.closePassword;
            passwordPicture.Location = new Point(345, 260);
            passwordPicture.Name = "passwordPicture";
            passwordPicture.Size = new Size(20, 20);
            passwordPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordPicture.TabIndex = 8;
            passwordPicture.TabStop = false;
            passwordPicture.Click += passwordPicture_Click;
            // 
            // forgotLb
            // 
            forgotLb.AutoSize = true;
            forgotLb.Cursor = Cursors.Hand;
            forgotLb.Font = new Font("SimSun", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            forgotLb.Location = new Point(127, 422);
            forgotLb.Name = "forgotLb";
            forgotLb.Size = new Size(169, 19);
            forgotLb.TabIndex = 9;
            forgotLb.Text = "Forgot password?";
            forgotLb.Click += forgotLb_Click;
            // 
            // registerLb
            // 
            registerLb.AutoSize = true;
            registerLb.Cursor = Cursors.Hand;
            registerLb.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerLb.Location = new Point(171, 355);
            registerLb.Name = "registerLb";
            registerLb.Size = new Size(71, 19);
            registerLb.TabIndex = 10;
            registerLb.Text = "or register";
            registerLb.Click += registerLb_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 450);
            Controls.Add(registerLb);
            Controls.Add(forgotLb);
            Controls.Add(passwordPicture);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(loginBtn);
            Controls.Add(loginTb);
            Controls.Add(passwordTb);
            Controls.Add(passwordKeyPicture);
            Controls.Add(loginPicrture);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyDictionary";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)loginPicrture).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordKeyPicture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLb;
        private PictureBox loginPicrture;
        private PictureBox passwordKeyPicture;
        private TextBox passwordTb;
        private Button loginBtn;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox loginTb;
        private PictureBox passwordPicture;
        private Label forgotLb;
        private Label registerLb;
    }
}
