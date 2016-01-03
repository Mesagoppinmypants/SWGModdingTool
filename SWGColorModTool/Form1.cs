using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWGColorModTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer illuminati = new SoundPlayer(Properties.Resources.illuminati);
        Process TreExplorer = Process.GetProcessesByName("TRE Explorer").FirstOrDefault();

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Properties.Settings.Default.SWGRebornDir) && !Directory.Exists(Properties.Settings.Default.TREDir))
            {
                DialogResult setupdirs = MessageBox.Show("ERROR: Both your TRE Explorer directory and SWG Reborn directory are blank, would you like to configure those?", "Configure Directories", MessageBoxButtons.YesNo);

                if (setupdirs == DialogResult.Yes)
                {
                    ConfigRebornDir();
                    ConfigTREDir();
                }
            }
            else if (!Directory.Exists(Properties.Settings.Default.SWGRebornDir))
            {
                ConfigRebornDir();
            }
            else if (!Directory.Exists(Properties.Settings.Default.TREDir))
            {
                ConfigTREDir();
            }

            if (!Directory.Exists(RebornDirTextBox.Text + "\\palette"))
            {
                Directory.CreateDirectory(RebornDirTextBox.Text + "\\palette");
            }

            if (TreExplorer != null) // Closes out any TRE Explorers that are already running
            {
                TreExplorer.Kill();
            }

            if (Properties.Settings.Default.LightsaberColorBefore != "" || Properties.Settings.Default.LightsaberColorAfter != "")
            {
                try
                {
                    if (File.Exists(RebornDirTextBox.Text + "\\palette\\wp_lightsaber.pal"))
                    {
                        Process.Start(TREDirTextBox.Text + "\\TRE Explorer.exe", RebornDirTextBox.Text + "\\palette\\wp_lightsaber.pal");
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Unable to find wp_lightsaber.pal in palette directory.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("EXCEPTION ERROR: Something went wrong while trying to open wp_lightsaber.pal. If this error keeps occurring, please contact Iosnowore.");
                }
            }

            //Process.Start(RebornDirTextBox.Text + "\\sku0_client.toc");
            //Thread.Sleep(8000); // Wait for TRE Explorer to load
            //GoToPalette();

            //FirstRowTimer.Enabled = true;
            //FirstRowTimer.Start();
        }

        private void LoadNewLightsaberPal()
        {

        }

        private void ConfigTREDir()
        {
            FolderBrowserDialog browseTREDir = new FolderBrowserDialog();
            browseTREDir = new FolderBrowserDialog();
            browseTREDir.Description = "Please select your TRE Explorer directory.";
            browseTREDir.ShowDialog();
            if (File.Exists(browseTREDir.SelectedPath + "\\TRE Explorer.exe"))
            {
                Properties.Settings.Default.TREDir = browseTREDir.SelectedPath;
                Properties.Settings.Default.Save();
                TREDirTextBox.Text = Properties.Settings.Default.TREDir;
                MessageBox.Show("You have successfully configured your TRE Explorer directory path.", "Success");
            }

            if (!File.Exists(browseTREDir.SelectedPath + "\\Tre Explorer.exe"))
            {
                //MessageBox.Show("ERROR: The directory that you have chosen is an invalid TRE Explorer directory.", "Error");
            }
        }

        private void ConfigRebornDir()
        {
            FolderBrowserDialog browseRebornDir = new FolderBrowserDialog();
            browseRebornDir.Description = "Please select your SWG Reborn game directory.";
            browseRebornDir.ShowDialog();
            if (File.Exists(browseRebornDir.SelectedPath + "\\SwgClient_r.exe"))
            {
                Properties.Settings.Default.SWGRebornDir = browseRebornDir.SelectedPath;
                Properties.Settings.Default.Save();
                RebornDirTextBox.Text = Properties.Settings.Default.SWGRebornDir;
                MessageBox.Show("You have successfully configured your SWG Reborn directory path.", "Success");
                browseRebornDir.Dispose();
            }

            if (!File.Exists(browseRebornDir.SelectedPath + "\\SwgClient_r.exe"))
            {
                //MessageBox.Show("ERROR: The directory that you have chosen is an invalid SWG Reborn game directory.", "Error");
            }
            
        }

        private void GoToPalette()
        {
            if (TreExplorer != null)
            {
                IntPtr h = TreExplorer.MainWindowHandle;
                SetForegroundWindow(h);
                //SendKeys.SendWait("^{f}");
                //SendKeys.SendWait("wp_lightsaber.pal");
                //SendKeys.SendWait("{ENTER}");
                //SendKeys.SendWait("{ESC}");
                //SetForegroundWindow(h);
                //SendKeys.SendWait("{DOWN}");
                // TODO: Implement a way to select the option wanted.
                //SendKeys.SendWait("DIR {ENTER}"); //Selects color and closes program.
            }
        }

        private void FirstRowTimer_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, this function isn't implemented yet.", "Function Not Implemented");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CloseProgramsCheckBox.Checked = Properties.Settings.Default.ClosePrograms;
            
            illuminati.PlayLooping();
            RebornDirTextBox.Text = Properties.Settings.Default.SWGRebornDir;
            TREDirTextBox.Text = Properties.Settings.Default.TREDir;
            PlacePaletteFiles();
        }

        private void PlacePaletteFiles()
        {
            if (!File.Exists(RebornDirTextBox.Text + "\\palette\\wp_lightsaber.pal"))
            {
                // TODO: Implement a way to load wp_lightsaber palette file from Resources
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ClosePrograms = CloseProgramsCheckBox.Checked;
            Properties.Settings.Default.Save();
            if (CloseProgramsCheckBox.Checked == true)
            {
                TreExplorer.Kill();
            }
            ClearSelectedMods();
        }

        private void ClearSelectedMods()
        {
            // Resets the lightsaber color mod values
            Properties.Settings.Default.LightsaberColorBefore = "";
            Properties.Settings.Default.LightsaberColorAfter = "";
            Properties.Settings.Default.Save();
        }

        private void InstallModsButton_Click(object sender, EventArgs e)
        {
            if (Environment.UserName != "Gene") // For testing purposes, if you want to test it you can just change it to your computer name.
            {
                MessageBox.Show("Sorry, this function isn't implemented yet.", "Function Not Implemented");
            }
            else
            {
                ModList ml = new ModList();
                ml.ShowDialog();
            }
        }

        private void DisableMusicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DisableMusicCheckBox.Checked == true)
            {
                illuminati.Stop();
            }
            else
            {
                illuminati.PlayLooping();
            }
        }
    }
}
