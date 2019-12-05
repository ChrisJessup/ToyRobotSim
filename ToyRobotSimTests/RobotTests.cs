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
            Bot.Place(3, 5, (int)Game.Directions.SOUTH);
            Assert.AreEqual(-1, Bot.GetX());
            Assert.AreEqual(-1, Bot.GetY());
            Assert.AreEqual("WEST", Bot.GetFacing());
        }

        [TestMethod()]
        public void InvalidPlaceTest2()
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
            Robot Bot = new Robot(new Robot[5, 5]);
            Bot.Place(3, 2, (int)Game.Directions.EAST);
            Bot.Move();
            Assert.AreEqual(4, Bot.GetX());
            Assert.AreEqual(2, Bot.GetY());
            Assert.AreEqual("EAST", Bot.GetFacing());
        }

        [TestMethod()]
        public void InvalidMoveTest()
        {
            Robot Bot = new Robot(new Robot[5, 5]);
            Bot.Place(4, 2, (int)Game.Directions.EAST);
            Bot.Move();
            Assert.AreEqual(4, Bot.GetX());
            Assert.AreEqual(2, Bot.GetY());
            Assert.AreEqual("EAST", Bot.GetFacing());
        }

        [TestMethod()]
        public void LeftTest()
        {
            Robot Bot = new Robot(new Robot[5, 5]);
            Bot.Place(0, 3, (int)Game.Directions.WEST);
            Bot.Left();
            Assert.AreEqual(0, Bot.GetX());
            Assert.AreEqual(3, Bot.GetY());
            Assert.AreEqual("SOUTH", Bot.GetFacing());
        }

        [TestMethod()]
        public void RightTest()
        {
            Robot Bot = new Robot(new Robot[5, 5]);
            Bot.Place(1, 2, (int)Game.Directions.NORTH);
            Bot.Right();
            Assert.AreEqual(1, Bot.GetX());
            Assert.AreEqual(2, Bot.GetY());
            Assert.AreEqual("EAST", Bot.GetFacing());
        }

        [TestMethod()]
        public void ReportTest()
        {
            Robot Bot = new Robot(new Robot[5, 5]);
            Bot.Place(2, 1, (int)Game.Directions.WEST);
            String report = Bot.Report();
            Assert.AreEqual("2,1,WEST", report);
        }

        [TestMethod()]
        public void InvalidReportTest()
        {
            Robot Bot = new Robot(new Robot[5, 5]);
            Bot.Place(6, 1, (int)Game.Directions.SOUTH);
            String report = Bot.Report();
            Assert.AreEqual(null, report);
        }


    }
}