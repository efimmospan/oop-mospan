using System.Drawing;

namespace PaintApp
{
    public class LineShape : Shape
    {
        public LineShape(Point start, Color color, int width) : base(start, color, width)
        {
        }

        public override void Draw(Graphics g)
        {
            using var pen = new Pen(Color, Width);
            g.DrawLine(pen, Start, End);
        }
        public override bool Contains(Point point)
        {
          
            var rect = Bounds();
            rect.Inflate(5, 5); 
            return rect.Contains(point);
        }
    }
}