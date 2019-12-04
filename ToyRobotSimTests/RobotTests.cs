using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotSim;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobotSim.Tests
{
    [TestClass()]
    public class RobotTests
    {
        [TestMethod()]
        public void PlaceTest()
        {
            Robot Bot = new Robot(new Robot[5, 5]);
            Bot.Place(3, 4, (int)Game.Directions.SOUTH);
            Assert.AreEqual(3, Bot.GetX());
            Assert.AreEqual(4, Bot.GetY());
            Assert.AreEqual("SOUTH", Bot.GetFacing());
        }

        [TestMethod()]
        public void InvalidPlaceTest()
        {
            Robot Bot = new Robot(new Robot[5, 5]);
            Bot.Place(2, 3, (int)Game.Directions.WEST);
            Bot.Place(3, 5, (int)Game.Directions.SOUTH);
            Assert.AreEqual(2, Bot.GetX());
            Assert.AreEqual(3, Bot.GetY());
            Assert.AreEqual("WEST", Bot.GetFacing());
        }

        [TestMethod()]
        public void MoveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MoveTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LeftTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RightTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ReportTest()
        {
            Assert.Fail();
        }

        
    }
}