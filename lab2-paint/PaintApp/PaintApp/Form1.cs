using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        private Drawing _drawing = new Drawing();
        private Shape _currentShape = null;
        private string _currentTool = "RectShape";

        public Form1()
        {
            InitializeComponent();
            cmbColor.Items.AddRange(new object[] { "Black", "Red", "Blue", "Green", "Orange" });
            cmbColor.SelectedIndex = 0;
        }
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Color selectedColor = Color.FromName(cmbColor.SelectedItem.ToString());
                int selectedWidth = (int)numWidth.Value;
                if (_currentTool == "RectShape")
                    _currentShape = new RectShape(e.Location, selectedColor, selectedWidth);
                else if (_currentTool == "EllipseShape")
                    _currentShape = new EllipseShape(e.Location, selectedColor, selectedWidth);
                else if (_currentTool == "PencilShape")
                    _currentShape = new PencilShape(e.Location, selectedColor, selectedWidth);
                else if (_currentTool == "LineShape")
                    _currentShape = new LineShape(e.Location, selectedColor, selectedWidth);

                _drawing.Add(_currentShape);
                canvas.Invalidate();
            }
        }
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _currentShape != null)
            {
                _currentShape.MoveEnd(e.Location);
                canvas.Invalidate();
            }
        }
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            _currentShape = null;
        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            _drawing.Draw(e.Graphics);
        }
        private void btnRect_Click(object sender, EventArgs e) => _currentTool = "RectShape";
        private void btnEllipse_Click(object sender, EventArgs e) => _currentTool = "EllipseShape";
        private void btnPencil_Click(object sender, EventArgs e) => _currentTool = "PencilShape";
        private void btnLine_Click(object sender, EventArgs e) => _currentTool = "LineShape";
        private void btnUndo_Click(object sender, EventArgs e)
        {
            _drawing.RemoveLast();
            canvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _drawing.Clear();
            canvas.Invalidate();
        }
    }
}