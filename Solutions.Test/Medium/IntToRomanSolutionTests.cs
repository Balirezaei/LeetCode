using Solutions.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solutions.Test.Medium
{
    public class IntToRomanSolutionTests
    {
        IntToRomanSolution solution = new IntToRomanSolution();
        [Fact]
        public void InShouldReturnSingleValue()
        {
            //I V   X L   C D   M
            //1   5   10  50  100 500 1000
            var expected = "MMI";
            var actual = solution.IntToRoman(2001);



        }
    }
}
