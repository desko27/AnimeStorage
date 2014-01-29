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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAnime = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDownloads = new System.Windows.Forms.ToolStripButton();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripTop
            // 
            this.toolStripTop.AutoSize = false;
            this.toolStripTop.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripTop.BackgroundImage")));
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAnime,
            this.toolStripButtonDownloads,
            this.toolStripButtonSettings});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Padding = new System.Windows.Forms.Padding(15, 0, 1, 0);
            this.toolStripTop.Size = new System.Drawing.Size(497, 40);
            this.toolStripTop.TabIndex = 5;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // toolStripButtonAnime
            // 
            this.toolStripButtonAnime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonAnime.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonAnime.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAnime.Image")));
            this.toolStripButtonAnime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAnime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnime.Name = "toolStripButtonAnime";
            this.toolStripButtonAnime.Size = new System.Drawing.Size(96, 37);
            this.toolStripButtonAnime.Text = "Anime";
            this.toolStripButtonAnime.Click += new System.EventHandler(this.toolStripButtonAnime_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSettings.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(108, 37);
            this.toolStripButtonSettings.Text = "Settings";
            // 
            // toolStripButtonDownloads
            // 
            this.toolStripButtonDownloads.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonDownloads.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonDownloads.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDownloads.Image")));
            this.toolStripButtonDownloads.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonDownloads.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDownloads.Name = "toolStripButtonDownloads";
            this.toolStripButtonDownloads.Size = new System.Drawing.Size(132, 37);
            this.toolStripButtonDownloads.Text = "Downloads";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(497, 265);
            this.Controls.Add(this.toolStripTop);
            this.Name = "MainForm";
            this.Text = "Anime Storage";
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnime;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripButton toolStripButtonDownloads;


    }
}

