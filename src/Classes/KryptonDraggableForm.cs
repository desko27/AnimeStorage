using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AnimeStorage
{
    public class KryptonDraggableForm : KryptonForm
    {
        // ==================================================
            # region interface events -> layout control
        // ==================================================

        // add the ability to move the window through other controls
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        protected void moveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        protected void InitializeDragEvents() { InitializeDragEvents(this, false); }
        protected void InitializeDragEvents(bool all_controls) { InitializeDragEvents(this, all_controls); }
        protected void InitializeDragEvents(Control parent, bool all_controls)
        {
            foreach (Control c in parent.Controls)
            {
                if (all_controls || c is KryptonPanel || c is FlowLayoutPanel || c is KryptonWrapLabel || c is KryptonLabel || c is KryptonGroupBox)
                    c.MouseDown += moveWindow;

                if (parent.HasChildren) InitializeDragEvents(c, all_controls);
            }
        }

        protected void InitializeCustomStyles() { InitializeCustomStyles(this); }
        protected void InitializeCustomStyles(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is KryptonGroupBox) ((KryptonGroupBox)c).StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
                if (c is KryptonLabel || c is KryptonWrapLabel) ((KryptonWrapLabel)c).LabelStyle = LabelStyle.NormalPanel;
                if (parent.HasChildren) InitializeCustomStyles(c);
            }
        }

            #endregion
    }
}
