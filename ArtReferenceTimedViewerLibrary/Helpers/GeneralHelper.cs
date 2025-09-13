using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtReferenceTimedViewerLibrary.Helpers
{
    public static class GeneralHelper
    {
        private static readonly Random _random = new Random();
        public static string? PickRandomString(HashSet<string> stringSet, bool removePicked)
        {
            if (stringSet is null || stringSet.Count == 0)
            {
                return null;
            }
            int pickedIndex = _random.Next(stringSet.Count);
            string picked = stringSet.ElementAt(pickedIndex);
            if (removePicked)
            {
                stringSet.Remove(picked);
            }
            return picked;
        }
    }
}
