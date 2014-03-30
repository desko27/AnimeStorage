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
    public partial class PSearchAnime : Form
    {

        // ==================================================
            # region init stuff
        // ==================================================

        private MainForm mainForm;
        public PSearchAnime(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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
        { mainForm.filterContents(""); mainForm.closeAnimeNorth(); }

            #endregion
    }
}
