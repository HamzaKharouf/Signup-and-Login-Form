namespace SignUp
{
    partial class Login
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
            txtPassLogin = new TextBox();
            Passtxt = new Label();
            txtEmailLogin = new TextBox();
            Emailtxt = new Label();
            label1 = new Label();
            buttonLogin = new Button();
            labelCreateAccount = new Label();
            SuspendLayout();
            // 
            // txtPassLogin
            // 
            txtPassLogin.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassLogin.Location = new Point(270, 218);
            txtPassLogin.Name = "txtPassLogin";
            txtPassLogin.Size = new Size(419, 39);
            txtPassLogin.TabIndex = 10;
            // 
            // Passtxt
            // 
            Passtxt.AutoSize = true;
            Passtxt.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Passtxt.Location = new Point(100, 218);
            Passtxt.Name = "Passtxt";
            Passtxt.Size = new Size(157, 33);
            Passtxt.TabIndex = 9;
            Passtxt.Text = "Password:";
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmailLogin.Location = new Point(270, 141);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.Size = new Size(419, 39);
            txtEmailLogin.TabIndex = 8;
            // 
            // Emailtxt
            // 
            Emailtxt.AutoSize = true;
            Emailtxt.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Emailtxt.Location = new Point(101, 147);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(102, 33);
            Emailtxt.TabIndex = 7;
            Emailtxt.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 37);
            label1.Name = "label1";
            label1.Size = new Size(126, 46);
            label1.TabIndex = 11;
            label1.Text = "Login";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(557, 294);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(132, 37);
            buttonLogin.TabIndex = 12;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += button1_Click;
            // 
            // labelCreateAccount
            // 
            labelCreateAccount.AutoSize = true;
            labelCreateAccount.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCreateAccount.ForeColor = Color.DodgerBlue;
            labelCreateAccount.Location = new Point(243, 368);
            labelCreateAccount.Name = "labelCreateAccount";
            labelCreateAccount.Size = new Size(403, 24);
            labelCreateAccount.TabIndex = 13;
            labelCreateAccount.Text = "Do not have an account? Create account.";
            labelCreateAccount.Click += labelCreateAccount_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 510);
            Controls.Add(labelCreateAccount);
            Controls.Add(buttonLogin);
            Controls.Add(label1);
            Controls.Add(txtPassLogin);
            Controls.Add(Passtxt);
            Controls.Add(txtEmailLogin);
            Controls.Add(Emailtxt);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassLogin;
        private Label Passtxt;
        private TextBox txtEmailLogin;
        private Label Emailtxt;
        private Label label1;
        private Button buttonLogin;
        private Label labelCreateAccount;
    }
}