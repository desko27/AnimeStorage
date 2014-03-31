using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using ComponentFactory.Krypton.Toolkit;
using System.Drawing;

namespace AnimeStorage
{
    public class SettingsBox
    {

        MainForm mainForm;
        public SettingsBox(MainForm mainForm) { this.mainForm = mainForm; }
        public void StartUp() {

            // treelistview style settings
            LoadListForeColor();
            LoadListBackColor();
            LoadListSelectedBackColor();
            LoadListSelectedForeColor();

        }

        public void LoadLanguage()
        {
            string lang = Thread.CurrentThread.CurrentUICulture.ToString();
            switch (Properties.Settings.Default.Language) {
                case "Español (ES)": lang = "es-ES"; break;
                case "Català (CA)": lang = "ca-CA"; break;
            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
        }

        public void LoadTheme(string theme) {
            Properties.Settings.Default.StyleTheme = theme;
            Properties.Settings.Default.Save();
            LoadTheme();
        }
        public void LoadTheme()
        {
            switch (Properties.Settings.Default.StyleTheme)
            {
                case "Mild Blue": mainForm.kryptonGlobals.GlobalPaletteMode = PaletteModeManager.Office2010Blue; break;
                case "Mild Black": mainForm.kryptonGlobals.GlobalPaletteMode = PaletteModeManager.Office2010Black; break;
                case "Mild Silver": mainForm.kryptonGlobals.GlobalPaletteMode = PaletteModeManager.Office2010Silver; break;
                case "Dark Blue": mainForm.kryptonGlobals.GlobalPaletteMode = PaletteModeManager.SparkleBlue; break;
                case "Dark Orange": mainForm.kryptonGlobals.GlobalPaletteMode = PaletteModeManager.SparkleOrange; break;
                case "Dark Purple": mainForm.kryptonGlobals.GlobalPaletteMode = PaletteModeManager.SparklePurple; break;
            }
        }

        public void LoadListForeColor(Color color) {
            Properties.Settings.Default.StyleListForeColor = color;
            Properties.Settings.Default.Save();
            LoadListForeColor();
        }
        public void LoadListForeColor()
        { mainForm.tlvAnime.ForeColor = Properties.Settings.Default.StyleListForeColor; }

        public void LoadListBackColor(Color color) {
            Properties.Settings.Default.StyleListBackColor = color;
            Properties.Settings.Default.Save();
            LoadListBackColor();
        }
        public void LoadListBackColor()
        { mainForm.tlvAnime.BackColor = Properties.Settings.Default.StyleListBackColor; }

        public void LoadListSelectedForeColor(Color color) {
            Properties.Settings.Default.StyleListSelectedForeColor = color;
            Properties.Settings.Default.Save();
            LoadListSelectedForeColor();
        }
        public void LoadListSelectedForeColor()
        { mainForm.tlvAnime.HighlightForegroundColor = Properties.Settings.Default.StyleListSelectedForeColor; }

        public void LoadListSelectedBackColor(Color color) {
            Properties.Settings.Default.StyleListSelectedBackColor = color;
            Properties.Settings.Default.Save();
            LoadListSelectedBackColor();
        }
        public void LoadListSelectedBackColor() {
            mainForm.tlvAnime.HighlightBackgroundColor = Properties.Settings.Default.StyleListSelectedBackColor;
            mainForm.setHotItemColor(Properties.Settings.Default.StyleListSelectedBackColor); // change hot item color too
        }

    }
}
