using ProjectF.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProjectF.TaskForms
{
    public partial class LogInForm : Form
    {
        TaskManagmentContext Context = new TaskManagmentContext();
        public static int LoggedInUserId; 

        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email and Password are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = Context.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                MessageBox.Show("User not found. Please register first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();

                RegisterForm registerForm = new RegisterForm(Context);
                registerForm.ShowDialog();
                this.Close();
                return;
            }

            if (VerifyPassword(password, user.PasswordHash))
            {
                LoggedInUserId = user.Id; 
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Form1 mainForm = new Form1(LoggedInUserId);
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string hashedPassword = HashPassword(enteredPassword); 
            return hashedPassword == storedHash; 
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); 
                }
                return builder.ToString();
            }
        }
    }
}
