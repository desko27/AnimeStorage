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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.kryptonGlobals = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.panelMenu = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flowLayoutMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStoreNow = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            this.menuDownloads = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            this.menuSettings = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menuLastOnes = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            this.menuConsole = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.splitContainerMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.headerGroupAnime = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.splitContainerRight = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.headerGroupEpisodes = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.headerGroupProperties = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenu)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.flowLayoutMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain.Panel1)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain.Panel2)).BeginInit();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupAnime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupAnime.Panel)).BeginInit();
            this.headerGroupAnime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight.Panel1)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight.Panel2)).BeginInit();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupEpisodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupEpisodes.Panel)).BeginInit();
            this.headerGroupEpisodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupProperties.Panel)).BeginInit();
            this.headerGroupProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.flowLayoutMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelMenu.Size = new System.Drawing.Size(791, 52);
            this.panelMenu.TabIndex = 0;
            // 
            // flowLayoutMenu
            // 
            this.flowLayoutMenu.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutMenu.Controls.Add(this.menuStoreNow);
            this.flowLayoutMenu.Controls.Add(this.menuDownloads);
            this.flowLayoutMenu.Controls.Add(this.menuSettings);
            this.flowLayoutMenu.Controls.Add(this.menuLastOnes);
            this.flowLayoutMenu.Controls.Add(this.menuConsole);
            this.flowLayoutMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutMenu.Name = "flowLayoutMenu";
            this.flowLayoutMenu.Size = new System.Drawing.Size(791, 47);
            this.flowLayoutMenu.TabIndex = 1;
            this.flowLayoutMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutMenu_MouseDown);
            // 
            // menuStoreNow
            // 
            this.menuStoreNow.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.menuStoreNow.Location = new System.Drawing.Point(0, 0);
            this.menuStoreNow.Margin = new System.Windows.Forms.Padding(0);
            this.menuStoreNow.Name = "menuStoreNow";
            this.menuStoreNow.Size = new System.Drawing.Size(130, 47);
            this.menuStoreNow.TabIndex = 3;
            this.menuStoreNow.Values.Image = ((System.Drawing.Image)(resources.GetObject("menuStoreNow.Values.Image")));
            this.menuStoreNow.Values.Text = "Store now!";
            // 
            // menuDownloads
            // 
            this.menuDownloads.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.menuDownloads.Location = new System.Drawing.Point(135, 0);
            this.menuDownloads.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menuDownloads.Name = "menuDownloads";
            this.menuDownloads.Size = new System.Drawing.Size(130, 47);
            this.menuDownloads.Splitter = false;
            this.menuDownloads.TabIndex = 1;
            this.menuDownloads.Values.Image = ((System.Drawing.Image)(resources.GetObject("menuDownloads.Values.Image")));
            this.menuDownloads.Values.Text = "Downloads";
            // 
            // menuSettings
            // 
            this.menuSettings.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.menuSettings.Location = new System.Drawing.Point(270, 0);
            this.menuSettings.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(104, 47);
            this.menuSettings.TabIndex = 0;
            this.menuSettings.Values.Image = ((System.Drawing.Image)(resources.GetObject("menuSettings.Values.Image")));
            this.menuSettings.Values.Text = "Settings";
            // 
            // menuLastOnes
            // 
            this.menuLastOnes.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.menuLastOnes.Location = new System.Drawing.Point(379, 0);
            this.menuLastOnes.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menuLastOnes.Name = "menuLastOnes";
            this.menuLastOnes.Size = new System.Drawing.Size(112, 47);
            this.menuLastOnes.Splitter = false;
            this.menuLastOnes.TabIndex = 2;
            this.menuLastOnes.Values.Image = ((System.Drawing.Image)(resources.GetObject("menuLastOnes.Values.Image")));
            this.menuLastOnes.Values.Text = "Last ones";
            // 
            // menuConsole
            // 
            this.menuConsole.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.menuConsole.Location = new System.Drawing.Point(496, 0);
            this.menuConsole.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menuConsole.Name = "menuConsole";
            this.menuConsole.Size = new System.Drawing.Size(104, 47);
            this.menuConsole.TabIndex = 4;
            this.menuConsole.Values.Image = ((System.Drawing.Image)(resources.GetObject("menuConsole.Values.Image")));
            this.menuConsole.Values.Text = "Console";
            this.menuConsole.Click += new System.EventHandler(this.menuConsole_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 52);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.headerGroupAnime);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerRight);
            this.splitContainerMain.Size = new System.Drawing.Size(791, 418);
            this.splitContainerMain.SplitterDistance = 395;
            this.splitContainerMain.TabIndex = 1;
            this.splitContainerMain.DoubleClick += new System.EventHandler(this.splitContainerMain_DoubleClick);
            // 
            // headerGroupAnime
            // 
            this.headerGroupAnime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerGroupAnime.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.headerGroupAnime.Location = new System.Drawing.Point(0, 0);
            this.headerGroupAnime.Name = "headerGroupAnime";
            this.headerGroupAnime.Size = new System.Drawing.Size(395, 418);
            this.headerGroupAnime.TabIndex = 0;
            this.headerGroupAnime.ValuesPrimary.Heading = "Anime";
            this.headerGroupAnime.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("headerGroupAnime.ValuesPrimary.Image")));
            this.headerGroupAnime.ValuesSecondary.Heading = "Your full anime list";
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            this.splitContainerRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.headerGroupEpisodes);
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.headerGroupProperties);
            this.splitContainerRight.Size = new System.Drawing.Size(391, 418);
            this.splitContainerRight.SplitterDistance = 209;
            this.splitContainerRight.TabIndex = 0;
            this.splitContainerRight.DoubleClick += new System.EventHandler(this.splitContainerRight_DoubleClick);
            // 
            // headerGroupEpisodes
            // 
            this.headerGroupEpisodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerGroupEpisodes.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.headerGroupEpisodes.Location = new System.Drawing.Point(0, 0);
            this.headerGroupEpisodes.Name = "headerGroupEpisodes";
            this.headerGroupEpisodes.Size = new System.Drawing.Size(391, 209);
            this.headerGroupEpisodes.TabIndex = 0;
            this.headerGroupEpisodes.ValuesPrimary.Heading = "Episodes";
            this.headerGroupEpisodes.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("headerGroupEpisodes.ValuesPrimary.Image")));
            this.headerGroupEpisodes.ValuesSecondary.Heading = "Episodes of the selected anime";
            // 
            // headerGroupProperties
            // 
            this.headerGroupProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerGroupProperties.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlToolTip;
            this.headerGroupProperties.Location = new System.Drawing.Point(0, 0);
            this.headerGroupProperties.Name = "headerGroupProperties";
            this.headerGroupProperties.Size = new System.Drawing.Size(391, 204);
            this.headerGroupProperties.TabIndex = 0;
            this.headerGroupProperties.ValuesPrimary.Heading = "Properties";
            this.headerGroupProperties.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("headerGroupProperties.ValuesPrimary.Image")));
            this.headerGroupProperties.ValuesSecondary.Heading = "Properties of the selected item";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 470);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(630, 400);
            this.Name = "MainForm";
            this.Text = "Anime Storage";
            ((System.ComponentModel.ISupportInitialize)(this.panelMenu)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.flowLayoutMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain.Panel1)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain.Panel2)).EndInit();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupAnime.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupAnime)).EndInit();
            this.headerGroupAnime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight.Panel1)).EndInit();
            this.splitContainerRight.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight.Panel2)).EndInit();
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupEpisodes.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupEpisodes)).EndInit();
            this.headerGroupEpisodes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupProperties.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerGroupProperties)).EndInit();
            this.headerGroupProperties.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonGlobals;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton menuSettings;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainerMain;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainerRight;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup headerGroupAnime;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup headerGroupEpisodes;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup headerGroupProperties;
        private ComponentFactory.Krypton.Toolkit.KryptonDropButton menuDownloads;
        private ComponentFactory.Krypton.Toolkit.KryptonDropButton menuLastOnes;
        private ComponentFactory.Krypton.Toolkit.KryptonDropButton menuStoreNow;
        private ComponentFactory.Krypton.Toolkit.KryptonButton menuConsole;
    }
}