using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes
{
    /// <summary>
    /// Описывает сущность "Птица". Летит все расстояние с постоянной скоростью в диапазоне 0-20 км/ч (заданной случайно). 
    /// Если генерируется скорость 0 км/ч, птица никуда не летит и остается на месте.
    /// После перелета координаты птицы меняются на новые.
    /// </summary>
    class Bird : Flying
    {
        public Bird(Point3D location) : base(location, 0) { }

        /// <summary>
        /// Представляет перелет птицы из одной точки в другую, меняя при этом текущие координаты на новые. Выводит на экран информацию о перелете.
        /// </summary>
        /// <param name="newLocation">Координаты нового местоположения.</param>
        public override void FlyTo(Point3D newLocation)
        {
            Speed = new Random().Next(20);
            double distance = Math.Round(GetDistance(newLocation), 2);
            Console.WriteLine($"Птица сидит на дереве с координатами {currentLocation}.");

            if (Speed == 0)
            {
                Console.WriteLine($"Решила отдохнуть и никуда не полетела, скорость 0 км/ч.");
            }
            else
            {
                Console.WriteLine($"Полетела в точку с координатами {newLocation}.");
                Console.WriteLine($"Расстояние: {distance} км., cкорость: {Speed} км/ч.");
            }

            Console.WriteLine($"Время перелета составило: {GetFlyTime(newLocation)} ч.");
            Location = newLocation;
        }

        /// <summary>
        /// Определяет время перелета из текущего местоположения в новое.
        /// </summary>
        /// <param name="newLocation">Координаты нового местоположения.</param>
        /// <returns>Время перелета в часах.</returns>
        public override double GetFlyTime(Point3D newLocation)
        {
            return ((Speed == 0) ? 0 : Math.Round((GetDistance(newLocation) / Speed), 1));
        }
    }
}