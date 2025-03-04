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
    public partial class OverdueAlertForm : Form
    {
        private int _loggedInUserId;
        private TaskManagmentContext _context;

        public OverdueAlertForm(string message, int loggedInUserId, TaskManagmentContext context)
        {
            InitializeComponent();

            _loggedInUserId = loggedInUserId;
            _context = context;

            this.Text = "Overdue Tasks";
            this.Size = new Size(350, 200);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;


            Label lblMessage = new Label();
            lblMessage.Text = message;
            lblMessage.Font = new Font("Arial", 10, FontStyle.Bold);
            lblMessage.ForeColor = Color.Brown;
            lblMessage.Size = new Size(320, 80);
            lblMessage.Location = new Point(15, 20);

            Button btnViewTasks = new Button();
            btnViewTasks.Text = "View Tasks";
            btnViewTasks.Location = new Point(50, 110);
            btnViewTasks.Click += (s, e) =>
            {
                this.Close();
                OverdueTasksForm overdueForm = new OverdueTasksForm(loggedInUserId, context);
                overdueForm.ShowDialog();
            };

            Button btnSnooze = new Button();
            btnSnooze.Text = "Snooze";
            btnSnooze.Location = new Point(180, 110);
            btnSnooze.Click += (s, e) => { this.Close(); };

            this.Controls.Add(lblMessage);
            this.Controls.Add(btnViewTasks);
            this.Controls.Add(btnSnooze);
        }
    }

}
