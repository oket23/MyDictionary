namespace MyDictionary.Forms
{
    partial class NewWord
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
            addWordLb = new Label();
            backButton = new Button();
            addWordBtn = new Button();
            originalWordLb = new Label();
            typeWordLb = new Label();
            aboutWordLb = new Label();
            synonymLb = new Label();
            translationsLb = new Label();
            userOriginalWordTb = new TextBox();
            panel3 = new Panel();
            panel1 = new Panel();
            userAboutWordTb = new TextBox();
            panel2 = new Panel();
            userTypeWordTb = new TextBox();
            panel4 = new Panel();
            userSynonymTb = new TextBox();
            panel5 = new Panel();
            userTransTb = new TextBox();
            SuspendLayout();
            // 
            // addWordLb
            // 
            addWordLb.AutoSize = true;
            addWordLb.BackColor = Color.White;
            addWordLb.Cursor = Cursors.Hand;
            addWordLb.Font = new Font("Lucida Sans", 18.25F, FontStyle.Bold);
            addWordLb.ForeColor = Color.Black;
            addWordLb.Location = new Point(127, 9);
            addWordLb.Name = "addWordLb";
            addWordLb.Size = new Size(195, 28);
            addWordLb.TabIndex = 6;
            addWordLb.Text = "Add new word";
            // 
            // backButton
            // 
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.Location = new Point(12, 336);
            backButton.Name = "backButton";
            backButton.Size = new Size(96, 32);
            backButton.TabIndex = 17;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // addWordBtn
            // 
            addWordBtn.FlatStyle = FlatStyle.Flat;
            addWordBtn.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addWordBtn.Location = new Point(352, 336);
            addWordBtn.Name = "addWordBtn";
            addWordBtn.Size = new Size(96, 32);
            addWordBtn.TabIndex = 17;
            addWordBtn.Text = "Add word";
            addWordBtn.UseVisualStyleBackColor = true;
            addWordBtn.Click += addWordBtn_Click;
            // 
            // originalWordLb
            // 
            originalWordLb.AutoSize = true;
            originalWordLb.BackColor = Color.White;
            originalWordLb.Cursor = Cursors.Hand;
            originalWordLb.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            originalWordLb.ForeColor = Color.Black;
            originalWordLb.Location = new Point(115, 91);
            originalWordLb.Name = "originalWordLb";
            originalWordLb.Size = new Size(57, 22);
            originalWordLb.TabIndex = 18;
            originalWordLb.Text = "Word";
            // 
            // typeWordLb
            // 
            typeWordLb.AutoSize = true;
            typeWordLb.BackColor = Color.White;
            typeWordLb.Cursor = Cursors.Hand;
            typeWordLb.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeWordLb.ForeColor = Color.Black;
            typeWordLb.Location = new Point(68, 174);
            typeWordLb.Name = "typeWordLb";
            typeWordLb.Size = new Size(104, 22);
            typeWordLb.TabIndex = 18;
            typeWordLb.Text = "Word type";
            // 
            // aboutWordLb
            // 
            aboutWordLb.AutoSize = true;
            aboutWordLb.BackColor = Color.White;
            aboutWordLb.Cursor = Cursors.Hand;
            aboutWordLb.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aboutWordLb.ForeColor = Color.Black;
            aboutWordLb.Location = new Point(52, 132);
            aboutWordLb.Name = "aboutWordLb";
            aboutWordLb.Size = new Size(120, 22);
            aboutWordLb.TabIndex = 18;
            aboutWordLb.Text = "About Word";
            // 
            // synonymLb
            // 
            synonymLb.AutoSize = true;
            synonymLb.BackColor = Color.White;
            synonymLb.Cursor = Cursors.Hand;
            synonymLb.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            synonymLb.ForeColor = Color.Black;
            synonymLb.Location = new Point(68, 214);
            synonymLb.Name = "synonymLb";
            synonymLb.Size = new Size(96, 22);
            synonymLb.TabIndex = 18;
            synonymLb.Text = "Synonym";
            // 
            // translationsLb
            // 
            translationsLb.AutoSize = true;
            translationsLb.BackColor = Color.White;
            translationsLb.Cursor = Cursors.Hand;
            translationsLb.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            translationsLb.ForeColor = Color.Black;
            translationsLb.Location = new Point(46, 258);
            translationsLb.Name = "translationsLb";
            translationsLb.Size = new Size(126, 22);
            translationsLb.TabIndex = 18;
            translationsLb.Text = "Translations";
            // 
            // userOriginalWordTb
            // 
            userOriginalWordTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userOriginalWordTb.BorderStyle = BorderStyle.None;
            userOriginalWordTb.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userOriginalWordTb.Location = new Point(208, 91);
            userOriginalWordTb.MaxLength = 25;
            userOriginalWordTb.Name = "userOriginalWordTb";
            userOriginalWordTb.PlaceholderText = "Enter word";
            userOriginalWordTb.Size = new Size(170, 18);
            userOriginalWordTb.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(208, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 3);
            panel3.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(208, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 3);
            panel1.TabIndex = 23;
            // 
            // userAboutWordTb
            // 
            userAboutWordTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userAboutWordTb.BorderStyle = BorderStyle.None;
            userAboutWordTb.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userAboutWordTb.Location = new Point(208, 132);
            userAboutWordTb.MaxLength = 20;
            userAboutWordTb.Name = "userAboutWordTb";
            userAboutWordTb.PlaceholderText = "Enter about word";
            userAboutWordTb.Size = new Size(170, 18);
            userAboutWordTb.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(208, 192);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 3);
            panel2.TabIndex = 23;
            // 
            // userTypeWordTb
            // 
            userTypeWordTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userTypeWordTb.BorderStyle = BorderStyle.None;
            userTypeWordTb.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTypeWordTb.Location = new Point(208, 174);
            userTypeWordTb.MaxLength = 20;
            userTypeWordTb.Name = "userTypeWordTb";
            userTypeWordTb.PlaceholderText = "Enter word type";
            userTypeWordTb.Size = new Size(169, 18);
            userTypeWordTb.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(207, 232);
            panel4.Name = "panel4";
            panel4.Size = new Size(170, 3);
            panel4.TabIndex = 23;
            // 
            // userSynonymTb
            // 
            userSynonymTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userSynonymTb.BorderStyle = BorderStyle.None;
            userSynonymTb.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userSynonymTb.Location = new Point(207, 214);
            userSynonymTb.MaxLength = 20;
            userSynonymTb.Name = "userSynonymTb";
            userSynonymTb.PlaceholderText = "Enter word synonym";
            userSynonymTb.Size = new Size(171, 18);
            userSynonymTb.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(207, 277);
            panel5.Name = "panel5";
            panel5.Size = new Size(170, 3);
            panel5.TabIndex = 23;
            // 
            // userTransTb
            // 
            userTransTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userTransTb.BorderStyle = BorderStyle.None;
            userTransTb.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTransTb.Location = new Point(207, 258);
            userTransTb.MaxLength = 40;
            userTransTb.Name = "userTransTb";
            userTransTb.PlaceholderText = "Enter translations";
            userTransTb.Size = new Size(170, 18);
            userTransTb.TabIndex = 22;
            // 
            // NewWord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 388);
            Controls.Add(userTransTb);
            Controls.Add(panel5);
            Controls.Add(userSynonymTb);
            Controls.Add(panel4);
            Controls.Add(userTypeWordTb);
            Controls.Add(panel2);
            Controls.Add(userAboutWordTb);
            Controls.Add(panel1);
            Controls.Add(userOriginalWordTb);
            Controls.Add(panel3);
            Controls.Add(aboutWordLb);
            Controls.Add(translationsLb);
            Controls.Add(synonymLb);
            Controls.Add(typeWordLb);
            Controls.Add(originalWordLb);
            Controls.Add(addWordBtn);
            Controls.Add(backButton);
            Controls.Add(addWordLb);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NewWord";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyDictionary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addWordLb;
        private Button backButton;
        private Button addWordBtn;
        private Label originalWordLb;
        private Label typeWordLb;
        private Label aboutWordLb;
        private Label synonymLb;
        private Label translationsLb;
        private TextBox userOriginalWordTb;
        private Panel panel3;
        private Panel panel1;
        private TextBox userAboutWordTb;
        private Panel panel2;
        private TextBox userTypeWordTb;
        private Panel panel4;
        private TextBox userSynonymTb;
        private Panel panel5;
        private TextBox userTransTb;
    }
}