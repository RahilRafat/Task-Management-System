namespace ProjectF.TaskForms
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(31, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 357);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.Brown;
            lblLogin.Location = new Point(526, 26);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(90, 37);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LogIn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(395, 132);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 2;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(395, 193);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Info;
            txtEmail.Location = new Point(526, 132);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 34);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.Location = new Point(526, 193);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(195, 34);
            txtPassword.TabIndex = 5;
            txtPassword.PasswordChar = '*';
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Peru;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(526, 304);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(157, 39);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LogIn";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(779, 496);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}