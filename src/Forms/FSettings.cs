using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.InteropServices;

namespace AnimeStorage
{
    public partial class FSettings : KryptonDraggableForm
    {

        // ==================================================
            # region init stuff
        // ==================================================
        
        MainForm mainForm;
        SettingsBox settings;

        public FSettings(MainForm mainForm)
        {
            InitializeComponent();
            InitializeDragEvents();
            InitializeCustomStyles();

            this.mainForm = mainForm;
            settings = mainForm.settings;

            // get existing settings
            // --------------------------------------------------
            cbTheme.Text = settings.GetSetting("StyleTheme");
            cListFore.SelectedColor = settings.GetSetting("StyleListForeColor");
            cListBack.SelectedColor = settings.GetSetting("StyleListBackColor");
            cSelectedFore.SelectedColor = settings.GetSetting("StyleListSelectedForeColor");
            cSelectedBack.SelectedColor = settings.GetSetting("StyleListSelectedBackColor");
            // ---
        }

            #endregion

        // ==================================================
            # region interface events
        // ==================================================

        // close settings
        private void bClose_Click(object sender, EventArgs e)
        { this.Dispose(); }

            #endregion

        // ==================================================
            # region general group
        // ==================================================



            #endregion

        // ==================================================
            # region style group
        // ==================================================

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        { settings.LoadSetting("StyleTheme", cbTheme.SelectedItem.ToString()); }

        private void cListFore_SelectedColorChanged(object sender, ColorEventArgs e)
        { settings.LoadSetting("StyleListForeColor", cListFore.SelectedColor); }

        private void cListBack_SelectedColorChanged(object sender, ColorEventArgs e)
        { settings.LoadSetting("StyleListBackColor", cListBack.SelectedColor); }

        private void cSelectedFore_SelectedColorChanged(object sender, ColorEventArgs e)
        { settings.LoadSetting("StyleListSelectedForeColor", cSelectedFore.SelectedColor); }

        private void cSelectedBack_SelectedColorChanged(object sender, ColorEventArgs e)
        { settings.LoadSetting("StyleListSelectedBackColor", cSelectedBack.SelectedColor); }

            #endregion

    }
}
