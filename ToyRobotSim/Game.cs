using System;
using System.Text.RegularExpressions;

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
                if(Regex.Match(Input, @"PLACE\s\d+[,]\d+[,]NORTH").Success)
                {
                    int x = Int32.Parse(Regex.Match(Input, @"\d+").ToString());
                    int y = Int32.Parse(Regex.Match(Input, @"\d+").NextMatch().ToString());
                    Bot.Place(x, y, (int)Directions.NORTH);
                }

                else if (Regex.Match(Input, @"PLACE\s\d+[,]\d+[,]EAST").Success)
                {
                    int x = Int32.Parse(Regex.Match(Input, @"\d+").ToString());
                    int y = Int32.Parse(Regex.Match(Input, @"\d+").NextMatch().ToString());
                    Bot.Place(x, y, (int)Directions.EAST);
                }

                else if (Regex.Match(Input, @"PLACE\s\d+[,]\d+[,]SOUTH").Success)
                {
                    int x = Int32.Parse(Regex.Match(Input, @"\d+").ToString());
                    int y = Int32.Parse(Regex.Match(Input, @"\d+").NextMatch().ToString());
                    Bot.Place(x, y, (int)Directions.SOUTH);
                }

                else if (Regex.Match(Input, @"PLACE\s\d+[,]\d+[,]WEST").Success)
                {
                    int x = Int32.Parse(Regex.Match(Input, @"\d+").ToString());
                    int y = Int32.Parse(Regex.Match(Input, @"\d+").NextMatch().ToString());
                    Bot.Place(x, y, (int)Directions.WEST);
                }

                else if (Regex.Match(Input, @"MOVE").Success)
                {
                    Bot.Move();
                }

                else if (Regex.Match(Input, @"LEFT").Success)
                {
                    Bot.Left();
                }

                else if (Regex.Match(Input, @"RIGHT").Success)
                {
                    Bot.Right();
                }

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
