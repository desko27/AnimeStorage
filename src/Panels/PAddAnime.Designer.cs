namespace AnimeStorage.Panels
{
    partial class PAddAnime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PAddAnime));
            this.rowName = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.flPanelFinal = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bAccept = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chkAniDB = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.lName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rowFansub = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cbFansub = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pManageFansubs = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bManageFansubs = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lFansub = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rowFolder = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tFolder = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pCreateFolder = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.chkCreateFolder = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.pExplore = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bExplore = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lFolder = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kBorder = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            ((System.ComponentModel.ISupportInitialize)(this.rowName)).BeginInit();
            this.rowName.SuspendLayout();
            this.flPanelFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowFansub)).BeginInit();
            this.rowFansub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFansub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pManageFansubs)).BeginInit();
            this.pManageFansubs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowFolder)).BeginInit();
            this.rowFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCreateFolder)).BeginInit();
            this.pCreateFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pExplore)).BeginInit();
            this.pExplore.SuspendLayout();
            this.SuspendLayout();
            // 
            // rowName
            // 
            this.rowName.Controls.Add(this.tName);
            this.rowName.Controls.Add(this.flPanelFinal);
            this.rowName.Controls.Add(this.lName);
            this.rowName.Dock = System.Windows.Forms.DockStyle.Top;
            this.rowName.Location = new System.Drawing.Point(0, 0);
            this.rowName.Name = "rowName";
            this.rowName.Padding = new System.Windows.Forms.Padding(7, 7, 7, 0);
            this.rowName.Size = new System.Drawing.Size(405, 30);
            this.rowName.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.rowName.TabIndex = 0;
            // 
            // tName
            // 
            this.tName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tName.Location = new System.Drawing.Point(67, 7);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(182, 23);
            this.tName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.tName.TabIndex = 1;
            this.tName.TextChanged += new System.EventHandler(this.valuesValidation);
            this.tName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tName_KeyDown);
            // 
            // flPanelFinal
            // 
            this.flPanelFinal.Controls.Add(this.bCancel);
            this.flPanelFinal.Controls.Add(this.bAccept);
            this.flPanelFinal.Controls.Add(this.chkAniDB);
            this.flPanelFinal.Dock = System.Windows.Forms.DockStyle.Right;
            this.flPanelFinal.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flPanelFinal.Location = new System.Drawing.Point(249, 7);
            this.flPanelFinal.Name = "flPanelFinal";
            this.flPanelFinal.Size = new System.Drawing.Size(149, 23);
            this.flPanelFinal.TabIndex = 2;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(122, 0);
            this.bCancel.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(27, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Values.Image = ((System.Drawing.Image)(resources.GetObject("bCancel.Values.Image")));
            this.bCancel.Values.Text = "";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAccept
            // 
            this.bAccept.Enabled = false;
            this.bAccept.Location = new System.Drawing.Point(88, 0);
            this.bAccept.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(27, 23);
            this.bAccept.TabIndex = 0;
            this.bAccept.Values.Image = ((System.Drawing.Image)(resources.GetObject("bAccept.Values.Image")));
            this.bAccept.Values.Text = "";
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // chkAniDB
            // 
            this.chkAniDB.Checked = true;
            this.chkAniDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAniDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAniDB.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.chkAniDB.Location = new System.Drawing.Point(10, 0);
            this.chkAniDB.Margin = new System.Windows.Forms.Padding(0);
            this.chkAniDB.Name = "chkAniDB";
            this.chkAniDB.Size = new System.Drawing.Size(71, 24);
            this.chkAniDB.TabIndex = 2;
            this.chkAniDB.Values.Image = ((System.Drawing.Image)(resources.GetObject("chkAniDB.Values.Image")));
            this.chkAniDB.Values.Text = "";
            this.chkAniDB.CheckedChanged += new System.EventHandler(this.chkAniDB_CheckedChanged);
            // 
            // lName
            // 
            this.lName.AutoSize = false;
            this.lName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lName.Location = new System.Drawing.Point(7, 7);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(60, 23);
            this.lName.TabIndex = 0;
            this.lName.Values.Text = "Name";
            // 
            // rowFansub
            // 
            this.rowFansub.Controls.Add(this.cbFansub);
            this.rowFansub.Controls.Add(this.pManageFansubs);
            this.rowFansub.Controls.Add(this.lFansub);
            this.rowFansub.Dock = System.Windows.Forms.DockStyle.Top;
            this.rowFansub.Location = new System.Drawing.Point(0, 30);
            this.rowFansub.Name = "rowFansub";
            this.rowFansub.Padding = new System.Windows.Forms.Padding(7, 7, 7, 0);
            this.rowFansub.Size = new System.Drawing.Size(405, 30);
            this.rowFansub.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.rowFansub.TabIndex = 1;
            // 
            // cbFansub
            // 
            this.cbFansub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFansub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFansub.DropDownWidth = 335;
            this.cbFansub.Items.AddRange(new object[] {
            "Backbeard",
            "HorribleSubs",
            "Inshuheki"});
            this.cbFansub.Location = new System.Drawing.Point(67, 7);
            this.cbFansub.Name = "cbFansub";
            this.cbFansub.Size = new System.Drawing.Size(297, 23);
            this.cbFansub.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbFansub.StateCommon.ComboBox.Border.Rounding = 4;
            this.cbFansub.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbFansub.TabIndex = 1;
            this.cbFansub.SelectionChangeCommitted += new System.EventHandler(this.valuesValidation);
            // 
            // pManageFansubs
            // 
            this.pManageFansubs.Controls.Add(this.bManageFansubs);
            this.pManageFansubs.Dock = System.Windows.Forms.DockStyle.Right;
            this.pManageFansubs.Location = new System.Drawing.Point(364, 7);
            this.pManageFansubs.Name = "pManageFansubs";
            this.pManageFansubs.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.pManageFansubs.Size = new System.Drawing.Size(34, 23);
            this.pManageFansubs.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pManageFansubs.TabIndex = 2;
            // 
            // bManageFansubs
            // 
            this.bManageFansubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bManageFansubs.Location = new System.Drawing.Point(7, 0);
            this.bManageFansubs.Name = "bManageFansubs";
            this.bManageFansubs.Size = new System.Drawing.Size(27, 23);
            this.bManageFansubs.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bManageFansubs.TabIndex = 0;
            this.bManageFansubs.Values.Image = ((System.Drawing.Image)(resources.GetObject("bManageFansubs.Values.Image")));
            this.bManageFansubs.Values.Text = "";
            // 
            // lFansub
            // 
            this.lFansub.AutoSize = false;
            this.lFansub.Dock = System.Windows.Forms.DockStyle.Left;
            this.lFansub.Location = new System.Drawing.Point(7, 7);
            this.lFansub.Name = "lFansub";
            this.lFansub.Size = new System.Drawing.Size(60, 23);
            this.lFansub.TabIndex = 0;
            this.lFansub.Values.Text = "Fansub";
            // 
            // rowFolder
            // 
            this.rowFolder.Controls.Add(this.tFolder);
            this.rowFolder.Controls.Add(this.pCreateFolder);
            this.rowFolder.Controls.Add(this.pExplore);
            this.rowFolder.Controls.Add(this.lFolder);
            this.rowFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.rowFolder.Location = new System.Drawing.Point(0, 60);
            this.rowFolder.Name = "rowFolder";
            this.rowFolder.Padding = new System.Windows.Forms.Padding(7);
            this.rowFolder.Size = new System.Drawing.Size(405, 37);
            this.rowFolder.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.rowFolder.TabIndex = 2;
            // 
            // tFolder
            // 
            this.tFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tFolder.Location = new System.Drawing.Point(101, 7);
            this.tFolder.Name = "tFolder";
            this.tFolder.Size = new System.Drawing.Size(211, 23);
            this.tFolder.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.tFolder.TabIndex = 2;
            // 
            // pCreateFolder
            // 
            this.pCreateFolder.Controls.Add(this.chkCreateFolder);
            this.pCreateFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pCreateFolder.Location = new System.Drawing.Point(312, 7);
            this.pCreateFolder.Name = "pCreateFolder";
            this.pCreateFolder.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.pCreateFolder.Size = new System.Drawing.Size(86, 23);
            this.pCreateFolder.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pCreateFolder.TabIndex = 3;
            // 
            // chkCreateFolder
            // 
            this.chkCreateFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkCreateFolder.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.chkCreateFolder.Location = new System.Drawing.Point(7, 0);
            this.chkCreateFolder.Name = "chkCreateFolder";
            this.chkCreateFolder.Size = new System.Drawing.Size(79, 23);
            this.chkCreateFolder.TabIndex = 0;
            this.chkCreateFolder.Text = "Create";
            this.chkCreateFolder.Values.Image = ((System.Drawing.Image)(resources.GetObject("chkCreateFolder.Values.Image")));
            this.chkCreateFolder.Values.Text = "Create";
            this.chkCreateFolder.CheckedChanged += new System.EventHandler(this.chkCreateFolder_CheckedChanged);
            // 
            // pExplore
            // 
            this.pExplore.Controls.Add(this.bExplore);
            this.pExplore.Dock = System.Windows.Forms.DockStyle.Left;
            this.pExplore.Location = new System.Drawing.Point(67, 7);
            this.pExplore.Name = "pExplore";
            this.pExplore.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.pExplore.Size = new System.Drawing.Size(34, 23);
            this.pExplore.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pExplore.TabIndex = 1;
            // 
            // bExplore
            // 
            this.bExplore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bExplore.Location = new System.Drawing.Point(0, 0);
            this.bExplore.Name = "bExplore";
            this.bExplore.Size = new System.Drawing.Size(27, 23);
            this.bExplore.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExplore.TabIndex = 0;
            this.bExplore.Values.Image = ((System.Drawing.Image)(resources.GetObject("bExplore.Values.Image")));
            this.bExplore.Values.Text = "";
            // 
            // lFolder
            // 
            this.lFolder.AutoSize = false;
            this.lFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.lFolder.Location = new System.Drawing.Point(7, 7);
            this.lFolder.Name = "lFolder";
            this.lFolder.Size = new System.Drawing.Size(60, 23);
            this.lFolder.TabIndex = 0;
            this.lFolder.Values.Text = "Folder";
            // 
            // kBorder
            // 
            this.kBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kBorder.Location = new System.Drawing.Point(0, 97);
            this.kBorder.Name = "kBorder";
            this.kBorder.Size = new System.Drawing.Size(405, 1);
            this.kBorder.Text = "kryptonBorderEdge1";
            // 
            // PAddAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 98);
            this.Controls.Add(this.kBorder);
            this.Controls.Add(this.rowFolder);
            this.Controls.Add(this.rowFansub);
            this.Controls.Add(this.rowName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PAddAnime";
            this.Text = "PNewAnime";
            this.Shown += new System.EventHandler(this.PNewAnime_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.rowName)).EndInit();
            this.rowName.ResumeLayout(false);
            this.rowName.PerformLayout();
            this.flPanelFinal.ResumeLayout(false);
            this.flPanelFinal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowFansub)).EndInit();
            this.rowFansub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbFansub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pManageFansubs)).EndInit();
            this.pManageFansubs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rowFolder)).EndInit();
            this.rowFolder.ResumeLayout(false);
            this.rowFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCreateFolder)).EndInit();
            this.pCreateFolder.ResumeLayout(false);
            this.pCreateFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pExplore)).EndInit();
            this.pExplore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel rowName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tName;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel rowFansub;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel rowFolder;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lFansub;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pManageFansubs;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbFansub;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bManageFansubs;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bAccept;
        private System.Windows.Forms.FlowLayoutPanel flPanelFinal;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pExplore;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bExplore;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tFolder;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lFolder;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pCreateFolder;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkCreateFolder;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lName;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kBorder;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkAniDB;
    }
}