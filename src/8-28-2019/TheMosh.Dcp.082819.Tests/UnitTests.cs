using System;
using Xunit;

namespace TheMosh.Dcp._082819.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Test1()
        {
            HitCounter hc = new HitCounter();
            hc.Record(1);
            hc.Record(3);
            hc.Record(2);
            hc.Record(6);
            hc.Record(4);
            hc.Record(7);
            hc.Record(5);
            hc.Record(8);

            Assert.True(hc.Total() == 8);

            Assert.True(hc.Range(2, 6) == 5);
        }

        [Fact]
        public void Test2()
        {
            HitCounter hc = new HitCounter();
            hc.Record(1);
            hc.Record(3);
            hc.Record(9);
            hc.Record(6);
            hc.Record(4);
            hc.Record(7);
            hc.Record(5);
            hc.Record(12);

            Assert.True(hc.Total() == 8);

            Assert.True(hc.Range(2, 10) == 6);
        }
    }
}
