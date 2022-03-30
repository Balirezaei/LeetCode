using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.Hard
{
    public class ReversePairsSolution
    {
        public int ReversePairsSimpleWay(int[] nums)
        {
            var reverseCondition = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var limitation = int.MaxValue / 2;
                    if (nums[j] < limitation)
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


        public int ReversePairsMergeSort(int[] nums)
        {
            return DivideArrayWithMergeSortAlgorithm(nums, 0, nums.Length - 1);
        }

        static int DivideArrayWithMergeSortAlgorithm(int[] nums, int low, int high)
        {
            if (low >= high)
            {
                return 0;
            }
            int mid = (low + high) / 2;
            int inv = DivideArrayWithMergeSortAlgorithm(nums, low, mid);
            inv += DivideArrayWithMergeSortAlgorithm(nums, mid + 1, high);
            inv += CheckDividedArrayWithSort(nums, low, mid, high);
            return inv;
        }

        static int CheckDividedArrayWithSort(int[] nums, int low, int mid, int high)
        {

            int count = 0;
            int leftPartP = low;
            int rightPartP = mid + 1;

            while (leftPartP <= mid && rightPartP <= high)
            {
                if ((long)nums[leftPartP] > (long)2 * nums[rightPartP])
                {
                    count += mid - leftPartP + 1;
                    rightPartP++;
                }
                else
                {
                    leftPartP++;
                }
            }

            List<int> temp = new List<int>();;
            int left = low;
            int right = mid + 1;
            while (left <= mid && right <= high)
            {
                if (nums[left] <= nums[right])
                { 
                    temp.Add(nums[left++]);  
                }
                else
                {
                    temp.Add(nums[right++]);
                }
            }
            while (left <= mid)
            {    
                temp.Add(nums[left++]);
            }
            while (right <= high)
            {   
                temp.Add(nums[right++]);
            }
            for (int i = low; i <= high; i++)
            {
                nums[i] = temp[i - low];  
            }
            return count;
        }



    }


}