using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ArtReferenceTimedViewerLibrary.Helpers
{
    public static class InputHelper
    {
        public static bool IsValidSessionFormat(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return false;
            }
            string formatInputCheckRegex = @"^((([1-9][0-9]*)|inf)x[1-9][0-9]*, )*((([1-9][0-9]*)|inf)x[1-9][0-9]*(, $|$|,$))";
            return Regex.IsMatch(input.Trim(), formatInputCheckRegex);
        }
        public static List<(int Count, int TimeInSeconds)> ParseSessionFormat(string input)
        {
            // assume a validated input is already being passed in

            string formatInputParseRegex = @"(([1-9][0-9]*)|inf)x[1-9][0-9]*";

            return Regex.Matches(input, formatInputParseRegex)
                .Select(match =>
                {
                    string[] currentMatch = match.Value.Split('x');
                    if (currentMatch[0].Equals("inf"))
                    {
                        return (-1, int.Parse(currentMatch[1]));
                    }
                    return (int.Parse(currentMatch[0]), int.Parse(currentMatch[1]));
                })
                .ToList();

        }
        public static bool IsValidSubfolderSelection(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return false;
            }
            string folderInputCheckRegex = @"^([a-zA-Z0-9_]*\.?[a-zA-Z0-9_]+, )*([a-zA-Z0-9_]*\.?[a-zA-Z0-9_]+)$";
            return Regex.IsMatch(input.Trim(), folderInputCheckRegex);
        }
        public static HashSet<string> ParseSubfolderSelection(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return new();
            }
            // assume a validated input is already being passed in
            string folderInputParseRegex = @"[a-zA-Z0-9_]*\.?[a-zA-Z0-9_]+";

            return Regex.Matches(input, folderInputParseRegex)
                .Select(match => match.Value)
                .ToHashSet();
        }

    }
}
