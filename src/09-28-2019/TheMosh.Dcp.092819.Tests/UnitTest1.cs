using System;
using Xunit;

namespace TheMosh.Dcp._092819.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 7 };

            int duplicate = DuplicateFinder.FindDuplicate(array);

            Assert.True(duplicate == 7);
        }

        [Fact]
        public void Test2()
        {
            int[] array = new int[] { 1, 5, 2, 3, 4, 5, 6, 7 };

            int duplicate = DuplicateFinder.FindDuplicate(array);

            Assert.True(duplicate == 5);
        }

        [Fact]
        public void Test3()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 1 };

            int duplicate = DuplicateFinder.FindDuplicate(array);

            Assert.True(duplicate == 1);
        }
    }
}
