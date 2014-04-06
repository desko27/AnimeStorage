﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AnimeStorage
{
    public partial class FWaitingApi : KryptonForm
    {

        // ==================================================
            # region init stuff
        // ==================================================

        public AnimeClass result, anime;
        
        private int id;
        private MainForm mainForm;
        
        BackgroundWorker bw = new BackgroundWorker();

        public FWaitingApi(MainForm mainForm, int id)
        {
            InitializeComponent();

            // propagate 'move window'
            pMain.MouseDown += moveWindow;
            foreach (Control item in pMain.Controls) item.MouseDown += moveWindow;

            // load incoming data
            this.mainForm = mainForm;
            this.id = id;

            // start anime query
            // --------------------------------------------------
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.RunWorkerAsync();
            lStatus.Text = "Requesting data...";
            // ---
        }

            #endregion

        // ==================================================
            # region thread -> api query job
        // ==================================================

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        { result = ApiRequest.Anime(id); }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            anime = new AnimeClass(mainForm, result.ID, result.Picture, result.Name, result.Year, result.Episodes, result.Rating, result.Japanese);
            this.DialogResult = DialogResult.OK;
            Close();
        }

            #endregion

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
        private void moveWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

            #endregion

    }
}
