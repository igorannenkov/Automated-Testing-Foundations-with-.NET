using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes
{
    //Реазизация интерфейса IFlyable возложена на производные классы, унаследованные от абстрактного класса Flying.

    /// <summary>
    /// Описывает абсрактную сущность летающего транспортного средства.
    /// </summary>
    abstract class Flying : IFlyable
    {
        protected Point3D currentLocation;
        protected int speed;
        public virtual int Speed { get; set; }

        public Point3D Location
        {
            get { return currentLocation; }
            set { currentLocation = value; }
        }

        public Flying(Point3D location, int Speed)
        {
            currentLocation = location;
            speed = Speed;
        }
        /// <summary>
        /// Определяет расстояние между двумя точками в пространстве.
        /// </summary>
        /// <param name="newLocation">Координаты местоположения, до которого необходимо вычислить расстояние от текущего.</param>
        /// <returns>Расстояние между двумя точками в пространстве. Вычисляется по теореме Пифагора.</returns>
        public virtual double GetDistance(Point3D newLocation)//метод GetDistance возвращает 
        {
            int dX = newLocation.X - currentLocation.X;
            int dY = newLocation.Y - currentLocation.Y;
            int dZ = newLocation.Z - currentLocation.Z;
            return Math.Round(Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2) + Math.Pow(dZ, 2)), 3);
        }

        /// <summary>
        /// Дефолтная реализация метода. Меняет текущие координаты объекта на новые.
        /// </summary>
        /// <param name="newLocation">Новые координаты объекта.</param>
        public virtual void FlyTo(Point3D newLocation)
        {
            currentLocation = newLocation;
        }

        /// <summary>
        /// Определяет время перемещения из текущего местоположения в новое.
        /// Абстрактный метод, который необходимо реализовать в производных классах.
        /// </summary>
        /// <param name="newLocation">Новые координаты объекта.</param>
        /// <returns>Время перелета из одной точки в другую (в часах).</returns>
        public abstract double GetFlyTime(Point3D newLocation);
    }
}