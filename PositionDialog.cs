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
    public partial class PositionDialog : Form
    {
        public PositionDialog()
        {
            InitializeComponent();
        }

        private void PositionDialog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar <'0' || e.KeyChar > '9')
                e.Handled = true;
        }
        public int Left
        {
            get { return int.Parse(txtBoxLeft.Text); }
            set { txtBoxLeft.Text = value.ToString(); }
        }
        public int Top
        {
            get { return int.Parse(txtBoxTop.Text); }
            set { txtBoxTop.Text = value.ToString(); }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
