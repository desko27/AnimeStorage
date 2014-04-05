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

namespace AnimeStorage
{
    public partial class FWaitingApi : KryptonForm
    {

        // ==================================================
            # region init stuff
        // ==================================================

        public AnimeClass result, anime;
        public Dictionary<string, object> r;
        
        private int id;
        private MainForm mainForm;
        
        BackgroundWorker bw = new BackgroundWorker();

        public FWaitingApi(MainForm mainForm, int id)
        {
            InitializeComponent();

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
            anime = new AnimeClass(mainForm, result.ID, result.Picture, result.Name, result.Year, result.Rating, result.Japanese);
            this.DialogResult = DialogResult.OK;
            Close();
        }

            #endregion
    }
}
