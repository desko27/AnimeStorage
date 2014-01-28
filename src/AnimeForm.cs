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
            listViewAnime.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            tNew.Text = "";
        }
        
        bool canAdd(string str)
        { return str != ""; }

        private void tNew_TextChanged(object sender, EventArgs e)
        {
            // check conditions to enable button
            if (canAdd(tNew.Text))
                bNew.Enabled = true;
            else
                bNew.Enabled = false;
        }

        private void tNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && canAdd(tNew.Text))
                bNew_Click(sender, e);
        }

    }
}
