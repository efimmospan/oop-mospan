namespace PaintApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            canvas = new PictureBox();
            btnEllipse = new Button();
            btnPencil = new Button();
            btnLine = new Button();
            btnRect = new Button();
            cmbColor = new ComboBox();
            numWidth = new NumericUpDown();
            btnUndo = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            SuspendLayout();
            // 
            // canvas
            // 
            canvas.BackColor = SystemColors.Window;
            canvas.Location = new Point(-3, 70);
            canvas.Name = "canvas";
            canvas.Size = new Size(801, 383);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            canvas.Paint += canvas_Paint;
            canvas.MouseDown += canvas_MouseDown;
            canvas.MouseMove += canvas_MouseMove;
            canvas.MouseUp += canvas_MouseUp;
            // 
            // btnEllipse
            // 
            btnEllipse.Location = new Point(125, 8);
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new Size(114, 27);
            btnEllipse.TabIndex = 2;
            btnEllipse.Text = "Эллипс";
            btnEllipse.UseVisualStyleBackColor = true;
            btnEllipse.Click += btnEllipse_Click;
            // 
            // btnPencil
            // 
            btnPencil.Location = new Point(254, 8);
            btnPencil.Name = "btnPencil";
            btnPencil.Size = new Size(109, 27);
            btnPencil.TabIndex = 3;
            btnPencil.Text = "карандаш";
            btnPencil.UseVisualStyleBackColor = true;
            btnPencil.Click += btnPencil_Click;
            // 
            // btnLine
            // 
            btnLine.Location = new Point(369, 8);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(96, 27);
            btnLine.TabIndex = 4;
            btnLine.Text = "линия";
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;
            // 
            // btnRect
            // 
            btnRect.Location = new Point(8, 8);
            btnRect.Name = "btnRect";
            btnRect.Size = new Size(111, 27);
            btnRect.TabIndex = 1;
            btnRect.Text = "прямоугольник";
            btnRect.UseVisualStyleBackColor = true;
            btnRect.Click += btnRect_Click;
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Location = new Point(645, 12);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(121, 23);
            cmbColor.TabIndex = 5;
            // 
            // numWidth
            // 
            numWidth.Location = new Point(471, 12);
            numWidth.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(120, 23);
            numWidth.TabIndex = 6;
            numWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(8, 41);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(75, 23);
            btnUndo.TabIndex = 7;
            btnUndo.Text = "отменить";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(113, 41);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(89, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(553, 41);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(677, 41);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(89, 23);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "открыть";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnUndo);
            Controls.Add(numWidth);
            Controls.Add(cmbColor);
            Controls.Add(btnLine);
            Controls.Add(btnPencil);
            Controls.Add(btnEllipse);
            Controls.Add(btnRect);
            Controls.Add(canvas);
            Name = "Form1";
            Text = "Paint";
            
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox canvas;
        private Button btnEllipse;
        private Button btnPencil;
        private Button btnLine;
        private Button btnRect;
        private ComboBox cmbColor;
        private NumericUpDown numWidth;
        private Button btnUndo;
        private Button btnClear;
        private Button btnSave;
        private Button btnLoad;
    }
}