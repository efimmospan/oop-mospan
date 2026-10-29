using System;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class MainForm : Form
    {
        private TodoList _list = new TodoList();
        private string _filePath = "tasks.json";
        private string _currentFilter = "Все";
        private string _currentSort = "Сначала ранние";

        public MainForm()
        {
            InitializeComponent();
            _list.LoadFromFile(_filePath);
            RefreshList();
        }

        private void RefreshList()
        {
            lstTasks.Items.Clear();
            var displayItems = _list.GetFilteredAndSorted(_currentFilter, _currentSort);

            foreach (var item in displayItems)
            {
                string status = item.IsDone ? "☑" : "☐";
                lstTasks.Items.Add($"{status} {item.Title} (Срок: {item.DueDate.ToShortDateString()})");
            }
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.SelectedItem != null)
            {
                _currentSort = cmbSort.SelectedItem.ToString();
                RefreshList();
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

                // ИСПРАВЛЕНО: берем отфильтрованный список
                var items = _list.GetFilteredAndSorted(_currentFilter, _currentSort);
                _list.Complete(items[i]);
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

                // ИСПРАВЛЕНО: берем отфильтрованный список
                var items = _list.GetFilteredAndSorted(_currentFilter, _currentSort);
                string newTitle = Microsoft.VisualBasic.Interaction.InputBox("Новое название:", "Переименовать", items[i].Title);
                if (string.IsNullOrWhiteSpace(newTitle)) return;

                _list.Rename(items[i], newTitle);
                RefreshList();
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Ошибка"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lstTasks.SelectedIndex;
                if (i == -1) throw new ArgumentException("Выберите задачу!");

                // ИСПРАВЛЕНО: берем отфильтрованный список
                var items = _list.GetFilteredAndSorted(_currentFilter, _currentSort);
                _list.Remove(items[i]);
                RefreshList();
            }
            catch (ArgumentException ex) { MessageBox.Show(ex.Message, "Ошибка"); }
        }

        private void btnFilterAll_Click(object sender, EventArgs e)
        {
            _currentFilter = "Все";
            RefreshList();
        }

        private void btnFilterActive_Click(object sender, EventArgs e)
        {
            _currentFilter = "Активные";
            RefreshList();
        }

        private void btnFilterDone_Click(object sender, EventArgs e)
        {
            _currentFilter = "Выполненные";
            RefreshList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _list.SaveToFile(_filePath);
        }
    }
}