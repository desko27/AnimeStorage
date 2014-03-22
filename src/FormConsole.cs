﻿using System;
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
    public partial class FormConsole : KryptonForm
    {
        public FormConsole()
        {
            InitializeComponent();
        }

        private void FormConsole_Activated(object sender, EventArgs e)
        {
            tPrompt.Focus();
        }

        private void FormConsole_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

    }
}
