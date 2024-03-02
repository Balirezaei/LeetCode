using FluentAssertions;
using Solutions.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solutions.Test.Easy
{
    public class LongestCommonPrefixTests
    {

        [Fact]
        public void LongestCommonPrefix()
        {

            var strs = new string[] { "flower", "flow", "flight" };
            var expected = "fl";

            var longestCommonPrefixSolution = new LongestCommonPrefixSolution();
            var actual =longestCommonPrefixSolution.LongestCommonPrefix(strs);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
