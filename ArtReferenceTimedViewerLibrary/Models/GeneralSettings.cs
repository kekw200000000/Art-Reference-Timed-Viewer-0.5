using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtReferenceTimedViewerLibrary.Models
{
    public class GeneralSettings
    {
        public bool BlacklistModeEnabled { get; set; } = false;
        public string SessionFormatLastText { get; set; } = "";
        public string SubfoldersLastText { get; set; } = "";
        public string MainFolderLastPath { get; set; } = "";
        public GeneralSettings() { }
    }
}
