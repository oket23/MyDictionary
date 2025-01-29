namespace MyDictionary
{
    partial class ForgotPassword
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
            unluckLb = new Label();
            backToLogginBtn = new Button();
            SuspendLayout();
            // 
            // unluckLb
            // 
            unluckLb.AutoSize = true;
            unluckLb.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            unluckLb.Location = new Point(129, 79);
            unluckLb.Name = "unluckLb";
            unluckLb.Size = new Size(107, 31);
            unluckLb.TabIndex = 0;
            unluckLb.Text = "Unluck :(";
            // 
            // backToLogginBtn
            // 
            backToLogginBtn.FlatStyle = FlatStyle.Flat;
            backToLogginBtn.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backToLogginBtn.Location = new Point(12, 405);
            backToLogginBtn.Name = "backToLogginBtn";
            backToLogginBtn.Size = new Size(103, 33);
            backToLogginBtn.TabIndex = 1;
            backToLogginBtn.Text = "Back to login";
            backToLogginBtn.UseVisualStyleBackColor = true;
            backToLogginBtn.Click += backToLogginBtn_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 450);
            Controls.Add(backToLogginBtn);
            Controls.Add(unluckLb);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ForgotPassword";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyDictionary";
            FormClosed += ForgotPassword_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label unluckLb;
        private Button backToLogginBtn;
    }
}