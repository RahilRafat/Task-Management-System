namespace ProjectF.TaskForms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblPassword = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            btnlogin = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 342);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(638, 21);
            label1.Name = "label1";
            label1.Size = new Size(191, 58);
            label1.TabIndex = 1;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Sienna;
            label2.Location = new Point(518, 127);
            label2.Name = "label2";
            label2.Size = new Size(85, 31);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Sienna;
            label3.Location = new Point(518, 200);
            label3.Name = "label3";
            label3.Size = new Size(81, 31);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Sienna;
            lblPassword.Location = new Point(518, 272);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(125, 31);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Info;
            txtName.Location = new Point(667, 133);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(245, 36);
            txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Info;
            txtEmail.Location = new Point(667, 200);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 31);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Info;
            txtPassword.Location = new Point(667, 272);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(245, 31);
            txtPassword.TabIndex = 7;
            txtPassword.PasswordChar = '*';
            //txtPassword.UseSystemPasswordChar = true;
            
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(719, 349);
            button1.Name = "button1";
            button1.Size = new Size(139, 46);
            button1.TabIndex = 8;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnRegister_Click;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Peru;
            btnlogin.FlatStyle = FlatStyle.Popup;
            btnlogin.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.Location = new Point(869, 507);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 34);
            btnlogin.TabIndex = 9;
            btnlogin.Text = "LogIn";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(613, 507);
            label4.Name = "label4";
            label4.Size = new Size(259, 27);
            label4.TabIndex = 10;
            label4.Text = "If You already have Account ";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1034, 588);
            Controls.Add(label4);
            Controls.Add(btnlogin);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblPassword;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button button1;
        private Button btnlogin;
        private Label label4;
    }
}