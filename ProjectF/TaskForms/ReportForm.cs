using ProjectF.Models;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectF.TaskForms
{
    public partial class ReportForm : Form
    {
        private readonly int _loggedInUserId;

        public ReportForm(int userId)
        {
            InitializeComponent();
            _loggedInUserId = userId;
            LoadChartData();
        }

        private void LoadChartData()
        {
            using (var context = new TaskManagmentContext())
            {
                var taskStatusCounts = context.TaskItems
                    .Where(t => t.UserId == _loggedInUserId)
                    .GroupBy(t => t.Status)
                    .Select(g => new { Status = g.Key, Count = g.Count() })
                    .ToList();

                chart1.Series.Clear();
                Series series = new Series("Task Status")
                {
                    ChartType = SeriesChartType.Pie
                };
                int totalTasks = taskStatusCounts.Sum(t => t.Count);
                foreach (var item in taskStatusCounts)
                {
                    
                    double percentage = (double)item.Count / totalTasks * 100; 

                    DataPoint point = new DataPoint
                    {
                        AxisLabel = $"{item.Status}", 
                        YValues = new double[] { item.Count } 
                    };

                   
                    point.Label = $"{item.Status} : {percentage:F2}%";

                    series.Points.Add(point);

                }
                chart1.Series.Add(series);
                series.IsValueShownAsLabel = true;

                series["PieLabelStyle"] = "Outside"; 
                series["PieLineColor"] = "Brown"; 

                
                chart1.Legends[0].Enabled = true; 
            }



        }
    }
}
