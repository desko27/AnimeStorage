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
    public partial class AnimeForm : Form
    {
        public AnimeForm()
        {
            InitializeComponent();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            // retrieve item from textbox
            var item = new ListViewItem();
            item.Text = tNew.Text;

            // ask for the source folder
            // ...

            // add item and emtpy textbox
            listViewAnime.Items.Add(item);
            tNew.Text = "";
        }
    }
}
