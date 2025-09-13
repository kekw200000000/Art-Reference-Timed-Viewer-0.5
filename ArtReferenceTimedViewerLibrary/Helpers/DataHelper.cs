using ArtReferenceTimedViewerLibrary.DataRecords;
using ArtReferenceTimedViewerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
#nullable enable

namespace ArtReferenceTimedViewerLibrary.Helpers
{
    public class DataHelper
    {
        public string TotalDataFileName { get; private set; }
        public string DayDataFileName { get; private set; }
        public string SettingsDataFileName { get; private set; }
        public DataHelper(string totalDataFileName = "totaldata", 
                          string dayDataFileName = "daydata", 
                          string settingsDataFileName = "settingsdata")
        {
            TotalDataFileName = totalDataFileName;
            DayDataFileName = dayDataFileName;
            SettingsDataFileName = settingsDataFileName;
        }

        public TotalData? LoadTotalData()
        {
            try
            {
                if (!File.Exists(TotalDataFileName))
                {
                    return null;
                }
                TotalData result = new();
                using FileStream? stream = File.OpenRead(TotalDataFileName);
                using StreamReader? reader = new StreamReader(stream);

                string? currentLine = null;
                SessionData currentSession;
                bool addedSome = false;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    addedSome = true;
                    currentSession = StringToSession(currentLine);
                    if (currentSession == null)
                    {
                        continue;
                    }
                    result.AddSession(currentSession);
                }

                if (addedSome)
                {
                    return result;
                }
                return null;
            }
            catch
            {
                return null;
            }
            
        }
        public async Task<TotalData?> LoadTotalDataAsync()
        {
            return await Task.Run(LoadTotalData);
        }
        public DayData? LoadDayData()
        {
            SessionData? currentSession;
            try
            {
                string[] dayLines = File.ReadAllLines(DayDataFileName);
                DayData resultDay = new();
                bool dateToCheck = true;
                foreach (string sessionString in dayLines)
                {
                    currentSession = StringToSession(sessionString);
                    if (currentSession == null)
                    {
                        continue;
                    }
                    if (dateToCheck)
                    {
                        if (!DateOnly.FromDateTime(DateTime.Now.Date).Equals(currentSession.SessionDate))
                        {
                            ClearDayData();
                            return null;
                        }
                        dateToCheck = false;
                    }
                    resultDay.AddSession(StringToSession(sessionString));
                }
                return resultDay;
            }
            catch
            {
                return null;
            }

            // Yes the error checking here is absolutely abhorrent but I think it should be sufficient.
            // Reading all lines shouldn't be a problem as the day data is just 1 day (it's done differently in the LoadTotalData method.
            // I am pretty much assuming correct format in the target file so they're there just in case.
            // (and to avoid having to check whether the file exists)
        }
        public async Task<DayData?> LoadDayDataAsync()
        {
            return await Task.Run(LoadDayData);
        }
        public bool IsDayToday(DateOnly date)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            return date.Equals(today);
        }
        public void ClearDayData()
        {
            File.Create(DayDataFileName).Dispose();
        }
        public void LogSession(SessionData sessionData)
        {
            SaveSessionTo(sessionData, TotalDataFileName);
            SaveSessionTo(sessionData, DayDataFileName);
        }
        public async Task LogSessionAsync(SessionData sessionData)
        {
            await Task.Run(() => LogSession(sessionData));
        }
        public void SaveSessionTo(SessionData sessionData, string appendTargetFileName)
        {
            File.AppendAllText(appendTargetFileName, SessionToString(sessionData));
        }

        // yes this could be added to SessionData itself but it's a DataHelper specific format so I'm putting it here
        public string SessionToString(SessionData sessionData)
        {
            string sessionString = $"{sessionData.SessionDate}-{sessionData.SessionTime}-{sessionData.SessionProgress.Count}-";
            foreach (int time in sessionData.SessionProgress)
            {
                sessionString += $"{time};";
            }
            return sessionString + "\n";
        }
        public SessionData? StringToSession(string sessionString)
        {
            if (sessionString == null)
            {
                return null;
            }
            string[] splitString = sessionString.Trim().Split('-');
            DateOnly sessionDate = DateOnly.Parse(splitString[0]);
            int sessionTime = int.Parse(splitString[1]);
            List<int> sessionProgress = new();
            int currentTime;
            if (splitString.Length != 4 || splitString[3].Length == 0)
            {
                return null;
            }
            foreach (string timeString in splitString[3].Split(';'))
            {
                if (int.TryParse(timeString, out currentTime))
                {
                    sessionProgress.Add(currentTime);
                }
            }
            return new SessionData(sessionProgress, sessionTime, sessionDate);


            // assume correct format already, the try-catch is there just in case
        }
        public SettingsWrapper? LoadSettingsData()
        {
            return JsonHelper.DeserializeSettings(SettingsDataFileName);
        }
        public async Task<SettingsWrapper?> LoadSettingsDataAsync()
        {
            return await Task.Run(LoadSettingsData);
        }
        public void SaveSettingsData(SettingsWrapper settings)
        {
            JsonHelper.SerializeSettings(settings, SettingsDataFileName);
        }
        
    }
}
