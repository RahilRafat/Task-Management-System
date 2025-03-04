using Microsoft.VisualBasic;
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
    public partial class OverdueTasksForm : Form
    {

        private readonly TaskManagmentContext _context;
        private readonly int _loggedInUserId;
        public OverdueTasksForm(int loggedInUserId, TaskManagmentContext context)
        {
            InitializeComponent();
            _loggedInUserId = loggedInUserId;
            _context = context;
            LoadOverdueTasks();

        }
      

        private void LoadOverdueTasks()
        {
            
            
            try
            {

                DateTime today = DateTime.Now.Date;

                var overdueTasks = _context.TaskItems
                    .Where(t => t.UserId == _loggedInUserId &&
                                t.DueDate < today &&
                                t.Status != Models.TaskStatus.Completed)
                    .Select(t => new
                    {
                        Id = t.Id,
                        Title = t.Title,
                        Description = t.Description,
                        DueDate = t.DueDate,
                        Priorty = t.Priority.ToString(),
                        Status = t.Status.ToString(),
                        Category = t.Category.Name,

                    }).ToList();

                dataGridViewOverdue.DataSource = overdueTasks;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading overdue tasks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
