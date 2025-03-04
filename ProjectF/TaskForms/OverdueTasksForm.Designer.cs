namespace ProjectF.TaskForms
{
    partial class OverdueTasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewOverdue = new DataGridView();
            btnClose = new Button();
            lblOverDue = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverdue).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOverdue
            // 
            dataGridViewOverdue.BackgroundColor = SystemColors.Info;
            dataGridViewOverdue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOverdue.Location = new Point(41, 105);
            dataGridViewOverdue.Name = "dataGridViewOverdue";
            dataGridViewOverdue.RowHeadersWidth = 51;
            dataGridViewOverdue.RowTemplate.Height = 29;
            dataGridViewOverdue.Size = new Size(723, 213);
            dataGridViewOverdue.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Peru;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Location = new Point(662, 379);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblOverDue
            // 
            lblOverDue.AutoSize = true;
            lblOverDue.BackColor = Color.Sienna;
            lblOverDue.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblOverDue.Location = new Point(41, 50);
            lblOverDue.Name = "lblOverDue";
            lblOverDue.Size = new Size(241, 31);
            lblOverDue.TabIndex = 2;
            lblOverDue.Text = "Your OverDue Tasks:";
            // 
            // OverdueTasksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOverDue);
            Controls.Add(btnClose);
            Controls.Add(dataGridViewOverdue);
            Name = "OverdueTasksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Overdue Tasks";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOverdue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOverdue;
        private Button btnClose;
        private Label lblOverDue;
    }
}