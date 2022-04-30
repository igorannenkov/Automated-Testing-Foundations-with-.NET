using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes
{
    /// <summary>
    /// Описывает сущность "Самолет". Увеличивает скорость на 10 км/ч каждые 10 км полета от начальной скорости 200 км/ч.
    /// Не может разогнаться выше максимальной скорости 1000км/ч.
    /// </summary>
    class Airplane : Flying
    {
        const int MinSpeed = 200;
        const int MaxSpeed = 1000;
        const int SpeedIncrementStep = 10;
        const int SpeedIncrementDistance = 10;
        /// <summary>
        /// Ограничивает диапазон допустимых значений скорости
        /// </summary>
        public override int Speed
        {
            get { return speed; }
            set
            {
                if (value <= MinSpeed) { speed = MinSpeed; }
                if (value < MaxSpeed && value > MinSpeed) { speed = value; }
                if (value >= MaxSpeed) { speed = MaxSpeed; }
            }
        }
        public Airplane(Point3D location) : base(location, MinSpeed) { }

        /// <summary>
        /// Перемещает самолет из одной точки в другую, меняя при этом координаты на новые. Выводит на экран информацию о перелете.
        /// </summary>
        /// <param name="newLocation">Новое местоположение объекта.</param>
        public override void FlyTo(Point3D newLocation)
        {
            Speed = MinSpeed;
            double distance = Math.Round(GetDistance(newLocation), 3);
            double passedDistance = 0;

            Console.WriteLine($"Самолет находится в аэропорту c координатами {currentLocation}.");
            Console.WriteLine($"Вылетел в аэропорт с координатам {newLocation}.");
            // Увеличиваем скорость на 10км/ч каждые 10км пути, скорость ограничена макс. значением.
            while (passedDistance < distance)
            {
                Speed += SpeedIncrementStep;
                passedDistance += SpeedIncrementDistance;
            }

            Console.WriteLine($"Расстояние: {distance} км. Во время перелета увеличил скорость до {speed} из 1000 км/ч.");
            Console.WriteLine($"Время перелета составило: {GetFlyTime(newLocation)} ч.");
            Location = newLocation;
        }
        /// <summary>
        /// Определяет время перелета из текущего пестоположения в новое.
        /// </summary>
        /// <param name="newLocation">Новое местоположение.</param>
        /// <returns>Время перелета в часах.</returns>
        /// <remarks>
        /// Считаем время в пути как сумму времени на каждом интервале перелета на участках длиной по 10км.
        /// На каждом последующем участке длиной 10км увеличиваем скорость на 10км/ч,
        /// пока не достигнем 1000км/ч либо оставшееся расстояние перелета будет менее 10км.  
        /// Остаток пути (менее 10км.) самолет летит на максимально развитой скорости, но не более 1000км/ч
        /// </remarks>
        public override double GetFlyTime(Point3D newLocation)
        {
            Speed = MinSpeed;
            double flyTime = 0;
            double fullDistance = GetDistance(newLocation);
            double remainingDistance = fullDistance;

            while ((Speed < MaxSpeed) && (remainingDistance > SpeedIncrementDistance))
            {
                Speed += SpeedIncrementStep;
                flyTime += (double)SpeedIncrementDistance / (double)(Speed); //добавим время перелета очередного участка длиной 10км с текущей скоростью
                remainingDistance -= SpeedIncrementDistance; //уменьшим оставшееся расстояние на длину очередного скоростного участка 
            }

            if (remainingDistance > 0)
            {
                flyTime += remainingDistance / (Speed);
            }
            return Math.Round(flyTime, 2);
        }
    }
}