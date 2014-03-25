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
using BrightIdeasSoftware;

namespace AnimeStorage
{
    public partial class MainForm : KryptonForm
    {

        // ==================================================
            # region init stuff
        // ==================================================

        // global objects
        public FormConsole console;
        public List<AnimeClass> anime = new List<AnimeClass>();
        // ---

        public MainForm()
        {
            InitializeComponent();

            // always-active console form
            console = new FormConsole(this);

            // anime olv hotitemstyle for rows
            RowBorderDecoration rbd = new RowBorderDecoration();
            rbd.BorderPen = new Pen(Color.FromArgb(255, Color.White), 1);
            rbd.FillBrush = Brushes.Transparent;
            rbd.BoundsPadding = new Size(1, 1);
            rbd.CornerRounding = 0;
            olvAnime.HotItemStyle = new HotItemStyle();
            olvAnime.HotItemStyle.Decoration = rbd;

            // anime olv rating drawing
            cRating.Renderer = new MultiImageRenderer(ResourcesInterface.rating, 5, 0, 5);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            anime.Add(new AnimeClass("Hunter x Hunter", 4));
            anime.Add(new AnimeClass("Code Geass", 5));
            anime.Add(new AnimeClass("One Piece", 3));
            anime.Add(new AnimeClass("Naruto Shippuden", 1));
            anime.Add(new AnimeClass("Densetsu no Yuusha no Densetsu", 3));
            olvAnime.SetObjects(anime);
            //olvAnime.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            olvAnime.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            //olvAnime.SetNativeBackgroundWatermark();
        }

            #endregion

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

        // ==================================================
            # region interface events -> anime list
        // ==================================================

        private void bAddAnime_Click(object sender, EventArgs e)
        {
            anime.Add(new AnimeClass("Hey!", 5));
            olvAnime.BuildList();
        }

            #endregion

        private void bAnimeMax_Click(object sender, EventArgs e)
        {
            if (bAnimeMax.Type == PaletteButtonSpecStyle.WorkspaceMaximize) {
                splitContainerMain.Panel2Collapsed = true; splitContainerMain.Panel2.Hide();
                bAnimeMax.Type = PaletteButtonSpecStyle.WorkspaceRestore;
            } else {
                splitContainerMain.Panel2Collapsed = false; splitContainerMain.Panel2.Show();
                bAnimeMax.Type = PaletteButtonSpecStyle.WorkspaceMaximize;
            }
        }
        private void bEpisodesMax_Click(object sender, EventArgs e)
        {
            if (bEpisodesMax.Type == PaletteButtonSpecStyle.WorkspaceMaximize) {
                splitContainerMain.Panel1Collapsed = true; splitContainerMain.Panel1.Hide();
                splitContainerRight.Panel2Collapsed = true; splitContainerRight.Panel2.Hide();
                bEpisodesMax.Type = PaletteButtonSpecStyle.WorkspaceRestore;
            } else {
                splitContainerMain.Panel1Collapsed = false; splitContainerMain.Panel1.Show();
                splitContainerRight.Panel2Collapsed = false; splitContainerRight.Panel2.Show();
                bEpisodesMax.Type = PaletteButtonSpecStyle.WorkspaceMaximize;
            }
        }
        private void bPropertiesMax_Click(object sender, EventArgs e)
        {
            if (bPropertiesMax.Type == PaletteButtonSpecStyle.WorkspaceMaximize) {
                splitContainerMain.Panel1Collapsed = true; splitContainerMain.Panel1.Hide();
                splitContainerRight.Panel1Collapsed = true; splitContainerRight.Panel1.Hide();
                bPropertiesMax.Type = PaletteButtonSpecStyle.WorkspaceRestore;
            } else {
                splitContainerMain.Panel1Collapsed = false; splitContainerMain.Panel1.Show();
                splitContainerRight.Panel1Collapsed = false; splitContainerRight.Panel1.Show();
                bPropertiesMax.Type = PaletteButtonSpecStyle.WorkspaceMaximize;
            }
        }


    }

}
