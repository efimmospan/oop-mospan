using System.Collections.Generic;
using System.Drawing;

namespace PaintApp
{
    public class Drawing
    {
        private List<Shape> _shapes = new List<Shape>();

        public void Add(Shape shape) => _shapes.Add(shape);

        public void RemoveLast()
        {
            if (_shapes.Count > 0) _shapes.RemoveAt(_shapes.Count - 1);
        }

        public void Clear() => _shapes.Clear();

        public void Draw(Graphics g)
        {
            foreach (var shape in _shapes)
            {
                shape.Draw(g);
            }
        }
    }
}