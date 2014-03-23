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

        // ** always-active console form
        public FormConsole console;
        // ---

        // ** lists
        public List<AnimeClass> anime = new List<AnimeClass>();
        // ---

        public MainForm()
        {
            InitializeComponent();
            console = new FormConsole(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            anime.Add(new AnimeClass("Hunter x Hunter", 5));
            anime.Add(new AnimeClass("Code Geass", 5));
            anime.Add(new AnimeClass("One Piece", 5));
            anime.Add(new AnimeClass("Naruto Shippuden", 5));
            anime.Add(new AnimeClass("Densetsu no Yuusha no Densetsu", 5));
            olvAnime.SetObjects(anime);
            olvAnime.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //olvAnime.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            //olvAnime.SetNativeBackgroundWatermark();
        }

        // ==================================================
            # region interface events -> top menu
        // ==================================================

        private void menuConsole_Click(object sender, EventArgs e)
        { if (!console.Visible) console.Show(); else console.Focus(); }

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
        private void flowLayoutMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        // double-click separators to return the dual-panel layout to its default `50% each one`
        private void splitContainerMain_DoubleClick(object sender, EventArgs e) { splitContainerMain.SplitterDistance = splitContainerMain.Width / 2; }
        private void splitContainerRight_DoubleClick(object sender, EventArgs e) { splitContainerRight.SplitterDistance = splitContainerRight.Height / 2; }

            #endregion

        private void bAddAnime_Click(object sender, EventArgs e)
        {
            anime.Add(new AnimeClass("Hey!", 5));
            olvAnime.BuildList();
        }

        
    }

}
