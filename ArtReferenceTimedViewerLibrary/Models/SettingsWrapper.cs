using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtReferenceTimedViewerLibrary.Models
{
    public record SettingsWrapper
    {
        public GeneralSettings GeneralSettings { get; set; }
        public SessionSettings SessionSettings { get; set; }
        public SettingsWrapper(GeneralSettings generalSettings, SessionSettings sessionSettings)
        {
            GeneralSettings = generalSettings;
            SessionSettings = sessionSettings;
        }
    }
}
