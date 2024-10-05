namespace SignUp
{
    partial class SignUp
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
            label1 = new Label();
            Nametxt = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            Emailtxt = new Label();
            txtPass = new TextBox();
            Passtxt = new Label();
            label2 = new Label();
            txtCountry = new ComboBox();
            buttonSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 46);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // Nametxt
            // 
            Nametxt.AutoSize = true;
            Nametxt.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nametxt.Location = new Point(67, 104);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(103, 33);
            Nametxt.TabIndex = 1;
            Nametxt.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(237, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(419, 39);
            txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(237, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(419, 39);
            txtEmail.TabIndex = 4;
            // 
            // Emailtxt
            // 
            Emailtxt.AutoSize = true;
            Emailtxt.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Emailtxt.Location = new Point(68, 175);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(102, 33);
            Emailtxt.TabIndex = 3;
            Emailtxt.Text = "Email:";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(237, 246);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(419, 39);
            txtPass.TabIndex = 6;
            // 
            // Passtxt
            // 
            Passtxt.AutoSize = true;
            Passtxt.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Passtxt.Location = new Point(67, 246);
            Passtxt.Name = "Passtxt";
            Passtxt.Size = new Size(157, 33);
            Passtxt.TabIndex = 5;
            Passtxt.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 306);
            label2.Name = "label2";
            label2.Size = new Size(132, 33);
            label2.TabIndex = 7;
            label2.Text = "Country:";
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCountry.FormattingEnabled = true;
            txtCountry.Items.AddRange(new object[] { "United Arab Emirates", "Jordan", "Saudi Arabia", "Jordan", "Syria", "Lebanon", "Egypt", "Qatar", "Oman" });
            txtCountry.Location = new Point(237, 306);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(419, 40);
            txtCountry.TabIndex = 8;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSignUp.Location = new Point(353, 391);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(166, 42);
            buttonSignUp.TabIndex = 9;
            buttonSignUp.Text = "SignUp";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 486);
            Controls.Add(buttonSignUp);
            Controls.Add(txtCountry);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(Passtxt);
            Controls.Add(txtEmail);
            Controls.Add(Emailtxt);
            Controls.Add(txtName);
            Controls.Add(Nametxt);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Nametxt;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label Emailtxt;
        private TextBox txtPass;
        private Label Passtxt;
        private Label label2;
        private ComboBox txtCountry;
        private Button buttonSignUp;
    }
}