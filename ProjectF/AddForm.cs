using ProjectF.Models;
using ProjectF.TaskForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectF
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(LogInForm.LoggedInUserId);
           
            this.Hide();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            cmboPirority.DataSource = Enum.GetValues(typeof(TaskPriority));
            cmboStatus.DataSource = Enum.GetValues(typeof(Models.TaskStatus));

            using (var context = new TaskManagmentContext())
            {
                var categories = context.Categories.ToList(); 

                if (categories.Count > 0)
                {
                    cmboCategory.DataSource = categories;
                    cmboCategory.DisplayMember = "Name";  
                    cmboCategory.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show("No categories found. Please add a category first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new TaskManagmentContext())
            {
                TaskItem newTask = new TaskItem
                {
                    Title = textboxTitle.Text,
                    Description = textBoxDescription.Text,
                    DueDate = dateTimetask.Value,
                    CreatedDate = DateTime.Now,
                    
                    Priority = (TaskPriority)cmboPirority.SelectedItem,
                    Status = (Models.TaskStatus)cmboStatus.SelectedItem,
                    CategoryId = (int)cmboCategory.SelectedValue,
                    UserId = LogInForm.LoggedInUserId 

                };
                context.TaskItems.Add(newTask);
                context.SaveChanges();

                MessageBox.Show("Task added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
        }

    }
}
