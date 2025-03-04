using Microsoft.EntityFrameworkCore;
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
    public partial class EditForm : Form
    {
        private int taskId;
        public EditForm(int taskId)
        {
            InitializeComponent();

            this.taskId = taskId;
            LoadTaskData();
        }

        private void LoadTaskData()
        {
            using (var context = new TaskManagmentContext())
            {
                var task = context.TaskItems.Include(t => t.Category).FirstOrDefault(t => t.Id == taskId);
                if (task == null)
                {
                    MessageBox.Show("Task not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); 
                    return;
                }

                
                textboxTitle.Text = task.Title;
                textBoxDescription.Text = task.Description;
                dateTimetask.Value = task.DueDate;
                cmboPirority.DataSource = Enum.GetValues(typeof(TaskPriority));
                cmboPirority.SelectedItem = task.Priority;
                cmboStatus.DataSource = Enum.GetValues(typeof(Models.TaskStatus));
                cmboStatus.SelectedItem = task.Status;

              
                cmboCategory.DataSource = context.Categories.ToList();
                cmboCategory.DisplayMember = "Name";
                cmboCategory.ValueMember = "Id";
                cmboCategory.SelectedValue = task.CategoryId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new TaskManagmentContext())
            {
                var task = context.TaskItems.Find(taskId);
                if (task == null)
                {
                    MessageBox.Show("Task not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                task.Title = textboxTitle.Text;
                task.Description = textBoxDescription.Text;
                task.DueDate = dateTimetask.Value;
                task.Priority = (TaskPriority)cmboPirority.SelectedItem;
                task.Status = (Models.TaskStatus)cmboStatus.SelectedItem;
                task.CategoryId = (int)cmboCategory.SelectedValue;

                context.SaveChanges();

                MessageBox.Show("Task updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(LogInForm.LoggedInUserId);
            this.Hide();
        }
    }
}
