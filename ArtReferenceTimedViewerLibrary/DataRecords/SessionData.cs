using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtReferenceTimedViewerLibrary.DataRecords
{
    public class SessionData
    {
        public List<int> SessionProgress { get; private set; }
        public int SessionTime { get; private set; }
        public DateOnly SessionDate { get; private set; }
        public SessionData()
        {
            SessionProgress = new();
            SessionDate = DateOnly.FromDateTime(DateTime.Today);
        }
        public SessionData(List<int> sessionProgress, int sessionTime, DateOnly sessionDate)        {
            SessionProgress = sessionProgress;
            SessionTime = sessionTime;
            SessionDate = sessionDate;
        }


        public void AddImage(int time)
        {
            SessionProgress.Add(time);
            SessionTime += time;
        }
    }
}
