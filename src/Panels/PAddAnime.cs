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
    public partial class PAddAnime : Form
    {

        // ==================================================
            # region init stuff
        // ==================================================

        private MainForm mainForm;
        private ButtonSpecHeaderGroup senderButton;
        public PAddAnime(MainForm mainForm, ButtonSpecHeaderGroup senderButton)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.senderButton = senderButton;

            // autocompletion anime titles
            tName.AutoCompleteCustomSource = mainForm.animeTitlesAutocomplete;
        }

        private void PNewAnime_Shown(object sender, EventArgs e)
        { tName.Focus(); }

            #endregion

        // ==================================================
            # region interface
        // ==================================================

        private void bAccept_Click(object sender, EventArgs e)
        {
            // prepare item
            AnimeClass anime = new AnimeClass(null, tName.Text, -1, -1, "");
            anime.Items.Add(new AnimeItem(anime, "", cbFansub.SelectedItem.ToString(), ""));

            // add it to the main list
            mainForm.addAnime(anime);

            // close north panel
            bCancel_Click(sender, e);
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            // do nothing if this `form panel` wasn't created by a checked button
            if (senderButton == null) return;
            
            // uncheck button
            senderButton.Checked = ButtonCheckState.Unchecked;

            // close north panel
            mainForm.closeAnimeNorth();
        }

        private void chkCreateFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCreateFolder.Checked) {

                bExplore.Enabled = false;
                tFolder.Enabled = false;

            } else {

                bExplore.Enabled = true;
                tFolder.Enabled = true;

            }
        }

            #endregion

        // ==================================================
            # region validation
        // ==================================================

        private void valuesValidation(object sender, EventArgs e)
        {
            if (tName.Text != "" && cbFansub.SelectedIndex != -1)
                bAccept.Enabled = true;
            else
                bAccept.Enabled = false;
        }

            #endregion

    }
}
