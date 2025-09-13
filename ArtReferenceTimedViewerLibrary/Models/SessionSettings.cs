using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtReferenceTimedViewerLibrary.Models
{
    public class SessionSettings
    {
        public bool ShowCurrentTimer { get; set; } = true;
        public bool ShowCurrentProgressBar { get; set; } = true;    
        public bool ShowSessionTimer { get; set; } = true;          // unused
        public bool ShowSessionProgressBar { get; set;} = true;     // unused
        public bool ShowSessionImageCount { get; set; } = true;
        public bool EnableSessionControl { get; set; } = true;
        public bool EnableRepeats { get; set; } = false;
        public SessionSettings() { }
    }
}
