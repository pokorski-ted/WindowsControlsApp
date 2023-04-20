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
            this.txtCouponName = new System.Windows.Forms.TextBox();
            this.txtCouponPercent = new System.Windows.Forms.TextBox();
            this.txtIsActive = new System.Windows.Forms.TextBox();
            this.txtCouponID = new System.Windows.Forms.TextBox();
            this.btnGetCoupon = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShape,
            this.editToolStripMenuItem});
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
            // txtCouponName
            // 
            this.txtCouponName.Location = new System.Drawing.Point(110, 210);
            this.txtCouponName.Name = "txtCouponName";
            this.txtCouponName.Size = new System.Drawing.Size(105, 20);
            this.txtCouponName.TabIndex = 1;
            // 
            // txtCouponPercent
            // 
            this.txtCouponPercent.Location = new System.Drawing.Point(110, 247);
            this.txtCouponPercent.Name = "txtCouponPercent";
            this.txtCouponPercent.Size = new System.Drawing.Size(105, 20);
            this.txtCouponPercent.TabIndex = 2;
            // 
            // txtIsActive
            // 
            this.txtIsActive.Location = new System.Drawing.Point(110, 284);
            this.txtIsActive.Name = "txtIsActive";
            this.txtIsActive.Size = new System.Drawing.Size(105, 20);
            this.txtIsActive.TabIndex = 3;
            // 
            // txtCouponID
            // 
            this.txtCouponID.Location = new System.Drawing.Point(110, 134);
            this.txtCouponID.Name = "txtCouponID";
            this.txtCouponID.Size = new System.Drawing.Size(105, 20);
            this.txtCouponID.TabIndex = 4;
            // 
            // btnGetCoupon
            // 
            this.btnGetCoupon.Location = new System.Drawing.Point(236, 131);
            this.btnGetCoupon.Name = "btnGetCoupon";
            this.btnGetCoupon.Size = new System.Drawing.Size(99, 24);
            this.btnGetCoupon.TabIndex = 5;
            this.btnGetCoupon.Text = "Get Coupon";
            this.btnGetCoupon.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(110, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Coupon";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPosition});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnuPosition
            // 
            this.mnuPosition.Name = "mnuPosition";
            this.mnuPosition.Size = new System.Drawing.Size(180, 22);
            this.mnuPosition.Text = "Position";
            this.mnuPosition.Click += new System.EventHandler(this.mnuPosition_Click);
            // 
            // ControlsDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 561);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGetCoupon);
            this.Controls.Add(this.txtCouponID);
            this.Controls.Add(this.txtIsActive);
            this.Controls.Add(this.txtCouponPercent);
            this.Controls.Add(this.txtCouponName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlsDemoForm";
            this.Text = "ControlsDemoForm";
            this.Load += new System.EventHandler(this.ControlsDemoForm_Load);
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
        private System.Windows.Forms.TextBox txtCouponName;
        private System.Windows.Forms.TextBox txtCouponPercent;
        private System.Windows.Forms.TextBox txtIsActive;
        private System.Windows.Forms.TextBox txtCouponID;
        private System.Windows.Forms.Button btnGetCoupon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPosition;
    }
}