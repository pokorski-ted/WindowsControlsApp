using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void ControlsDemoForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(0, menuStrip1.Height);

            if (shp == ShapeType.Rectangle)
                g.DrawRectangle(Pens.Red, 10, 10, 100, 80);
            else
                g.DrawEllipse(Pens.Red, 10, 10, 100, 80);
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

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
