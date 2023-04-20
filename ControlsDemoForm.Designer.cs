namespace WindowsControlsApp
{
    partial class ControlsDemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuShape = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuElipse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShape});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuShape
            // 
            this.mnuShape.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRectangle,
            this.mnuElipse,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuShape.Name = "mnuShape";
            this.mnuShape.Size = new System.Drawing.Size(51, 20);
            this.mnuShape.Text = "Shape";
            // 
            // mnuRectangle
            // 
            this.mnuRectangle.Name = "mnuRectangle";
            this.mnuRectangle.Size = new System.Drawing.Size(180, 22);
            this.mnuRectangle.Text = "Rectangle";
            this.mnuRectangle.Click += new System.EventHandler(this.mnuRectangle_Click);
            // 
            // mnuElipse
            // 
            this.mnuElipse.Name = "mnuElipse";
            this.mnuElipse.Size = new System.Drawing.Size(180, 22);
            this.mnuElipse.Text = "Elipse";
            this.mnuElipse.Click += new System.EventHandler(this.mnuElipse_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // ControlsDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlsDemoForm";
            this.Text = "ControlsDemoForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlsDemoForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuShape;
        private System.Windows.Forms.ToolStripMenuItem mnuRectangle;
        private System.Windows.Forms.ToolStripMenuItem mnuElipse;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}