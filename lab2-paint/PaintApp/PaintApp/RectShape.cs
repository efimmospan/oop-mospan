using System.Drawing;
namespace PaintApp
{
    public class RectShape : Shape
    {
        public RectShape(Point start, Color color, int width) : base(start, color, width) { }
        public override void Draw(Graphics g)
        {
            using var pen = new Pen(Color, Width);
            g.DrawRectangle(pen, Bounds());
        }
        public override bool Contains(Point p) => Bounds().Contains(p);
    }
}