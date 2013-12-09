using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace CircleLib
{
    public class CommonCircle
    {
        /// <summary>Координата X.</summary>
        public int X;
        /// <summary>Координата Y.</summary>
        public int Y;
        /// <summary>Радиус.</summary>
        public int R;

        /// <summary>Создаёт круг.</summary>
        /// <param name="X">Координата X.</param>
        /// <param name="Y">Координата Y.</param>
        /// <param name="R">Радиус.</param>
        public CommonCircle(int X = 0, int Y = 0, int R = 0)
        {
            this.X = X;
            this.Y = Y;
            this.R = R;
        }


        /// <summary>Проверяет, пересекается ли этот круг с другим.</summary>
        /// <param name="c">Второй круг.</param>
        /// <returns>True - пересекает, false - нет.</returns>
        public bool Intersect(CommonCircle c)
        {
            return Math.Sqrt(Math.Pow(X - c.X, 2) + Math.Pow(Y - c.Y, 2)) <= R + c.R;
        }
    }
}
