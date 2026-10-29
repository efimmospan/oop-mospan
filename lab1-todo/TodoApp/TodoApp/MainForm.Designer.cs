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
            btnFilterAll = new Button();
            btnFilterActive = new Button();
            btnFilterDone = new Button();
            cmbSort = new ComboBox();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(395, 23);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Название задачи";
           
            // 
            // lstTasks
            // 
            lstTasks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(12, 81);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(494, 319);
            lstTasks.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(439, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
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
            // btnFilterAll
            // 
            btnFilterAll.BackColor = SystemColors.ActiveCaption;
            btnFilterAll.FlatStyle = FlatStyle.Flat;
            btnFilterAll.Location = new Point(12, 52);
            btnFilterAll.Name = "btnFilterAll";
            btnFilterAll.Size = new Size(106, 23);
            btnFilterAll.TabIndex = 8;
            btnFilterAll.Text = "Все";
            btnFilterAll.UseVisualStyleBackColor = false;
            btnFilterAll.Click += btnFilterAll_Click;
            // 
            // btnFilterActive
            // 
            btnFilterActive.BackColor = SystemColors.Info;
            btnFilterActive.FlatStyle = FlatStyle.Flat;
            btnFilterActive.Location = new Point(144, 52);
            btnFilterActive.Name = "btnFilterActive";
            btnFilterActive.Size = new Size(117, 23);
            btnFilterActive.TabIndex = 9;
            btnFilterActive.Text = "Активные";
            btnFilterActive.UseVisualStyleBackColor = false;
            btnFilterActive.Click += btnFilterActive_Click;
            // 
            // btnFilterDone
            // 
            btnFilterDone.BackColor = SystemColors.ButtonHighlight;
            btnFilterDone.FlatStyle = FlatStyle.Flat;
            btnFilterDone.Location = new Point(291, 52);
            btnFilterDone.Name = "btnFilterDone";
            btnFilterDone.Size = new Size(116, 23);
            btnFilterDone.TabIndex = 10;
            btnFilterDone.Text = "Выполненные ";
            btnFilterDone.UseVisualStyleBackColor = false;
            btnFilterDone.Click += btnFilterDone_Click;
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Сначала ранние", "Сначала поздние" });
            cmbSort.Location = new Point(640, 52);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(121, 23);
            cmbSort.TabIndex = 11;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbSort);
            Controls.Add(btnFilterDone);
            Controls.Add(btnFilterActive);
            Controls.Add(btnFilterAll);
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
        private Button btnFilterAll;
        private Button btnFilterActive;
        private Button btnFilterDone;
        private Label label1;
        private ComboBox cmbSort;
    }
}