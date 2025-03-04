using ProjectF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectF.TaskForms
{
    public partial class LogoutControl : UserControl
    {
        private TaskManagmentContext _context;

        public LogoutControl()
        {
            InitializeComponent();
        }
        public LogoutControl(TaskManagmentContext context) : this()
        {

            _context = context;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Hide();
                }

                
                RegisterForm registerForm = new RegisterForm(_context);
                registerForm.ShowDialog();





            }

        }
    }
}
