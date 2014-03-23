using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace AnimeStorage
{
    public partial class FormConsole : KryptonForm
    {
        private MainForm mainForm;
        private List<string> history = new List<string>();
        private int history_index = 0;

        public FormConsole(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        // ==================================================
            # region console functions
        // ==================================================

        public void WriteLine(string msg) { tConsole.Text += msg + "\n"; }
        public void ReadCommand(string msg)
        {
            string[] cmd = msg.Trim().Split(' ');
            switch (cmd[0])
            {
                default:
                    this.WriteLine("Unknown command!");
                    break;

                case "check":

                    if (cmd.Length < 2) { this.WriteLine("Bad arguments!"); break; }
                    switch (cmd[1])
                    {
                        default:
                            this.WriteLine("Bad arguments!");
                            break;

                        case "olv":
                            this.WriteLine(String.Format("`anime` list size -> anime({0}) olv({1})", mainForm.anime.Count, mainForm.olvAnime.Items.Count));
                            break;
                    }
                    break;

                case "exit":
                case "close":
                    mainForm.Close();
                    break;

                case "quit":
                case "hide":
                    this.Hide();
                    break;
            }
        }

        private void HistoryBrowse(int step)
        {
            history_index += step;
            if (history_index == history.Count) {
                tPrompt.Text = "";
                return;
            }
            tPrompt.Text = history[history_index];
            tPrompt.SelectionStart = tPrompt.Text.Length;
        }
        private void HistoryAdd()
        {
            string command = tPrompt.Text;
            tPrompt.Text = "";
            this.ReadCommand(command);
            
            // don't add repeated commands
            bool repeated = false;
            if (history_index > 0 && history[history.Count - 1] == command) repeated = true;
            if (!repeated) history.Add(command);
            history_index = history.Count;
        }

            #endregion

        // ==================================================
            # region automatic events
        // ==================================================

        // set focus to the prompt
        private void FormConsole_Activated(object sender, EventArgs e) { tPrompt.Focus(); }

            #endregion

        // ==================================================
            # region interface events
        // ==================================================

        // avoid the form to be destroyed when closing it through the window `x` button
        private void FormConsole_FormClosing(object sender, FormClosingEventArgs e) { this.Hide(); e.Cancel = true; }

        // send commands through the bottom textbox (prompt)
        private void tPrompt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { e.Handled = true; HistoryAdd(); }
            else if (e.KeyCode == Keys.Up) { e.Handled = true; if (history_index > 0) HistoryBrowse(-1); }
            else if (e.KeyCode == Keys.Down) { e.Handled = true; if (history_index < history.Count) HistoryBrowse(1); }
        }
            
            #endregion

    }
}
