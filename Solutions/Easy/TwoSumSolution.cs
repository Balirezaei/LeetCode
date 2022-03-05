namespace Solutions.Easy
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            bool isCompleted = false;
            int[] output = new int[2] { 0, 0 };
            for (int i = 0; i < (nums.Length - 1); i++)
            {
                if (isCompleted)
                {
                    break;
                }
                int forSumToNext = nums[i];
                for (int j = i + 1; j < (nums.Length); j++)
                {
                    if ((forSumToNext + nums[j]) == target)
                    {
                        output[0] = i;
                        output[1] = j;
                        isCompleted = true;
                        break;
                    }
                }
            }
            return output;
        }
    }


    struct Numerals
    {
        public int Key;
        public string Value;
    }
}