using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes
{
    /// <summary>
    /// Хранит 3D координаты объекта. Принимаются только положительные значения координат.
    /// </summary>
    struct Point3D
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get { return x; }
            set { if (value >= 0) { x = value; } }
        }

        public int Y
        {
            get { return y; }
            set { if (value >= 0) { y = value; } }
        }

        public int Z
        {
            get { return z; }
            set { if (value >= 0) { z = value; } }
        }

        public Point3D(int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        /// <summary>
        /// Преобразовывает 3D координаты в строковое значение. Используется для вывода на экран.
        /// </summary>
        /// <returns>Значение 3D координат в виде строки, например: "[90, 60, 90]".</returns>
        public override string ToString()
        {
            return $"[{x},{y},{z}]";
        }
    }
}