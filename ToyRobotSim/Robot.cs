using System;

namespace ToyRobotSim
{
    class Robot
    {
        private int X;
        private int Y;
        private int Facing;
        enum Directions { NORTH, EAST, SOUTH, WEST };
        private Robot[,] Table;
        bool OnTable;

        public Robot(Robot[,] table)
        {
            X = 0;
            Y = 0;
            Facing = 0;
            Table = table;
            OnTable = false;
        }

        public void Place(int x, int y, int facing)
        {
            if(x < Table.GetLength(0) && y < Table.GetLength(1))
            {
                if (x >= 0 && y >= 0)
                {
                    X = x;
                    Y = y;
                    Facing = facing;
                    OnTable = true;
                }
            }
        }
        public void Move()
        {
            if (OnTable)
            {
                if ((Facing % 4) == (int)Directions.NORTH)
                {
                    if (Y < Table.GetLength(1) - 1)
                    {
                        Y += 1;
                    }
                }
                if ((Facing % 4) == (int)Directions.EAST)
                {
                    if (X < Table.GetLength(0) - 1)
                    {
                        X += 1;
                    }
                }
                if ((Facing % 4) == (int)Directions.SOUTH)
                {
                    if (Y > 0)
                    {
                        Y -= 1;
                    }
                }
                if ((Facing % 4) == (int)Directions.WEST)
                {
                    if (X > 0)
                    {
                        X -= 1;
                    }
                }
            }
        }
        public void Left()
        {
            if (OnTable)
            {
                Facing -= 1;
            }
        }
        public void Right()
        {
            if (OnTable)
            {
                Facing += 1;
            }
        }
        public string Report()
        {
            if (OnTable)
            {
                return X.ToString() + "," + Y.ToString() + "," + Enum.GetName(typeof(Directions), (Facing % 4));
            }
            return null;
        }
    }
}
