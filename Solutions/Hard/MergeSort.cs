using System;
using System.Linq;

public class MergeSortSulotion {

    public int[] DoSort (int[] nums) {

        var arrayLen = nums.Length;
        if (arrayLen > 2) {

            int splitHalf = (int) Math.Ceiling (arrayLen / (decimal) 2);
            int index_ = 0;
            var splitArray_01 = new int[splitHalf];
            for (; index_ < splitHalf; index_++) {
                splitArray_01[index_] = nums[index_];
            }
            var left = DoSort (splitArray_01).ToList ();
            var splitArray_02 = new int[arrayLen - splitHalf];
            for (int j = 0; index_ < arrayLen; index_++, j++) {
                splitArray_02[j] = nums[index_];
            }
            var right = DoSort (splitArray_02).ToList ();

            for (index_ = 0; index_ < arrayLen; index_++) {

                if (left.Count () > 0 && right.Count () > 0) {
                    if (left[0] > right[0]) {
                        nums[index_] = right[0];
                        right.Remove (right[0]);
                    } else {
                        nums[index_] = left[0];
                        left.Remove (left[0]);
                    }
                } else if (left.Count () > 0) {
                    nums[index_] = left[0];
                    left.Remove (left[0]);
                } else if (right.Count () > 0) {
                    nums[index_] = right[0];
                    right.Remove (right[0]);
                }

            }

            return nums;

        } else if (arrayLen == 2) {
            if (nums[0] < nums[1]) {
                return nums;
            } else {
                return new int[] { nums[1], nums[0] };
            }
        } else {
            return nums;
        }
    }
}