using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.InteropServices;

namespace AnimeStorage.Forms
{
    public partial class FormSettings : KryptonForm
    {

        // ==================================================
            # region init stuff
        // ==================================================
        
        MainForm mainForm;
        public FormSettings(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            // load existing settings
            // --------------------------------------------------
            cbTheme.Text = Properties.Settings.Default.StyleTheme;
            cListFore.SelectedColor = Properties.Settings.Default.StyleListForeColor;
            cListBack.SelectedColor = Properties.Settings.Default.StyleListBackColor;
            cSelectedFore.SelectedColor = Properties.Settings.Default.StyleListSelectedForeColor;
            cSelectedBack.SelectedColor = Properties.Settings.Default.StyleListSelectedBackColor;
            // ---

            // propagate 'move window' and other common properties
            foreach (Control item in pWrapper.Controls) {
                if (item is KryptonGroupBox) {
                    item.MouseDown += moveWindow;
                    ((KryptonGroupBox)item).StateCommon.Back.Color1 = Color.Transparent;
                    var panel = ((KryptonGroupBox)item).Panel;
                    panel.MouseDown += moveWindow;

                    foreach (Control subitem in panel.Controls)
                        if (subitem is KryptonLabel || subitem is KryptonWrapLabel) subitem.MouseDown += moveWindow;
                }
            }
        }

            #endregion

        // ==================================================
            # region interface events -> layout control
        // ==================================================

        // add the ability to move the window through the top panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void moveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

            #endregion

        // ==================================================
            # region interface events
        // ==================================================

        // close settings
        private void bClose_Click(object sender, EventArgs e)
        { this.Dispose(); }

            #endregion

        // ==================================================
            # region general group
        // ==================================================



            #endregion

        // ==================================================
            # region style group
        // ==================================================

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        { mainForm.settings.LoadTheme(cbTheme.SelectedItem.ToString()); }

        private void cListFore_SelectedColorChanged(object sender, ColorEventArgs e)
        { mainForm.settings.LoadListForeColor(cListFore.SelectedColor); }

        private void cListBack_SelectedColorChanged(object sender, ColorEventArgs e)
        { mainForm.settings.LoadListBackColor(cListBack.SelectedColor); }

        private void cSelectedFore_SelectedColorChanged(object sender, ColorEventArgs e)
        { mainForm.settings.LoadListSelectedForeColor(cSelectedFore.SelectedColor); }

        private void cSelectedBack_SelectedColorChanged(object sender, ColorEventArgs e)
        { mainForm.settings.LoadListSelectedBackColor(cSelectedBack.SelectedColor); }

            #endregion

    }
}
