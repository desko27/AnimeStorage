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
    public partial class AnimeEditForm : Form
    {

        // returned data
        public string data;

        public AnimeEditForm(String name)
        {
            InitializeComponent();

            // retrieve values
            toolStripLabelName.Text = name;
            tOriginalName.Text = name;
            
        }

        private void tOriginalName_TextChanged(object sender, EventArgs e)
        { toolStripLabelName.Text = tOriginalName.Text; }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            // successful! close it!
            data = tOriginalName.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

    }
}
