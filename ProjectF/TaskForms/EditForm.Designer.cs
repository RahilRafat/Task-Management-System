namespace ProjectF.TaskForms
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            Cancel = new Button();
            button1 = new Button();
            cmboCategory = new ComboBox();
            lblCategory = new Label();
            cmboStatus = new ComboBox();
            lblstatus = new Label();
            lblPirority = new Label();
            cmboPirority = new ComboBox();
            dateTimetask = new DateTimePicker();
            textBoxDescription = new TextBox();
            textboxTitle = new TextBox();
            lbldate = new Label();
            label1 = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.Sienna;
            Cancel.FlatStyle = FlatStyle.Popup;
            Cancel.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Cancel.Location = new Point(913, 551);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(103, 42);
            Cancel.TabIndex = 27;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(781, 551);
            button1.Name = "button1";
            button1.Size = new Size(110, 42);
            button1.TabIndex = 26;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmboCategory
            // 
            cmboCategory.FormattingEnabled = true;
            cmboCategory.Location = new Point(362, 464);
            cmboCategory.Name = "cmboCategory";
            cmboCategory.Size = new Size(151, 28);
            cmboCategory.TabIndex = 25;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Peru;
            lblCategory.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(308, 430);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(111, 31);
            lblCategory.TabIndex = 24;
            lblCategory.Text = "Category:";
            // 
            // cmboStatus
            // 
            cmboStatus.FormattingEnabled = true;
            cmboStatus.Location = new Point(362, 382);
            cmboStatus.Name = "cmboStatus";
            cmboStatus.Size = new Size(151, 28);
            cmboStatus.TabIndex = 23;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.BackColor = Color.Peru;
            lblstatus.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblstatus.Location = new Point(308, 348);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(82, 31);
            lblstatus.TabIndex = 22;
            lblstatus.Text = "Status:";
            // 
            // lblPirority
            // 
            lblPirority.AutoSize = true;
            lblPirority.BackColor = Color.Peru;
            lblPirority.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPirority.Location = new Point(308, 259);
            lblPirority.Name = "lblPirority";
            lblPirority.Size = new Size(93, 31);
            lblPirority.TabIndex = 21;
            lblPirority.Text = "pirority:";
            // 
            // cmboPirority
            // 
            cmboPirority.FormattingEnabled = true;
            cmboPirority.Location = new Point(362, 293);
            cmboPirority.Name = "cmboPirority";
            cmboPirority.Size = new Size(151, 28);
            cmboPirority.TabIndex = 20;
            // 
            // dateTimetask
            // 
            dateTimetask.Location = new Point(362, 217);
            dateTimetask.MinDate = new DateTime(2025, 2, 27, 0, 0, 0, 0);
            dateTimetask.Name = "dateTimetask";
            dateTimetask.Size = new Size(250, 27);
            dateTimetask.TabIndex = 19;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(362, 133);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Task Description";
            textBoxDescription.Size = new Size(481, 27);
            textBoxDescription.TabIndex = 18;
            // 
            // textboxTitle
            // 
            textboxTitle.Location = new Point(362, 50);
            textboxTitle.Name = "textboxTitle";
            textboxTitle.PlaceholderText = "Task Title";
            textboxTitle.Size = new Size(493, 27);
            textboxTitle.TabIndex = 17;
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.BackColor = Color.Peru;
            lbldate.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbldate.Location = new Point(308, 173);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(114, 31);
            lbldate.TabIndex = 16;
            lbldate.Text = "Due Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Peru;
            label1.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(308, 89);
            label1.Name = "label1";
            label1.Size = new Size(136, 31);
            label1.TabIndex = 15;
            label1.Text = "Description:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Peru;
            lblTitle.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(308, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(63, 31);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Title:";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1060, 628);
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
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancel;
        private Button button1;
        private ComboBox cmboCategory;
        private Label lblCategory;
        private ComboBox cmboStatus;
        private Label lblstatus;
        private Label lblPirority;
        private ComboBox cmboPirority;
        private DateTimePicker dateTimetask;
        private TextBox textBoxDescription;
        private TextBox textboxTitle;
        private Label lbldate;
        private Label label1;
        private Label lblTitle;
    }
}