using System;
using System.IO;
using System.Windows.Forms;

namespace SWGColorModTool
{
    public partial class ModList : Form
    {
        public ModList()
        {
            InitializeComponent();
        }

        private void ModToInstallComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModToInstallComboBox.SelectedIndex >= 0)
            {
                BeforeComboBox.Enabled = true;
                AfterComboBox.Enabled = true;
            }
            else
            {
                BeforeComboBox.Enabled = false;
                AfterComboBox.Enabled = false;
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (ModToInstallComboBox.Text == "Lightsaber Color")
            {
                if (BeforeComboBox.Text == "Red" && AfterComboBox.Text == "Red")
                {
                    MessageBox.Show("Sorry, you cannot change your lightsaber blade to the color red if it's already red.", "Error");
                }
                else if (BeforeComboBox.Text == "Blue" && AfterComboBox.Text == "Blue")
                {
                    MessageBox.Show("Sorry, you cannot change your lightsaber blade to the color blue if it's already blue.", "Error");
                }
                else if (BeforeComboBox.Text == "Light Green" && AfterComboBox.Text == "Light Green")
                {
                    MessageBox.Show("Sorry, you cannot change your lightsaber blade to the color green if it's already green.", "Error");
                }
                else if (BeforeComboBox.Text == "Yellow" && AfterComboBox.Text == "Yellow")
                {
                    MessageBox.Show("Sorry, you cannot change your lightsaber blade to the color yellow if it's already yellow.", "Error");
                }
                else
                {
                    Properties.Settings.Default.LightsaberColorBefore = BeforeComboBox.Text;
                    Properties.Settings.Default.LightsaberColorAfter = AfterComboBox.Text;
                    Properties.Settings.Default.Save();
                }
            }
            Dispose();
        }

        private void ModList_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.LightsaberColorBefore != "" || Properties.Settings.Default.LightsaberColorAfter != "")
            {
                ModToInstallComboBox.Text = "Lightsaber Color";
                BeforeComboBox.Text = Properties.Settings.Default.LightsaberColorBefore;
                AfterComboBox.Text = Properties.Settings.Default.LightsaberColorAfter;
            }
        }

        private void DeleteAllModsButton_Click(object sender, EventArgs e)
        {
            DialogResult deletemods = MessageBox.Show("Are you sure you want to delete all installed mods?", "Warning", MessageBoxButtons.YesNo);
            if (deletemods == DialogResult.Yes)
            {
                string rebornDirPalette = Properties.Settings.Default.SWGRebornDir + "\\palette\\wp_lightsaber.pal";
                if (File.Exists(rebornDirPalette))
                {
                    File.Delete(rebornDirPalette);
                }
                else
                {
                    MessageBox.Show("No mods are currently installed.");
                }
            }
        }
    }
}
