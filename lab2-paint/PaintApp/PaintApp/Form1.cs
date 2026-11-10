using System;
using System.Drawing;
using System.Windows.Forms;
namespace PaintApp
{
    public partial class Form1 : Form
    {
        private Drawing _drawing = new Drawing();
        private History _history = new History();
        private Shape _currentShape = null;
        private string _currentTool = "RectShape";
        private string _filePath = "picture.json";

        private Shape _selectedShape = null;
        private Point _lastMousePos;

        public Form1()
        {
            InitializeComponent();
            cmbColor.Items.AddRange(new object[] { "Black", "Red", "Blue", "Green", "Orange" });
            cmbColor.SelectedIndex = 0;
            this.KeyPreview = true; 
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            canvas.Focus();
            if (e.Button == MouseButtons.Left)
            {
                _lastMousePos = e.Location;
                _selectedShape = _drawing.GetShapeAt(e.Location);
                if (_selectedShape != null)
                {
                    _currentShape = null;
                    canvas.Invalidate();
                    return;
                }
                Color selectedColor = Color.FromName(cmbColor.SelectedItem.ToString());
                int selectedWidth = (int)numWidth.Value;
                if (_currentTool == "RectShape") _currentShape = new RectShape(e.Location, selectedColor, selectedWidth);
                else if (_currentTool == "EllipseShape") _currentShape = new EllipseShape(e.Location, selectedColor, selectedWidth);
                else if (_currentTool == "PencilShape") _currentShape = new PencilShape(e.Location, selectedColor, selectedWidth);
                else if (_currentTool == "LineShape") _currentShape = new LineShape(e.Location, selectedColor, selectedWidth);

                _history.Do(new AddShapeCommand(_drawing, _currentShape)); // <--- ЧЕРЕЗ ИСТОРИЮ
                canvas.Invalidate();
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_selectedShape != null)
                {
                    int dx = e.X - _lastMousePos.X;
                    int dy = e.Y - _lastMousePos.Y;
                    _selectedShape.Move(dx, dy);
                    _lastMousePos = e.Location;
                    canvas.Invalidate();
                }
                else if (_currentShape != null)
                {
                    _currentShape.MoveEnd(e.Location);
                    canvas.Invalidate();
                }
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            _currentShape = null;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            _drawing.Draw(e.Graphics);

            if (_selectedShape != null)
            {
                using var pen = new Pen(Color.Red, 2);
                int x = Math.Min(_selectedShape.Start.X, _selectedShape.End.X) - 5;
                int y = Math.Min(_selectedShape.Start.Y, _selectedShape.End.Y) - 5;
                int w = Math.Abs(_selectedShape.End.X - _selectedShape.Start.X) + 10;
                int h = Math.Abs(_selectedShape.End.Y - _selectedShape.Start.Y) + 10;
                e.Graphics.DrawRectangle(pen, x, y, w, h);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                _history.Undo();
                _selectedShape = null;
                canvas.Invalidate();
                return;
            }
            if (e.Control && e.KeyCode == Keys.Y)
            {
                _history.Redo();
                canvas.Invalidate();
                return;
            }
            if (e.KeyCode == Keys.Delete && _selectedShape != null)
            {
                _history.Do(new RemoveShapeCommand(_drawing, _selectedShape));
                _selectedShape = null;
                canvas.Invalidate();
            }
        }
        private void btnRect_Click(object sender, EventArgs e) => _currentTool = "RectShape";
        private void btnEllipse_Click(object sender, EventArgs e) => _currentTool = "EllipseShape";
        private void btnPencil_Click(object sender, EventArgs e) => _currentTool = "PencilShape";
        private void btnLine_Click(object sender, EventArgs e) => _currentTool = "LineShape";

        private void btnUndo_Click(object sender, EventArgs e)
        {
            _history.Undo();
            _selectedShape = null;
            canvas.Invalidate();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            _history.Do(new ClearCommand(_drawing));
            _selectedShape = null;
            canvas.Invalidate();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _drawing.SaveToFile(_filePath);
            MessageBox.Show("Рисунок сохранен!");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _drawing.LoadFromFile(_filePath);
            _selectedShape = null;
            canvas.Invalidate();
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            using var bmp = new Bitmap(canvas.Width, canvas.Height);
            canvas.DrawToBitmap(bmp, new Rectangle(0, 0, canvas.Width, canvas.Height));
            bmp.Save("drawing.png", System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("Сохранено в drawing.png", "Экспорт");
        }
    }
}