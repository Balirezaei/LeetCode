namespace Solutions.Medium
{
    public class ReverseIntegerSolution
    {
        public int Reverse(int x)
        {
            var stringNumber = x.ToString().Replace("-", "");
            bool isMinus = x < 0;
            var outputString = "";
            for (int i = stringNumber.Length; i > 0; i--)
            {
                outputString += stringNumber.Substring(i - 1, 1);
            }
            int outPut = 0;
            if (int.TryParse(outputString, out outPut))
            {
                return isMinus ? outPut * -1 : outPut;
            }
            return 0;
        }
    }
}