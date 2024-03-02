using Solutions.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solutions.Test.Medium
{
    public class ContainerWithMostWaterSolutionTest
    {
        ContainerWithMostWaterSolution Solution = new ContainerWithMostWaterSolution();

        [Fact]
        public void UnitTest1()
        {
            var input = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var expected = 49;
            var actual = Solution.MaxArea(input);

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void UnitTest2()
        {
            var input = new int[] { 1,1 };
            var expected = 1;
            var actual = Solution.MaxArea(input);

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void UnitTest3()
        {
            var input = new int[] { 1, 2 };
            var expected = 1;
            var actual = Solution.MaxArea(input);

            Assert.Equal(expected, actual);

        }
   

    }
}
