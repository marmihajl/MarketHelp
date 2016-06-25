namespace MarketHelp
{
    partial class Izbornik
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
            this.narudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljačiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rokTrajanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plaćeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uputeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.računiToolStripMenuItem,
            this.narudžbeToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.dobavljačiToolStripMenuItem,
            this.rokTrajanjaToolStripMenuItem,
            this.plaćeToolStripMenuItem,
            this.uputeToolStripMenuItem,
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
            // narudžbeToolStripMenuItem
            // 
            this.narudžbeToolStripMenuItem.Name = "narudžbeToolStripMenuItem";
            this.narudžbeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narudžbeToolStripMenuItem.Text = "Narudžbe";
            this.narudžbeToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.narudžbeToolStripMenuItem_MouseUp);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.korisniciToolStripMenuItem_MouseUp);
            // 
            // dobavljačiToolStripMenuItem
            // 
            this.dobavljačiToolStripMenuItem.Name = "dobavljačiToolStripMenuItem";
            this.dobavljačiToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.dobavljačiToolStripMenuItem.Text = "Dobavljači";
            this.dobavljačiToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dobavljačiToolStripMenuItem_MouseUp);
            // 
            // rokTrajanjaToolStripMenuItem
            // 
            this.rokTrajanjaToolStripMenuItem.Name = "rokTrajanjaToolStripMenuItem";
            this.rokTrajanjaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.rokTrajanjaToolStripMenuItem.Text = "Rok trajanja";
            this.rokTrajanjaToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rokTrajanjaToolStripMenuItem_MouseUp);
            // 
            // plaćeToolStripMenuItem
            // 
            this.plaćeToolStripMenuItem.Name = "plaćeToolStripMenuItem";
            this.plaćeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.plaćeToolStripMenuItem.Text = "Plaće";
            this.plaćeToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plaćeToolStripMenuItem_MouseUp);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.odjavaToolStripMenuItem_MouseUp);
            // 
            // uputeToolStripMenuItem
            // 
            this.uputeToolStripMenuItem.Name = "uputeToolStripMenuItem";
            this.uputeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.uputeToolStripMenuItem.Text = "Upute(F1)";
            this.uputeToolStripMenuItem.Click += new System.EventHandler(this.uputeToolStripMenuItem_Click);
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Izbornik";
            this.Text = "Izbornik";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Izbornik_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem računiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljačiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rokTrajanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plaćeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uputeToolStripMenuItem;
    }
}