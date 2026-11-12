using System;
using System.Drawing;
namespace PaintApp
{
    public abstract class Shape
    {
        public Point Start { get; protected set; }
        public Point End { get; protected set; }
        public Color Color { get; }
        public int Width { get; }

        protected Shape(Point start, Color color, int width)
        {
            Start = End = start;
            Color = color;
            Width = width;
        }

        public virtual void MoveEnd(Point p) => End = p;

        protected Rectangle Bounds() => new Rectangle(
            Math.Min(Start.X, End.X), Math.Min(Start.Y, End.Y),
            Math.Abs(End.X - Start.X), Math.Abs(End.Y - Start.Y));
        public abstract bool Contains(Point point);
        public abstract void Draw(Graphics g);
        public virtual void Move(int dx, int dy)
        {
            Start = new Point(Start.X + dx, Start.Y + dy);
            End = new Point(End.X + dx, End.Y + dy);
        }
    }
}