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
            int id = -1;
            AnimeClass anime = null;

            // get id from basic title searching
            foreach (var title in mainForm.animeTitles) {
                if (tName.Text == title.XJatName || tName.Text == title.EnglishName)
                    id = title.Id;
            }

            // request data from api if checkbox is checked and id has been found
            if (chkAniDB.Checked && id != -1)
            {
                var fApiQuery = new FWaitingApi(mainForm, id);
                fApiQuery.StartPosition = FormStartPosition.CenterParent;
                fApiQuery.ShowDialog();

                if (fApiQuery.DialogResult == DialogResult.OK)
                    anime = fApiQuery.anime;
            }
            
            // default object otherwise
            else { anime = new AnimeClass(mainForm, -1, null, tName.Text, -1, -1, -1, ""); }

            if (anime == null)
                MessageBox.Show("Request ERROR!");
            else
            {
                // add fansub data
                anime.Items.Add(new AnimeItem(anime, "", cbFansub.SelectedItem.ToString(), ""));

                // add it to the main list
                mainForm.addAnime(anime);
            }

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

        private void tName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string[] titles = new string[mainForm.animeTitlesAutocomplete.Count];
                mainForm.animeTitlesAutocomplete.CopyTo(titles, 0);
                foreach (var title in titles)
                {
                    if (title.ToLower() == tName.Text.ToLower())
                    {
                        tName.Text = title;
                        tName.SelectionStart = tName.Text.Length;
                        break;
                    }
                }

            }
        }

            #endregion

    }
}
