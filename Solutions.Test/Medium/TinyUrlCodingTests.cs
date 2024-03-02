using Solutions.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static System.Net.WebRequestMethods;

namespace Solutions.Test.Medium
{
    public class TinyUrlCodingTests
    {
        TinyURLCodec tinyURLCodec;
        string Host = "http://tinyurl.com/";
        public TinyUrlCodingTests()
        {
            tinyURLCodec = new TinyURLCodec(Host);
        }

        [Fact]
        public void Decode()
        {
            var url = "https://leetcode.com/problems/design-tinyurl";
            var expected = Host + "4e9iAk";

            tinyURLCodec.encode(url);

            string value = "4e9iAk";

            // Convert the string into a byte[].
            byte[] asciiBytes = Encoding.ASCII.GetBytes(value);

        }
    }
}
