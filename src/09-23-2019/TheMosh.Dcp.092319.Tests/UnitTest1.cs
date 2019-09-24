using System;
using Xunit;

namespace TheMosh.Dcp._092319.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string c = Finder.FindFirstRecurring("acbbac");
            Assert.Equal("b", c);
        }

        [Fact]
        public void Test2()
        {
            string c = Finder.FindFirstRecurring("abcdef");
            Assert.True(string.IsNullOrWhiteSpace(c));
        }
    }
}
