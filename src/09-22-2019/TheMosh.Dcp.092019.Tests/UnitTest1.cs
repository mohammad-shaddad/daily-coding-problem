using System;
using Xunit;

namespace TheMosh.Dcp._092019.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var matrix = new int[,] {
                { 0, 0, 1 },
                { 0, 0, 1 },
                { 1, 0, 0 }
            };

            PathFinder pathFinder = new PathFinder();
            int nPaths = pathFinder.FindPaths(matrix);

            Assert.True(nPaths == 2);
        }


        [Fact]
        public void Test2()
        {
            var matrix = new int[,] {
                { 0, 0, 1 },
                { 0, 0, 1 },
                { 1, 0, 0 },
                { 1, 0, 0 }
            };

            PathFinder pathFinder = new PathFinder();
            int nPaths = pathFinder.FindPaths(matrix);

            Assert.True(nPaths == 4);
        }
    }
}
