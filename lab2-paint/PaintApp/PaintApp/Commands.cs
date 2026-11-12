using System.Collections.Generic;

namespace PaintApp
{
    public class AddShapeCommand : ICommand
    {
        private readonly Drawing _drawing;
        private readonly Shape _shape;
        public AddShapeCommand(Drawing drawing, Shape shape) { _drawing = drawing; _shape = shape; }
        public void Execute() => _drawing.Add(_shape);
        public void Undo() => _drawing.Remove(_shape);
    }
    public class RemoveShapeCommand : ICommand
    {
        private readonly Drawing _drawing;
        private readonly Shape _shape;
        public RemoveShapeCommand(Drawing drawing, Shape shape) { _drawing = drawing; _shape = shape; }
        public void Execute() => _drawing.Remove(_shape);
        public void Undo() => _drawing.Add(_shape);
    }

    public class ClearCommand : ICommand
    {
        private readonly Drawing _drawing;
        private readonly List<Shape> _oldShapes;

        public ClearCommand(Drawing drawing)
        {
            _drawing = drawing;
            _oldShapes = drawing.GetAllShapes();
        }
        public void Execute() => _drawing.Clear();
        public void Undo()
        {
            foreach (var shape in _oldShapes) _drawing.Add(shape);
        }
    }
}