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
using System.Collections;
using System.Xml.Linq;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace AnimeStorage
{
    public partial class MainForm : KryptonMovingForm
    {

        // ==================================================
            # region init stuff
        // ==================================================

        // define constants
        public const int MAX_ROW_HEIGHT = 64;

        // global objects
        public FormConsole console;
        public SettingsBox settings;
        public List<AnimeClass> animeList = new List<AnimeClass>();
        public Dictionary<int, AnimeTitle> animeTitles = new Dictionary<int, AnimeTitle>();
        public AutoCompleteStringCollection animeTitlesAutocomplete = new AutoCompleteStringCollection();
        // ---

        // workers (threads)
        BackgroundWorker bw = new BackgroundWorker();
        // ---

        // interface control lists/groups
        private List<ButtonSpecHeaderGroup> animeHeaderButtons = new List<ButtonSpecHeaderGroup>();
        // ---

        // holding values
        public Size formSize;
        // ---

        public MainForm()
        {

            // create cache directory if does not exist
            if (!Directory.Exists("Cache")) Directory.CreateDirectory("Cache");

            // settings object
            settings = new SettingsBox(this);

            // load language
            settings.LoadSetting("Language");

            // default's form components
            InitializeComponent();

            // propagate 'move window'
            flowLayoutMenu.MouseDown += moveWindow;
            lStatus.MouseDown += moveWindow;

#if !DEBUG
            // hide debug interface elements
            menuConsole.Hide();
#endif

            // always-active console form
            console = new FormConsole(this);

            // interface groups - add elements
            animeHeaderButtons.Add(bAddAnime);
            animeHeaderButtons.Add(bSearchAnime);

            // holding form size for setting
            MainForm_Resize(null, null);

            // anime list configs (mostly visuals)
            // --------------------------------------------------

            // treelistview expand getters
            tlvAnime.CanExpandGetter = delegate(object x) { return x is AnimeClass ? (((AnimeClass)x).Items.Count > 1) : false; };
            tlvAnime.ChildrenGetter = delegate(object x) { return new ArrayList(((AnimeClass)x).Items); };

            // linepen of child elements in tree (hidden by now)
            TreeListView.TreeRenderer renderer = new TreeListView.TreeRenderer();
            renderer.LinePen = new Pen(Color.Gray, 1);
            renderer.LinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            renderer.IsShowLines = false;
            tlvAnime.TreeColumnRenderer = renderer;

            // hotitemstyle for rows
            setHotItemColor(Color.White);

            // rating drawing
            cRating.Renderer = new MultiImageRenderer(ResourcesInterface.rating, 5, 0, 11);

            // background image
            //tlvAnime.SetNativeBackgroundWatermark();

#if DEBUG
            // test values
            animeList.Add(new AnimeClass(this, -1, Tests.HunterHunter, "Hunter x Hunter", 2011, -1, 8.22, "ハンターハンター"));
            animeList[0].Items.Add(new AnimeItem(animeList[0], "Epañol", "Backbeard", "D:\\Anime\\Hunter x Hunter (Backbeard)"));
            animeList.Add(new AnimeClass(this, -1, Tests.CodeGeass, "Code Geass", 2006, 25, 9.56, "コードギアス"));
            animeList.Add(new AnimeClass(this, -1, Tests.OnePiece, "One Piece", 1999, -1, 8.47, "ワンピース"));
            animeList.Add(new AnimeClass(this, -1, Tests.NarutoShippuden, "Naruto Shippuden", 2007, -1, 5.71, "ナルト 疾風伝"));
            animeList.Add(new AnimeClass(this, -1, Tests.Densetsu, "Densetsu no Yuusha no Densetsu", 2010, 24, 4.3, "伝説の勇者の伝説"));
            tlvAnime.SetObjects(animeList);
#endif
            // ---

            // load anime titles into memory from xml file
            // --------------------------------------------------
            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            pbStatus.Style = ProgressBarStyle.Marquee;
            bw.RunWorkerAsync();
            lStatus.Text = "Loading anime titles...";
            // ---

            // finally, load settings
            settings.StartUp();

            // dynamic columns width
            int tmp = Properties.Settings.Default.AL_PictureWidth;
            tlvAnime.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            cPicture.Width = tmp;
            cRating.Width = 90;

        }

            #endregion

        // ==================================================
            # region thread -> http check & load anime titles
        // ==================================================

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;
            
            // get xml file, http request if expired
            XDocument doc = Utils.GetCachedXmlFile("Cache\\anime-titles.xml", 1, "http://anidb.net/api/anime-titles.xml.gz");
            var xmlAnime = (from p in doc.Descendants().Elements()
                            where p.Name.LocalName == "anime"
                            select p);

            int i = 0, total = xmlAnime.Count();
            foreach (var item in xmlAnime)
            {
                if ((worker.CancellationPending == true)) {
                    e.Cancel = true;
                    break;
                } else {

                    int id = Convert.ToInt32(item.Attribute("aid").Value);
                    String xjatname = "", ename = "", jname = "";
                    foreach (var title in item.Elements())
                    {
                        foreach (var attr in title.Attributes())
                        {
                            if ((title.Attribute("type").Value == "official" || title.Attribute("type").Value == "main") && attr.Name == XNamespace.Xml + "lang" && attr.Value == "x-jat")
                                xjatname = title.Value;
                            if ((title.Attribute("type").Value == "official" || title.Attribute("type").Value == "synonym") && attr.Name == XNamespace.Xml + "lang" && attr.Value == "ja")
                                if (Regex.IsMatch(title.Value, "[^\x00-\x80]+")) jname = title.Value; // must include japanese characters
                            if (title.Attribute("type").Value == "official" && attr.Name == XNamespace.Xml + "lang" && attr.Value == "en")
                                ename = title.Value;
                        }
                    }

                    // titles (+japanese) list
                    animeTitles.Add(id, new AnimeTitle(id, xjatname, ename, jname));

                    // autocomplete object (en & x-jat)
                    if (xjatname != "") animeTitlesAutocomplete.Add(xjatname);
                    if (ename != "" && ename != xjatname) animeTitlesAutocomplete.Add(ename);

#if DEBUG
                    // Debug.WriteLine(String.Format("{0} - {1} : {2} : {3}", id, xjatname, ename, jname));
#endif
                }

                i++;
                //worker.ReportProgress((i * 1000) / total);
            }
            // ---
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        { pbStatus.Value = e.ProgressPercentage; }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            { lStatus.Text = "Canceled!"; }

            else if (!(e.Error == null))
            { lStatus.Text = ("Error: " + e.Error.Message); }

            else {
                lStatus.Text = "Ready!";
                pbStatus.Value = 0;
                pbStatus.Style = ProgressBarStyle.Blocks;
            }
        }

            #endregion

        // ==================================================
            # region treelistview related functions
        // ==================================================

        public void setHotItemColor(Color color)
        {
            RowBorderDecoration rbd = new RowBorderDecoration();
            rbd.BorderPen = new Pen(Color.FromArgb(255, color), 1);
            rbd.FillBrush = Brushes.Transparent;
            rbd.BoundsPadding = new Size(1, 1);
            rbd.CornerRounding = 0;
            tlvAnime.HotItemStyle = new HotItemStyle();
            tlvAnime.HotItemStyle.Decoration = rbd;
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
                    FSettings fSettings = new FSettings(this);
                    fSettings.StartPosition = FormStartPosition.CenterParent;
                    fSettings.ShowDialog();
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

        // double-click separators to return the dual-panel layout to its default `50% each one`
        private void splitContainerMain_DoubleClick(object sender, EventArgs e) { splitContainerMain.SplitterDistance = splitContainerMain.Width / 2; }
        private void splitContainerRight_DoubleClick(object sender, EventArgs e) { splitContainerRight.SplitterDistance = splitContainerRight.Height / 2; }

        // layout control through mainLayout dropdown buttons
        private void bLayoutNormal_Click(object sender, EventArgs e) {
            splitContainerMain.SplitterDistance = splitContainerMain.Width / 2;
            splitContainerRight.SplitterDistance = splitContainerRight.Height / 2;
        }
        private void bLayoutBigList_Click(object sender, EventArgs e) {
            splitContainerMain.SplitterDistance = splitContainerMain.Width - (splitContainerMain.Width / 4);
            splitContainerRight.SplitterDistance = splitContainerRight.Height / 2;
        }
        private void bLayoutBigListEpisodes_Click(object sender, EventArgs e) {
            splitContainerMain.SplitterDistance = splitContainerMain.Width - (splitContainerMain.Width / 4);
            splitContainerRight.SplitterDistance = splitContainerRight.Height - (splitContainerRight.Height / 3);
        }

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

        // hold form size & make top menu buttons collapsible
        // --------------------------------------------------
        private void MainForm_Resize(object sender, EventArgs e)
        {
            // hold form size
            if (WindowState == FormWindowState.Normal) formSize = Size;

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

        // allow right picture column resizing in anime list
        // --------------------------------------------------
        private void pictureColumnConstraints(int columnIndex)
        {
            if (columnIndex == cPicture.Index)
            {
                if (cPicture.Width > MAX_ROW_HEIGHT) tlvAnime.RowHeight = MAX_ROW_HEIGHT;
                else tlvAnime.RowHeight = cPicture.Width;

                // resize anime thumbnail pictures
                foreach (var item in animeList) item.setThumbnailPicture();
            }
        }
        private void tlvAnime_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) { /*pictureColumnConstraints(e.ColumnIndex);*/ }
        private void tlvAnime_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e) { pictureColumnConstraints(e.ColumnIndex); }
        private void tlvAnime_ColumnClick(object sender, ColumnClickEventArgs e) { pictureColumnConstraints(e.Column); }
        // ---

            #endregion

        // ==================================================
            # region interface events -> anime list
        // ==================================================

        public void AddTest() { addAnime(new AnimeClass(this, -1, null, "Hey!", 2014, 7, new Random().NextDouble() * 10, "おい！")); }
        private void animeHeaderButton_Click(object sender, EventArgs e)
        {

            var button = (ButtonSpecHeaderGroup)sender;
            if (button.Checked == ButtonCheckState.Checked) {

                // if north panel is already displayed, delete its contents
                // in order to show the contents of this one
                if (pAnimeNorth.Visible) closeAnimeNorth(false);

                // uncheck other check buttons but this one
                foreach (var other in animeHeaderButtons)
                    if (button != other && other.Checked != ButtonCheckState.NotCheckButton)
                        other.Checked = ButtonCheckState.Unchecked;

                // add corresponding `form panel`
                Form appendingForm = null;
                switch (button.Tag.ToString()) {
                    
                    case "Add":
                        // don't open if xml autocompletion is not ready
                        if (bw.IsBusy) {
                            button.Checked = ButtonCheckState.Unchecked;
                            pAnimeNorth.Hide();
                            MessageBox.Show("Sorry, anime titles are still loading!", "Please wait", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                            appendingForm = new Panels.PAddAnime(this, button);
                        break;

                    case "Search": appendingForm = new Panels.PSearchAnime(this, button); break;
                }

                if (appendingForm != null)
                {
                    // configure form to fit the panel
                    appendingForm.Dock = DockStyle.Fill;
                    appendingForm.TopLevel = false;
                    appendingForm.Show();
                    pAnimeNorth.Height = appendingForm.Height;

                    // add it to the panel
                    pAnimeNorth.Controls.Add(appendingForm);
                }
                
                // show it if still not visible
                if (!pAnimeNorth.Visible) pAnimeNorth.Show();

            } else {

                // unchecked button means to be closing north panel
                if (pAnimeNorth.Visible) closeAnimeNorth();

            }

        }

        // method for correctly closing anime north panel
        public void closeAnimeNorth() { closeAnimeNorth(true); }
        public void closeAnimeNorth(bool hide) {
            foreach (Form panelForm in pAnimeNorth.Controls) panelForm.Dispose();
            pAnimeNorth.Controls.Clear();
            if (hide) pAnimeNorth.Hide();
        }

        // add new anime item to both, the anime list and visual tlv anime list
        // :: must be able to be called from [PAddAime] & co.
        public void addAnime(AnimeClass anime) {
            animeList.Add(anime);
            tlvAnime.UpdateObjects(animeList);
        }

        // search function -> contents filter for anime list
        // :: must be able to be called from [PAddAime] & co.
        public void filterContents(string text)
        { tlvAnime.ModelFilter = TextMatchFilter.Contains(tlvAnime, text); }

            #endregion

        // ==================================================
            # region ending procedures when closing app
        // ==================================================

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // remember last state for some elements
            Properties.Settings.Default.LayoutHorizontal = (splitContainerMain.SplitterDistance * 100) / splitContainerMain.Width;
            Properties.Settings.Default.LayoutVertical = (splitContainerRight.SplitterDistance * 100) / splitContainerRight.Height;
            Properties.Settings.Default.WindowSize = formSize;
            if (WindowState != FormWindowState.Minimized) Properties.Settings.Default.WindowState = WindowState;

            // remember last state for anime list layout elements
            pictureColumnConstraints(cPicture.Index);
            Properties.Settings.Default.AL_PictureWidth = cPicture.Width;
            Properties.Settings.Default.AL_RowHeight = tlvAnime.RowHeight;
            
            // save them all
            Properties.Settings.Default.Save();
        }

            #endregion

    }

}
