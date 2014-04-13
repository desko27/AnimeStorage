using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Diagnostics;

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
            # region functions
        // ==================================================

        private void QueryToAPI(int id, ref AnimeClass anime)
        {
            var fApiQuery = new FWaitingApi(mainForm, id);
            fApiQuery.StartPosition = FormStartPosition.CenterParent;
            fApiQuery.ShowDialog();

            if (fApiQuery.DialogResult == DialogResult.OK)
                anime = fApiQuery.anime;
        }

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
                if (tName.Text == title.Value.XJatName || tName.Text == title.Value.EnglishName)
                    id = title.Key;
            }

            // request data from api if checkbox is checked
            if (chkAniDB.Checked)
            {
                // and if an id has been found
                if (id != -1) QueryToAPI(id, ref anime);
                
                // id not directly found, look for similar titles and show them
                else
                {
                    // make `similar titles` list
                    // tuple :  id,  title, dist
                    List<Tuple<int, string, int>> similars = Utils.GetSimilarTitles(tName.Text, mainForm.animeTitles, 10);

                    // open dialog
                    FTitleSuggestions fTitleSuggestions = new FTitleSuggestions(tName.Text, similars);
                    fTitleSuggestions.StartPosition = FormStartPosition.CenterParent;
                    fTitleSuggestions.ShowDialog();

                    // get results
                    if (fTitleSuggestions.DialogResult == DialogResult.OK)
                        QueryToAPI(fTitleSuggestions.selectedID, ref anime);
                    else
                        return;
                }
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

        private void chkAniDB_CheckedChanged(object sender, EventArgs e)
        {
            // don't use title autocompletion if AniDB support is unchecked
            if (!chkAniDB.Checked) tName.AutoCompleteMode = AutoCompleteMode.None;
            else tName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
