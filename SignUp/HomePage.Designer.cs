namespace SignUp
{
    partial class HomePage
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
            txtCountryHome = new ComboBox();
            label2 = new Label();
            txtPassHome = new TextBox();
            Passtxt = new Label();
            txtEmailHome = new TextBox();
            Emailtxt = new Label();
            txtNameHome = new TextBox();
            Nametxt = new Label();
            buttonUpdate = new Button();
            label1 = new Label();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // txtCountryHome
            // 
            txtCountryHome.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCountryHome.FormattingEnabled = true;
            txtCountryHome.Items.AddRange(new object[] { "United Arab Emirates", "Jordan", "Saudi Arabia", "Jordan", "Syria", "Lebanon", "Egypt", "Qatar", "Oman" });
            txtCountryHome.Location = new Point(203, 320);
            txtCountryHome.Name = "txtCountryHome";
            txtCountryHome.Size = new Size(419, 40);
            txtCountryHome.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 320);
            label2.Name = "label2";
            label2.Size = new Size(132, 33);
            label2.TabIndex = 15;
            label2.Text = "Country:";
            // 
            // txtPassHome
            // 
            txtPassHome.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassHome.Location = new Point(203, 260);
            txtPassHome.Name = "txtPassHome";
            txtPassHome.Size = new Size(419, 39);
            txtPassHome.TabIndex = 14;
            // 
            // Passtxt
            // 
            Passtxt.AutoSize = true;
            Passtxt.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Passtxt.Location = new Point(33, 260);
            Passtxt.Name = "Passtxt";
            Passtxt.Size = new Size(157, 33);
            Passtxt.TabIndex = 13;
            Passtxt.Text = "Password:";
            // 
            // txtEmailHome
            // 
            txtEmailHome.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmailHome.Location = new Point(203, 183);
            txtEmailHome.Name = "txtEmailHome";
            txtEmailHome.Size = new Size(419, 39);
            txtEmailHome.TabIndex = 12;
            // 
            // Emailtxt
            // 
            Emailtxt.AutoSize = true;
            Emailtxt.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Emailtxt.Location = new Point(34, 189);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(102, 33);
            Emailtxt.TabIndex = 11;
            Emailtxt.Text = "Email:";
            // 
            // txtNameHome
            // 
            txtNameHome.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNameHome.Location = new Point(203, 115);
            txtNameHome.Name = "txtNameHome";
            txtNameHome.Size = new Size(419, 39);
            txtNameHome.TabIndex = 10;
            // 
            // Nametxt
            // 
            Nametxt.AutoSize = true;
            Nametxt.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nametxt.Location = new Point(33, 118);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(103, 33);
            Nametxt.TabIndex = 9;
            Nametxt.Text = "Name:";
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.ButtonFace;
            buttonUpdate.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(203, 390);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(419, 42);
            buttonUpdate.TabIndex = 17;
            buttonUpdate.Text = "Update My Account Info ";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(223, 36);
            label1.Name = "label1";
            label1.Size = new Size(352, 40);
            label1.TabIndex = 18;
            label1.Text = "Change Account Info";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ScrollBar;
            buttonDelete.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = SystemColors.WindowText;
            buttonDelete.Location = new Point(692, 142);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(419, 202);
            buttonDelete.TabIndex = 19;
            buttonDelete.Text = "Delete My Account";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 506);
            Controls.Add(buttonDelete);
            Controls.Add(label1);
            Controls.Add(buttonUpdate);
            Controls.Add(txtCountryHome);
            Controls.Add(label2);
            Controls.Add(txtPassHome);
            Controls.Add(Passtxt);
            Controls.Add(txtEmailHome);
            Controls.Add(Emailtxt);
            Controls.Add(txtNameHome);
            Controls.Add(Nametxt);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txtCountryHome;
        private Label label2;
        private TextBox txtPassHome;
        private Label Passtxt;
        private TextBox txtEmailHome;
        private Label Emailtxt;
        private TextBox txtNameHome;
        private Label Nametxt;
        private Button buttonUpdate;
        private Label label1;
        private Button buttonDelete;
    }
}