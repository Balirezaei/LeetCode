using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Solutions.Hard
{
    public class RegularExpressionMatchingSolution
    {
        public bool IsMatch(string s, string p)
        {
            List<char> characters = s.ToCharArray().ToList();
            string tempInputText = s;
            string tempPattern = p;
            string zeroMatch = "";
            while (characters.Any() || p.Length > 0)
            {
                if (p.Length > 1 && p.Substring(0, 2).Contains("*"))
                {
                    int starIndex = p.IndexOf("*");

                    var charInPattern = p.Substring(starIndex - 1, 1)[0];

                    var temp = characters.ToList();
                    bool isMatched = false;
                    p = p.Substring(starIndex + 1, p.Length - 2);



                    if (p.Length > 0 && p.Substring(0, 1) == charInPattern.ToString())
                    {
                        p = p.Substring(1);
                    }

                    foreach (var character in temp)
                    {
                        if (character == charInPattern || charInPattern == '.')
                        {
                            characters.RemoveAt(0);
                            if (!isMatched)
                            {
                                isMatched = true;
                            }
                        }
                        else if (isMatched)
                        {

                            break;
                        }
                    }

                    if (!isMatched)
                    {
                        zeroMatch += charInPattern + "*,";
                    }
                }
                else if (p.Substring(0, 1).Contains("."))
                {
                    p = p.Substring(1);
                    characters.RemoveAt(0);
                }
                else
                {
                    if (characters.Any())
                    {
                        var charIndex = p.IndexOf(characters[0]);
                        if (charIndex != -1)
                        {
                            p = p.Substring(charIndex + 1);
                        }
                        characters.RemoveAt(0);
                    }
                    else if (zeroMatch!="")
                    {
                        
                        var zeroMatchArray = zeroMatch.Split(",").Where(m => m != "");
                        foreach (var s1 in zeroMatchArray)
                        {
                            tempPattern = tempPattern.Replace(s1, "");
                        }

                        if (tempPattern.Contains(p[0] + "*"))
                        {
                            p = p.Substring(1);
                        }

                    }
                    else
                    {
                        break;
                    }

                }
                if (p.Length == 0)
                {
                    break;
                }
            }
            return p.Length == 0 && characters.Count == 0;
        }



        public bool IsMatch2(string s, string p)
        {
            if (string.IsNullOrEmpty(p))
                return string.IsNullOrEmpty(s);
            var dp = new bool[s.Length + 1, p.Length + 1];
            dp[0, 0] = true;
            for (int i = 2; i <= p.Length; i++)
                dp[0, i] = p[i - 1] == '*' && dp[0, i - 2];

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= p.Length; j++)
                {
                    if (s[i - 1] == p[j - 1] || p[j - 1] == '.')
                        dp[i, j] = dp[i - 1, j - 1];
                    else if (p[j - 1] == '*')
                        dp[i, j] = dp[i, j - 2] || ((s[i - 1] == p[j - 2] || p[j - 2] == '.') && dp[i - 1, j]);
                }
            }

            return dp[s.Length, p.Length];
        }
    }
}