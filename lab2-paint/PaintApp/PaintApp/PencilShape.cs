using System.Collections.Generic;
using System.Drawing;

namespace PaintApp
{
    public class PencilShape : Shape
    {
        public List<Point> Points => _points;
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

        public override bool Contains(Point p)
        {
            foreach (var point in _points)
            {
                if (System.Math.Abs(point.X - p.X) < 10 && System.Math.Abs(point.Y - p.Y) < 10)
                    return true;
            }
            return false;
        }
        public override void Move(int dx, int dy)
        {
            base.Move(dx, dy);
            for (int i = 0; i < _points.Count; i++)
            {
                _points[i] = new Point(_points[i].X + dx, _points[i].Y + dy);
            }
        }
    }
}