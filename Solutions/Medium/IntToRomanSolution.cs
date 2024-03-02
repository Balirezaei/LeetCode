using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Medium
{
    public class IntToRomanSolution
    {
        public string IntToRoman(int num)
        {
            int[] values = {
            1000, 900, 500, 400,
            100, 90, 50, 40,
            10, 9, 5, 4,
            1
        };

            string[] symbols = {
            "M", "CM", "D", "CD",
            "C", "XC", "L", "XL",
            "X", "IX", "V", "IV",
            "I"
        };

            StringBuilder romanNumeral = new StringBuilder();
            int i = 0;
            while (num > 0)
            {
                int remain = num / values[i];
                if ((remain) > 0) {
                    num -= (remain * values[i]);
                    while (remain > 0)
                    {
                        romanNumeral.Append(symbols[i]);
                        remain--;
                    }
                }
                i++;
           
            }

            return romanNumeral.ToString();


        }
    }
}
