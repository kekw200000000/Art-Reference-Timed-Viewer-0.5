using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtReferenceTimedViewerLibrary.DataRecords
{
    public class TotalData
    {
        public Dictionary<DateOnly, DayData> Days { get; set; }
        public int TotalImagesCount { get; set; }
        public int TotalTime { get; set; }
        public TotalData()
        {
            Days = new();
            TotalImagesCount = 0;
        }
        public void AddSession(SessionData sessionData)
        {
            DayData? today;
            if (!Days.TryGetValue(sessionData.SessionDate, out today))
            {
                today = new DayData(sessionData.SessionDate);
                Days.Add(sessionData.SessionDate, today);
            }
            today.AddSession(sessionData);
            TotalImagesCount += sessionData.SessionProgress.Count;
            TotalTime += sessionData.SessionTime;
        }
    }
}
