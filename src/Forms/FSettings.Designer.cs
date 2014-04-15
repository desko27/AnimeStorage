namespace AnimeStorage
{
    partial class FSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSettings));
            this.gbStyles = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lTheme = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.cbTheme = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lListFore = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.cListFore = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.lListBack = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.cListBack = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.lSelectedBack = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.cSelectedBack = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.lSelectedFore = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.cSelectedFore = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.pWrapper = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gbGeneral = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lLanguage = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.cbLanguage = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.bClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonWrapLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonWrapLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonWrapLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonColorButton1 = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.kryptonWrapLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonColorButton2 = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.kryptonWrapLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.kryptonColorButton3 = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            ((System.ComponentModel.ISupportInitialize)(this.gbStyles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStyles.Panel)).BeginInit();
            this.gbStyles.Panel.SuspendLayout();
            this.gbStyles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWrapper)).BeginInit();
            this.pWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbGeneral.Panel)).BeginInit();
            this.gbGeneral.Panel.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStyles
            // 
            this.gbStyles.Location = new System.Drawing.Point(258, 12);
            this.gbStyles.Name = "gbStyles";
            // 
            // gbStyles.Panel
            // 
            this.gbStyles.Panel.Controls.Add(this.lTheme);
            this.gbStyles.Panel.Controls.Add(this.cbTheme);
            this.gbStyles.Panel.Controls.Add(this.lListFore);
            this.gbStyles.Panel.Controls.Add(this.cListFore);
            this.gbStyles.Panel.Controls.Add(this.lListBack);
            this.gbStyles.Panel.Controls.Add(this.cListBack);
            this.gbStyles.Panel.Controls.Add(this.lSelectedBack);
            this.gbStyles.Panel.Controls.Add(this.cSelectedBack);
            this.gbStyles.Panel.Controls.Add(this.lSelectedFore);
            this.gbStyles.Panel.Controls.Add(this.cSelectedFore);
            this.gbStyles.Size = new System.Drawing.Size(249, 147);
            this.gbStyles.TabIndex = 0;
            this.gbStyles.Text = "Styles";
            this.gbStyles.Values.Heading = "Styles";
            this.gbStyles.Values.Image = ((System.Drawing.Image)(resources.GetObject("gbStyles.Values.Image")));
            // 
            // lTheme
            // 
            this.lTheme.AutoSize = false;
            this.lTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lTheme.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.lTheme.Location = new System.Drawing.Point(10, 8);
            this.lTheme.Name = "lTheme";
            this.lTheme.Size = new System.Drawing.Size(124, 21);
            this.lTheme.Text = "Global layout theme";
            this.lTheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbTheme
            // 
            this.cbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheme.DropDownWidth = 60;
            this.cbTheme.Items.AddRange(new object[] {
            "Mild Blue",
            "Mild Black",
            "Mild Silver",
            "Dark Blue",
            "Dark Orange",
            "Dark Purple"});
            this.cbTheme.Location = new System.Drawing.Point(140, 8);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(92, 21);
            this.cbTheme.TabIndex = 1;
            this.cbTheme.Text = "Mild Blue";
            this.cbTheme.SelectedIndexChanged += new System.EventHandler(this.cbTheme_SelectedIndexChanged);
            // 
            // lListFore
            // 
            this.lListFore.AutoSize = false;
            this.lListFore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lListFore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lListFore.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.lListFore.Location = new System.Drawing.Point(10, 37);
            this.lListFore.Name = "lListFore";
            this.lListFore.Size = new System.Drawing.Size(52, 32);
            this.lListFore.Text = "List fore";
            this.lListFore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cListFore
            // 
            this.cListFore.Location = new System.Drawing.Point(15, 72);
            this.cListFore.Name = "cListFore";
            this.cListFore.SelectedColor = System.Drawing.Color.Black;
            this.cListFore.SelectedRect = new System.Drawing.Rectangle(0, 18, 16, 4);
            this.cListFore.Size = new System.Drawing.Size(43, 34);
            this.cListFore.Splitter = false;
            this.cListFore.TabIndex = 13;
            this.cListFore.Values.Image = ((System.Drawing.Image)(resources.GetObject("cListFore.Values.Image")));
            this.cListFore.Values.Text = "";
            this.cListFore.VisibleNoColor = false;
            this.cListFore.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.cListFore_SelectedColorChanged);
            // 
            // lListBack
            // 
            this.lListBack.AutoSize = false;
            this.lListBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lListBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lListBack.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.lListBack.Location = new System.Drawing.Point(68, 37);
            this.lListBack.Name = "lListBack";
            this.lListBack.Size = new System.Drawing.Size(52, 32);
            this.lListBack.Text = "List back";
            this.lListBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cListBack
            // 
            this.cListBack.Location = new System.Drawing.Point(73, 72);
            this.cListBack.Name = "cListBack";
            this.cListBack.SelectedColor = System.Drawing.Color.Black;
            this.cListBack.SelectedRect = new System.Drawing.Rectangle(0, 18, 16, 4);
            this.cListBack.Size = new System.Drawing.Size(43, 34);
            this.cListBack.Splitter = false;
            this.cListBack.TabIndex = 3;
            this.cListBack.Values.Image = ((System.Drawing.Image)(resources.GetObject("cListBack.Values.Image")));
            this.cListBack.Values.Text = "";
            this.cListBack.VisibleNoColor = false;
            this.cListBack.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.cListBack_SelectedColorChanged);
            // 
            // lSelectedBack
            // 
            this.lSelectedBack.AutoSize = false;
            this.lSelectedBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lSelectedBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lSelectedBack.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.lSelectedBack.Location = new System.Drawing.Point(184, 37);
            this.lSelectedBack.Name = "lSelectedBack";
            this.lSelectedBack.Size = new System.Drawing.Size(52, 32);
            this.lSelectedBack.Text = "Selected back";
            this.lSelectedBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cSelectedBack
            // 
            this.cSelectedBack.Location = new System.Drawing.Point(189, 72);
            this.cSelectedBack.Name = "cSelectedBack";
            this.cSelectedBack.SelectedColor = System.Drawing.Color.Black;
            this.cSelectedBack.SelectedRect = new System.Drawing.Rectangle(0, 18, 16, 4);
            this.cSelectedBack.Size = new System.Drawing.Size(43, 34);
            this.cSelectedBack.Splitter = false;
            this.cSelectedBack.TabIndex = 10;
            this.cSelectedBack.Values.Image = ((System.Drawing.Image)(resources.GetObject("cSelectedBack.Values.Image")));
            this.cSelectedBack.Values.Text = "";
            this.cSelectedBack.VisibleNoColor = false;
            this.cSelectedBack.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.cSelectedBack_SelectedColorChanged);
            // 
            // lSelectedFore
            // 
            this.lSelectedFore.AutoSize = false;
            this.lSelectedFore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lSelectedFore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lSelectedFore.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.lSelectedFore.Location = new System.Drawing.Point(126, 37);
            this.lSelectedFore.Name = "lSelectedFore";
            this.lSelectedFore.Size = new System.Drawing.Size(52, 32);
            this.lSelectedFore.Text = "Selected fore";
            this.lSelectedFore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cSelectedFore
            // 
            this.cSelectedFore.Location = new System.Drawing.Point(131, 72);
            this.cSelectedFore.Name = "cSelectedFore";
            this.cSelectedFore.SelectedColor = System.Drawing.Color.Black;
            this.cSelectedFore.SelectedRect = new System.Drawing.Rectangle(0, 18, 16, 4);
            this.cSelectedFore.Size = new System.Drawing.Size(43, 34);
            this.cSelectedFore.Splitter = false;
            this.cSelectedFore.TabIndex = 11;
            this.cSelectedFore.Values.Image = ((System.Drawing.Image)(resources.GetObject("cSelectedFore.Values.Image")));
            this.cSelectedFore.Values.Text = "";
            this.cSelectedFore.VisibleNoColor = false;
            this.cSelectedFore.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.cSelectedFore_SelectedColorChanged);
            // 
            // pWrapper
            // 
            this.pWrapper.Controls.Add(this.gbGeneral);
            this.pWrapper.Controls.Add(this.bClose);
            this.pWrapper.Controls.Add(this.gbStyles);
            this.pWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pWrapper.Location = new System.Drawing.Point(0, 0);
            this.pWrapper.Name = "pWrapper";
            this.pWrapper.Size = new System.Drawing.Size(519, 218);
            this.pWrapper.StateCommon.Image = ((System.Drawing.Image)(resources.GetObject("pWrapper.StateCommon.Image")));
            this.pWrapper.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.pWrapper.TabIndex = 1;
            // 
            // gbGeneral
            // 
            this.gbGeneral.Location = new System.Drawing.Point(12, 12);
            this.gbGeneral.Name = "gbGeneral";
            // 
            // gbGeneral.Panel
            // 
            this.gbGeneral.Panel.Controls.Add(this.lLanguage);
            this.gbGeneral.Panel.Controls.Add(this.cbLanguage);
            this.gbGeneral.Size = new System.Drawing.Size(229, 147);
            this.gbGeneral.TabIndex = 2;
            this.gbGeneral.Text = "General";
            this.gbGeneral.Values.Heading = "General";
            this.gbGeneral.Values.Image = ((System.Drawing.Image)(resources.GetObject("gbGeneral.Values.Image")));
            // 
            // lLanguage
            // 
            this.lLanguage.AutoSize = false;
            this.lLanguage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lLanguage.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.lLanguage.Location = new System.Drawing.Point(12, 8);
            this.lLanguage.Name = "lLanguage";
            this.lLanguage.Size = new System.Drawing.Size(74, 21);
            this.lLanguage.Text = "Language";
            this.lLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.DropDownWidth = 60;
            this.cbLanguage.Items.AddRange(new object[] {
            "English (EN)",
            "Español (ES)",
            "Català (CA)"});
            this.cbLanguage.Location = new System.Drawing.Point(92, 8);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(113, 21);
            this.cbLanguage.TabIndex = 3;
            this.cbLanguage.Text = "English (EN)";
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(209, 181);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(100, 25);
            this.bClose.TabIndex = 1;
            this.bClose.Values.Text = "Close";
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // kryptonWrapLabel1
            // 
            this.kryptonWrapLabel1.AutoSize = false;
            this.kryptonWrapLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonWrapLabel1.Location = new System.Drawing.Point(11, 8);
            this.kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            this.kryptonWrapLabel1.Size = new System.Drawing.Size(142, 21);
            this.kryptonWrapLabel1.Text = "Global layout theme";
            this.kryptonWrapLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 60;
            this.kryptonComboBox1.Items.AddRange(new object[] {
            "Mild Blue",
            "Mild Black",
            "Mild Silver",
            "Dark Blue",
            "Dark Orange",
            "Dark Purple"});
            this.kryptonComboBox1.Location = new System.Drawing.Point(159, 8);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(84, 21);
            this.kryptonComboBox1.TabIndex = 1;
            // 
            // kryptonWrapLabel2
            // 
            this.kryptonWrapLabel2.AutoSize = false;
            this.kryptonWrapLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonWrapLabel2.Location = new System.Drawing.Point(11, 36);
            this.kryptonWrapLabel2.Name = "kryptonWrapLabel2";
            this.kryptonWrapLabel2.Size = new System.Drawing.Size(62, 69);
            this.kryptonWrapLabel2.Text = "Anime list colors";
            this.kryptonWrapLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kryptonWrapLabel3
            // 
            this.kryptonWrapLabel3.AutoSize = false;
            this.kryptonWrapLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonWrapLabel3.Location = new System.Drawing.Point(76, 36);
            this.kryptonWrapLabel3.Name = "kryptonWrapLabel3";
            this.kryptonWrapLabel3.Size = new System.Drawing.Size(52, 32);
            this.kryptonWrapLabel3.Text = "List back";
            this.kryptonWrapLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonColorButton1
            // 
            this.kryptonColorButton1.Location = new System.Drawing.Point(81, 71);
            this.kryptonColorButton1.Name = "kryptonColorButton1";
            this.kryptonColorButton1.SelectedColor = System.Drawing.Color.Black;
            this.kryptonColorButton1.SelectedRect = new System.Drawing.Rectangle(0, 18, 16, 4);
            this.kryptonColorButton1.Size = new System.Drawing.Size(43, 34);
            this.kryptonColorButton1.Splitter = false;
            this.kryptonColorButton1.TabIndex = 3;
            this.kryptonColorButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonColorButton1.Values.Image")));
            this.kryptonColorButton1.Values.Text = "";
            this.kryptonColorButton1.VisibleNoColor = false;
            // 
            // kryptonWrapLabel4
            // 
            this.kryptonWrapLabel4.AutoSize = false;
            this.kryptonWrapLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonWrapLabel4.Location = new System.Drawing.Point(135, 36);
            this.kryptonWrapLabel4.Name = "kryptonWrapLabel4";
            this.kryptonWrapLabel4.Size = new System.Drawing.Size(52, 32);
            this.kryptonWrapLabel4.Text = "Selected back";
            this.kryptonWrapLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonColorButton2
            // 
            this.kryptonColorButton2.Location = new System.Drawing.Point(140, 71);
            this.kryptonColorButton2.Name = "kryptonColorButton2";
            this.kryptonColorButton2.SelectedColor = System.Drawing.Color.Black;
            this.kryptonColorButton2.SelectedRect = new System.Drawing.Rectangle(0, 18, 16, 4);
            this.kryptonColorButton2.Size = new System.Drawing.Size(43, 34);
            this.kryptonColorButton2.Splitter = false;
            this.kryptonColorButton2.TabIndex = 10;
            this.kryptonColorButton2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonColorButton2.Values.Image")));
            this.kryptonColorButton2.Values.Text = "";
            this.kryptonColorButton2.VisibleNoColor = false;
            // 
            // kryptonWrapLabel5
            // 
            this.kryptonWrapLabel5.AutoSize = false;
            this.kryptonWrapLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonWrapLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.kryptonWrapLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonWrapLabel5.Location = new System.Drawing.Point(195, 36);
            this.kryptonWrapLabel5.Name = "kryptonWrapLabel5";
            this.kryptonWrapLabel5.Size = new System.Drawing.Size(52, 32);
            this.kryptonWrapLabel5.Text = "Selected fore";
            this.kryptonWrapLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonColorButton3
            // 
            this.kryptonColorButton3.Location = new System.Drawing.Point(200, 71);
            this.kryptonColorButton3.Name = "kryptonColorButton3";
            this.kryptonColorButton3.SelectedColor = System.Drawing.Color.Black;
            this.kryptonColorButton3.SelectedRect = new System.Drawing.Rectangle(0, 18, 16, 4);
            this.kryptonColorButton3.Size = new System.Drawing.Size(43, 34);
            this.kryptonColorButton3.Splitter = false;
            this.kryptonColorButton3.TabIndex = 11;
            this.kryptonColorButton3.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonColorButton3.Values.Image")));
            this.kryptonColorButton3.Values.Text = "";
            this.kryptonColorButton3.VisibleNoColor = false;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 218);
            this.Controls.Add(this.pWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.gbStyles.Panel)).EndInit();
            this.gbStyles.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbStyles)).EndInit();
            this.gbStyles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWrapper)).EndInit();
            this.pWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbGeneral.Panel)).EndInit();
            this.gbGeneral.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbGeneral)).EndInit();
            this.gbGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbStyles;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbTheme;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pWrapper;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bClose;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton cListBack;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lSelectedFore;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lSelectedBack;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lListBack;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lTheme;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton cSelectedFore;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton cSelectedBack;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbGeneral;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton kryptonColorButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton kryptonColorButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton kryptonColorButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lLanguage;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbLanguage;
        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lListFore;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton cListFore;

    }
}