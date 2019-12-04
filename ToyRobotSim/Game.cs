using System;
using System.Text.RegularExpressions;

namespace ToyRobotSim
{
    public class Game
    {
        static int TABLE_WIDTH = 5;
        static int TABLE_DEPTH = 5;
        static Robot[,] Table = new Robot[TABLE_WIDTH, TABLE_DEPTH];
        static Robot Bot = new Robot(Table);
        public enum Directions {NORTH, EAST, SOUTH, WEST};

        static void Main(string[] args)
        {
            //Keep reading input until there isn't any more
            string Input;
            while ((Input = Console.ReadLine()) != null)
            {
                //Regex match for PLACE with NORTH
                if(Regex.Match(Input, @"PLACE\s\d+[,]\d+[,]NORTH").Success)
                {
                    int x = Int32.Parse(Regex.Match(Input, @"\d+").ToString());
                    int y = Int32.Parse(Regex.Match(Input, @"\d+").NextMatch().ToString());
                    Bot.Place(x, y, (int)Directions.NORTH);
                }

                //Regex match for PLACE with EAST
                else if (Regex.Match(Input, @"PLACE\s\d+[,]\d+[,]EAST").Success)
                {
                    int x = Int32.Parse(Regex.Match(Input, @"\d+").ToString());
                    int y = Int32.Parse(Regex.Match(Input, @"\d+").NextMatch().ToString());
                    Bot.Place(x, y, (int)Directions.EAST);
                }

                //Regex match for PLACE with SOUTH
                else if (Regex.Match(Input, @"PLACE\s\d+[,]\d+[,]SOUTH").Success)
                {
                    int x = Int32.Parse(Regex.Match(Input, @"\d+").ToString());
                    int y = Int32.Parse(Regex.Match(Input, @"\d+").NextMatch().ToString());
                    Bot.Place(x, y, (int)Directions.SOUTH);
                }

                //Regex match for PLACE with WEST
                else if (Regex.Match(Input, @"PLACE\s\d+[,]\d+[,]WEST").Success)
                {
                    int x = Int32.Parse(Regex.Match(Input, @"\d+").ToString());
                    int y = Int32.Parse(Regex.Match(Input, @"\d+").NextMatch().ToString());
                    Bot.Place(x, y, (int)Directions.WEST);
                }

                //Regex match for MOVE
                else if (Regex.Match(Input, @"MOVE").Success)
                {
                    Bot.Move();
                }

                //Regex match for LEFT
                else if (Regex.Match(Input, @"LEFT").Success)
                {
                    Bot.Left();
                }

                //Regex match for RIGHT
                else if (Regex.Match(Input, @"RIGHT").Success)
                {
                    Bot.Right();
                }

                //Regex match for REPORT
                else if (Regex.Match(Input, @"REPORT").Success)
                {
                    string result = Bot.Report();
                    if(result != null)
                    {
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}
