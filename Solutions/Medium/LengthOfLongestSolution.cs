using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Medium
{
    public class LengthOfLongestSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s == null) return 0;
            if (s.Length == 1) return 1;
            int start = -1, max = 0;
            var dict = new int[256];
            Array.Fill(dict, -1);
            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] > start)
                    start = dict[s[i]];
                dict[s[i]] = i;
                var a = i - start;
                max = Math.Max(max, i - start);
            }
            return max;


            //var middle = s.Length / 2;
            //var longestSubstring = "";
            //for (var i = 0; i < middle; i++)
            //{

            //    for (int j = i+1; j < s.Length; j++)
            //    {
            //        if (s[i]== s[j] && j-1 ==i)
            //        {
            //            if (longestSubstring.Length == 0)
            //                longestSubstring = s[i].ToString();
            //            continue;
            //        }
            //        var substring = s.Substring(i, j);
            //        var nextString= s.Substring(j, ((s.Length - j)));
            //        if (nextString.Contains(substring))
            //        {

            //            longestSubstring= longestSubstring.Length < substring.Length ? substring : longestSubstring;
            //        }
            //        else
            //        {
            //            break;
            //        }

            //    }
            //}

            //return longestSubstring.Length;
        }
    }
}
