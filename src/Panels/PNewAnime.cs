using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimeStorage.Panels
{
    public partial class PNewAnime : Form
    {

        // ==================================================
            # region init stuff
        // ==================================================

        private MainForm mainForm;
        public PNewAnime(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

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
            AnimeClass anime = new AnimeClass(tName.Text, -1, -1, "");
            anime.Items.Add(new AnimeItem(anime, "", cbFansub.SelectedItem.ToString(), ""));
            mainForm.addAnime(anime, true);
        }

        private void bCancel_Click(object sender, EventArgs e)
        { mainForm.closeAnimeNorth(); }

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
