namespace RO_ManualSoft
{
    partial class Form1
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
            this.termekek = new System.Windows.Forms.ToolStripMenuItem();
            this.hozzáasásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osmoPocket3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osmoPocket3ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termekek,
            this.hozzáasásToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // termekek
            // 
            this.termekek.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osmoPocket3ToolStripMenuItem});
            this.termekek.Name = "termekek";
            this.termekek.Size = new System.Drawing.Size(70, 20);
            this.termekek.Text = "Termékek";
            this.termekek.Click += new System.EventHandler(this.egyToolStripMenuItem_Click);
            // 
            // hozzáasásToolStripMenuItem
            // 
            this.hozzáasásToolStripMenuItem.Name = "hozzáasásToolStripMenuItem";
            this.hozzáasásToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hozzáasásToolStripMenuItem.Text = "Hozzáasás";
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osmoPocket3ToolStripMenuItem2});
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.törlésToolStripMenuItem.Text = "Törlés";
            // 
            // osmoPocket3ToolStripMenuItem
            // 
            this.osmoPocket3ToolStripMenuItem.Name = "osmoPocket3ToolStripMenuItem";
            this.osmoPocket3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osmoPocket3ToolStripMenuItem.Text = "Osmo Pocket 3";
            this.osmoPocket3ToolStripMenuItem.Click += new System.EventHandler(this.osmoPocket3ToolStripMenuItem_Click);
            // 
            // osmoPocket3ToolStripMenuItem2
            // 
            this.osmoPocket3ToolStripMenuItem2.Name = "osmoPocket3ToolStripMenuItem2";
            this.osmoPocket3ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.osmoPocket3ToolStripMenuItem2.Text = "Osmo Pocket 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "Form1";
            this.Text = "RO-ManualSoft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termekek;
        private System.Windows.Forms.ToolStripMenuItem hozzáasásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osmoPocket3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osmoPocket3ToolStripMenuItem2;
    }
}

