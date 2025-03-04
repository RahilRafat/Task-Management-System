namespace ProjectF
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            lblTitle = new Label();
            label1 = new Label();
            lbldate = new Label();
            textboxTitle = new TextBox();
            textBoxDescription = new TextBox();
            dateTimetask = new DateTimePicker();
            cmboPirority = new ComboBox();
            lblPirority = new Label();
            lblstatus = new Label();
            cmboStatus = new ComboBox();
            lblCategory = new Label();
            cmboCategory = new ComboBox();
            button1 = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Peru;
            lblTitle.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(296, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(63, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Peru;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(296, 111);
            label1.Name = "label1";
            label1.Size = new Size(136, 31);
            label1.TabIndex = 1;
            label1.Text = "Description:";
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.BackColor = Color.Peru;
            lbldate.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbldate.Location = new Point(296, 196);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(114, 31);
            lbldate.TabIndex = 2;
            lbldate.Text = "Due Date:";
            // 
            // textboxTitle
            // 
            textboxTitle.Location = new Point(326, 72);
            textboxTitle.Name = "textboxTitle";
            textboxTitle.PlaceholderText = "Task Title";
            textboxTitle.Size = new Size(493, 27);
            textboxTitle.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(326, 156);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Task Description";
            textBoxDescription.Size = new Size(481, 27);
            textBoxDescription.TabIndex = 4;
            // 
            // dateTimetask
            // 
            dateTimetask.Location = new Point(326, 230);
            dateTimetask.MinDate = new DateTime(2025, 2, 27, 0, 0, 0, 0);
            dateTimetask.Name = "dateTimetask";
            dateTimetask.Size = new Size(250, 27);
            dateTimetask.TabIndex = 5;
            dateTimetask.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cmboPirority
            // 
            cmboPirority.FormattingEnabled = true;
            cmboPirority.Location = new Point(326, 314);
            cmboPirority.Name = "cmboPirority";
            cmboPirority.Size = new Size(151, 28);
            cmboPirority.TabIndex = 6;
            // 
            // lblPirority
            // 
            lblPirority.AutoSize = true;
            lblPirority.BackColor = Color.Peru;
            lblPirority.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPirority.Location = new Point(296, 280);
            lblPirority.Name = "lblPirority";
            lblPirority.Size = new Size(93, 31);
            lblPirority.TabIndex = 7;
            lblPirority.Text = "pirority:";
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.BackColor = Color.Peru;
            lblstatus.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblstatus.Location = new Point(296, 354);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(82, 31);
            lblstatus.TabIndex = 8;
            lblstatus.Text = "Status:";
            // 
            // cmboStatus
            // 
            cmboStatus.FormattingEnabled = true;
            cmboStatus.Location = new Point(326, 388);
            cmboStatus.Name = "cmboStatus";
            cmboStatus.Size = new Size(151, 28);
            cmboStatus.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Peru;
            lblCategory.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(296, 432);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(111, 31);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Category:";
            // 
            // cmboCategory
            // 
            cmboCategory.FormattingEnabled = true;
            cmboCategory.Location = new Point(326, 478);
            cmboCategory.Name = "cmboCategory";
            cmboCategory.Size = new Size(151, 28);
            cmboCategory.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(757, 556);
            button1.Name = "button1";
            button1.Size = new Size(108, 41);
            button1.TabIndex = 12;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.Sienna;
            Cancel.FlatStyle = FlatStyle.Popup;
            Cancel.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Cancel.Location = new Point(888, 556);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(110, 41);
            Cancel.TabIndex = 13;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1072, 624);
            Controls.Add(Cancel);
            Controls.Add(button1);
            Controls.Add(cmboCategory);
            Controls.Add(lblCategory);
            Controls.Add(cmboStatus);
            Controls.Add(lblstatus);
            Controls.Add(lblPirority);
            Controls.Add(cmboPirority);
            Controls.Add(dateTimetask);
            Controls.Add(textBoxDescription);
            Controls.Add(textboxTitle);
            Controls.Add(lbldate);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Task";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label lbldate;
        private TextBox textboxTitle;
        private TextBox textBoxDescription;
        private DateTimePicker dateTimetask;
        private ComboBox cmboPirority;
        private Label lblPirority;
        private Label lblstatus;
        private ComboBox cmboStatus;
        private Label lblCategory;
        private ComboBox cmboCategory;
        private Button button1;
        private Button Cancel;
    }
}