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

namespace AnimeStorage
{
    public partial class MainForm : KryptonForm
    {
        FormConsole fConsole = new FormConsole();

        public MainForm()
        {
            InitializeComponent();
        }

        private void menuConsole_Click(object sender, EventArgs e)
        {
            if (!fConsole.Visible) fConsole.Show();
            else fConsole.Focus();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void flowLayoutMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void splitContainerMain_DoubleClick(object sender, EventArgs e)
        {
            splitContainerMain.SplitterDistance = splitContainerMain.Width / 2;
        }

        private void splitContainerRight_DoubleClick(object sender, EventArgs e)
        {
            splitContainerRight.SplitterDistance = splitContainerRight.Height / 2;
        }
    }

}
