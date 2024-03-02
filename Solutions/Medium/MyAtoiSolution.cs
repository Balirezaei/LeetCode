using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Medium
{
    public class MyAtoiSolution
    {
        public int MyAtoi(string s)
        {
            int number = 0;
            s = s.Trim();
            bool isNumber = true;
            var isMinus = false;
            bool checkOverFlow = false;
            var needToBeNumber = false;


            for (int i = 0; i < s.Length; i++)
            {
                int currentDigit = 0;

                switch (s[i])
                {
                    case '1':
                        isNumber = true;
                        currentDigit = 1;
                        needToBeNumber= true;
                        break;
                    case '2':
                        isNumber = true;
                        currentDigit = 2; 
                        needToBeNumber = true;
                        break;
                    case '3':
                        isNumber = true;
                        currentDigit = 3;
                        needToBeNumber = true;
                        break;
                    case '4':
                        isNumber = true;
                        currentDigit = 4;
                        needToBeNumber = true;
                        break;
                    case '5':
                        isNumber = true;
                        currentDigit = 5;
                        needToBeNumber = true;
                        break;
                    case '6':
                        isNumber = true;
                        currentDigit = 6;
                        needToBeNumber = true;
                        break;
                    case '7':
                        currentDigit = 7;
                        needToBeNumber = true;

                        break;
                    case '8':
                        isNumber = true;
                        currentDigit = 8;
                        needToBeNumber = true;

                        break;
                    case '9':
                        isNumber = true;
                        currentDigit = 9;
                        needToBeNumber = true;

                        break;
                    case '0':
                        isNumber = true;
                        currentDigit = 0;
                        needToBeNumber = true;

                        break;
                    case '-':
                        if (needToBeNumber)
                        {
                            if (number >= 1)
                            {
                                return isMinus ? number * -1 : number;
                            }
                            return 0;
                        }
                        needToBeNumber = true;
                        isMinus = true;
                        break;
                    case '+':
                        if (needToBeNumber)
                        {
                            if (number >= 1)
                            {
                                return isMinus ? number * -1 : number;
                            }
                            return 0; 
                        }
                        needToBeNumber = true;
                        break;
                    case ' ':
                       
                       
                            return isMinus ? number * -1 : number;
                    
                        break;
                    case '.':
                        return isMinus ? number * -1 : number;
                    default:
                        //  i = 0;
                        //if (number > 1)
                        //{
                        //    return isMinus ? number * -1 : number;
                        //}
                        if (number >= 1)
                        {
                            return isMinus ? number * -1 : number;
                        }
                        return 0;
                        break;

                }

                if (isNumber)
                {
                    if (checkOverFlow)
                    {
                        number = CheckOverFlow(number, currentDigit, isMinus);
                        if (number == int.MinValue || number == int.MaxValue)
                        {
                            return isMinus && number>0 ? number * -1 : number;
                        }
                    }
                    else
                    {
                        number = number * 10 + (currentDigit);
                        if (int.MaxValue / 10 <= number)
                            checkOverFlow = true;
                    }
                }

            }

            return isMinus ? number * -1 : number;
        }

        private int CheckOverFlow(int number, int currentDigit, bool isMinus)
        {
            var maxInt = int.MaxValue;
            if (((long)number * 10) + ((long)currentDigit) > maxInt)
            {
                if (isMinus)
                    return maxInt * -1 - 1;
                else
                    return maxInt;
            }
            else
                return number * 10 + (currentDigit);
        }
    }
}
