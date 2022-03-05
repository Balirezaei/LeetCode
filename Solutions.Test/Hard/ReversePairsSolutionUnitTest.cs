using System;
using System.Linq;
using FluentAssertions;
using Solutions.Hard;
using Xunit;

namespace Solutions.Test.Hard
{
    public class ReversePairsSolutionUnitTest
    {
        [Fact]
        public void Algorithm_Shoud_Detect_Reverse_Pair_with_simple_input_Correctly()
        {
            var numsInput = new int[] { 1, 3, 2, 3, 1 };
            var expected = 2;

            var solution = new ReversePairsSolution();

            var actual = solution.ReversePairs(numsInput);

            actual.Should().Be(expected);
        }

        [Fact]
        public void Algorithm_Shoud_Detect_Reverse_Pair_with_complex_input_Correctly()
        {
            var numsInput = new int[] { 2, 4, 3, 5, 1 };
            var expected = 3;

            var solution = new ReversePairsSolution();

            var actual = solution.ReversePairs(numsInput);

            actual.Should().Be(expected);
        }

        [Fact]
        public void Algorithm_Shoud_Detect_Reverse_Pair_with_array_with_equal_member_maxIntValue_Correctly()
        {
            var numsInput = new int[] { 2147483647, 2147483647, 2147483647, 2147483647, 2147483647, 2147483647 };
            var expected = 0;

            var solution = new ReversePairsSolution();

            var actual = solution.ReversePairs(numsInput);
            actual.Should().Be(expected);
        }

        [Fact]
        public void Algorithm_Shoud_Detect_Reverse_Pair_in_effitient_time_with_large_array_Correctly()
        {

            int Min = 0;
            int Max = 60000;
            Random randNum = new Random();
            int[] numsInput = Enumerable
                .Repeat(0, 500000)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();


            Action action = () =>
            {
                var solution = new ReversePairsSolution();

                var actual = solution.ReversePairs(numsInput);

            };
           //


        }
    }

}