using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Medium
{

    public class SumResult
    {
        public int Level { get; set; }
        public int Value { get; set; }

        public SumResult(int level, int value)
        {
            Level = level;
            Value = value;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode() { }
        public TreeNode(int val, TreeNode left, TreeNode right)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

        public static class MyTreeNode 
    { 
     
      

        public static SumResult GetSumDeepestValue(this TreeNode node,int level=0)
        {
            if (node.right != null || node.left != null)
            {
                var rightSideSum = node.right ==null ? new SumResult(0,0): node.right.GetSumDeepestValue(level+1);
                var leftSideSum = node.left ==null ? new SumResult(0, 0) :  node.left.GetSumDeepestValue(level+1);
                if (rightSideSum.Level==leftSideSum.Level)
                    return new SumResult(rightSideSum.Level, rightSideSum.Value+leftSideSum.Value);
                return rightSideSum.Level > leftSideSum.Level ? rightSideSum : leftSideSum;

            }
            else  {
                return new SumResult(level,node.val);
            }

        }

    }

  
}
