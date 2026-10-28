using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TodoApp
{
    public class TodoList
    {
        private List<TodoItem> _items = new List<TodoItem>();

        public IReadOnlyList<TodoItem> Items => _items;
        public void Remove(TodoItem item)
        {
            if (item == null) throw new ArgumentException("Задача не выбрана");
            _items.Remove(item);
        }

        public void Rename(TodoItem item, string newTitle)
        {
            if (item == null) throw new ArgumentException("Задача не выбрана");
            item.Rename(newTitle);
        }

        public void Complete(TodoItem item)
        {
            if (item == null) throw new ArgumentException("Задача не выбрана");
            item.Complete();
        }

        public void SaveToFile(string filePath)
        {
            string json = JsonSerializer.Serialize(_items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
        public void Add(string title, DateTime dueDate)
        {
            _items.Add(new TodoItem(title, dueDate));
        }
        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                _items = new List<TodoItem>();
                return;
            }

            string json = File.ReadAllText(filePath);
            var loaded = JsonSerializer.Deserialize<List<TodoItem>>(json);
            _items = loaded ?? new List<TodoItem>();
        }
    }
}