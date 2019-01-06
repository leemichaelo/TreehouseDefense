using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreehouseDefense.Tests
{
    [TestClass()]
    public class PointTests
    {
        [TestMethod()]
        public void Point_Test()
        {
            int x = 5;
            int y = 6;

            var point = new Point(x, y);

            Assert.AreEqual(x, point.X);
            Assert.AreEqual(y, point.Y);
        }

        [TestMethod()]
        public void Distance_To_With_Pathagorean_Triple()
        {
            //Assemble
            var point = new Point(3, 4);
            var target = new Point(0, 0);
            var expected = 5.0;

            //Act
            var actual = target.DistanceTo(point);

            //Assert
            Assert.AreEqual(expected, actual, 2);
        }

        [TestMethod()]
        public void Distance_To_Point_At_Same_Position()
        {
            //Assemble
            var point = new Point(3, 4);
            var target = new Point(3, 4);
            var expected = 0;

            //Act
            var actual = target.DistanceTo(point);

            //Assert
            Assert.AreEqual(expected, actual, 2);
        }

        [TestMethod()]
        public void Does_Not_Equal_Null()
        {
            var target = new Point(0, 0);

            Assert.IsFalse(target.Equals(null));
        }

        [TestMethod()]
        public void Distinct_Objects_Are_Equal()
        {
            var target = new Point(4, 5);

            Assert.IsTrue(target.Equals(new Point(4, 5)));
        }

        [TestMethod()]
        public void Points_Are_Not_Equal()
        {
            var target = new Point(4, 5);

            Assert.IsFalse(target.Equals(new Point(4, 6)));
        }

        [TestMethod()]
        public void Similar_Points_Have_Different_Hash_Codes1()
        {
            var target = new Point(4, 5);

            Assert.AreNotEqual(new Point(5, 4).GetHashCode(), target.GetHashCode());
        }

        [TestMethod()]
        public void Similar_Points_Have_Different_Hash_Codes2()
        {
            var target = new Point(4, 5);

            Assert.AreNotEqual(new Point(4, 6).GetHashCode(), target.GetHashCode());
        }

        [TestMethod()]
        public void Equal_Points_Have_Same_Hash_Codes()
        {
            var target = new Point(4, 5);

            Assert.AreEqual(new Point(4, 5).GetHashCode(), target.GetHashCode());
        }
    }
}