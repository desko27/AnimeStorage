using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Reflection;
using System.Configuration;

namespace AnimeStorage
{
    public class SettingsBox
    {

        // ==================================================
            # region init stuff
        // ==================================================

        MainForm mainForm;
        public SettingsBox(MainForm mainForm) { this.mainForm = mainForm; }
        public void StartUp()
        {

            // load all settings but some of them
            foreach (SettingsProperty setting in Properties.Settings.Default.Properties)
                if (setting.Name != "Language") LoadSetting(setting.Name);

        }

            #endregion

        // ==================================================
            # region setting setter & getter
        // ==================================================

        public dynamic GetSetting(string setting)
        { return Properties.Settings.Default[setting];  }

        public void LoadSetting(string setting)
        {

            // prepare call
            string method_string = "Load_" + setting;
            var type = this.GetType();

            // do specific call using reflection
            if (type.GetMethod(method_string) != null) {
                MethodInfo method = type.GetMethod(method_string);
                method.Invoke(this, new object[] { Properties.Settings.Default[setting] });
            }

        }

            #endregion

        // ==================================================
            # region setting load functions
        // ==================================================

        // generic loading method
        public void LoadSetting(string setting, dynamic value)
        {

            // set & save value
            Properties.Settings.Default[setting] = value;
            Properties.Settings.Default.Save();

            // specific call
            LoadSetting(setting);

        }

        // specific setting loading methods
        // --------------------------------------------------
        public void Load_Language(string value)
        {
            string lang = Thread.CurrentThread.CurrentUICulture.ToString();
            switch (value) {
                case "Español (ES)": lang = "es-ES"; break;
                case "Català (CA)": lang = "ca-CA"; break;
            }
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
        }

        public void Load_StyleTheme(string value)
        {
            switch (value) {
                case "Mild Blue": mainForm.kryptonGlobals.GlobalPaletteMode = PaletteModeManager.Office2010Blue; break;
                case "Mild Black": mainForm.kryptonGlobals.GlobalPaletteMode = PaletteModeManager.Office2010Black; break;
                case "Mild Silver": mainForm.kryptonGlobals.GlobalPaletteMode = PaletteModeManager.Office2010Silver; break;
                case "Dark Blue": mainForm.kryptonGlobals.GlobalPaletteMode = PaletteModeManager.SparkleBlue; break;
                case "Dark Orange": mainForm.kryptonGlobals.GlobalPaletteMode = PaletteModeManager.SparkleOrange; break;
                case "Dark Purple": mainForm.kryptonGlobals.GlobalPaletteMode = PaletteModeManager.SparklePurple; break;
            }
        }

        public void Load_StyleListForeColor(Color value) { mainForm.tlvAnime.ForeColor = value; }
        public void Load_StyleListBackColor(Color value) { mainForm.tlvAnime.BackColor = value; }
        public void Load_StyleListSelectedBackColor(Color value) { mainForm.tlvAnime.HighlightBackgroundColor = value; }
        public void Load_StyleListSelectedForeColor(Color value) {
            mainForm.tlvAnime.HighlightForegroundColor = value;
            mainForm.setHotItemColor(value); // change hot item color too
        }

        public void Load_WindowSize(Size value) { mainForm.Size = value; }
        public void Load_WindowState(System.Windows.Forms.FormWindowState value) { mainForm.WindowState = value; }
        public void Load_LayoutHorizontal(int value) { mainForm.splitContainerMain.SplitterDistance = (int)(mainForm.splitContainerMain.Width * ((float)value/100)); }
        public void Load_LayoutVertical(int value) { mainForm.splitContainerRight.SplitterDistance = (int)(mainForm.splitContainerRight.Height * ((float)value / 100)); }
        public void Load_AL_PictureWidth(int value) { mainForm.cPicture.Width = value; }
        public void Load_AL_RowHeight(int value) { mainForm.tlvAnime.RowHeight = value; }
        // ---

            #endregion

    }
}
