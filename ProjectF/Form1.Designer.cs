namespace ProjectF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            btnNew = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            cmboFilter = new ComboBox();
            btnSort = new Button();
            pictureBox1 = new PictureBox();
            richTBSearch = new RichTextBox();
            button1 = new Button();
            label4 = new Label();
            cmboFilter2 = new ComboBox();
            lblPageNumber = new Label();
            btnPrev = new Button();
            btnNext = new Button();
            panelDashboard = new Panel();
            logoutControl1 = new TaskForms.LogoutControl();
            btnShowOverdue = new Button();
            notifyIcon1 = new NotifyIcon(components);
            timer1 = new System.Windows.Forms.Timer(components);
            btnReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Ivory;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.AliceBlue;
            dataGridView1.Location = new Point(200, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(984, 269);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Peru;
            btnNew.FlatStyle = FlatStyle.Popup;
            btnNew.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(-1, 437);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(200, 49);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(-1, 483);
            button2.Name = "button2";
            button2.Size = new Size(201, 46);
            button2.TabIndex = 2;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Peru;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(-2, 526);
            button3.Name = "button3";
            button3.Size = new Size(201, 45);
            button3.TabIndex = 3;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.NavajoWhite;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 4;
            label1.Text = "Filter by Status:";
            // 
            // cmboFilter
            // 
            cmboFilter.BackColor = Color.LightYellow;
            cmboFilter.ForeColor = Color.SaddleBrown;
            cmboFilter.FormattingEnabled = true;
            cmboFilter.Location = new Point(3, 43);
            cmboFilter.Name = "cmboFilter";
            cmboFilter.Size = new Size(159, 28);
            cmboFilter.TabIndex = 5;
            cmboFilter.SelectedIndexChanged += cmboFilter_SelectedIndexChanged;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.Peru;
            btnSort.FlatStyle = FlatStyle.Popup;
            btnSort.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSort.ForeColor = SystemColors.ActiveCaptionText;
            btnSort.Location = new Point(-1, 172);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(201, 48);
            btnSort.TabIndex = 6;
            btnSort.Text = "Sort By DueDate";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(919, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 50);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // richTBSearch
            // 
            richTBSearch.BackColor = SystemColors.Info;
            richTBSearch.Location = new Point(976, 15);
            richTBSearch.Name = "richTBSearch";
            richTBSearch.Size = new Size(206, 50);
            richTBSearch.TabIndex = 8;
            richTBSearch.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(-1, 219);
            button1.Name = "button1";
            button1.Size = new Size(208, 42);
            button1.TabIndex = 9;
            button1.Text = "Group by Priority";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.NavajoWhite;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(-1, 87);
            label4.Name = "label4";
            label4.Size = new Size(174, 31);
            label4.TabIndex = 12;
            label4.Text = "Filter by Priorty:";
            // 
            // cmboFilter2
            // 
            cmboFilter2.BackColor = Color.LightYellow;
            cmboFilter2.ForeColor = Color.SaddleBrown;
            cmboFilter2.FormattingEnabled = true;
            cmboFilter2.Location = new Point(3, 121);
            cmboFilter2.Name = "cmboFilter2";
            cmboFilter2.Size = new Size(159, 28);
            cmboFilter2.TabIndex = 13;
            cmboFilter2.SelectedIndexChanged += cmboFilter2_SelectedIndexChanged;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.BackColor = Color.Sienna;
            lblPageNumber.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPageNumber.Location = new Point(1052, 427);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(132, 27);
            lblPageNumber.TabIndex = 14;
            lblPageNumber.Text = "Page Number";
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.Peru;
            btnPrev.FlatStyle = FlatStyle.Popup;
            btnPrev.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrev.Location = new Point(1039, 457);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(76, 29);
            btnPrev.TabIndex = 15;
            btnPrev.Text = "Previous";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Peru;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(1121, 457);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(73, 29);
            btnNext.TabIndex = 16;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.SaddleBrown;
            panelDashboard.Controls.Add(logoutControl1);
            panelDashboard.Controls.Add(btnShowOverdue);
            panelDashboard.Controls.Add(label1);
            panelDashboard.Controls.Add(cmboFilter);
            panelDashboard.Controls.Add(label4);
            panelDashboard.Controls.Add(cmboFilter2);
            panelDashboard.Controls.Add(button1);
            panelDashboard.Controls.Add(button3);
            panelDashboard.Controls.Add(button2);
            panelDashboard.Controls.Add(btnSort);
            panelDashboard.Controls.Add(btnNew);
            panelDashboard.Dock = DockStyle.Left;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(200, 691);
            panelDashboard.TabIndex = 17;
            // 
            // logoutControl1
            // 
            logoutControl1.BackColor = Color.SaddleBrown;
            logoutControl1.Location = new Point(-1, 621);
            logoutControl1.Name = "logoutControl1";
            logoutControl1.Size = new Size(201, 70);
            logoutControl1.TabIndex = 19;
            // 
            // btnShowOverdue
            // 
            btnShowOverdue.BackColor = Color.Peru;
            btnShowOverdue.FlatStyle = FlatStyle.Popup;
            btnShowOverdue.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnShowOverdue.Location = new Point(-1, 570);
            btnShowOverdue.Name = "btnShowOverdue";
            btnShowOverdue.Size = new Size(201, 45);
            btnShowOverdue.TabIndex = 18;
            btnShowOverdue.Text = "OverDue Tasks";
            btnShowOverdue.UseVisualStyleBackColor = false;
            btnShowOverdue.Click += btnShowOverdue_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon";
            notifyIcon1.Visible = true;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.Peru;
            btnReport.FlatStyle = FlatStyle.Popup;
            btnReport.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnReport.Location = new Point(1072, 648);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(122, 38);
            btnReport.TabIndex = 18;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1194, 691);
            Controls.Add(btnReport);
            Controls.Add(panelDashboard);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(lblPageNumber);
            Controls.Add(richTBSearch);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnNew;
        private Button button2;
        private Button button3;
        private Label label1;
        private ComboBox cmboFilter;
        private Button btnSort;
        private PictureBox pictureBox1;
        private RichTextBox richTBSearch;
        private Button button1;
        private Label label4;
        private ComboBox cmboFilter2;
        private Label lblPageNumber;
        private Button btnPrev;
        private Button btnNext;
        private Panel panelDashboard;
        private Button btnShowOverdue;
        private NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private Button btnReport;
        private TaskForms.LogoutControl logoutControl1;
    }
}