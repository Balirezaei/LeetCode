namespace Solutions.Hard
{
    public class ReversePairsSolution
    {
        public int ReversePairs(int[] nums)
        {
            var reverseCondition = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var limitation = int.MaxValue / 2;
                    if (nums[j]< limitation)
                    {
                        if (nums[i] > (nums[j] * 2))
                        {
                            reverseCondition++;
                        }
                    }
                }
            }
            return reverseCondition;
        }
    }
}