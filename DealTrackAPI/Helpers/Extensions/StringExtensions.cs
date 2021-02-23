using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DealTrackAPI.Helpers
{
    public static class StringExtensions
    {
        public static string[] SplitCSVRow(this string input)
        {
            Regex csvSplit = new Regex("(?:^|,)(\"(?:[^\"]+|\"\")*\"|[^,]*)", RegexOptions.Compiled);
           List<string> output = new List<string>();
            foreach (Match match in csvSplit.Matches(input))
            {
                output.Add(match.Value.TrimStart(','));
            }

            return output.ToArray();
        }
    }

}
