using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArtReferenceTimedViewerLibrary.DataRecords
{
    public class DayData
    {
        public Dictionary<int, int> ImagesByTime { get; set; }
        public int ImagesCount { get; set; }
        public int Time { get; set; }
        public DateOnly Date { get; set; }
        public DayData() : this(DateOnly.FromDateTime(DateTime.Now))
        {
        }
        public DayData(Dictionary<int, int> timeCount, int imagesCount, int time, DateOnly date)
        {
            ImagesByTime = timeCount;
            ImagesCount = imagesCount;
            Time = time;
            Date = date;
        }
        public DayData(DateOnly date)
        {
            Date = date;

            ImagesByTime = new();
            ImagesCount = 0;
            Time = 0;
        }

        public void AddSession(SessionData sessionData)
        {
            foreach (int imageTime in sessionData.SessionProgress)
            {
                AddImage(imageTime);
            }
        }
        public void AddImage(int time)
        {
            if (time <= 0)
            {
                return;
            }
            ImagesCount++;
            Time += time;
            if (!ImagesByTime.TryAdd(time, 1))
            {
                ImagesByTime[time]++;
            }
        }
    }
}
