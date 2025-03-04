using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectF.TaskForms
{
    partial class ReportForm
    {
        private IContainer components = null;
        private Chart chart1;
        private Button btnCloseReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Title title1 = new Title();
            chart1 = new Chart();
            btnCloseReport = new Button();
            ((ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = SystemColors.Info;
            chart1.BorderlineColor = SystemColors.Info;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Tasks Report";
            legend1.TitleBackColor = SystemColors.Info;
            legend1.TitleFont = new Font("Microsoft YaHei", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            legend1.TitleForeColor = Color.Brown;
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(30, 13);
            chart1.Margin = new Padding(3, 4, 3, 4);
            chart1.Name = "chart1";
            chart1.Palette = ChartColorPalette.Chocolate;
            chart1.Size = new Size(760, 419);
            chart1.TabIndex = 0;
            chart1.Text = "Task Report";
            title1.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            title1.ForeColor = Color.Brown;
            title1.Name = "Title1";
            title1.Text = "Tasks Report";
            chart1.Titles.Add(title1);
            // 
            // btnCloseReport
            // 
            btnCloseReport.BackColor = Color.Peru;
            btnCloseReport.FlatStyle = FlatStyle.Popup;
            btnCloseReport.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnCloseReport.Location = new Point(690, 452);
            btnCloseReport.Margin = new Padding(3, 4, 3, 4);
            btnCloseReport.Name = "btnCloseReport";
            btnCloseReport.Size = new Size(100, 38);
            btnCloseReport.TabIndex = 1;
            btnCloseReport.Text = "Close";
            btnCloseReport.UseVisualStyleBackColor = false;
            btnCloseReport.Click += BtnCloseReport_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(848, 517);
            Controls.Add(chart1);
            Controls.Add(btnCloseReport);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Report";
            ((ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        private void BtnCloseReport_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
