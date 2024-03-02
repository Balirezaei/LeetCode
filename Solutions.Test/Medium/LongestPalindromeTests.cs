using Solutions.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solutions.Test.Medium
{
    public class LongestPalindromeTests
    {

        [Fact]
        public void LongestPalindrome1()
        {
            var input = "aa";
            var expected = "aa";
            var actual = new LongestPalindromeSolution().LongestPalindrome(input);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void LongestPalindrome2()
        {
            var input = "babad";
            var expected = "bab";
            var actual = new LongestPalindromeSolution().LongestPalindrome(input);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void LongestPalindrome3()
        {
            var input = "cbbd";
            var expected = "bb";
            var actual = new LongestPalindromeSolution().LongestPalindrome(input);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void LongestPalindrome4()
        {
            var input = "as";
            var expected = "a";
            var actual = new LongestPalindromeSolution().LongestPalindrome(input);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void LongestPalindrome5()
        {
            var input = "ccc";
            var expected = "ccc";
            var actual = new LongestPalindromeSolution().LongestPalindrome(input);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void LongestPalindrome6()
        {
            var input = "cccc";
            var expected = "cccc";
            var actual = new LongestPalindromeSolution().LongestPalindrome(input);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void LongestPalindrome7()
        {
            var input = "abb";
            var expected = "bb";
            var actual = new LongestPalindromeSolution().LongestPalindrome(input);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void LongestPalindrome8()
        {
            var input = "ccd";
            var expected = "cc";
            var actual = new LongestPalindromeSolution().LongestPalindrome(input);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void LongestPalindrome9()
        {
            var input = "adam";
            var expected = "ada";
            var actual = new LongestPalindromeSolution().LongestPalindrome(input);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void LongestPalindrome10()
        {
            var input = "abbcccbbbcaaccbababcbcabca";

            var expected = "bbcccbb";

            var actual = new LongestPalindromeSolution().LongestPalindrome(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LongestPalindrome11()
        {
            var input = "aaaabaaa";

            var expected = "aaabaaa";

            var actual = new LongestPalindromeSolution().LongestPalindrome(input);

            Assert.Equal(expected, actual);
        }


    }
}
