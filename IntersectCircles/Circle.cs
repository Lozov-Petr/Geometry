using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using CircleLib;

namespace IntersectCircles
{
    public class Circle : CommonCircle
    {

        static Random rnd = new Random();

        public void createRandCircle()
        {
            this.R = rnd.Next(10, 65);
            this.X = rnd.Next(R, 200 - R);
            this.Y = rnd.Next(R, 200 - R);
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(Color.BlueViolet, 2.0f), X - R, Y - R, 2 * R, 2 * R);
        }
    }
}
