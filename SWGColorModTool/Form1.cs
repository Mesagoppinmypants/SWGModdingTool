using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
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

        private void KillTreExplorer()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("TRE Explorer"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Properties.Settings.Default.SWGRebornDir) && !Directory.Exists(Properties.Settings.Default.TREDir))
            {
                DialogResult setupdirs = MessageBox.Show("ERROR: Your SWG Reborn directory is blank, would you like to configure it?", "Configure SWG Reborn Directory", MessageBoxButtons.YesNo);

                if (setupdirs == DialogResult.Yes)
                {
                    ConfigRebornDir();
                }
            }
            else if (!Directory.Exists(Properties.Settings.Default.SWGRebornDir))
            {
                ConfigRebornDir();
            }

            if (!Directory.Exists(RebornDirTextBox.Text + "\\palette"))
            {
                Directory.CreateDirectory(RebornDirTextBox.Text + "\\palette");
            }

            if (TreExplorer != null) // Closes out any TRE Explorers that are already running
            {
                KillTreExplorer();
            }

            if (Properties.Settings.Default.LightsaberColorBefore != "" || Properties.Settings.Default.LightsaberColorAfter != "")
            {
                try
                {
                    if (File.Exists(RebornDirTextBox.Text + "\\palette\\wp_lightsaber.pal"))
                    {
                        Process.Start("TRE Explorer.exe", RebornDirTextBox.Text + "\\palette\\wp_lightsaber.pal");
                    }
                    else
                    {
                        PlacePaletteFiles();
                    }
                }
                catch (Exception)
                {
                    if (!File.Exists(Application.StartupPath + "\\Resources\\wp_lightsaber.pal"))
                    {
                        MessageBox.Show("ERROR: Unable to install mod, you are missing a palette file", "Error: Missing .PAL File");
                    }
                }

                // Begin to make mod changes
                if (File.Exists(RebornDirTextBox.Text + "\\palette\\wp_lightsaber.pal"))
                {
                    Thread.Sleep(3000);

                    if (Properties.Settings.Default.LightsaberColorBefore == "Red")
                    {
                        ChangeRed();
                    }
                    else if (Properties.Settings.Default.LightsaberColorBefore == "Blue")
                    {
                        ChangeBlue();
                    }
                    else if (Properties.Settings.Default.LightsaberColorBefore == "Green")
                    {
                        ChangeLightGreen();
                    }
                    else if (Properties.Settings.Default.LightsaberColorBefore == "Green")
                    {
                        ChangeYellow();
                    }
                    SendKeys.SendWait("DIR {ENTER}");
                    SendKeys.SendWait("^{s}");
                    KillTreExplorer();
                    MessageBox.Show("Mod has been successfully installed!", "Success");

                    if (Properties.Settings.Default.LightsaberColorBefore == "" && Properties.Settings.Default.LightsaberColorAfter == "")
                    {
                        MessageBox.Show("There is currently no mod to install.");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: File wp_lightsaber.pal not found.");
                }
            }
        }

        private void ChangeRed()
        {
            SendKeys.SendWait("{ENTER}");
            SendKeys.SendWait("{F2}");

            if (Properties.Settings.Default.LightsaberColorAfter == "Blue")
            {
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{DOWN}");
                SendKeys.SendWait("{DOWN}");
            }
            else if (Properties.Settings.Default.LightsaberColorAfter == "Green")
            {
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{DOWN}");
            }
            else if (Properties.Settings.Default.LightsaberColorAfter == "Yellow")
            {
                SendKeys.SendWait("{RIGHT}");
            }
        }

        private void ChangeBlue()
        {
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{ENTER}");
            SendKeys.SendWait("{F2}");

            if (Properties.Settings.Default.LightsaberColorAfter == "Green")
            {
                SendKeys.SendWait("{LEFT}");
                SendKeys.SendWait("{LEFT}");
                SendKeys.SendWait("{UP}");
            }
            else if (Properties.Settings.Default.LightsaberColorAfter == "Red")
            {
                SendKeys.SendWait("{LEFT}");
                SendKeys.SendWait("{LEFT}");
                SendKeys.SendWait("{LEFT}");
                SendKeys.SendWait("{LEFT}");
                SendKeys.SendWait("{UP}");
                SendKeys.SendWait("{UP}");

            }
            else if (Properties.Settings.Default.LightsaberColorAfter == "Yellow")
            {
                SendKeys.SendWait("{LEFT}");
                SendKeys.SendWait("{LEFT}");
                SendKeys.SendWait("{LEFT}");
                SendKeys.SendWait("{UP}");
                SendKeys.SendWait("{UP}");
            }
        }

        private void ChangeLightGreen()
        {
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{ENTER}");
            SendKeys.SendWait("{F2}");

            if (Properties.Settings.Default.LightsaberColorAfter == "Blue")
            {
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{DOWN}");
            }
            else if (Properties.Settings.Default.LightsaberColorAfter == "Red")
            {
                SendKeys.SendWait("{LEFT}");
                SendKeys.SendWait("{LEFT}");
                SendKeys.SendWait("{UP}");
            }
            else if (Properties.Settings.Default.LightsaberColorAfter == "Yellow")
            {
                SendKeys.SendWait("{LEFT}");
                SendKeys.SendWait("{UP}");
            }
        }

        private void ChangeYellow()
        {
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{RIGHT}");
            SendKeys.SendWait("{ENTER}");
            SendKeys.SendWait("{F2}");

            if (Properties.Settings.Default.LightsaberColorAfter == "Blue")
            {
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{DOWN}");
                SendKeys.SendWait("{DOWN}");
            }
            else if (Properties.Settings.Default.LightsaberColorAfter == "Red")
            {
                SendKeys.SendWait("{LEFT}");
            }
            else if (Properties.Settings.Default.LightsaberColorAfter == "Green")
            {
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{DOWN}");
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
                MessageBox.Show("ERROR: The directory that you have chosen is an invalid SWG Reborn game directory.", "Error");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, this function isn't implemented yet.", "Function Not Implemented");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CloseProgramsCheckBox.Checked = Properties.Settings.Default.ClosePrograms;
            RebornDirTextBox.Text = Properties.Settings.Default.SWGRebornDir;
            Properties.Settings.Default.LightsaberColorBefore = "";
            Properties.Settings.Default.LightsaberColorAfter = "";

            illuminati.PlayLooping();
            PlacePaletteFiles();
        }

        private void PlacePaletteFiles()
        {
            if (RebornDirTextBox.Text == "")
            {
                ConfigRebornDir(); // Needs to config the game directory before it can place the palette files
            }
            else
            {
                if (!File.Exists(RebornDirTextBox.Text + "\\palette\\wp_lightsaber.pal"))
                {
                    File.Copy(Application.StartupPath + "\\Resources\\wp_lightsaber.pal", RebornDirTextBox.Text + "\\palette\\wp_lightsaber.pal"); // Instead of placing a backup file in the directory, it would be better if it was placed inside the actuall program.
                }
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
            //ClearSelectedMods();
            Properties.Settings.Default.LightsaberColorBefore = "";
            Properties.Settings.Default.LightsaberColorAfter = "";
            Properties.Settings.Default.Save();
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
            ModList ml = new ModList();
            ml.ShowDialog();
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
