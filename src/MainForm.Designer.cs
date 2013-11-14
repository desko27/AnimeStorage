namespace AnimeStorage
{
    partial class MainForm
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
            this.ConsoleTextbox = new System.Windows.Forms.RichTextBox();
            this.MainStatusBar = new System.Windows.Forms.StatusStrip();
            this.MainProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.MainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mStoreNow = new System.Windows.Forms.ToolStripMenuItem();
            this.mRules = new System.Windows.Forms.ToolStripMenuItem();
            this.mSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mErrors = new System.Windows.Forms.ToolStripMenuItem();
            this.mCheckErrors = new System.Windows.Forms.ToolStripMenuItem();
            this.mShowInConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.mNews = new System.Windows.Forms.ToolStripMenuItem();
            this.mCheckNews = new System.Windows.Forms.ToolStripMenuItem();
            this.mConfigureRSS = new System.Windows.Forms.ToolStripMenuItem();
            this.mUpdateAfterStoring = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.MainStatusBar.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsoleTextbox
            // 
            this.ConsoleTextbox.BackColor = System.Drawing.SystemColors.WindowText;
            this.ConsoleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleTextbox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleTextbox.ForeColor = System.Drawing.SystemColors.Window;
            this.ConsoleTextbox.Location = new System.Drawing.Point(12, 12);
            this.ConsoleTextbox.Name = "ConsoleTextbox";
            this.ConsoleTextbox.ReadOnly = true;
            this.ConsoleTextbox.Size = new System.Drawing.Size(634, 228);
            this.ConsoleTextbox.TabIndex = 0;
            this.ConsoleTextbox.Text = "Waiting for an action...";
            this.ConsoleTextbox.WordWrap = false;
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainProgressBar,
            this.MainStatusLabel});
            this.MainStatusBar.Location = new System.Drawing.Point(0, 276);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Size = new System.Drawing.Size(658, 22);
            this.MainStatusBar.TabIndex = 1;
            this.MainStatusBar.Text = "statusStrip1";
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(200, 16);
            // 
            // MainStatusLabel
            // 
            this.MainStatusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainStatusLabel.Name = "MainStatusLabel";
            this.MainStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.MainStatusLabel.Text = "Ready";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mStoreNow,
            this.mRules,
            this.mSettings,
            this.mLog,
            this.mErrors,
            this.mNews});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(658, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "menuStrip1";
            // 
            // mStoreNow
            // 
            this.mStoreNow.Name = "mStoreNow";
            this.mStoreNow.Size = new System.Drawing.Size(72, 20);
            this.mStoreNow.Text = "&Store now";
            // 
            // mRules
            // 
            this.mRules.Name = "mRules";
            this.mRules.Size = new System.Drawing.Size(47, 20);
            this.mRules.Text = "&Rules";
            this.mRules.Click += new System.EventHandler(this.mRules_Click);
            // 
            // mSettings
            // 
            this.mSettings.Name = "mSettings";
            this.mSettings.Size = new System.Drawing.Size(61, 20);
            this.mSettings.Text = "Se&ttings";
            // 
            // mLog
            // 
            this.mLog.CheckOnClick = true;
            this.mLog.Name = "mLog";
            this.mLog.Size = new System.Drawing.Size(39, 20);
            this.mLog.Text = "Log";
            this.mLog.CheckedChanged += new System.EventHandler(this.mLog_CheckedChanged);
            // 
            // mErrors
            // 
            this.mErrors.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mErrors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCheckErrors,
            this.mShowInConsole});
            this.mErrors.ForeColor = System.Drawing.Color.SeaGreen;
            this.mErrors.Name = "mErrors";
            this.mErrors.Size = new System.Drawing.Size(66, 20);
            this.mErrors.Text = "(0) &errors";
            // 
            // mCheckErrors
            // 
            this.mCheckErrors.Name = "mCheckErrors";
            this.mCheckErrors.Size = new System.Drawing.Size(160, 22);
            this.mCheckErrors.Text = "&Check errors";
            // 
            // mShowInConsole
            // 
            this.mShowInConsole.BackColor = System.Drawing.SystemColors.WindowText;
            this.mShowInConsole.Checked = true;
            this.mShowInConsole.CheckOnClick = true;
            this.mShowInConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mShowInConsole.ForeColor = System.Drawing.SystemColors.Window;
            this.mShowInConsole.Name = "mShowInConsole";
            this.mShowInConsole.Size = new System.Drawing.Size(160, 22);
            this.mShowInConsole.Text = "&Show in console";
            // 
            // mNews
            // 
            this.mNews.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mNews.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCheckNews,
            this.mConfigureRSS,
            this.mUpdateAfterStoring});
            this.mNews.ForeColor = System.Drawing.Color.SeaGreen;
            this.mNews.Name = "mNews";
            this.mNews.Size = new System.Drawing.Size(63, 20);
            this.mNews.Text = "(0) &news";
            // 
            // mCheckNews
            // 
            this.mCheckNews.Name = "mCheckNews";
            this.mCheckNews.Size = new System.Drawing.Size(179, 22);
            this.mCheckNews.Text = "&Check news";
            // 
            // mConfigureRSS
            // 
            this.mConfigureRSS.Name = "mConfigureRSS";
            this.mConfigureRSS.Size = new System.Drawing.Size(179, 22);
            this.mConfigureRSS.Text = "Configure &RSS";
            // 
            // mUpdateAfterStoring
            // 
            this.mUpdateAfterStoring.BackColor = System.Drawing.Color.SteelBlue;
            this.mUpdateAfterStoring.Checked = true;
            this.mUpdateAfterStoring.CheckOnClick = true;
            this.mUpdateAfterStoring.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mUpdateAfterStoring.ForeColor = System.Drawing.SystemColors.Window;
            this.mUpdateAfterStoring.Name = "mUpdateAfterStoring";
            this.mUpdateAfterStoring.Size = new System.Drawing.Size(179, 22);
            this.mUpdateAfterStoring.Text = "&Update after storing";
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.ConsolePanel.Controls.Add(this.ConsoleTextbox);
            this.ConsolePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsolePanel.Location = new System.Drawing.Point(0, 24);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Padding = new System.Windows.Forms.Padding(12);
            this.ConsolePanel.Size = new System.Drawing.Size(658, 252);
            this.ConsolePanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 298);
            this.Controls.Add(this.ConsolePanel);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.MainStatusBar);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Anime Storage";
            this.MainStatusBar.ResumeLayout(false);
            this.MainStatusBar.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ConsolePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ConsoleTextbox;
        private System.Windows.Forms.StatusStrip MainStatusBar;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripProgressBar MainProgressBar;
        private System.Windows.Forms.ToolStripMenuItem mSettings;
        private System.Windows.Forms.ToolStripMenuItem mRules;
        private System.Windows.Forms.Panel ConsolePanel;
        private System.Windows.Forms.ToolStripStatusLabel MainStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem mNews;
        private System.Windows.Forms.ToolStripMenuItem mStoreNow;
        private System.Windows.Forms.ToolStripMenuItem mErrors;
        private System.Windows.Forms.ToolStripMenuItem mShowInConsole;
        private System.Windows.Forms.ToolStripMenuItem mCheckErrors;
        private System.Windows.Forms.ToolStripMenuItem mCheckNews;
        private System.Windows.Forms.ToolStripMenuItem mUpdateAfterStoring;
        private System.Windows.Forms.ToolStripMenuItem mConfigureRSS;
        private System.Windows.Forms.ToolStripMenuItem mLog;
    }
}

