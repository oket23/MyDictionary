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
            backToLoginLb = new Label();
            SuspendLayout();
            // 
            // backToLoginLb
            // 
            backToLoginLb.AutoSize = true;
            backToLoginLb.Cursor = Cursors.Hand;
            backToLoginLb.Font = new Font("Lucida Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backToLoginLb.Location = new Point(21, 403);
            backToLoginLb.Name = "backToLoginLb";
            backToLoginLb.Size = new Size(159, 22);
            backToLoginLb.TabIndex = 0;
            backToLoginLb.Text = "Change account";
            backToLoginLb.Click += label1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backToLoginLb);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyDictionary";
            FormClosed += Menu_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label backToLoginLb;
    }
}