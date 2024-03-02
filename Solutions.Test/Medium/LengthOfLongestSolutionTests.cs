using FluentAssertions;
using Solutions.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solutions.Test.Medium
{
    public class LengthOfLongestSolutionTests
    {
        [Fact]

        public void test1()
        {
            //        Input: s = "abcabcbb"
            //Output: 3
            var input = "dvdf";
            var solution = new LengthOfLongestSolution();
            var actual = solution.LengthOfLongestSubstring(input);

            actual.Should().Be(3);

        }

        [Fact]

        public void test2()
        {
            //        Input: s = "abcabcbb"
            //Output: 3
            var input = "bbbb";
            var solution = new LengthOfLongestSolution();
            var actual = solution.LengthOfLongestSubstring(input);

            actual.Should().Be(3);

        }
    }
}
