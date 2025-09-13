using ArtReferenceTimedViewerLibrary.DataRecords;
using ArtReferenceTimedViewerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtReferenceTimedViewer
{
    public partial class StatisticsForm : Form
    {
        private TotalData _totalData;
        public StatisticsForm(TotalData totalData)
        {
            InitializeComponent();
            _totalData = totalData;
        }

        private void SetValues()
        {
            _usageStatisticsTotalImagesLabel.Text = $"Total images completed: {_totalData.TotalImagesCount}";
            Helpers.FormattingHelper.SetTimeFromSeconds("Total time spent: ", _usageStatisticsTotalTimeLabel, _totalData.TotalTime, false);

            int avgTimePerImage = _totalData.TotalImagesCount == 0 ? 0 : _totalData.TotalTime / _totalData.TotalImagesCount;
            Helpers.FormattingHelper.SetTimeFromSeconds("Average time per image: ", _usageStatisticsAverageTimePerImageLabel, avgTimePerImage, false);

            _usageStatisticsTotalNumberOfActiveDays.Text = $"Total number of active days: {_totalData.Days.Count}";

            int avgImagesPerDay = _totalData.Days.Count == 0 ? 0 : _totalData.TotalImagesCount / _totalData.Days.Count;
            _usageStatisticsAverageImagesPerDayLabel.Text = $"Average images per active day: {avgImagesPerDay}";

            int avgTimePerDay = _totalData.Days.Count == 0 ? 0 : _totalData.TotalTime / _totalData.Days.Count;
            Helpers.FormattingHelper.SetTimeFromSeconds("Average time per active day: ", _usageStatisticsAverageTimePerDayLabel, avgTimePerDay, false);
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            SetValues();
        }
    }
}
