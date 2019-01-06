using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreehouseDefense.Tests
{
    [TestClass()]
    public class MapLocationTests
    {
        [TestMethod()]
        public void Should_Throw_If_Not_On_Map()
        {
            //Assemble
            var map = new Map(3, 3);

            //Assert
            Assert.ThrowsException<OutOfBoundsException>(() => new MapLocation(3, 3, map));
        }

        [TestMethod()]
        public void In_Range_Of_With_Range_1()
        {
            var map = new Map(3, 3);
            var target = new MapLocation(0, 0, map);

            Assert.IsTrue(target.InRangeOf(new MapLocation(0, 1, map), 1));
        }
    }
}