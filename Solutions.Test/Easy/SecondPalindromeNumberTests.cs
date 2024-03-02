using FluentAssertions;
using Solutions.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solutions.Test.Easy
{
    public class SecondPalindromeNumberTests
    {
        [Theory]
        [InlineData(121, 121)]
        [InlineData(12345, 54321)]
        //[InlineData(6, 6)]
        //[InlineData(0, 0)]
        public void Test(int input, int expected)
        {
            var opration = new PalindromeNumber();

            var actual = opration.DoPalindrome(input);
            actual.Should().Be(expected);

        }

        [Fact]
        public void aaaaa()
        {
            var opration = new PalindromeNumber();

            var actual = opration.DoPalindrome(-121);
            actual.Should().Be(121);

        }

        [Fact]
        public void On_Zero_Number_Result_Is_True()
        {
            var opration = new PalindromeNumber();

            var expected = true;

            var actual = opration.IsPalindrome(0);

            actual.Should().Be(expected);
        }

        [Fact]
        public void On_Number_Lower_Than_10_The_Result_Is_True()
        {
            var opration = new PalindromeNumber();

            var expected = true;

            var actual = opration.IsPalindrome(1);

            actual.Should().Be(expected);
        }


        [Fact]
        public void On_Number_Two_Digit_Number_With_Two_Equal_numbers_The_Result_Is_True()
        {
            var opration = new PalindromeNumber();

            var expected = true;

            var actual = opration.IsPalindrome(22);

            actual.Should().Be(expected);
        }

        [Fact]
        public void On_Number_Three_Digit_Number_With_Start_AND_End_Equal_numbers_The_Result_Is_True()
        {
            var opration = new PalindromeNumber();

            var expected = true;

            var actual = opration.IsPalindrome(121);

            actual.Should().Be(expected);
        }
    }
}
