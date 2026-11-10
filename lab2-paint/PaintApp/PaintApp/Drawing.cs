using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
namespace PaintApp
{
    public class Drawing
    {
        private List<Shape> _shapes = new List<Shape>();
        public void Add(Shape shape)
        {
            _shapes.Add(shape);
        }
        public void RemoveLast()
        {
            if (_shapes.Count > 0)
                _shapes.RemoveAt(_shapes.Count - 1);
        }
        public void Clear()
        {
            _shapes.Clear();
        }
        public void Draw(Graphics g)
        {
            foreach (var shape in _shapes)
            {
                shape.Draw(g);
            }
        }
        public void SaveToFile(string filePath)
        {
            var dataToSave = new List<ShapeData>();
            foreach (var shape in _shapes)
            {
                dataToSave.Add(new ShapeData
                {
                    Kind = shape.GetType().Name,
                    Start = shape.Start,
                    End = shape.End,
                    Color = shape.Color.ToArgb(),
                    Width = shape.Width
                });
            }

            string json = JsonSerializer.Serialize(dataToSave, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return;
            string json = File.ReadAllText(filePath);
            var loadedData = JsonSerializer.Deserialize<List<ShapeData>>(json);

            _shapes.Clear();

            if (loadedData != null)
            {
                foreach (var item in loadedData)
                {
                    Color color = Color.FromArgb(item.Color);
                    Shape newShape = ShapeFactory.Create(item.Kind, item.Start, color, item.Width);
                    newShape.MoveEnd(item.End); 
                    _shapes.Add(newShape);
                }
            }
        }
    }

    public class ShapeData
    {
        public string Kind { get; set; } = "";
        public Point Start { get; set; }
        public Point End { get; set; }
        public int Color { get; set; }
        public int Width { get; set; }
    }
}