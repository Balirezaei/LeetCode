using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions.Medium
{
    public class ZigzagConversionSulotion
    {


        public string Convert(string s, int numRows)
        {
            var result = new List<string>();
            if (numRows == 1) return s;
            var preCharacterIndex = 0;
            for (var i = 0; i < numRows; i++)
            {
                var jump = numRows - 1;
                int nextChar = i;
                preCharacterIndex = nextChar;
                //if ((i + 1) % (numRows - 1) != 0)
                //{
                //  nextChar = ((jump * 2) - ((i*2== (jump * 2) ? 0: (i * 2)))) + preCharacterIndex;
                //}
                //else
                //{
                //    nextChar = (jump) + preCharacterIndex;
                //}
                int j = 0;
                while (nextChar < s.Length)
                {

                    result.Add(s[nextChar].ToString());


                    //if ((preCharacterIndex) % (numRows - 1) != 0)
                    //{


                    if (!(i == 0 || i == numRows - 1))//مخالف ردیف اول و اخر
                    {
                        if (i % 2 == 0 || j > 0 && j % 2 == 0)
                        {
                            nextChar = 2;
                        }
                        else
                        {
                            nextChar = 4;
                        }

                    }
                    else
                    {
                        nextChar = jump * 2;
                    }


                    nextChar = nextChar + preCharacterIndex;
                    preCharacterIndex = nextChar;

                    j = j + 2;
                    //if (j % 2 == 0)
                    //{
                    //    j = 0;
                    //}
                    //}
                    //else
                    //{
                    //    nextChar = (jump) + preCharacterIndex;
                    //}


                }
                //var numRowsInt = 1;
                //var x = (numRows + (numRows - 2));
                //while (s[((x * numRowsInt) + i) - (2 * i)].ToString() != null)
                //{
                //    var first = s[(x * numRowsInt) + i].ToString();
                //    var second = i != 0 && i < numRows - 1 ? s[((x * numRowsInt) + i) - (2 * i)].ToString() : "";
                //    result.Add(second);
                //    result.Add(first);
                //    numRowsInt++;
                //}
            }
            return string.Join("", result);

        }

    }
}

