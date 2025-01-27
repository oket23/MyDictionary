namespace MyDictionary
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
            exportBtn = new Button();
            allWordBtn = new Button();
            showAllInfoBtn = new Button();
            seachBtn = new Button();
            mainRtb = new RichTextBox();
            chooseDictionaryLb = new Label();
            dictionaryTypeB = new ComboBox();
            userWordTb = new TextBox();
            panel2 = new Panel();
            exportSimpleBtn = new Button();
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
            // exportBtn
            // 
            exportBtn.FlatStyle = FlatStyle.Flat;
            exportBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportBtn.Location = new Point(631, 77);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(126, 32);
            exportBtn.TabIndex = 3;
            exportBtn.Text = "Export dictionary";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // allWordBtn
            // 
            allWordBtn.FlatStyle = FlatStyle.Flat;
            allWordBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allWordBtn.Location = new Point(631, 200);
            allWordBtn.Name = "allWordBtn";
            allWordBtn.Size = new Size(126, 42);
            allWordBtn.TabIndex = 3;
            allWordBtn.Text = "Show all words in dictionary";
            allWordBtn.UseVisualStyleBackColor = true;
            allWordBtn.Click += allWordBtn_Click;
            // 
            // showAllInfoBtn
            // 
            showAllInfoBtn.FlatStyle = FlatStyle.Flat;
            showAllInfoBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showAllInfoBtn.Location = new Point(631, 259);
            showAllInfoBtn.Name = "showAllInfoBtn";
            showAllInfoBtn.Size = new Size(126, 45);
            showAllInfoBtn.TabIndex = 3;
            showAllInfoBtn.Text = "Show all info about word ";
            showAllInfoBtn.UseVisualStyleBackColor = true;
            showAllInfoBtn.Click += showAllInfoBtn_Click;
            // 
            // seachBtn
            // 
            seachBtn.FlatStyle = FlatStyle.Flat;
            seachBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            seachBtn.Location = new Point(631, 322);
            seachBtn.Name = "seachBtn";
            seachBtn.Size = new Size(126, 45);
            seachBtn.TabIndex = 3;
            seachBtn.Text = "Search word in dictionary";
            seachBtn.UseVisualStyleBackColor = true;
            seachBtn.Click += seachBtn_Click;
            // 
            // mainRtb
            // 
            mainRtb.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainRtb.Location = new Point(240, 153);
            mainRtb.Name = "mainRtb";
            mainRtb.ReadOnly = true;
            mainRtb.Size = new Size(368, 277);
            mainRtb.TabIndex = 4;
            mainRtb.Text = "";
            // 
            // chooseDictionaryLb
            // 
            chooseDictionaryLb.AutoSize = true;
            chooseDictionaryLb.BackColor = Color.White;
            chooseDictionaryLb.Cursor = Cursors.Hand;
            chooseDictionaryLb.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseDictionaryLb.ForeColor = Color.Black;
            chooseDictionaryLb.Location = new Point(240, 85);
            chooseDictionaryLb.Name = "chooseDictionaryLb";
            chooseDictionaryLb.Size = new Size(202, 22);
            chooseDictionaryLb.TabIndex = 1;
            chooseDictionaryLb.Text = "Choose a dictionary:";
            // 
            // dictionaryTypeB
            // 
            dictionaryTypeB.Cursor = Cursors.Hand;
            dictionaryTypeB.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dictionaryTypeB.FormattingEnabled = true;
            dictionaryTypeB.Items.AddRange(new object[] { "ukr-eng", "eng-ukr" });
            dictionaryTypeB.Location = new Point(448, 83);
            dictionaryTypeB.Name = "dictionaryTypeB";
            dictionaryTypeB.Size = new Size(160, 26);
            dictionaryTypeB.TabIndex = 5;
            dictionaryTypeB.Text = "Enter dictionary";
            dictionaryTypeB.SelectedIndexChanged += dictionaryTypeB_SelectedIndexChanged;
            // 
            // userWordTb
            // 
            userWordTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userWordTb.BorderStyle = BorderStyle.None;
            userWordTb.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userWordTb.Location = new Point(631, 163);
            userWordTb.MaxLength = 20;
            userWordTb.Name = "userWordTb";
            userWordTb.PlaceholderText = "Enter word";
            userWordTb.Size = new Size(126, 18);
            userWordTb.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(631, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(126, 3);
            panel2.TabIndex = 11;
            // 
            // exportSimpleBtn
            // 
            exportSimpleBtn.FlatStyle = FlatStyle.Flat;
            exportSimpleBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportSimpleBtn.Location = new Point(631, 385);
            exportSimpleBtn.Name = "exportSimpleBtn";
            exportSimpleBtn.Size = new Size(126, 45);
            exportSimpleBtn.TabIndex = 3;
            exportSimpleBtn.Text = "Export word ";
            exportSimpleBtn.UseVisualStyleBackColor = true;
            exportSimpleBtn.Click += exportSimpleBtn_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userWordTb);
            Controls.Add(panel2);
            Controls.Add(dictionaryTypeB);
            Controls.Add(mainRtb);
            Controls.Add(exportSimpleBtn);
            Controls.Add(seachBtn);
            Controls.Add(showAllInfoBtn);
            Controls.Add(allWordBtn);
            Controls.Add(exportBtn);
            Controls.Add(chooseDictionaryLb);
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
        private Button exportBtn;
        private Button allWordBtn;
        private Button showAllInfoBtn;
        private Button seachBtn;
        private RichTextBox mainRtb;
        private Label chooseDictionaryLb;
        private ComboBox dictionaryTypeB;
        private TextBox userWordTb;
        private Panel panel2;
        private Button exportSimpleBtn;
    }
}