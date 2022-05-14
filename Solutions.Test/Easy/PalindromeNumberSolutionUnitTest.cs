using FluentAssertions;
using Solutions.Easy;
using Xunit;

namespace Solutions.Test.Easy
{
    public class PalindromeNumberSolutionUnitTest
    {

        [Theory]
        [InlineData(2, 2)]
        public void Algorithm_DoBackwardAsForward_Shoud_Work_Correctly_With_One_Digit(int input, int expexted)
        {
            PalindromeNumberSolution solution = new PalindromeNumberSolution();

            var actual = solution.DoBackwardAsForward(input);
            actual.Should().Be(expexted);
        }

        [Theory]
        [InlineData(10, 1)]
        [InlineData(12, 21)]
        [InlineData(13, 31)]
        [InlineData(25, 52)]
        public void Algorithm_DoBackwardAsForward_Shoud_Work_Correctly_With_Two_Digits(int input, int expexted)
        {
            PalindromeNumberSolution solution = new PalindromeNumberSolution();

            var actual = solution.DoBackwardAsForward(input);

            actual.Should().Be(expexted);
        }

        [Theory]
        [InlineData(123, 321)]
        [InlineData(456, 654)]
        public void Algorithm_DoBackwardAsForward_Shoud_Work_Correctly_With_Three_Digits(int input, int expexted)
        {

            PalindromeNumberSolution solution = new PalindromeNumberSolution();

            var actual = solution.DoBackwardAsForward(input);

            actual.Should().Be(expexted);
        }

        [Theory]
        [InlineData(1001, 1001)]
        public void Algorithm_DoBackwardAsForward_Shoud_Work_Correctly_With_four_Digits(int input, int expexted)
        {

            PalindromeNumberSolution solution = new PalindromeNumberSolution();

            var actual = solution.DoBackwardAsForward(input);

            actual.Should().Be(expexted);
        }

        
        [Theory]
        //        [InlineData(121, true)]
        //        [InlineData(136, false)]
        //        [InlineData (12366321, true)]
       // [InlineData(-121, false)]
        [InlineData(-2147483648, false)]
        public void Algorithm_IsPalindrome_Shoud_Work_Correctly_With_Three_Digits(int input, bool expexted)
        {

            PalindromeNumberSolution solution = new PalindromeNumberSolution();

            var actual = solution.IsPalindrome(input);

            actual.Should().Be(expexted);
        }



    }
}