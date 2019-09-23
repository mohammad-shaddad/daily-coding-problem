using System;
using Xunit;

namespace TheMosh.Dcp._092019.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Finder.Find(13) == 2);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(Finder.Find(27) == 3);
        }

        [Fact]
        public void Test3()
        {
            Assert.True(Finder.Find(16) == 1);
        }


        [Fact]
        public void Test4()
        {
            Assert.True(Finder.Find(6) == 3);
        }
    }
}
