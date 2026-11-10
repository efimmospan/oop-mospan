using System.Collections.Generic;
using System.Drawing;

namespace PaintApp
{
    public class PencilShape : Shape
    {
        private readonly List<Point> _points = new List<Point>();

        public PencilShape(Point start, Color color, int width) : base(start, color, width)
        {
            _points.Add(start);
        }
        public override void MoveEnd(Point p)
        {
            base.MoveEnd(p);
            _points.Add(p); 
        }
        public override void Draw(Graphics g)
        {
            if (_points.Count < 2) return;
            using var pen = new Pen(Color, Width);
            g.DrawLines(pen, _points.ToArray()); 
        }
    }
}