using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreehouseDefense.Tests
{
    public class MapTests
    {
        private Map _map3 = new Map(3, 3);

        [TestMethod()]
        public void MapSizeTooSmall()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Map(0, 0));
        }

        [TestMethod()]
        public void PointIsOnMap()
        {
            var target = _map3;
            Assert.IsTrue(target.OnMap(new Point(1, 2)));
        }

        [TestMethod()]
        public void PointIsNotOnMap()
        {
            var target = _map3;
            Assert.IsFalse(target.OnMap(new Point(3, 3)));
        }
    }
}
