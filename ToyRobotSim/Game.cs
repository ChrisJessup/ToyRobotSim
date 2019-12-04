using System;

namespace ToyRobotSim
{
    class Game
    {
        static int TABLE_WIDTH = 5;
        static int TABLE_DEPTH = 5;
        static Robot[,] Table = new Robot[TABLE_WIDTH, TABLE_DEPTH];
        static Robot Bot = new Robot(Table);
        enum Directions {NORTH, EAST, SOUTH, WEST};
        static void Main(string[] args)
        {
            string Input;
            while ((Input = Console.ReadLine()) != null)
            {

            }
        }
    }
}
