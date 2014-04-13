namespace AnimeStorage
{
    partial class FormConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsole));
            this.tConsole = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.tPrompt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tConsole
            // 
            this.tConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tConsole.Location = new System.Drawing.Point(0, 0);
            this.tConsole.Name = "tConsole";
            this.tConsole.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.tConsole.ReadOnly = true;
            this.tConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.tConsole.Size = new System.Drawing.Size(477, 234);
            this.tConsole.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.tConsole.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.tConsole.StateCommon.Content.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tConsole.TabIndex = 1;
            this.tConsole.Text = "Anime Storage console started.\n";
            this.tConsole.WordWrap = false;
            // 
            // tPrompt
            // 
            this.tPrompt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tPrompt.Location = new System.Drawing.Point(0, 5);
            this.tPrompt.Name = "tPrompt";
            this.tPrompt.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.tPrompt.Size = new System.Drawing.Size(477, 19);
            this.tPrompt.StateCommon.Content.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPrompt.TabIndex = 0;
            this.tPrompt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tPrompt_KeyDown);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.tPrompt);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 234);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonPanel1.Size = new System.Drawing.Size(477, 24);
            this.kryptonPanel1.TabIndex = 2;
            // 
            // FormConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 258);
            this.Controls.Add(this.tConsole);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsole";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.Text = "Console";
            this.Activated += new System.EventHandler(this.FormConsole_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsole_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox tConsole;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tPrompt;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
    }
}