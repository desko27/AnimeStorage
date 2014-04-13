namespace AnimeStorage
{
    partial class FTitleSuggestions
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
            this.lInfo = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.lbTitles = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.pWrapper = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.flPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bAccept = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pWrapper)).BeginInit();
            this.pWrapper.SuspendLayout();
            this.flPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lInfo
            // 
            this.lInfo.AutoSize = false;
            this.lInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lInfo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lInfo.Location = new System.Drawing.Point(0, 0);
            this.lInfo.Name = "lInfo";
            this.lInfo.Size = new System.Drawing.Size(354, 19);
            this.lInfo.Text = "Your title was not found. Did you mean any of these?";
            // 
            // lbTitles
            // 
            this.lbTitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitles.Location = new System.Drawing.Point(0, 19);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(354, 121);
            this.lbTitles.TabIndex = 1;
            this.lbTitles.SelectedIndexChanged += new System.EventHandler(this.lbTitles_SelectedIndexChanged);
            // 
            // pWrapper
            // 
            this.pWrapper.Controls.Add(this.lbTitles);
            this.pWrapper.Controls.Add(this.lInfo);
            this.pWrapper.Controls.Add(this.flPanelButtons);
            this.pWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pWrapper.Location = new System.Drawing.Point(0, 0);
            this.pWrapper.Name = "pWrapper";
            this.pWrapper.Size = new System.Drawing.Size(354, 174);
            this.pWrapper.TabIndex = 2;
            // 
            // flPanelButtons
            // 
            this.flPanelButtons.BackColor = System.Drawing.Color.Transparent;
            this.flPanelButtons.Controls.Add(this.bCancel);
            this.flPanelButtons.Controls.Add(this.bAccept);
            this.flPanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flPanelButtons.Location = new System.Drawing.Point(0, 140);
            this.flPanelButtons.Name = "flPanelButtons";
            this.flPanelButtons.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.flPanelButtons.Size = new System.Drawing.Size(354, 34);
            this.flPanelButtons.TabIndex = 2;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(244, 7);
            this.bCancel.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(110, 25);
            this.bCancel.TabIndex = 1;
            this.bCancel.Values.Text = "No, it\'s not here";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(127, 7);
            this.bAccept.Margin = new System.Windows.Forms.Padding(0);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(110, 25);
            this.bAccept.TabIndex = 0;
            this.bAccept.Values.Text = "Take this one";
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // FTitleSuggestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 174);
            this.Controls.Add(this.pWrapper);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 150);
            this.Name = "FTitleSuggestions";
            this.ShowIcon = false;
            this.Text = "Not found: \"{0}\"";
            ((System.ComponentModel.ISupportInitialize)(this.pWrapper)).EndInit();
            this.pWrapper.ResumeLayout(false);
            this.flPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbTitles;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pWrapper;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bAccept;
        private System.Windows.Forms.FlowLayoutPanel flPanelButtons;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bCancel;
    }
}