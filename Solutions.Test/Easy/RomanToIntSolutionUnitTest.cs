using FluentAssertions;
using Solutions.Easy;
using Xunit;

namespace Solutions.Test.Easy
{
    public class RomanToIntSolutionUnitTest
    {
        //Input: s = "III"
        //Output: 3
        //Explanation: III = 3.

        [Fact]
        public void Algorithm_Shoud_Return_Number_with_Single_charachter_input_Correctly()
        {
            RomanToIntSolution solution=new RomanToIntSolution();

            var input = "I";

            var actual = solution.RomanToInt(input);
            var expexted = 1;

            actual.Should().Be(expexted);
        }

        [Fact]
        public void Algorithm_Shoud_Return_Number_with_Complex_input_Correctly()
        {
            RomanToIntSolution solution = new RomanToIntSolution();

            var input = "MCMXCIV";

            var actual = solution.RomanToInt(input);
            var expexted = 1994;

            actual.Should().Be(expexted);
        }
    }
}