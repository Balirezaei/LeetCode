using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Easy
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var wordToBeExcerise = strs[0];
            string commaonPrefix = "";

            for (int i = 0; i < wordToBeExcerise.Length; i++)
            {
                var prefix = wordToBeExcerise[i];
                for (int j = 1; j< strs.Length; j++)
                {
                    if (!strs[j].StartsWith(commaonPrefix+prefix))
                    {
                        prefix = '\0';
                       
                    }
                }
                if (prefix== '\0')
                {
                    break;
                }
                commaonPrefix += prefix;
            }

            return commaonPrefix;
            
        }

    }
}
