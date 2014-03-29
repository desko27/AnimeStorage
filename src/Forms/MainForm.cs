﻿using System;
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
using System.Collections;
using System.Xml.Linq;
using System.Diagnostics;

namespace AnimeStorage
{
    public partial class MainForm : KryptonForm
    {

        // ==================================================
            # region init stuff
        // ==================================================

        // global objects
        public FormConsole console;
        public List<AnimeClass> animeList = new List<AnimeClass>();
        public List<AnimeTitle> animeTitles = new List<AnimeTitle>();
        public AutoCompleteStringCollection animeTitlesAutocomplete = new AutoCompleteStringCollection();
        // ---

        public MainForm()
        {
            InitializeComponent();

            // always-active console form
            console = new FormConsole(this);

            // anime list configs
            // --------------------------------------------------
            // treelistview expand getters
            tlvAnime.CanExpandGetter = delegate(object x) { return x is AnimeClass ? (((AnimeClass)x).Items.Count > 0) : false; };
            tlvAnime.ChildrenGetter = delegate(object x) { return new ArrayList(((AnimeClass)x).Items); };

            // linepen
            TreeListView.TreeRenderer renderer = new TreeListView.TreeRenderer();
            renderer.LinePen = new Pen(Color.Gray, 1);
            renderer.LinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            renderer.IsShowLines = false;
            tlvAnime.TreeColumnRenderer = renderer;

            // hotitemstyle for rows
            RowBorderDecoration rbd = new RowBorderDecoration();
            rbd.BorderPen = new Pen(Color.FromArgb(255, Color.White), 1);
            rbd.FillBrush = Brushes.Transparent;
            rbd.BoundsPadding = new Size(1, 1);
            rbd.CornerRounding = 0;
            tlvAnime.HotItemStyle = new HotItemStyle();
            tlvAnime.HotItemStyle.Decoration = rbd;

            // rating drawing
            cRating.Renderer = new MultiImageRenderer(ResourcesInterface.rating, 5, 0, 11);

            // background image
            //tlvAnime.SetNativeBackgroundWatermark();

            // test values
            animeList.Add(new AnimeClass("Hunter x Hunter", 2011, 8.22, "ハンターハンター"));
            animeList[0].Items.Add(new AnimeItem(animeList[0], "Epañol", "Backbeard", "D:\\Anime\\Hunter x Hunter (Backbeard)"));
            animeList.Add(new AnimeClass("Code Geass", 2006, 9.56, "コードギアス"));
            animeList.Add(new AnimeClass("One Piece", 1999, 8.47, "ワンピース"));
            animeList.Add(new AnimeClass("Naruto Shippuden", 2007, 5.71, "ナルト 疾風伝"));
            animeList.Add(new AnimeClass("Densetsu no Yuusha no Densetsu", 2010, 4.3, "伝説の勇者の伝説"));
            tlvAnime.SetObjects(animeList);
            tlvAnime.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            cRating.Width = 90;
            // ---

            // load anime titles into memory from xml file
            // --------------------------------------------------
            XDocument doc = XDocument.Load("Files\\anime-titles.xml");
            var xmlAnime = (from p in doc.Descendants().Elements()
                                     where p.Name.LocalName == "anime"
                                     select p);

            foreach (var item in xmlAnime)
            {
                int id = Convert.ToInt32(item.FirstAttribute.Value);
                String name = "", ename = "", jname = "";
                foreach (var title in item.Elements())
                {
                    foreach (var attr in title.Attributes())
                    {
                        if ((title.FirstAttribute.Value == "official" || title.FirstAttribute.Value == "main") && attr.Name == XNamespace.Xml + "lang" && attr.Value == "x-jat")
                            name = title.Value;
                        if (attr.Name == XNamespace.Xml + "lang" && attr.Value == "ja")
                            jname = title.Value;
                        if (title.FirstAttribute.Value == "official" && attr.Name == XNamespace.Xml + "lang" && attr.Value == "en")
                            ename = title.Value;
                    }
                }
                
                // titles (+japanese) list
                animeTitles.Add(new AnimeTitle(id, name, ename, jname));
                
                // autocomplete object (only x-jat)
                if (name != "") animeTitlesAutocomplete.Add(name);
                if (ename != "" && ename != name) animeTitlesAutocomplete.Add(ename);

                // debug loading
                Debug.WriteLine(String.Format("{0} - {1} : {2} : {3}", id, name, ename, jname));
            }
            // ---
        }

            #endregion

        // ==================================================
            #region common functions
        // ==================================================

        // add new anime item to the main list
        public void addAnime(AnimeClass anime) { addAnime(anime, false); }
        public void addAnime(AnimeClass anime, bool interfaceActions) {
            animeList.Add(anime);
            tlvAnime.UpdateObjects(animeList);
            if (interfaceActions) closeAnimeNorth();
        }

        // delete all controls on workspace panel and hide it
        public void closeAnimeNorth() {
            bAddAnime.Checked = ButtonCheckState.Unchecked;
            pAnimeNorth.Controls.Clear();
            pAnimeNorth.Hide();
        }

            #endregion

        // ==================================================
            # region interface events -> top menu items
        // ==================================================

        private void menuItem_Click(object sender, EventArgs e)
        {

            // retrieve name of the control
            string name;
            if (sender is KryptonContextMenuItem)
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

                if (flowLayoutMenu.Controls[i] is KryptonDropButton) {
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

        private void bAddTest_Click(object sender, EventArgs e)
        { addAnime(new AnimeClass("Hey!", 2014, new Random().NextDouble()*10, "おい！")); }

        private void bAddAnime_Click(object sender, EventArgs e)
        {
            if (bAddAnime.Checked == ButtonCheckState.Checked)
            {
                // create `form` panel
                Panels.PNewAnime pNewAnime = new Panels.PNewAnime(this);
                pNewAnime.Dock = DockStyle.Fill;
                pNewAnime.TopLevel = false;
                pNewAnime.Show();

                // add to the workspace panel and show it
                pAnimeNorth.Height = pNewAnime.Height;
                pAnimeNorth.Controls.Add(pNewAnime);
                pAnimeNorth.Show();
            }
            else { closeAnimeNorth(); }
        }

            #endregion
        
    }

}
