using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Properties.Settings.Default.LightsaberColorBefore = BeforeComboBox.Text;
                Properties.Settings.Default.LightsaberColorAfter = AfterComboBox.Text;
                Properties.Settings.Default.Save();
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
    }
}
