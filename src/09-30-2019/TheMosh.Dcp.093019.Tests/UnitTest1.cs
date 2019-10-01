using System;
using Xunit;

namespace TheMosh.Dcp._093019.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[][] input = new int[4][];
            input[0] = new int[] { 1, 2 };
            input[1] = new int[] { 3 };
            input[2] = new int[] {  };
            input[3] = new int[] { 4, 5, 6 };

            ArrayIterator iterator = new ArrayIterator(input);
            Assert.True(iterator.HasNext());
            Assert.True(iterator.Next() == 1);
            Assert.True(iterator.Next() == 2);
            Assert.True(iterator.Next() == 3);
            Assert.True(iterator.Next() == 4);
            Assert.True(iterator.Next() == 5);
            Assert.True(iterator.Next() == 6);
            Assert.True(!iterator.HasNext());
            Assert.Throws<Exception>(() => iterator.Next());
        }
    }
}