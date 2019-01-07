using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreehouseDefenseTests.Mocks;

namespace TreehouseDefense.Tests
{
    [TestClass()]
    public class TowerTests
    {
        [TestMethod()]
        public void FireOnInvadersDecreasesInvadersHealth()
        {
            var map = new Map(3, 3);
            var target = new Tower(new MapLocation(0, 0, map));

            var invaders = new InvaderMock[]
            {
                new InvaderMock() { Location = new MapLocation(0, 0, map) },
                new InvaderMock() { Location = new MapLocation(0, 0, map) }
            };

            target.FireOnInvaders(invaders);

            foreach(InvaderMock invader in invaders)
            {
                Assert.AreEqual(1, invader.Health);
            }
        }
    }
}
