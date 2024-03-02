using FluentAssertions;
using Solutions.Hard;
using Xunit;

namespace Solutions.Test.Hard
{
    public class RegularExpressionMatchingSolutionUnitTest
    {
        [Theory]
        //[InlineData("a", "a", true)]
        //[InlineData("ab", "ab", true)]
        //[InlineData("c", "n", false)]
        [InlineData("a", "aa", false)]
        //[InlineData("aa", "a", false)]
        public void SimpleEqualText_should_Match_Correctly(string input, string pattern, bool expected)
        {
            var solution = new RegularExpressionMatchingSolution();
            var actual = solution.IsMatch2(input, pattern);
            actual.Should().Be(expected);
        }


        [Theory]
        [InlineData("aa", "a*", true)]
        [InlineData("aaa", "a*a", true)]
        [InlineData("aab", "a*b*", true)]
        [InlineData("aab", "c*a*b", true)]
        [InlineData("mississippi", "mis*is*ip*.", true)]
        [InlineData("aaa", "ab*a*c*a", true)]
        public void Algorith_With_star_Pattern_should_Match_Correctly(string input, string pattern, bool expected)
        {
            var solution = new RegularExpressionMatchingSolution();
            var actual = solution.IsMatch(input, pattern);
            actual.Should().Be(expected);
        }


        [Theory]
        [InlineData("ab", ".*", true)]
        [InlineData("aaab", "a*.*", true)]
        public void Algorith_With_Dot_Pattern_should_Match_Correctly(string input, string pattern, bool expected)
        {
            var solution = new RegularExpressionMatchingSolution();
            var actual = solution.IsMatch(input, pattern);
            actual.Should().Be(expected);
        }

    }
}