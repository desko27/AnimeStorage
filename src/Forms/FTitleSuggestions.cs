using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace AnimeStorage
{
    public partial class FTitleSuggestions : KryptonForm
    {

        // ==================================================
            # region init stuff
        // ==================================================

        public int selectedID;
        private List<Tuple<int, string, int>> similars;

        public FTitleSuggestions(string original, List<Tuple<int, string, int>> similars)
        {
            InitializeComponent();

            // load incoming data
            this.similars = similars;
            this.Text = String.Format(this.Text, original);

            // set up form elements
            foreach (var similar in similars)
                lbTitles.Items.Add(similar.Item2);

            // select the first one
            if (lbTitles.Items.Count > 0)
                lbTitles.SelectedIndex = 0;

            // custom events
            lbTitles.ListBox.DoubleClick += bAccept_Click;
        }

            #endregion

        // ==================================================
            # region interface
        // ==================================================

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        { if (lbTitles.SelectedIndex != -1) bAccept.Enabled = true; }

        private void bCancel_Click(object sender, EventArgs e) { this.Close(); }
        private void bAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            foreach (var similar in similars)
            {
                if (similar.Item2 == lbTitles.SelectedItem.ToString())
                    selectedID = similar.Item1;
            }

            this.Close();
        }

            #endregion

    }
}
