using FluentAssertions;
using Solutions.Medium;
using Xunit;

namespace Solutions.Test.Medium
{
    public class AddTwoNumbersInListNodeSolutionUnitTest
    {
        [Theory]
        [InlineData("0", "0", "0")]
        [InlineData("1", "1", "2")]
        [InlineData("9999999", "9999", "89990001")]
        [InlineData("342", "465", "708")]
        public void Algorithm_AddToListNumberWithSimpleInput_Should_work_Correctly(string v1, string v2, string result)
        {
            AddTwoNumbersInListNodeSolution solution = new AddTwoNumbersInListNodeSolution();
            var l1 = solution.InputToListNode(v1);
            var l2 = solution.InputToListNode(v2);
            var expected = solution.InputToListNode(result);

            var actual = solution.AddTwoNumbers(l1, l2);
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]

        public void Algorithm_AddToListNumberWithMediumLevelInput_Should_work_Correctly()
        {
            AddTwoNumbersInListNodeSolution solution = new AddTwoNumbersInListNodeSolution();
            var l1 = solution.InputToListNode("56");
            var l2 = solution.InputToListNode("549");
            var expected = solution.InputToListNode("0101");

            var actual = solution.AddTwoNumbers(l1, l2);
            actual.Should().BeEquivalentTo(expected);
        }

    }
}