using FluentAssertions;
using Xunit;

public class MergeSortSolutionUnitTest {
    [Fact]
    public void Algorithm_Shoud_Sort_simple_array_input_Correctly () {
        var numsInput = new int[] { 1, 3, 2 };
        var expected = new int[] { 1, 2, 3 };

        var solution = new MergeSortSulotion ();

        var actual = solution.DoSort (numsInput);

        actual.Should ().Equal (expected);
    }

    [Fact]
    public void Algorithm_Shoud_Sort_complex_array_input_Correctly () {
        var numsInput = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 4 };
        var expected = new int[] { 1, 1, 2, 3, 4, 4, 5, 5, 6, 9 };
        var solution = new MergeSortSulotion ();
        var actual = solution.DoSort (numsInput);
        actual.Should ().Equal (expected);
    }
    
}