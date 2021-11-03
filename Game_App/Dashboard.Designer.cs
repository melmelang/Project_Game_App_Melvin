namespace Game_App
{
    partial class Dashboard
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
            this.dashboardMenu = new System.Windows.Forms.MenuStrip();
            this.PlayerNameLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tikTakToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardMenu
            // 
            this.dashboardMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dashboardMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayerNameLabel,
            this.SudokuToolStripMenuItem,
            this.tikTakToeToolStripMenuItem});
            this.dashboardMenu.Location = new System.Drawing.Point(0, 0);
            this.dashboardMenu.Name = "dashboardMenu";
            this.dashboardMenu.Size = new System.Drawing.Size(800, 28);
            this.dashboardMenu.TabIndex = 4;
            this.dashboardMenu.Text = "menuStrip1";
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(63, 24);
            this.PlayerNameLabel.Text = "Player";
            // 
            // SudokuToolStripMenuItem
            // 
            this.SudokuToolStripMenuItem.Name = "SudokuToolStripMenuItem";
            this.SudokuToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.SudokuToolStripMenuItem.Text = "Sudoku";
            // 
            // tikTakToeToolStripMenuItem
            // 
            this.tikTakToeToolStripMenuItem.Name = "tikTakToeToolStripMenuItem";
            this.tikTakToeToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.tikTakToeToolStripMenuItem.Text = "Tik-Tak-Toe";
            this.tikTakToeToolStripMenuItem.Click += new System.EventHandler(this.tikTakToeToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dashboardMenu);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.dashboardMenu.ResumeLayout(false);
            this.dashboardMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip dashboardMenu;
        private System.Windows.Forms.ToolStripMenuItem PlayerNameLabel;
        private System.Windows.Forms.ToolStripMenuItem SudokuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tikTakToeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

