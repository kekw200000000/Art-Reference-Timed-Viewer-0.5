using ArtReferenceTimedViewerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtReferenceTimedViewer
{
    public partial class SettingsForm : Form
    {
        private SessionSettings _sessionSettings;
        public SettingsForm(SessionSettings sessionSettings)
        {
            InitializeComponent();
            _sessionSettings = sessionSettings;
        }


        private void _enableCurrentTimerSettingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _sessionSettings.ShowCurrentTimer = _enableCurrentTimerSettingCheckBox.Checked;
        }

        private void _enableCurrentProgressBarSettingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _sessionSettings.ShowCurrentProgressBar = _enableCurrentProgressBarSettingCheckBox.Checked;
        }

        private void _enableSessionProgressBarSettingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _sessionSettings.ShowSessionProgressBar = _enableSessionProgressBarSettingCheckBox.Checked;
        }

        private void _enableRepeatsSettingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _sessionSettings.EnableRepeats = _enableRepeatsSettingCheckBox.Checked;
        }

        private void _disableInSessionControlsSettingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _sessionSettings.EnableSessionControl = !_disableInSessionControlsSettingCheckBox.Checked;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            _enableCurrentTimerSettingCheckBox.Checked = _sessionSettings.ShowCurrentTimer;
            _enableCurrentProgressBarSettingCheckBox.Checked = _sessionSettings.ShowCurrentProgressBar;
            _enableSessionProgressBarSettingCheckBox.Checked = _sessionSettings.ShowSessionProgressBar;
            _enableRepeatsSettingCheckBox.Checked = _sessionSettings.EnableRepeats;
            _disableInSessionControlsSettingCheckBox.Checked = !_sessionSettings.EnableSessionControl;
        }
    }
}
