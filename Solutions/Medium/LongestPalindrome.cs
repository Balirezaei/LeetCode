using Solutions.Easy;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Solutions.Medium
{
    public class LongestPalindromeSolution
    {

        public string LongestPalindrome(string s)
        {

            //int start = 0;
            //int resLen = 0;
            //if (s.Length < 3)
            //{
            //    if (s.Length == 1)
            //    {
            //        return s;
            //    }
            //    else
            //    {
            //        if (s[0] == s[1]) return s;
            //        else return s[0].ToString();
            //    }
            //}
            //for (int i = 0; i < s.Length; i++)
            //{
            //    int left = i, right = i;
            //    //if (s.Length % 2 == 0)
            //    //{
            //    //    // left = i - 1;
            //    //    // right = i + 1;
            //    //}


            //    while ((left >= -1 && right < s.Length+1))
            //    {
            //        if ((left >= 0 && right < s.Length) && s[left] == s[right])
            //        {
            //            if (right - left + 1 > resLen)
            //            {
            //                start = left;
            //                resLen = right - left + 1;
            //            }
            //        }
            //        else if (right >= s.Length  && s[left] == s[i])
            //        {
            //            if ((i) - left + 1 > resLen)
            //            {
            //                start = left;
            //                resLen = (i) - left + 1;
            //            }
            //            // break;
            //        }
            //        else if (left < 0  && s[right] == s[i])
            //        {
            //            if ((right) - i + 1 > resLen)
            //            {
            //                start = i;
            //                resLen = (right) - i + 1;
            //            }
            //            //break;
            //        }
            //        //else if (right < s.Length && (right - i) == 1 && s[right] == s[i])
            //        //{
            //        //    if ((right) - i + 1 > resLen)
            //        //    {
            //        //        start = i;
            //        //        resLen = (right) - i + 1;
            //        //    }
            //        //}
            //        //else if (left > 0 && (i - left) == 1 && s[left] == s[i])
            //        //{
            //        //    if ((i) - left + 1 > resLen)
            //        //    {
            //        //        start = left;
            //        //        resLen = (i) - left + 1;
            //        //    }
            //        //}
            //        else
            //        {
            //            break;
            //        }

            //        left--;
            //        right++;
            //    }


            //}
            //return s.Substring(start, resLen);




            if (s.Length < 2)
            {
                return s;
            }
            int start = 0;
            int maxLength = 1;
            for (int i = 0; i < s.Length; i++)
            {
                int left = i;
                int right = i;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    if (right - left + 1 > maxLength)
                    {
                        start = left;
                        maxLength = right - left + 1;
                    }
                    left--;
                    right++;
                }
                left = i;
                right = i + 1;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    if (right - left + 1 > maxLength)
                    {
                        start = left;
                        maxLength = right - left + 1;
                    }
                    left--;
                    right++;
                }
            }
            return s.Substring(start, maxLength);


        }

    }
}
