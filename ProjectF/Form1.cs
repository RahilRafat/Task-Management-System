
using Microsoft.VisualBasic;
using ProjectF.Models;
using ProjectF.TaskForms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Linq;
using System.Windows.Forms.VisualStyles;

namespace ProjectF
{

    public partial class Form1 : Form
    {
        TaskManagmentContext Context = new TaskManagmentContext();
        private int LoggedInUserId;
        private System.Windows.Forms.Timer overdueTaskTimer; 
        private bool sortAscending = true; 
        private int currentPage = 1; 
        private int pageSize = 5;
        private int totalPages = 10; 



        public Form1(int userId)
        {
            InitializeComponent();
            LoggedInUserId = userId;

        }
        private void InitializeOverdueTaskTimer()
        {
            overdueTaskTimer = new System.Windows.Forms.Timer();
            overdueTaskTimer.Interval = 60000; // Check every 1 min
            overdueTaskTimer.Tick += (s, e) => CheckOverdueTasks();
            overdueTaskTimer.Start();
        }





        private double CalculateAverageCompletionTime()
        {
            var completedTasks = Context.TaskItems
                .Where(t => t.UserId == LoggedInUserId && t.Status == Models.TaskStatus.Completed)
                .ToList();

            if (!completedTasks.Any())
                return 0; 

            double averageHoures = completedTasks
                .Where(t => t.CompletionTime.HasValue)
                .Average(t => t.CompletionTime.Value.TotalHours);

            return Math.Round(averageHoures, 2); 
        }

        private void LoadUserTasks()
        {
            var tasks = Context.TaskItems
                .Where(t => t.UserId == LoggedInUserId) 
                .Select(t => new
                {
                    Id = t.Id,
                    Title = t.Title,
                    Description = t.Description,
                    DueDate = t.DueDate,
                    CreatedDate = t.CreatedDate,
                    CompletedDate = t.CompletedDate,
                    Priority = t.Priority.ToString(),
                    Status = t.Status.ToString(),
                    User = t.User.Name,
                    Category = t.Category.Name,
                    CompletionTime = t.CompletionTime.HasValue
                    ? t.CompletionTime.Value.TotalHours.ToString("F2")
                    : "N/A"



                }
            ).ToList();






            double avgCompletionTime = CalculateAverageCompletionTime();

            var avgRow = new List<object>
            {
                 "Average", "", "", "", "", "", "", "", "", "", avgCompletionTime.ToString() + " Min"
             };

            
            var dataTable = new System.Data.DataTable();

            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Title");
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("DueDate");
            dataTable.Columns.Add("CreatedDate");
            dataTable.Columns.Add("CompletedDate");
            dataTable.Columns.Add("Priority");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("User");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("CompletionTime");

            foreach (var task in tasks)
            {
                dataTable.Rows.Add(task.Id, task.Title, task.Description, task.DueDate,
                    task.CreatedDate, task.CompletedDate, task.Priority, task.Status,
                    task.User, task.Category, task.CompletionTime);
            }

            dataGridView1.DataSource = dataTable;


            dataTable.Rows.Add(avgRow.ToArray()); 

            dataGridView1.DataSource = dataTable;

            

            var query = Context.TaskItems.Where(t => t.UserId == LoggedInUserId).AsQueryable();


            string selectedStatus = cmboFilter.SelectedItem?.ToString();



            if (selectedStatus != "All") 
            {
                
                if (Enum.TryParse(selectedStatus, out Models.TaskStatus statusEnum))
                {
                    query = query.Where(t => t.Status == statusEnum);
                }
            }


            string selectedPriorty = cmboFilter2.SelectedItem?.ToString();


            if (selectedPriorty != "All") 
            {

                if (Enum.TryParse(selectedPriorty, out TaskPriority priorityEnum))
                {
                    query = query.Where(t => t.Priority == priorityEnum);
                }
            }


            
            if (sortAscending)
                query = query.OrderBy(t => t.DueDate);
            else
                query = query.OrderByDescending(t => t.DueDate);


            
            int totalRecords = query.Count();
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);



            tasks = query
            .Skip((currentPage - 1) * pageSize) 
            .Take(pageSize) 
            .Select(t => new
            {
                Id = t.Id,
                Title = t.Title,
                Description = t.Description,
                DueDate = t.DueDate,
                CreatedDate = t.CreatedDate,
                CompletedDate = t.CompletedDate,
                Priority = t.Priority.ToString(),
                Status = t.Status.ToString(),
                User = t.User.Name,
                Category = t.Category.Name,
                CompletionTime = t.CompletionTime.HasValue
                 ? t.CompletionTime.Value.TotalHours.ToString("F2")
                    : "N/A"
            }).ToList();
            dataGridView1.DataSource = tasks;
            
            lblPageNumber.Text = $"Page {currentPage} of {totalPages}";

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeDataGridView()
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "Edit";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editButton);



            
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButton);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int taskId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value; 
            if (e.RowIndex >= 0) 
            {


                EditForm editForm = new EditForm(taskId); 
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUserTasks();
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete") 
            {
                DeleteTask(taskId);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeOverdueTaskTimer();
            if (LoggedInUserId == 0)
            {
                MessageBox.Show("You need to log in first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                
                cmboFilter.Items.Add("All");
                cmboFilter.Items.Add(Models.TaskStatus.Pending.ToString());
                cmboFilter.Items.Add(Models.TaskStatus.InProgress.ToString());
                cmboFilter.Items.Add(Models.TaskStatus.Completed.ToString());
                cmboFilter.SelectedIndex = 0; 
                cmboFilter2.Items.Add("All"); 
                cmboFilter2.Items.Add(TaskPriority.Low.ToString());
                cmboFilter2.Items.Add(TaskPriority.Medium.ToString());
                cmboFilter2.Items.Add(TaskPriority.High.ToString());
                cmboFilter2.SelectedIndex = 0; 

                LoadUserTasks();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
           
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadUserTasks(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                int taskId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value; 

                EditForm editForm = new EditForm(taskId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUserTasks();
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void DeleteTask(int taskId)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this task?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var task = Context.TaskItems.Find(taskId);
                if (task != null)
                {
                    Context.TaskItems.Remove(task);
                    Context.SaveChanges();
                    LoadUserTasks(); 
                    MessageBox.Show("Task deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Task not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int taskId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value; 
                DeleteTask(taskId);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUserTasks();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            sortAscending = !sortAscending;
            LoadUserTasks();
        }


        private void SearchTasks()
        {
            string searchText = richTBSearch.Text.Trim().ToLower();
            var filteredTasks = Context.TaskItems
                   .Where(t => t.UserId == LoggedInUserId && 
                   (t.Title.ToLower().Contains(searchText) ||
                    t.Description.ToLower().Contains(searchText)))
               .Select(t => new
               {
                   Id = t.Id,
                   Title = t.Title,
                   Description = t.Description,
                   DueDate = t.DueDate,
                   CreatedDate = t.CreatedDate,
                   CompletedDate = t.CompletedDate,
                   Priority = t.Priority.ToString(),
                   Status = t.Status.ToString(),
                   User = t.User.Name,
                   Category = t.Category.Name,
                   CompletionTime = t.CompletionTime.HasValue
                     ? t.CompletionTime.Value.TotalHours.ToString("F2")
                    : "N/A"
               }).ToList();

            dataGridView1.DataSource = filteredTasks;
        }


        private void CheckOverdueTasks()
        {
            var overdueTasks = Context.TaskItems
                .Where(t => t.UserId == LoggedInUserId && t.DueDate < DateTime.Now && t.Status != Models.TaskStatus.Completed)
                .ToList();

            if (overdueTasks.Any())
            {
                string message = $"{overdueTasks.Count} Task(s) Overdue!\n\n" +
                                 string.Join("\n", overdueTasks.Select(t => $"- {t.Title} (Due: {t.DueDate:dd/MM/yyyy})"));

                OverdueAlertForm alertForm = new OverdueAlertForm(message, LoggedInUserId, Context);
                alertForm.ShowDialog();
            }
        }

        
        private void TBSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchTasks();
                e.SuppressKeyPress = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SearchTasks();
        }


        private void GroupTasksByPriority()
        {

            var groupedTasks = Context.TaskItems
                .Where(t => t.UserId == LoggedInUserId)
                .GroupBy(t => t.Priority)

                .Select(g => new
                {
                    priority = g.Key.ToString(),
                    Count = g.Count(),
                    Tasks = string.Join(",", g.Select(t => t.Title))
                }).ToList();
            dataGridView1.DataSource = groupedTasks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupTasksByPriority();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmboFilter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUserTasks();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadUserTasks();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadUserTasks();
            }
        }

        private void btnShowOverdue_Click(object sender, EventArgs e)
        {
            OverdueTasksForm overdueForm = new OverdueTasksForm(LoggedInUserId, Context);
            overdueForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            ReportForm reportForm = new ReportForm(LoggedInUserId);
            reportForm.Show();
        }
    }
}


