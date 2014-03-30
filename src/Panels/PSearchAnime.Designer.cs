namespace AnimeStorage.Panels
{
    partial class PSearchAnime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PSearchAnime));
            this.rowSearch = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kBorder = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.pCancel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.rowSearch)).BeginInit();
            this.rowSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCancel)).BeginInit();
            this.pCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rowSearch
            // 
            this.rowSearch.Controls.Add(this.tSearch);
            this.rowSearch.Controls.Add(this.pCancel);
            this.rowSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.rowSearch.Location = new System.Drawing.Point(0, 0);
            this.rowSearch.Name = "rowSearch";
            this.rowSearch.Padding = new System.Windows.Forms.Padding(7);
            this.rowSearch.Size = new System.Drawing.Size(408, 37);
            this.rowSearch.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.rowSearch.TabIndex = 3;
            // 
            // tSearch
            // 
            this.tSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tSearch.Location = new System.Drawing.Point(7, 7);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(360, 23);
            this.tSearch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.tSearch.TabIndex = 2;
            this.tSearch.TextChanged += new System.EventHandler(this.tSearch_TextChanged);
            // 
            // kBorder
            // 
            this.kBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kBorder.Location = new System.Drawing.Point(0, 37);
            this.kBorder.Name = "kBorder";
            this.kBorder.Size = new System.Drawing.Size(408, 1);
            this.kBorder.Text = "kryptonBorderEdge1";
            // 
            // pCancel
            // 
            this.pCancel.Controls.Add(this.bCancel);
            this.pCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pCancel.Location = new System.Drawing.Point(367, 7);
            this.pCancel.Name = "pCancel";
            this.pCancel.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.pCancel.Size = new System.Drawing.Size(34, 23);
            this.pCancel.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pCancel.TabIndex = 3;
            // 
            // bCancel
            // 
            this.bCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bCancel.Location = new System.Drawing.Point(7, 0);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(27, 23);
            this.bCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.TabIndex = 0;
            this.bCancel.Values.Image = ((System.Drawing.Image)(resources.GetObject("bManageFansubs.Values.Image")));
            this.bCancel.Values.Text = "";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // PSearchAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 38);
            this.Controls.Add(this.kBorder);
            this.Controls.Add(this.rowSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PSearchAnime";
            this.Text = "PSearch";
            this.Shown += new System.EventHandler(this.PSearchAnime_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.rowSearch)).EndInit();
            this.rowSearch.ResumeLayout(false);
            this.rowSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCancel)).EndInit();
            this.pCancel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel rowSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kBorder;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bCancel;
    }
}