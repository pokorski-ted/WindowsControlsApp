using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsControlsApp
{
    public partial class ControlsDemoForm : Form
    {
        public ControlsDemoForm()
        {
            InitializeComponent();
        }

        enum ShapeType
        {
        Rectangle, Elipse
        }

        ShapeType shp = ShapeType.Rectangle;
        int X, Y;

        private void ControlsDemoForm_Load(object sender, EventArgs e) 
        {
        
        }
        private void ControlsDemoForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(0, menuStrip1.Height);

            if (shp == ShapeType.Rectangle)
                g.DrawRectangle(Pens.Red, X, Y, 100, 80);
            else
                g.DrawEllipse(Pens.Red, X, Y, 100, 80);
        }

        private void mnuRectangle_Click(object sender, EventArgs e)
        {
            shp = ShapeType.Rectangle;
            Invalidate();
        }

        private void mnuElipse_Click(object sender, EventArgs e)
        {
            shp = ShapeType.Elipse;
            Invalidate();
        }

        private void mnuPosition_Click(object sender, EventArgs e)
        {
            PositionDialog dlgPosition = new PositionDialog();
            dlgPosition.Left = X;
            dlgPosition.Top = Y;

            if (dlgPosition.ShowDialog() == DialogResult.OK) 
            {
            X = dlgPosition.Left;
            Y = dlgPosition.Top;    

            Invalidate();
            
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
