using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace CircleLib
{
    public class CommonCircle
    {
        public int X;
        public int Y;
        public int R;

        public CommonCircle(int X = 0, int Y = 0, int R = 0)
        {
            this.X = X;
            this.Y = Y;
            this.R = R;
        }

        public bool Intersect(CommonCircle c)
        {
            return Math.Sqrt(Math.Pow(X - c.X, 2) + Math.Pow(Y - c.Y, 2)) <= R + c.R;
        }
    }
}
