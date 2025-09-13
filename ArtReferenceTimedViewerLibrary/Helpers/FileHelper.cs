using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable

namespace ArtReferenceTimedViewerLibrary.Helpers
{
    public static class FileHelper
    {
        public static bool MainFolderContainsSubfolderss(string mainFolderPath, IEnumerable<string> subfoldersInput)
        {
            HashSet<string> subfoldersActual = System.IO.Directory.GetDirectories(mainFolderPath, "*")
                .Select(subdirectoryPath => Path.GetFileName(subdirectoryPath))
                .ToHashSet();

            foreach (string subfolder in subfoldersInput)
            {
                if (!subfoldersActual.Contains(subfolder))
                {
                    return false;
                }
            }
            return true;
        }

        public static HashSet<string> GetImageSet(string mainFolderPath, HashSet<string> subfoldersSelected, bool blacklistModeEnabled)
        {
            HashSet<string> subfoldersActual = System.IO.Directory.GetDirectories(mainFolderPath, "*")
                .Where(subdirectoryPath => ( !blacklistModeEnabled && subfoldersSelected.Contains(Path.GetFileName(subdirectoryPath)) ) ||
                                           ( blacklistModeEnabled && !subfoldersSelected.Contains(Path.GetFileName(subdirectoryPath))  ))
                .ToHashSet();

            List<string> allFilesTemp = new();
            foreach (string subfolder in subfoldersActual)
            {
                allFilesTemp.AddRange(System.IO.Directory.GetFiles(subfolder, "*.*", SearchOption.AllDirectories)
                    .Where(filePath => filePath.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                       filePath.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                       filePath.EndsWith(".png", StringComparison.OrdinalIgnoreCase)));

            }
            return allFilesTemp.ToHashSet<string>();
        }
    }
}
