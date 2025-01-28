namespace MyDictionary
{
    partial class AdminTools
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
            adminToolsLbH = new Label();
            userTransTb = new TextBox();
            panel2 = new Panel();
            dictionaryTypeB = new ComboBox();
            mainRtb = new RichTextBox();
            allWordBtn = new Button();
            chooseDictionaryLb = new Label();
            panel3 = new Panel();
            userWordTb = new TextBox();
            deleteWordBtn = new Button();
            deleteTransBtn = new Button();
            changeWordBtn = new Button();
            changeTransBtn = new Button();
            addDictionaryBtn = new Button();
            addNewWord = new Button();
            panel4 = new Panel();
            userNewTransTb = new TextBox();
            panel5 = new Panel();
            userNewWordTb = new TextBox();
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
            panel1.Location = new Point(-4, -18);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 472);
            panel1.TabIndex = 4;
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
            settingsLb.Click += settingsLb_Click;
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
            // adminToolsLbH
            // 
            adminToolsLbH.AutoSize = true;
            adminToolsLbH.BackColor = Color.White;
            adminToolsLbH.Cursor = Cursors.Hand;
            adminToolsLbH.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            adminToolsLbH.ForeColor = Color.Black;
            adminToolsLbH.Location = new Point(429, 17);
            adminToolsLbH.Name = "adminToolsLbH";
            adminToolsLbH.Size = new Size(163, 28);
            adminToolsLbH.TabIndex = 5;
            adminToolsLbH.Text = "Admin tools";
            // 
            // userTransTb
            // 
            userTransTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userTransTb.BorderStyle = BorderStyle.None;
            userTransTb.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTransTb.Location = new Point(652, 136);
            userTransTb.MaxLength = 20;
            userTransTb.Name = "userTransTb";
            userTransTb.PlaceholderText = "Enter translation";
            userTransTb.Size = new Size(127, 18);
            userTransTb.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(652, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(126, 3);
            panel2.TabIndex = 21;
            // 
            // dictionaryTypeB
            // 
            dictionaryTypeB.Cursor = Cursors.Hand;
            dictionaryTypeB.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dictionaryTypeB.FormattingEnabled = true;
            dictionaryTypeB.Items.AddRange(new object[] { "ukr-eng", "eng-ukr" });
            dictionaryTypeB.Location = new Point(447, 71);
            dictionaryTypeB.Name = "dictionaryTypeB";
            dictionaryTypeB.Size = new Size(160, 26);
            dictionaryTypeB.TabIndex = 19;
            dictionaryTypeB.Text = "Enter dictionary";
            dictionaryTypeB.SelectedIndexChanged += dictionaryTypeB_SelectedIndexChanged;
            // 
            // mainRtb
            // 
            mainRtb.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainRtb.Location = new Point(239, 141);
            mainRtb.Name = "mainRtb";
            mainRtb.ReadOnly = true;
            mainRtb.Size = new Size(253, 277);
            mainRtb.TabIndex = 18;
            mainRtb.Text = "";
            // 
            // allWordBtn
            // 
            allWordBtn.FlatStyle = FlatStyle.Flat;
            allWordBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allWordBtn.Location = new Point(652, 65);
            allWordBtn.Name = "allWordBtn";
            allWordBtn.Size = new Size(126, 42);
            allWordBtn.TabIndex = 16;
            allWordBtn.Text = "Show all words in dictionary";
            allWordBtn.UseVisualStyleBackColor = true;
            allWordBtn.Click += allWordBtn_Click;
            // 
            // chooseDictionaryLb
            // 
            chooseDictionaryLb.AutoSize = true;
            chooseDictionaryLb.BackColor = Color.White;
            chooseDictionaryLb.Cursor = Cursors.Hand;
            chooseDictionaryLb.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chooseDictionaryLb.ForeColor = Color.Black;
            chooseDictionaryLb.Location = new Point(239, 73);
            chooseDictionaryLb.Name = "chooseDictionaryLb";
            chooseDictionaryLb.Size = new Size(202, 22);
            chooseDictionaryLb.TabIndex = 12;
            chooseDictionaryLb.Text = "Choose a dictionary:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(509, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(126, 3);
            panel3.TabIndex = 21;
            // 
            // userWordTb
            // 
            userWordTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userWordTb.BorderStyle = BorderStyle.None;
            userWordTb.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userWordTb.Location = new Point(509, 136);
            userWordTb.MaxLength = 20;
            userWordTb.Name = "userWordTb";
            userWordTb.PlaceholderText = "Enter word";
            userWordTb.Size = new Size(127, 18);
            userWordTb.TabIndex = 20;
            // 
            // deleteWordBtn
            // 
            deleteWordBtn.FlatStyle = FlatStyle.Flat;
            deleteWordBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteWordBtn.Location = new Point(509, 209);
            deleteWordBtn.Name = "deleteWordBtn";
            deleteWordBtn.Size = new Size(126, 42);
            deleteWordBtn.TabIndex = 16;
            deleteWordBtn.Text = "Delete word";
            deleteWordBtn.UseVisualStyleBackColor = true;
            deleteWordBtn.Click += deleteWordBtn_Click;
            // 
            // deleteTransBtn
            // 
            deleteTransBtn.FlatStyle = FlatStyle.Flat;
            deleteTransBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteTransBtn.Location = new Point(652, 209);
            deleteTransBtn.Name = "deleteTransBtn";
            deleteTransBtn.Size = new Size(126, 42);
            deleteTransBtn.TabIndex = 16;
            deleteTransBtn.Text = "Delete translation";
            deleteTransBtn.UseVisualStyleBackColor = true;
            deleteTransBtn.Click += deleteTransBtn_Click;
            // 
            // changeWordBtn
            // 
            changeWordBtn.FlatStyle = FlatStyle.Flat;
            changeWordBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changeWordBtn.Location = new Point(509, 270);
            changeWordBtn.Name = "changeWordBtn";
            changeWordBtn.Size = new Size(126, 42);
            changeWordBtn.TabIndex = 16;
            changeWordBtn.Text = "Change word";
            changeWordBtn.UseVisualStyleBackColor = true;
            changeWordBtn.Click += changeWordBtn_Click;
            // 
            // changeTransBtn
            // 
            changeTransBtn.FlatStyle = FlatStyle.Flat;
            changeTransBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changeTransBtn.Location = new Point(652, 270);
            changeTransBtn.Name = "changeTransBtn";
            changeTransBtn.Size = new Size(126, 42);
            changeTransBtn.TabIndex = 16;
            changeTransBtn.Text = "Change translation";
            changeTransBtn.UseVisualStyleBackColor = true;
            // 
            // addDictionaryBtn
            // 
            addDictionaryBtn.FlatStyle = FlatStyle.Flat;
            addDictionaryBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addDictionaryBtn.Location = new Point(509, 330);
            addDictionaryBtn.Name = "addDictionaryBtn";
            addDictionaryBtn.Size = new Size(126, 42);
            addDictionaryBtn.TabIndex = 16;
            addDictionaryBtn.Text = "Add new dictionary";
            addDictionaryBtn.UseVisualStyleBackColor = true;
            // 
            // addNewWord
            // 
            addNewWord.FlatStyle = FlatStyle.Flat;
            addNewWord.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNewWord.Location = new Point(652, 330);
            addNewWord.Name = "addNewWord";
            addNewWord.Size = new Size(126, 42);
            addNewWord.TabIndex = 16;
            addNewWord.Text = "Add new word";
            addNewWord.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(652, 191);
            panel4.Name = "panel4";
            panel4.Size = new Size(126, 3);
            panel4.TabIndex = 21;
            // 
            // userNewTransTb
            // 
            userNewTransTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userNewTransTb.BorderStyle = BorderStyle.None;
            userNewTransTb.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNewTransTb.Location = new Point(652, 173);
            userNewTransTb.MaxLength = 20;
            userNewTransTb.Name = "userNewTransTb";
            userNewTransTb.PlaceholderText = "Enter new translition";
            userNewTransTb.Size = new Size(127, 18);
            userNewTransTb.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(509, 191);
            panel5.Name = "panel5";
            panel5.Size = new Size(126, 3);
            panel5.TabIndex = 21;
            // 
            // userNewWordTb
            // 
            userNewWordTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userNewWordTb.BorderStyle = BorderStyle.None;
            userNewWordTb.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNewWordTb.Location = new Point(509, 173);
            userNewWordTb.MaxLength = 20;
            userNewWordTb.Name = "userNewWordTb";
            userNewWordTb.PlaceholderText = "Enter new word";
            userNewWordTb.Size = new Size(127, 18);
            userNewWordTb.TabIndex = 20;
            // 
            // AdminTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(userNewWordTb);
            Controls.Add(userWordTb);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(userNewTransTb);
            Controls.Add(panel4);
            Controls.Add(userTransTb);
            Controls.Add(panel2);
            Controls.Add(dictionaryTypeB);
            Controls.Add(mainRtb);
            Controls.Add(deleteTransBtn);
            Controls.Add(changeTransBtn);
            Controls.Add(addNewWord);
            Controls.Add(addDictionaryBtn);
            Controls.Add(changeWordBtn);
            Controls.Add(deleteWordBtn);
            Controls.Add(allWordBtn);
            Controls.Add(chooseDictionaryLb);
            Controls.Add(adminToolsLbH);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminTools";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyDictionary";
            FormClosed += AdminTools_FormClosed;
            Load += AdminTools_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label adminToolsLb;
        private Label viewDictionariesLb;
        private Label settingsLb;
        private Label exitLb;
        private Label adminToolsLbH;
        private TextBox userTransTb;
        private Panel panel2;
        private ComboBox dictionaryTypeB;
        private RichTextBox mainRtb;
        private Button allWordBtn;
        private Label chooseDictionaryLb;
        private Panel panel3;
        private TextBox userWordTb;
        private Button deleteWordBtn;
        private Button deleteTransBtn;
        private Button changeWordBtn;
        private Button changeTransBtn;
        private Button addDictionaryBtn;
        private Button addNewWord;
        private Panel panel4;
        private TextBox userNewTransTb;
        private Panel panel5;
        private TextBox userNewWordTb;
    }
}