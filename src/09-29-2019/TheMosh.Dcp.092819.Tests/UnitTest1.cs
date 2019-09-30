using System;
using Xunit;

namespace TheMosh.Dcp._092819.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] array = new int[] { 3, 4, 9, 6, 1 };

            int[] smallers = SmallerFinder.Find(array);

            Assert.True(smallers[0] == 1);
            Assert.True(smallers[1] == 1);
            Assert.True(smallers[2] == 2);
            Assert.True(smallers[3] == 1);
            Assert.True(smallers[4] == 0);
        }
    }
}
