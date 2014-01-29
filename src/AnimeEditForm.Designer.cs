namespace AnimeStorage
{
    partial class AnimeEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimeEditForm));
            this.lOriginalName = new System.Windows.Forms.Label();
            this.tOriginalName = new System.Windows.Forms.TextBox();
            this.gRules = new System.Windows.Forms.GroupBox();
            this.listViewAnime = new System.Windows.Forms.ListView();
            this.cName = new System.Windows.Forms.ColumnHeader();
            this.cSource = new System.Windows.Forms.ColumnHeader();
            this.panelRules = new System.Windows.Forms.Panel();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelName = new System.Windows.Forms.ToolStripLabel();
            this.bNewName = new System.Windows.Forms.Button();
            this.tNewName = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelRowFolder = new System.Windows.Forms.Panel();
            this.panelFieldFolder = new System.Windows.Forms.Panel();
            this.panelField2Folder = new System.Windows.Forms.Panel();
            this.tFolder = new System.Windows.Forms.TextBox();
            this.bFolder = new System.Windows.Forms.Button();
            this.lFolder = new System.Windows.Forms.Label();
            this.panelRowNewName = new System.Windows.Forms.Panel();
            this.panelFieldNewName = new System.Windows.Forms.Panel();
            this.panelField2NewName = new System.Windows.Forms.Panel();
            this.lNewName = new System.Windows.Forms.Label();
            this.panelRowOriginalName = new System.Windows.Forms.Panel();
            this.panelFieldOriginalName = new System.Windows.Forms.Panel();
            this.gRules.SuspendLayout();
            this.panelRules.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelRowFolder.SuspendLayout();
            this.panelFieldFolder.SuspendLayout();
            this.panelField2Folder.SuspendLayout();
            this.panelRowNewName.SuspendLayout();
            this.panelFieldNewName.SuspendLayout();
            this.panelField2NewName.SuspendLayout();
            this.panelRowOriginalName.SuspendLayout();
            this.panelFieldOriginalName.SuspendLayout();
            this.SuspendLayout();
            // 
            // lOriginalName
            // 
            this.lOriginalName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lOriginalName.Location = new System.Drawing.Point(0, 0);
            this.lOriginalName.Name = "lOriginalName";
            this.lOriginalName.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lOriginalName.Size = new System.Drawing.Size(104, 19);
            this.lOriginalName.TabIndex = 0;
            this.lOriginalName.Text = "Original name";
            this.lOriginalName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tOriginalName
            // 
            this.tOriginalName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tOriginalName.Location = new System.Drawing.Point(0, 0);
            this.tOriginalName.Name = "tOriginalName";
            this.tOriginalName.Size = new System.Drawing.Size(630, 20);
            this.tOriginalName.TabIndex = 1;
            this.tOriginalName.TextChanged += new System.EventHandler(this.tOriginalName_TextChanged);
            // 
            // gRules
            // 
            this.gRules.Controls.Add(this.listViewAnime);
            this.gRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRules.Location = new System.Drawing.Point(10, 0);
            this.gRules.Name = "gRules";
            this.gRules.Padding = new System.Windows.Forms.Padding(9);
            this.gRules.Size = new System.Drawing.Size(734, 252);
            this.gRules.TabIndex = 2;
            this.gRules.TabStop = false;
            this.gRules.Text = "Custom rules";
            // 
            // listViewAnime
            // 
            this.listViewAnime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cSource});
            this.listViewAnime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAnime.FullRowSelect = true;
            this.listViewAnime.Location = new System.Drawing.Point(9, 22);
            this.listViewAnime.Name = "listViewAnime";
            this.listViewAnime.Size = new System.Drawing.Size(716, 221);
            this.listViewAnime.TabIndex = 3;
            this.listViewAnime.UseCompatibleStateImageBehavior = false;
            this.listViewAnime.View = System.Windows.Forms.View.Details;
            // 
            // cName
            // 
            this.cName.Text = "Name";
            this.cName.Width = 120;
            // 
            // cSource
            // 
            this.cSource.Text = "Folder";
            this.cSource.Width = 144;
            // 
            // panelRules
            // 
            this.panelRules.Controls.Add(this.gRules);
            this.panelRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRules.Location = new System.Drawing.Point(0, 140);
            this.panelRules.Name = "panelRules";
            this.panelRules.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panelRules.Size = new System.Drawing.Size(754, 262);
            this.panelRules.TabIndex = 0;
            // 
            // toolStripTop
            // 
            this.toolStripTop.AutoSize = false;
            this.toolStripTop.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripTop.BackgroundImage")));
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripLabelName});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Padding = new System.Windows.Forms.Padding(15, 0, 1, 0);
            this.toolStripTop.Size = new System.Drawing.Size(754, 40);
            this.toolStripTop.TabIndex = 4;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSave.ForeColor = System.Drawing.Color.White;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(82, 37);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripLabelName
            // 
            this.toolStripLabelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelName.Name = "toolStripLabelName";
            this.toolStripLabelName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripLabelName.Size = new System.Drawing.Size(95, 37);
            this.toolStripLabelName.Text = "<anime>";
            // 
            // bNewName
            // 
            this.bNewName.Dock = System.Windows.Forms.DockStyle.Left;
            this.bNewName.Location = new System.Drawing.Point(0, 0);
            this.bNewName.Name = "bNewName";
            this.bNewName.Size = new System.Drawing.Size(25, 19);
            this.bNewName.TabIndex = 0;
            this.bNewName.Text = "...";
            this.bNewName.UseVisualStyleBackColor = true;
            // 
            // tNewName
            // 
            this.tNewName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tNewName.Enabled = false;
            this.tNewName.Location = new System.Drawing.Point(7, 0);
            this.tNewName.Name = "tNewName";
            this.tNewName.Size = new System.Drawing.Size(598, 20);
            this.tNewName.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelRowFolder);
            this.panelTop.Controls.Add(this.panelRowNewName);
            this.panelTop.Controls.Add(this.panelRowOriginalName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 40);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(10);
            this.panelTop.Size = new System.Drawing.Size(754, 100);
            this.panelTop.TabIndex = 4;
            // 
            // panelRowFolder
            // 
            this.panelRowFolder.Controls.Add(this.panelFieldFolder);
            this.panelRowFolder.Controls.Add(this.lFolder);
            this.panelRowFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRowFolder.Location = new System.Drawing.Point(10, 64);
            this.panelRowFolder.Name = "panelRowFolder";
            this.panelRowFolder.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panelRowFolder.Size = new System.Drawing.Size(734, 27);
            this.panelRowFolder.TabIndex = 4;
            // 
            // panelFieldFolder
            // 
            this.panelFieldFolder.Controls.Add(this.panelField2Folder);
            this.panelFieldFolder.Controls.Add(this.bFolder);
            this.panelFieldFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFieldFolder.Location = new System.Drawing.Point(104, 0);
            this.panelFieldFolder.Name = "panelFieldFolder";
            this.panelFieldFolder.Size = new System.Drawing.Size(630, 19);
            this.panelFieldFolder.TabIndex = 3;
            // 
            // panelField2Folder
            // 
            this.panelField2Folder.Controls.Add(this.tFolder);
            this.panelField2Folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelField2Folder.Location = new System.Drawing.Point(25, 0);
            this.panelField2Folder.Name = "panelField2Folder";
            this.panelField2Folder.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.panelField2Folder.Size = new System.Drawing.Size(605, 19);
            this.panelField2Folder.TabIndex = 3;
            // 
            // tFolder
            // 
            this.tFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tFolder.Enabled = false;
            this.tFolder.Location = new System.Drawing.Point(7, 0);
            this.tFolder.Name = "tFolder";
            this.tFolder.Size = new System.Drawing.Size(598, 20);
            this.tFolder.TabIndex = 2;
            // 
            // bFolder
            // 
            this.bFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.bFolder.Location = new System.Drawing.Point(0, 0);
            this.bFolder.Name = "bFolder";
            this.bFolder.Size = new System.Drawing.Size(25, 19);
            this.bFolder.TabIndex = 0;
            this.bFolder.Text = "...";
            this.bFolder.UseVisualStyleBackColor = true;
            // 
            // lFolder
            // 
            this.lFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.lFolder.Location = new System.Drawing.Point(0, 0);
            this.lFolder.Name = "lFolder";
            this.lFolder.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lFolder.Size = new System.Drawing.Size(104, 19);
            this.lFolder.TabIndex = 0;
            this.lFolder.Text = "Default destination";
            this.lFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelRowNewName
            // 
            this.panelRowNewName.Controls.Add(this.panelFieldNewName);
            this.panelRowNewName.Controls.Add(this.lNewName);
            this.panelRowNewName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRowNewName.Location = new System.Drawing.Point(10, 37);
            this.panelRowNewName.Name = "panelRowNewName";
            this.panelRowNewName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panelRowNewName.Size = new System.Drawing.Size(734, 27);
            this.panelRowNewName.TabIndex = 3;
            // 
            // panelFieldNewName
            // 
            this.panelFieldNewName.Controls.Add(this.panelField2NewName);
            this.panelFieldNewName.Controls.Add(this.bNewName);
            this.panelFieldNewName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFieldNewName.Location = new System.Drawing.Point(104, 0);
            this.panelFieldNewName.Name = "panelFieldNewName";
            this.panelFieldNewName.Size = new System.Drawing.Size(630, 19);
            this.panelFieldNewName.TabIndex = 2;
            // 
            // panelField2NewName
            // 
            this.panelField2NewName.Controls.Add(this.tNewName);
            this.panelField2NewName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelField2NewName.Location = new System.Drawing.Point(25, 0);
            this.panelField2NewName.Name = "panelField2NewName";
            this.panelField2NewName.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.panelField2NewName.Size = new System.Drawing.Size(605, 19);
            this.panelField2NewName.TabIndex = 3;
            // 
            // lNewName
            // 
            this.lNewName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lNewName.Location = new System.Drawing.Point(0, 0);
            this.lNewName.Name = "lNewName";
            this.lNewName.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lNewName.Size = new System.Drawing.Size(104, 19);
            this.lNewName.TabIndex = 0;
            this.lNewName.Text = "New name";
            this.lNewName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelRowOriginalName
            // 
            this.panelRowOriginalName.Controls.Add(this.panelFieldOriginalName);
            this.panelRowOriginalName.Controls.Add(this.lOriginalName);
            this.panelRowOriginalName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRowOriginalName.Location = new System.Drawing.Point(10, 10);
            this.panelRowOriginalName.Name = "panelRowOriginalName";
            this.panelRowOriginalName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panelRowOriginalName.Size = new System.Drawing.Size(734, 27);
            this.panelRowOriginalName.TabIndex = 0;
            // 
            // panelFieldOriginalName
            // 
            this.panelFieldOriginalName.Controls.Add(this.tOriginalName);
            this.panelFieldOriginalName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFieldOriginalName.Location = new System.Drawing.Point(104, 0);
            this.panelFieldOriginalName.Name = "panelFieldOriginalName";
            this.panelFieldOriginalName.Size = new System.Drawing.Size(630, 19);
            this.panelFieldOriginalName.TabIndex = 2;
            // 
            // AnimeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 402);
            this.Controls.Add(this.panelRules);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.toolStripTop);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "AnimeEditForm";
            this.Text = "Editing anime element";
            this.gRules.ResumeLayout(false);
            this.panelRules.ResumeLayout(false);
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelRowFolder.ResumeLayout(false);
            this.panelFieldFolder.ResumeLayout(false);
            this.panelField2Folder.ResumeLayout(false);
            this.panelField2Folder.PerformLayout();
            this.panelRowNewName.ResumeLayout(false);
            this.panelFieldNewName.ResumeLayout(false);
            this.panelField2NewName.ResumeLayout(false);
            this.panelField2NewName.PerformLayout();
            this.panelRowOriginalName.ResumeLayout(false);
            this.panelFieldOriginalName.ResumeLayout(false);
            this.panelFieldOriginalName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lOriginalName;
        private System.Windows.Forms.TextBox tOriginalName;
        private System.Windows.Forms.GroupBox gRules;
        private System.Windows.Forms.Panel panelRules;
        private System.Windows.Forms.ListView listViewAnime;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cSource;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelName;
        private System.Windows.Forms.TextBox tNewName;
        private System.Windows.Forms.Button bNewName;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelRowOriginalName;
        private System.Windows.Forms.Panel panelFieldOriginalName;
        private System.Windows.Forms.Panel panelRowFolder;
        private System.Windows.Forms.Label lFolder;
        private System.Windows.Forms.Panel panelRowNewName;
        private System.Windows.Forms.Panel panelFieldNewName;
        private System.Windows.Forms.Label lNewName;
        private System.Windows.Forms.Panel panelField2NewName;
        private System.Windows.Forms.Panel panelFieldFolder;
        private System.Windows.Forms.Panel panelField2Folder;
        private System.Windows.Forms.TextBox tFolder;
        private System.Windows.Forms.Button bFolder;
    }
}