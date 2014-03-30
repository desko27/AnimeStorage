using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace AnimeStorage.Panels
{
    public partial class PSearchAnime : Form
    {

        // ==================================================
            # region init stuff
        // ==================================================

        private MainForm mainForm;
        private ButtonSpecHeaderGroup senderButton;
        public PSearchAnime(MainForm mainForm, ButtonSpecHeaderGroup senderButton)
        {
            InitializeComponent();
            this.Disposed += cleanUp;

            this.mainForm = mainForm;
            this.senderButton = senderButton;
        }

        private void PSearchAnime_Shown(object sender, EventArgs e)
        { tSearch.Focus(); }

            #endregion

        // ==================================================
            # region interface
        // ==================================================

        private void tSearch_TextChanged(object sender, EventArgs e)
        { mainForm.filterContents(tSearch.Text); }

        private void bCancel_Click(object sender, EventArgs e)
        {

            // do nothing if this `form panel` wasn't created by a checked button
            if (senderButton == null) return;

            // uncheck button
            senderButton.Checked = ButtonCheckState.Unchecked;

            // close north panel
            mainForm.closeAnimeNorth();

        }

            #endregion

        // ==================================================
            # region cleaning up actions
        // ==================================================

        private void cleanUp(object sender, EventArgs e)
        {
            // reset contents filter for main list
            mainForm.filterContents("");
        }

            #endregion

    }
}
