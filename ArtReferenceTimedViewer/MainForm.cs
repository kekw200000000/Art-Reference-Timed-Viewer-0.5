using ArtReferenceTimedViewerLibrary.DataRecords;
using ArtReferenceTimedViewerLibrary.Helpers;
using ArtReferenceTimedViewerLibrary.Models;
using System.Text.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
#nullable enable

namespace ArtReferenceTimedViewer
{
    public partial class MainForm : Form
    {
        private SessionSettings? _sessionSettings;
        private GeneralSettings? _generalSettings;
        private DataHelper _dataHelper;
        private TotalData _totalData;
        private DayData _dayData;
        private SessionData? _sessionData;
        private (bool Format,
                 bool Subfolders,
                 bool MainFolder) _inputValid = (false, false, false);
        private bool InputValid     // convenient instead of making a method (that's why the large I at the start of the name)
        {
            get => _inputValid.Format && _inputValid.Subfolders && _inputValid.MainFolder;
        }
        public MainForm()
        {
            _dataHelper = new();
            _sessionSettings = new();
            _generalSettings = new();
            _dayData = new();
            _totalData = new();
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            // not sure what this method is, either to be implemented or to be deleted?
        }

        private void _showHelpFormButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void _mainFolderSelectionButton_Click(object sender, EventArgs e)
        {
            _mainFolderSelectionFolderBrowserDialog.ShowDialog();
            _mainFolderCurrentPathLabel.Text = (_mainFolderSelectionFolderBrowserDialog.SelectedPath);
            _generalSettings.MainFolderLastPath = _mainFolderSelectionFolderBrowserDialog.SelectedPath;

            _inputValid.MainFolder = !String.IsNullOrWhiteSpace(_generalSettings.MainFolderLastPath);
            _startSessionButton.Enabled = InputValid;
        }
        private void _mainFolderSelectionChanged() // custom for initialization
        {
            _mainFolderCurrentPathLabel.Text = _generalSettings.MainFolderLastPath;

            _inputValid.MainFolder = !String.IsNullOrWhiteSpace(_generalSettings.MainFolderLastPath);
            _startSessionButton.Enabled = InputValid;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetAll(sender, e);
        }
        private async void MainForm_Shown(object sender, EventArgs e)
        {
            this.Refresh();

            // in case this for some reason takes long (the Settings file being parsed is super short so maybe the file
            // system hangs up or whatever) and the user changes some settings in the meantime,
            // they are going to get overwritten same with if the user
            //
            // finishes a session before the statistics data is loaded

            await LoadSettingsData();
            SetAll(sender, e);
            await LoadStatisticsData();
            SetDayStatistics();

            _showStatisticsButton.Enabled = true;
            _loadingDataLabel.Visible = false;
        }
        private void SetAll(object sender, EventArgs e)
        {
            _blacklistModeEnabledCheckbox.Checked = _generalSettings.BlacklistModeEnabled
                ;

            _sessionFormatTextBox.Text = _generalSettings.SessionFormatLastText;
            _sessionFormatTextBox_TextChanged(sender, e);   // the parameters don't matter so just passing these to avoid having to create new ones
            _subfolderSelectionTextBox.Text = _generalSettings.SubfoldersLastText;
            _subfolderSelectionTextBox_TextChanged(sender, e);
            _mainFolderSelectionFolderBrowserDialog.SelectedPath = _generalSettings.MainFolderLastPath;
            _mainFolderSelectionChanged();
        }
        private void SetDayStatistics()
        {
            ThreadHelper.SetText(this, _todayStatisticsImagesLabel, $"{_dayData.ImagesCount} images");
            if (_dayData.Time >= 3600)
            {
                ThreadHelper.SetText(this, _todayStatisticsMinutesLabel, $"{_dayData.Time / 3600}h{(_dayData.Time % 3600) / 60:D2}m{_dayData.Time % 60:D2}s");
            }
            else
            {
                ThreadHelper.SetText(this, _todayStatisticsMinutesLabel, $"{_dayData.Time / 60:D2}m{_dayData.Time % 60:D2}s");
            }

            int secsPerImage = _dayData.ImagesCount == 0 ? 0 : _dayData.Time / _dayData.ImagesCount;
            if (secsPerImage >= 60)
            {
                ThreadHelper.SetText(this, _todayStatisticsAvgPerImageLabel, $"average {secsPerImage / 60:D2}:{secsPerImage % 60:D2}/image");
            }
            else
            {
                ThreadHelper.SetText(this, _todayStatisticsAvgPerImageLabel, $"average {secsPerImage} seconds/image");
            }
        }
        private async Task LoadSettingsData()
        {
            SettingsWrapper? settings = await _dataHelper.LoadSettingsDataAsync();
            if (settings != null)
            {
                if (settings.SessionSettings != null)
                {
                    _sessionSettings = settings.SessionSettings;
                }
                if (settings.GeneralSettings != null)
                {
                    _generalSettings = settings.GeneralSettings;
                }
            }
        }
        private async Task LoadStatisticsData()
        {
            DayData dayData = await _dataHelper.LoadDayDataAsync();
            if (dayData != null)
            {
                _dayData = dayData;
            }

            TotalData totalData = await _dataHelper.LoadTotalDataAsync();
            if (totalData != null)
            {
                _totalData = totalData;
            }
        }

        // All these format checking methods could be run asynchronously but I feel like, considering the average
        // length of format inputs (very short), it would be slower because of the async overhead?
        // So I just run the check synchronously.
        private void _sessionFormatTextBox_TextChanged(object sender, EventArgs e)
        {
            _inputValid.Format = InputHelper.IsValidSessionFormat(_sessionFormatTextBox.Text);
            _incorrectSessionFormatEnteredWarning.Visible = !_inputValid.Format;
            _startSessionButton.Enabled = InputValid;
        }

        private void _subfolderSelectionTextBox_TextChanged(object sender, EventArgs e)
        {
            _inputValid.Subfolders = InputHelper.IsValidSubfolderSelection(_subfolderSelectionTextBox.Text);
            _incorrectSubfoldersEnteredWarning.Visible = !_inputValid.Subfolders;
            _startSessionButton.Enabled = InputValid;
            if (String.IsNullOrEmpty(_subfolderSelectionTextBox.Text) && _generalSettings.BlacklistModeEnabled)
            {
                _inputValid.Subfolders = true;
                _incorrectSubfoldersEnteredWarning.Visible = false;
                _startSessionButton.Enabled = InputValid;
            }
            _subfoldersNotFoundWarningLabel.Visible = false;
        }

        private void _showSettingsFormButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(_sessionSettings);
            settingsForm.ShowDialog();
        }

        private void _showStatisticsButton_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm(_totalData);
            statisticsForm.ShowDialog();
        }

        private async void _startSessionButton_Click(object sender, EventArgs e)
        {
            HashSet<string> subfoldersChosen = InputHelper.ParseSubfolderSelection(_subfolderSelectionTextBox.Text);

            if (!_generalSettings.BlacklistModeEnabled && !FileHelper.MainFolderContainsSubfolderss(_mainFolderSelectionFolderBrowserDialog.SelectedPath, subfoldersChosen))
            {
                _subfoldersNotFoundWarningLabel.Visible = true;
            }
            else
            {
                Session session = new Session(
                    InputHelper.ParseSessionFormat(_sessionFormatTextBox.Text),
                    FileHelper.GetImageSet(
                        _generalSettings.MainFolderLastPath,
                        subfoldersChosen,
                        _generalSettings.BlacklistModeEnabled),
                    _sessionSettings.EnableRepeats
                    );

                DateOnly sessionStartDate = DateOnly.FromDateTime(DateTime.Now);

                SessionForm? sessionForm = new SessionForm(_sessionSettings, session);
                sessionForm.ShowDialog();
                _startSessionButton.Enabled = false;
                _sessionData = sessionForm.SessionData;
                if (_dayData == null || !sessionStartDate.Equals(_sessionData.SessionDate))
                {
                    _dayData = new();
                    _dataHelper.ClearDayData();
                }

                // the session we get back could very well be "empty" as in having "0-0-" at the end
                // wasn't sure whether to count these as sessions or not (matters only for active day logging)
                // leaving it in for now
                await _dataHelper.LogSessionAsync(_sessionData);
                _totalData.AddSession(_sessionData);
                _dayData.AddSession(_sessionData);
                SetDayStatistics();
                sessionForm = null;
                _startSessionButton.Enabled = true;
            }
        }

        private void _blacklistModeEnabledCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            _generalSettings.BlacklistModeEnabled = _blacklistModeEnabledCheckbox.Checked;
            _subfolderSelectionTextBox_TextChanged(sender, e);
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _generalSettings.SessionFormatLastText = _sessionFormatTextBox.Text;
            _generalSettings.SubfoldersLastText = _subfolderSelectionTextBox.Text;

            JsonHelper.SerializeSettings(new SettingsWrapper(_generalSettings, _sessionSettings), _dataHelper.SettingsDataFileName);
        }
    }
}
