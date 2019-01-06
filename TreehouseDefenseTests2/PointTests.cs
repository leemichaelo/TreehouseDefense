using Xunit;
using TreehouseDefense;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense.Tests
{
    public class PointTests
    {
        [Fact()]
        public void PointTest()
        {
            int x = 5;
            int y = 6;

            var point = new Point(x, y);

            Assert.Equal(x, point.X);
            Assert.AreEqual(y, point.Y);
        }

        [Fact()]
        public void DistanceToTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}