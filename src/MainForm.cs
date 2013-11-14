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

        // ==================================================
        # region menu bar events
        // ==================================================

        private void mLog_CheckedChanged(object sender, EventArgs e)
        {
            if (mLog.Checked) {
                mLog.BackColor = Color.DarkBlue;
                mLog.ForeColor = SystemColors.Window;
            } else {
                mLog.BackColor = SystemColors.Control;
                mLog.ForeColor = SystemColors.ControlText;
            }
        }

        private void mRules_Click(object sender, EventArgs e)
        {
            var f = new RulesForm();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        # endregion
    }
}
