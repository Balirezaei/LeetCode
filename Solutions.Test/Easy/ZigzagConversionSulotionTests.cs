using FluentAssertions;
using Solutions.Easy;
using Solutions.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Solutions.Test.Easy
{
    public class ZigzagConversionSulotionTests
    {
        [Fact]
        public void LongestCommonPrefix()
        {
            var zigzag = new ZigzagConversionSulotion();
            var expected = "abdc";
            var actual = zigzag.Convert("abcd", 3);
        }
        [Fact]
        public void LongestCommonSuffix2()
        {
            var zigzag = new ZigzagConversionSulotion();
            var expected = "PAHNAPLSIIGYIR";
            var actual = zigzag.Convert("PAYPALISHIRING", 3);
            actual.Should().Be(expected);
        }


        [Fact]
        public void LongestCommonSuffix_Row4()
        {
            var zigzag = new ZigzagConversionSulotion();
            var expected = "PINALSIGYAHRPI";
            var actual = zigzag.Convert("PAYPALISHIRING", 4);
            actual.Should().Be(expected);
        }

    }
}
