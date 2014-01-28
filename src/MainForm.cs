using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimeStorage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // dev. form
            var f = new AnimeForm();
            f.Show();
            // ---
        }

        private void mainMenuItemAnime_Click(object sender, EventArgs e)
        {
            var f = new AnimeForm();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

    }
}
