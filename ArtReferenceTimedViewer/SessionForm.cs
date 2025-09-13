using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtReferenceTimedViewer.Properties;
using ArtReferenceTimedViewerLibrary;
using ArtReferenceTimedViewerLibrary.DataRecords;
using ArtReferenceTimedViewerLibrary.Enums;
using ArtReferenceTimedViewerLibrary.Helpers;
using ArtReferenceTimedViewerLibrary.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace ArtReferenceTimedViewer
{
    public partial class SessionForm : Form
    {
        private SessionSettings _sessionSettings;
        private Session _session;
        private bool _cancelSession = false;
        private Task? _sessionTask;
        private System.Timers.Timer _timer = new(1000);
        private string? _currentImagePath;
        private int _currentTimeWindow;
        private int _currentTimePassed;
        private object _currentImageIdentifierObj;
        private object _timerLock = new();
        private bool _paused = false;

        private SessionData _sessionData;
        public SessionData SessionData
        {
            get { return _sessionData; }
        }
        public SessionForm(SessionSettings sessionSettings, Session session)
        {
            InitializeComponent();
            _sessionSettings = sessionSettings;
            _session = session;
            _sessionData = new();
            _timer.Elapsed += TimerTick;
        }

        private void SessionForm_Load(object sender, EventArgs e)
        {
            ApplyFormSettings();
            _sessionTask = Task.Run(() => RunSessionAsync());
        }
        private void ApplyFormSettings()
        {
            _currentTimeLabel.Visible = _sessionSettings.ShowCurrentTimer;
            _currentImageProgressBar.Visible = _sessionSettings.ShowCurrentProgressBar;
            if (!_sessionSettings.EnableSessionControl)
            {
                _skipBackButtonPictureBox.Enabled = false;
                _skipBackButtonPictureBox.Visible = false;
                _pauseSessionButtonPictureBox.Enabled = false;
                _pauseSessionButtonPictureBox.Visible = false;
                _skipForwardButtonPictureBox.Enabled = false;
                _skipForwardButtonPictureBox.Visible = false;
            }
        }
        private async Task RunSessionAsync()
        {
            // _timer = new(1000);

            await Task.Run(() => SetCurrentImage());
        }
        private void SkipNext()
        {
            object ownImageIdentifierObj = new();
            _currentImageIdentifierObj = ownImageIdentifierObj;
            SessionTraversalStatus currentImageStatus = _session.NextImage();
            (_currentImagePath, _currentTimeWindow) = _session.CurrentImage();
            DialogForm dialogForm;

            if (currentImageStatus == SessionTraversalStatus.NO_MORE_IMAGES)
            {
                // _timer.Stop();
                dialogForm = new DialogForm("Error: ran out of images. :O");
                dialogForm.ShowDialog();
                _cancelSession = true;
                return;
            }
            else if (currentImageStatus == SessionTraversalStatus.END_OF_SESSION)
            {
                // _timer.Stop();
                dialogForm = new DialogForm("End of session. Can't go any further. Thanks for playing :)");
                dialogForm.ShowDialog();
                _cancelSession = true;
                return;
            }
            SetCurrentImage();
        }
        private async void SetCurrentImage()
        {
            (_currentImagePath, _currentTimeWindow) = _session.CurrentImage();
            if (_currentImagePath is null)
            {
                _timer.Stop();
                DialogForm dialogForm = new DialogForm("Unknown error. :(");
                dialogForm.ShowDialog();
                _cancelSession = true;
                return;
            }
            //_currentImagePictureBox.Image = Image.FromFile(_currentImagePath);

            try
            {
                ThreadHelper.SetImage(this, _currentImagePictureBox, Image.FromFile(_currentImagePath));
            }
            catch
            {
                ThreadHelper.SetImage(this, _currentImagePictureBox, Resources.error_loading_image);
            }


            int sessionCurrentProgress = _session.SessionIndex < _session.SessionMax ? _session.SessionIndex + 1 : _session.SessionMax;
            ThreadHelper.SetText(this, _sessionProgressTextLabel, $"{sessionCurrentProgress}/{_session.SessionMax}");
            TimerSet();
        }
        private void TimerSet()
        {
            lock (_timerLock)
            {
                // _timer.Elapsed += TimerTick

                _currentTimePassed = 0;
                SetTimerText();
                _timer.Start();
            }
        }
        private void TimerTick(object? sender, EventArgs e)
        {
            _currentTimePassed++;
            if (_currentTimePassed >= _currentTimeWindow)
            {
                _timer.Stop();
                _sessionData.AddImage(_currentTimeWindow);
                SetTimerText();
                SkipNext();
            }
            else
            {
                SetTimerText();
            }
        }
        private void SetTimerText()
        {
            int timeLeft = _currentTimeWindow - _currentTimePassed;
            ThreadHelper.SetText(this, _currentTimeLabel, $"{timeLeft / 60:D2}:{timeLeft % 60:D2}");
            if (_currentImageProgressBar.Visible)
            {
                int progressValue = _currentTimeWindow == 0 ? 0 : (int) Math.Round( 100 * ((float)_currentTimePassed / _currentTimeWindow) );
                ThreadHelper.SetProgressBar(this, _currentImageProgressBar, progressValue);
            }
        }
        private void EndSession()
        {
            _timer.Stop();
        }
        private void _endSessionButtonPictureBox_Click(object sender, EventArgs e)
        {
            EndSession();
            this.Close();
        }

        // yes async is not being used here really
        private async void _skipForwardButtonPictureBox_Click(object sender, EventArgs e)
        {
            if (_paused)
            {
                _paused = false;
                _pauseSessionButtonPictureBox.Image = Properties.Resources.button_pause;
            }
            SkipNext();
        }

        private void _pauseSessionButtonPictureBox_Click(object sender, EventArgs e)
        {
            if (_paused)
            {
                _timer.Start();
                _pauseSessionButtonPictureBox.Image = Properties.Resources.button_pause;
            }
            else
            {
                _timer.Stop();
                _pauseSessionButtonPictureBox.Image = Properties.Resources.button_play;
            }
            _paused = !_paused;
        }

        private void _skipBackButtonPictureBox_Click(object sender, EventArgs e)
        {
            SessionTraversalStatus skipBackStatus = _session.LastImage();
            DialogForm dialogForm;
            if (skipBackStatus == SessionTraversalStatus.START_OF_SESSION)
            {
                dialogForm = new DialogForm("Error: no preceding images to skip to.");
                dialogForm.ShowDialog();
                return;
            }
            if (skipBackStatus == SessionTraversalStatus.NO_MORE_IMAGES)
            {
                dialogForm = new DialogForm("Error: something went wrong :(.");
                dialogForm.ShowDialog();
                return;
            }
            SetCurrentImage();
        }

        private void SessionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EndSession();
        }
    }
}
