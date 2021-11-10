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
            this.components = new System.ComponentModel.Container();
            this.dashboardMenu = new System.Windows.Forms.MenuStrip();
            this.PlayerNameLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SudokuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tikTakToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.game_App_DbDataSet = new Game_App.Game_App_DbDataSet();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerTableAdapter = new Game_App.Game_App_DbDataSetTableAdapters.PlayerTableAdapter();
            this.tableAdapterManager = new Game_App.Game_App_DbDataSetTableAdapters.TableAdapterManager();
            this.TicTacToeScoreboard = new System.Windows.Forms.GroupBox();
            this.Loses = new System.Windows.Forms.Label();
            this.Wins = new System.Windows.Forms.Label();
            this.SudokuScoreboard = new System.Windows.Forms.GroupBox();
            this.SudokuScoreList = new System.Windows.Forms.ListBox();
            this.MenuDashboard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gamezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sudokuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tikTakToeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.game_App_DbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.TicTacToeScoreboard.SuspendLayout();
            this.SudokuScoreboard.SuspendLayout();
            this.MenuDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardMenu
            // 
            this.dashboardMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dashboardMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayerNameLabel,
            this.SudokuToolStripMenuItem,
            this.tikTakToeToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.dashboardMenu.Location = new System.Drawing.Point(0, 0);
            this.dashboardMenu.Name = "dashboardMenu";
            this.dashboardMenu.Size = new System.Drawing.Size(1538, 30);
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
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // SudokuToolStripMenuItem
            // 
            this.SudokuToolStripMenuItem.Name = "SudokuToolStripMenuItem";
            this.SudokuToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.SudokuToolStripMenuItem.Text = "Sudoku";
            this.SudokuToolStripMenuItem.Click += new System.EventHandler(this.SudokuToolStripMenuItem_Click);
            // 
            // tikTakToeToolStripMenuItem
            // 
            this.tikTakToeToolStripMenuItem.Name = "tikTakToeToolStripMenuItem";
            this.tikTakToeToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.tikTakToeToolStripMenuItem.Text = "Tik-Tak-Toe";
            this.tikTakToeToolStripMenuItem.Click += new System.EventHandler(this.tikTakToeToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // game_App_DbDataSet
            // 
            this.game_App_DbDataSet.DataSetName = "Game_App_DbDataSet";
            this.game_App_DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.game_App_DbDataSet;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayerTableAdapter = this.playerTableAdapter;
            this.tableAdapterManager.SudokuTableAdapter = null;
            this.tableAdapterManager.TicTacToeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Game_App.Game_App_DbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TicTacToeScoreboard
            // 
            this.TicTacToeScoreboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TicTacToeScoreboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TicTacToeScoreboard.Controls.Add(this.Loses);
            this.TicTacToeScoreboard.Controls.Add(this.Wins);
            this.TicTacToeScoreboard.Location = new System.Drawing.Point(28, 45);
            this.TicTacToeScoreboard.Name = "TicTacToeScoreboard";
            this.TicTacToeScoreboard.Size = new System.Drawing.Size(219, 178);
            this.TicTacToeScoreboard.TabIndex = 5;
            this.TicTacToeScoreboard.TabStop = false;
            this.TicTacToeScoreboard.Text = "Tic-Tac-Toe Scoreboard";
            // 
            // Loses
            // 
            this.Loses.AutoSize = true;
            this.Loses.Location = new System.Drawing.Point(51, 115);
            this.Loses.Name = "Loses";
            this.Loses.Size = new System.Drawing.Size(47, 16);
            this.Loses.TabIndex = 1;
            this.Loses.Text = "Loses:";
            // 
            // Wins
            // 
            this.Wins.AutoSize = true;
            this.Wins.Location = new System.Drawing.Point(58, 62);
            this.Wins.Name = "Wins";
            this.Wins.Size = new System.Drawing.Size(40, 16);
            this.Wins.TabIndex = 0;
            this.Wins.Text = "Wins:";
            // 
            // SudokuScoreboard
            // 
            this.SudokuScoreboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SudokuScoreboard.Controls.Add(this.SudokuScoreList);
            this.SudokuScoreboard.Location = new System.Drawing.Point(279, 45);
            this.SudokuScoreboard.Name = "SudokuScoreboard";
            this.SudokuScoreboard.Size = new System.Drawing.Size(328, 364);
            this.SudokuScoreboard.TabIndex = 6;
            this.SudokuScoreboard.TabStop = false;
            this.SudokuScoreboard.Text = "Sudoku Scoreboard";
            // 
            // SudokuScoreList
            // 
            this.SudokuScoreList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SudokuScoreList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SudokuScoreList.FormattingEnabled = true;
            this.SudokuScoreList.ItemHeight = 16;
            this.SudokuScoreList.Location = new System.Drawing.Point(27, 22);
            this.SudokuScoreList.Name = "SudokuScoreList";
            this.SudokuScoreList.Size = new System.Drawing.Size(295, 336);
            this.SudokuScoreList.TabIndex = 0;
            // 
            // MenuDashboard
            // 
            this.MenuDashboard.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem1,
            this.gamezToolStripMenuItem,
            this.disconnectToolStripMenuItem1,
            this.closeToolStripMenuItem1});
            this.MenuDashboard.Name = "MenuDashboard";
            this.MenuDashboard.Size = new System.Drawing.Size(152, 100);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(151, 24);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // gamezToolStripMenuItem
            // 
            this.gamezToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sudokuToolStripMenuItem1,
            this.tikTakToeToolStripMenuItem1});
            this.gamezToolStripMenuItem.Name = "gamezToolStripMenuItem";
            this.gamezToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.gamezToolStripMenuItem.Text = "Games";
            // 
            // sudokuToolStripMenuItem1
            // 
            this.sudokuToolStripMenuItem1.Name = "sudokuToolStripMenuItem1";
            this.sudokuToolStripMenuItem1.Size = new System.Drawing.Size(168, 26);
            this.sudokuToolStripMenuItem1.Text = "Sudoku";
            this.sudokuToolStripMenuItem1.Click += new System.EventHandler(this.SudokuToolStripMenuItem_Click);
            // 
            // tikTakToeToolStripMenuItem1
            // 
            this.tikTakToeToolStripMenuItem1.Name = "tikTakToeToolStripMenuItem1";
            this.tikTakToeToolStripMenuItem1.Size = new System.Drawing.Size(168, 26);
            this.tikTakToeToolStripMenuItem1.Text = "Tik-Tak-Toe";
            this.tikTakToeToolStripMenuItem1.Click += new System.EventHandler(this.tikTakToeToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem1
            // 
            this.disconnectToolStripMenuItem1.Name = "disconnectToolStripMenuItem1";
            this.disconnectToolStripMenuItem1.Size = new System.Drawing.Size(151, 24);
            this.disconnectToolStripMenuItem1.Text = "Disconnect";
            this.disconnectToolStripMenuItem1.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(151, 24);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 665);
            this.ContextMenuStrip = this.MenuDashboard;
            this.Controls.Add(this.SudokuScoreboard);
            this.Controls.Add(this.TicTacToeScoreboard);
            this.Controls.Add(this.dashboardMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.dashboardMenu;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.dashboardMenu.ResumeLayout(false);
            this.dashboardMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.game_App_DbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.TicTacToeScoreboard.ResumeLayout(false);
            this.TicTacToeScoreboard.PerformLayout();
            this.SudokuScoreboard.ResumeLayout(false);
            this.MenuDashboard.ResumeLayout(false);
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
        private Game_App_DbDataSet game_App_DbDataSet;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private Game_App_DbDataSetTableAdapters.PlayerTableAdapter playerTableAdapter;
        private Game_App_DbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox TicTacToeScoreboard;
        private System.Windows.Forms.Label Loses;
        private System.Windows.Forms.Label Wins;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.GroupBox SudokuScoreboard;
        private System.Windows.Forms.ListBox SudokuScoreList;
        private System.Windows.Forms.ContextMenuStrip MenuDashboard;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gamezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sudokuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tikTakToeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
    }
}

