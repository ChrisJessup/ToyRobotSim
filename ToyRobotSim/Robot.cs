using System;

namespace ToyRobotSim
{
    public class Robot
    {
        private int X;
        private int Y;
        private int Facing;
        enum Directions { NORTH, EAST, SOUTH, WEST };
        private Robot[,] Table;
        bool OnTable;

        //Constructor
        public Robot(Robot[,] table)
        {
            X = 0;
            Y = 0;
            Facing = 0;
            Table = table;
            OnTable = false;
        }

        //Place instruction
        public void Place(int x, int y, int facing)
        {
            if(x < Table.GetLength(0) && x >= 0)
            {
                if(y < Table.GetLength(1) && y >= 0)
                {
                    X = x;
                    Y = y;
                    Facing = facing;
                    OnTable = true;
                }
            }
        }

        //Move instruction
        public void Move()
        {
            if (OnTable)
            {
                //move north
                if ((Facing % 4) == (int)Directions.NORTH)
                {
                    if (Y < Table.GetLength(1) - 1)
                    {
                        Y += 1;
                    }
                }
                //move east
                if ((Facing % 4) == (int)Directions.EAST)
                {
                    if (X < Table.GetLength(0) - 1)
                    {
                        X += 1;
                    }
                }
                //move south
                if ((Facing % 4) == (int)Directions.SOUTH)
                {
                    if (Y > 0)
                    {
                        Y -= 1;
                    }
                }
                //move west
                if ((Facing % 4) == (int)Directions.WEST)
                {
                    if (X > 0)
                    {
                        X -= 1;
                    }
                }
            }
        }

        //Left instruction
        public void Left()
        {
            if (OnTable)
            {
                Facing -= 1;
            }
        }

        //Right instruction
        public void Right()
        {
            if (OnTable)
            {
                Facing += 1;
            }
        }

        //Report instruction
        public string Report()
        {
            if (OnTable)
            {
                return X.ToString() + "," + Y.ToString() + "," + Enum.GetName(typeof(Directions), mod(Facing));
            }
            //return null if not on table
            return null;
        }

        //Accessor methods for testing
        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }
        public String GetFacing()
        {
            return Enum.GetName(typeof(Directions), mod(Facing));
        }

        //Custom modulo for printing direction
        private int mod(int x)
        {
            return (x % 4 + 4) % 4;
        }
    }
}
