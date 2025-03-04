namespace ProjectF.TaskForms
{
    partial class LogoutControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnlogout = new Button();
            SuspendLayout();
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Red;
            btnlogout.FlatStyle = FlatStyle.Popup;
            btnlogout.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogout.Location = new Point(0, 17);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(197, 52);
            btnlogout.TabIndex = 0;
            btnlogout.Text = "LogOut";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // LogoutControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            Controls.Add(btnlogout);
            Name = "LogoutControl";
            Size = new Size(197, 72);
            ResumeLayout(false);
        }

        #endregion

        private Button btnlogout;
    }
}
