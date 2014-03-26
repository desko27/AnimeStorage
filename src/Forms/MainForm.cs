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

            // anime tlv -> linepen
            TreeListView.TreeRenderer renderer = new TreeListView.TreeRenderer();
            renderer.LinePen = new Pen(Color.Gray, 1);
            renderer.LinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            renderer.IsShowLines = true;
            tlvAnime.TreeColumnRenderer = renderer;

            // anime tlv -> hotitemstyle for rows
            RowBorderDecoration rbd = new RowBorderDecoration();
            rbd.BorderPen = new Pen(Color.FromArgb(255, Color.White), 1);
            rbd.FillBrush = Brushes.Transparent;
            rbd.BoundsPadding = new Size(1, 1);
            rbd.CornerRounding = 0;
            tlvAnime.HotItemStyle = new HotItemStyle();
            tlvAnime.HotItemStyle.Decoration = rbd;

            // anime tlv -> rating drawing
            cRating.Renderer = new MultiImageRenderer(ResourcesInterface.rating, 5, 0, 6);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            anime.Add(new AnimeClass("Hunter x Hunter", "ハンターハンター", 4));
            anime.Add(new AnimeClass("Code Geass", "コードギアス", 5));
            anime.Add(new AnimeClass("One Piece", "ワンピース", 3));
            anime.Add(new AnimeClass("Naruto Shippuden", "ナルト 疾風伝", 1));
            anime.Add(new AnimeClass("Densetsu no Yuusha no Densetsu", "伝説の勇者の伝説", 2));
            tlvAnime.SetObjects(anime);
            //tlvAnime.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            tlvAnime.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            tlvAnime.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            //tlvAnime.SetNativeBackgroundWatermark();
        }

            #endregion

        // ==================================================
            # region interface events -> top menu items
        // ==================================================

        private void menuItem_Click(object sender, EventArgs e)
        {

            // retrieve name of the control
            string name;
            if (sender.GetType().ToString() == "ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem")
                name = ((KryptonContextMenuItem)sender).Tag.ToString();
            else
                name = ((Control)sender).Name;

            // decide actions
            switch (name)
            {

                case "menuSettings":
                    break;

                case "menuConsole":
                    if (!console.Visible) console.Show(); else console.Focus();
                    break;

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

        // maximize & restore main form panels
        // --------------------------------------------------
        private void bAnimeMax_Click(object sender, EventArgs e) {
            if (bAnimeMax.Type == PaletteButtonSpecStyle.WorkspaceMaximize) {
                splitContainerMain.Panel2Collapsed = true; splitContainerMain.Panel2.Hide();
                bAnimeMax.Type = PaletteButtonSpecStyle.WorkspaceRestore;
            } else {
                splitContainerMain.Panel2Collapsed = false; splitContainerMain.Panel2.Show();
                bAnimeMax.Type = PaletteButtonSpecStyle.WorkspaceMaximize;
            }
        }
        private void bEpisodesMax_Click(object sender, EventArgs e) {
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
        private void bPropertiesMax_Click(object sender, EventArgs e) {
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
        // ---

        // make top menu buttons collapsible
        // --------------------------------------------------
        private void MainForm_Resize(object sender, EventArgs e)
        {
            // get all root items of `overflowed context menu`
            var menuItems = (KryptonContextMenuItems) cmOverflowedMenuItems.Items[0];

            // reverse loop to keep the original order of buttons
            for (int i = flowLayoutMenu.Controls.Count - 1; i >= 0; i--) {

                // ** retrieve icon image, and context menu in case of dropbutton
                Image img;
                KryptonContextMenu kcm = null;

                if (flowLayoutMenu.Controls[i].GetType().ToString() == "ComponentFactory.Krypton.Toolkit.KryptonDropButton") {
                    var tmp = (KryptonDropButton)flowLayoutMenu.Controls[i];
                    img = tmp.Values.Image;
                    kcm = tmp.KryptonContextMenu;
                }
                else
                    img = ((KryptonButton)flowLayoutMenu.Controls[i]).Values.Image;
                // ---

                var c = (Control) flowLayoutMenu.Controls[i];
                if (c.Top > 10) {

                    // look for this non-visible/wrapped control in context menu
                    bool found = false;
                    foreach (KryptonContextMenuItem item in menuItems.Items)
                        if (item.Tag.ToString() == c.Name) { found = true; break; }

                    // >> add it to the context menu if does not exist in it
                    if (!found) {
                        KryptonContextMenuItem item = new KryptonContextMenuItem(c.Text, img, null);
                        item.Tag = c.Name;
                        item.Click += menuItem_Click;
                        if (kcm != null) item.Items.AddRange(kcm.Items.ToArray());
                        menuItems.Items.Insert(0, item);
                    }

                } else {

                    // delete visible/non-wrapped controls in context menu
                    foreach (KryptonContextMenuItem item in menuItems.Items)
                        if (item.Tag.ToString() == c.Name) { menuItems.Items.Remove(item); break; }

                }
            }
            
            // show/hide button for overflowed items
            if (menuItems.Items.Count > 0) bOverflowedMenuItems.Show(); else bOverflowedMenuItems.Hide();
        }
        // ---

            #endregion

        // ==================================================
            # region interface events -> anime list
        // ==================================================

        private void bAddAnime_Click(object sender, EventArgs e)
        {
            anime.Add(new AnimeClass("Hey!", "おい！", 1));
            tlvAnime.UpdateObjects(anime);
        }

            #endregion
        
    }

}
