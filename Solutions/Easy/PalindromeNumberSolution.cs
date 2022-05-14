namespace Solutions.Easy
{
    public class PalindromeNumberSolution
    {
        public bool IsPalindrome(int x)
        {
            var temp = DoBackwardAsForward(x);
            return x == temp;
        }
        public int DoBackwardAsForward(int x)
        {
            if (x < 0)
            {
                var convertMinusInput = ((long) x * -1);
                x = convertMinusInput>int.MaxValue ?0:(int)convertMinusInput;
            }

            if (x < 10)
            {
                return x;
            }
            var temp = 0;
            int a = x;
            int lastDivded = (a / 10);
            while (a >= 10)
            {
                temp = (temp * 10) + (a % 10);
                a = (a / 10);
                lastDivded = a;
            }
            temp = (temp * 10) + (lastDivded);
            return temp;
        }

    }

}