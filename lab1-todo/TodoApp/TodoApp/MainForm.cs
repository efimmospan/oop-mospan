using System;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class MainForm : Form
    {
        private TodoList _list = new TodoList();
        private string _filePath = "tasks.json";

        public MainForm()
        {
            InitializeComponent();
            _list.LoadFromFile(_filePath);
            RefreshList();
        }

        private void RefreshList()
        {
            lstTasks.Items.Clear();
            foreach (var item in _list.Items)
            {
                string status = item.IsDone ? "☑" : "☐"; ;
                lstTasks.Items.Add($"{status} {item.Title} (Срок: {item.DueDate.ToShortDateString()})");

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _list.Add(txtTitle.Text, dtpDueDate.Value);
                RefreshList();
                txtTitle.Clear();
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Ошибка"); }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lstTasks.SelectedIndex;
                if (i == -1) throw new ArgumentException("Выберите задачу!");
                _list.Complete(_list.Items[i]);
                RefreshList();
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Ошибка"); }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lstTasks.SelectedIndex;
                if (i == -1) throw new ArgumentException("Выберите задачу!");

                string newTitle = Microsoft.VisualBasic.Interaction.InputBox("Новое название:", "Переименовать", _list.Items[i].Title);
                if (string.IsNullOrWhiteSpace(newTitle)) return;

                _list.Rename(_list.Items[i], newTitle);
                RefreshList();
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Ошибка"); }

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lstTasks.SelectedIndex;
                if (i == -1) throw new ArgumentException("Выберите задачу!");
                _list.Remove(_list.Items[i]);
                RefreshList();
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Ошибка"); }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _list.SaveToFile(_filePath);
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void numPriority_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}