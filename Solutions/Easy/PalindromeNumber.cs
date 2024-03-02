using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Easy
{
    public class PalindromeNumber
    {
        SplitInput _splitInput;

        public PalindromeNumber()
        {
            _splitInput = new SplitInput();
        }

        public int DoPalindrome(int x)
        {
            int temp = 0;

            if (x < 0)
            {
                x *= -1;
            }

            while (x > 0)
            {
                if (x < 10)
                {

                    temp = (temp * 10) + (x);
                    x = 0;
                }
                else
                {
                    var z = (x % 10);
                    temp = (temp * 10) + (z );
                    x = (x / 10);
                }

            }
            try {
              return  temp;
            } catch { 
            }
            return 0;

        }
        public bool IsPalindrome(int x)
        {
            //if (x >= 0)
            //{
            //    SplitInput(x);
            //    return _splitInput.IsNumberPalindrome();
            //}
            return DoPalindrome(x) == x;
           // return false;
        }
        public void SplitInput(int input)
        {
            var inputStr = input.ToString();
            int splitIndex = 0;
            if (inputStr.Length % 2 != 0)
            {
                splitIndex = inputStr.Length / 2;
                _splitInput.Left = inputStr.Substring(0, splitIndex);
                _splitInput.Right = inputStr.Substring(splitIndex + 1);
            }
            else
            {
                splitIndex = inputStr.Length / 2;
                _splitInput.Left = inputStr.Substring(0, splitIndex);
                _splitInput.Right = inputStr.Substring(splitIndex);
            }




            if (splitIndex > 0)
            {

            }
            else
            {
                _splitInput.Left = inputStr.Substring(0, splitIndex + 1);
            }


        }


    }

    public class SplitInput
    {
        public string Left;
        public string Right;
        public string ReverseRight
        {

            get
            {
                string _ReverseRight = "";
                if (Right != null && Right.Length > 0)
                {
                    for (int i = Right.Length - 1; i >= 0; i--)
                    {
                        _ReverseRight += Right[i];
                    }
                }

                return _ReverseRight;
            }
        }

        public bool IsNumberPalindrome()
        {

            if (ReverseRight.Length > 0)
            {
                return Left == ReverseRight;
            }
            return true;

        }
    }
}
