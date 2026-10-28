namespace TodoApp
{
    partial class MainForm
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
            txtTitle = new TextBox();
            lstTasks = new ListBox();
            btnAdd = new Button();
            btnComplete = new Button();
            btnRename = new Button();
            btnDelete = new Button();
            dtpDueDate = new DateTimePicker();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(395, 23);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Название задачи";
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(12, 81);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(494, 319);
            lstTasks.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(439, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(12, 415);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(106, 23);
            btnComplete.TabIndex = 4;
            btnComplete.Text = "выполнено";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(144, 415);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(117, 23);
            btnRename.TabIndex = 5;
            btnRename.Text = "Переименовать ";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(301, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "удалить ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(588, 12);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(200, 23);
            dtpDueDate.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDueDate);
            Controls.Add(btnDelete);
            Controls.Add(btnRename);
            Controls.Add(btnComplete);
            Controls.Add(btnAdd);
            Controls.Add(lstTasks);
            Controls.Add(txtTitle);
            Name = "MainForm";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private ListBox lstTasks;
        private Button btnAdd;
        private Button btnComplete;
        private Button btnRename;
        private Button btnDelete;
        private DateTimePicker dtpDueDate;
    }
}