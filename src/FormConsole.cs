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
    public partial class FormConsole : KryptonForm
    {

        public FormConsole()
        {
            InitializeComponent();
        }

        // ==================================================
            # region automatic events
        // ==================================================

        // set focus to the prompt
        private void FormConsole_Activated(object sender, EventArgs e) { tPrompt.Focus(); }

            #endregion

        // ==================================================
            # region interface events -> layout control
        // ==================================================

        // avoid the form to be destroyed when closing it through the window `x` button
        private void FormConsole_FormClosing(object sender, FormClosingEventArgs e) { this.Hide(); e.Cancel = true; }
            
            #endregion

    }
}
