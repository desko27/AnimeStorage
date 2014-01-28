namespace AnimeStorage
{
    partial class AnimeForm
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
            this.tNew = new System.Windows.Forms.TextBox();
            this.bNew = new System.Windows.Forms.Button();
            this.panelNew = new System.Windows.Forms.Panel();
            this.panelNewButton = new System.Windows.Forms.Panel();
            this.listViewAnime = new System.Windows.Forms.ListView();
            this.cName = new System.Windows.Forms.ColumnHeader();
            this.cSource = new System.Windows.Forms.ColumnHeader();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panelNew.SuspendLayout();
            this.panelNewButton.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tNew
            // 
            this.tNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNew.Location = new System.Drawing.Point(0, 0);
            this.tNew.Name = "tNew";
            this.tNew.Size = new System.Drawing.Size(372, 20);
            this.tNew.TabIndex = 0;
            this.tNew.TextChanged += new System.EventHandler(this.tNew_TextChanged);
            this.tNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tNew_KeyDown);
            // 
            // bNew
            // 
            this.bNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bNew.Enabled = false;
            this.bNew.Location = new System.Drawing.Point(11, 0);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(51, 20);
            this.bNew.TabIndex = 1;
            this.bNew.Text = "Add";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // panelNew
            // 
            this.panelNew.Controls.Add(this.tNew);
            this.panelNew.Controls.Add(this.panelNewButton);
            this.panelNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNew.Location = new System.Drawing.Point(10, 10);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(434, 20);
            this.panelNew.TabIndex = 2;
            // 
            // panelNewButton
            // 
            this.panelNewButton.Controls.Add(this.bNew);
            this.panelNewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNewButton.Location = new System.Drawing.Point(372, 0);
            this.panelNewButton.Name = "panelNewButton";
            this.panelNewButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.panelNewButton.Size = new System.Drawing.Size(62, 20);
            this.panelNewButton.TabIndex = 5;
            // 
            // listViewAnime
            // 
            this.listViewAnime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cSource});
            this.listViewAnime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAnime.FullRowSelect = true;
            this.listViewAnime.Location = new System.Drawing.Point(0, 11);
            this.listViewAnime.Name = "listViewAnime";
            this.listViewAnime.Size = new System.Drawing.Size(434, 228);
            this.listViewAnime.TabIndex = 2;
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
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.listViewAnime);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(10, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.MainPanel.Size = new System.Drawing.Size(434, 239);
            this.MainPanel.TabIndex = 4;
            // 
            // AnimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 279);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelNew);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnimeForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Anime";
            this.panelNew.ResumeLayout(false);
            this.panelNew.PerformLayout();
            this.panelNewButton.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tNew;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Panel panelNew;
        private System.Windows.Forms.ListView listViewAnime;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panelNewButton;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cSource;
    }
}