namespace MarketHelp
{
    partial class Izbornik_prodavac
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
            this.računiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rokTrajanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uputeF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.računiToolStripMenuItem,
            this.rokTrajanjaToolStripMenuItem,
            this.uputeF1ToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // računiToolStripMenuItem
            // 
            this.računiToolStripMenuItem.Name = "računiToolStripMenuItem";
            this.računiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.računiToolStripMenuItem.Text = "Računi";
            this.računiToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.računiToolStripMenuItem_MouseUp);
            // 
            // rokTrajanjaToolStripMenuItem
            // 
            this.rokTrajanjaToolStripMenuItem.Name = "rokTrajanjaToolStripMenuItem";
            this.rokTrajanjaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.rokTrajanjaToolStripMenuItem.Text = "Rok trajanja";
            this.rokTrajanjaToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rokTrajanjaToolStripMenuItem_MouseUp);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.odjavaToolStripMenuItem_MouseUp);
            // 
            // uputeF1ToolStripMenuItem
            // 
            this.uputeF1ToolStripMenuItem.Name = "uputeF1ToolStripMenuItem";
            this.uputeF1ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.uputeF1ToolStripMenuItem.Text = "Upute(F1)";
            this.uputeF1ToolStripMenuItem.Click += new System.EventHandler(this.uputeF1ToolStripMenuItem_Click);
            // 
            // Izbornik_prodavac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Izbornik_prodavac";
            this.Text = "Izbornik";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Izbornik_prodavac_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rokTrajanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uputeF1ToolStripMenuItem;
    }
}