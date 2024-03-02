using Solutions.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solutions.Test.Medium
{
    public class MyAtoiSolutionTests
    {
        MyAtoiSolution _solution;

        public MyAtoiSolutionTests()
        {
            _solution = new MyAtoiSolution();
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("9", 9)]
        [InlineData("5", 5)]
        public void SingleNumber(string input, int expected)
        {
            var actual = _solution.MyAtoi(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("10", 10)]
        [InlineData("19", 19)]
        [InlineData("25", 25)]
        public void TowDigitNumber(string input, int expected)
        {
            var actual = _solution.MyAtoi(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("-10", -10)]
        [InlineData("-19", -19)]
        [InlineData("-25", -25)]
        public void MinusTowDigitNumber(string input, int expected)
        {
            var actual = _solution.MyAtoi(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LeetCodeTest1()
        {
            var input = "4193 with words";
            var expected = 4193;
            var actual = _solution.MyAtoi(input);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void LeetCodeTest2()
        {
            var input = "words and 987";
            var expected = 0;
            var actual = _solution.MyAtoi(input);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void LeetCodeTest3()
        {
            var input = "-91283472332";
            var expected = -1 * int.MaxValue-1;
            var actual = _solution.MyAtoi(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LeetCodeTest4()
        {
            var input = "91283472332";
            var expected = int.MaxValue;
            var actual = _solution.MyAtoi(input);
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void LeetCodeTest5()
        {
            var input = "+-12";
            var expected = 0;
            var actual = _solution.MyAtoi(input);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LeetCodeTest6()
        {
            var input = "00000-42a1234";
            var expected = 0;
            var actual = _solution.MyAtoi(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LeetCodeTest7()
        {
            var input = "  -0012a42";
            var expected = -12;
            var actual = _solution.MyAtoi(input);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LeetCodeTest8()
        {
            var input = "    +0 123";
            var expected = 0;
            var actual = _solution.MyAtoi(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LeetCodeTest9()
        {
            var input = "21474836460";
            var expected = int.MaxValue;
            var actual = _solution.MyAtoi(input);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void LeetCodeTest10()
        {
            var input = "-2147483647";
            var expected = -2147483647;
            var actual = _solution.MyAtoi(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LeetCodeTest11()
        {
            var input = "1a";
            var expected = 1;
            var actual = _solution.MyAtoi(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LeetCodeTest12()
        {
            var input = "-5-";
            var expected = -5;
            var actual = _solution.MyAtoi(input);
            Assert.Equal(expected, actual);
        }
    }
}
