using System;

namespace TodoApp
{
    public class TodoItem
    {
        private string _title = "";
        private bool _done;
        private DateTime _dueDate;
        public TodoItem(string title,  DateTime dueDate)
        {
            Rename(title);
            
            _dueDate = dueDate;
            _done = false;
        }

        public string Title => _title;
        public bool IsDone => _done;
        
        public DateTime DueDate => _dueDate;

        public void Complete() => _done = true;

        public void Rename(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Название не может быть пустым");
            _title = title.Trim();
        }
    }
}