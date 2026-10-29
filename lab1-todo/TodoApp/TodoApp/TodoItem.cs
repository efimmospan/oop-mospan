using System;

namespace TodoApp
{
    public class TodoItem
    {
        private string _title = "";
        public bool IsDone { get; set; }

        public DateTime DueDate { get; private set; }

        public TodoItem(string title, DateTime dueDate)
        {
            Rename(title);
            DueDate = dueDate;
            IsDone = false; 
        }
        public string Title => _title;

        public void Complete() => IsDone = true;

        public void Rename(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Название не может быть пустым");
            _title = title.Trim();
        }
    }
}