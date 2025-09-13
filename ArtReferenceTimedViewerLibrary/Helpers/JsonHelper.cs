using ArtReferenceTimedViewerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
#nullable enable

namespace ArtReferenceTimedViewerLibrary.Helpers
{
    public static class JsonHelper
    {
        public static bool SerializeSettings(SettingsWrapper settings, string fileName)
        {
            string jsonString = JsonSerializer.Serialize<SettingsWrapper>(
                settings,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });
            try
            {
                File.WriteAllText(fileName, jsonString);
            }
            catch
            {
                /// well well well
                /// 
                return false;
            }
            return true;
        }
        public static SettingsWrapper? DeserializeSettings(string fileName)
        {
            SettingsWrapper? result;
            try
            {
                string jsonString = File.ReadAllText(fileName);
                result = JsonSerializer.Deserialize<SettingsWrapper>(jsonString);
            }
            catch
            {
                return null;
            }
            return result;
        }
    }
}
