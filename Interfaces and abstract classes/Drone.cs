using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes
{
    /// <summary>
    /// Описывает сущность "Дрон".
    /// Звисает в воздухе каждые 10 минут полета на 1 минуту.
    /// Дальность полета ограничена расстоянием в 1000км. Летает на скорости не ниже 50км/ч и не выше 300км/ч. Скорость генерируется случайным образом.
    /// </summary>
    class Drone : Flying
    {
        const double MaxDistance = 1000; // предельная дальность полета
        const int MinSpeed = 50;
        const int MaxSpeed = 300;
        const double HoveredTime = 0.0166666; // 1мин = 1/60ч = 0,0166666ч (время зависания дрона в воздухе)
        const double HoverTimeInterval = 0.166666; // 10 мин = 1/6ч = 0,166666ч (интервал времени зависания в воздухе)

        public Drone(Point3D location) : base(location, new Random().Next(MinSpeed, MaxSpeed)) { }

        /// <summary>
        /// Ограничивает диапазон допустимых значений скорости.
        /// </summary>
        public override int Speed
        {
            get { return speed; }
            set
            {
                if (value < MinSpeed) { speed = MinSpeed; }
                if (value < MaxSpeed && value > MinSpeed) { speed = value; }
                if (value >= MaxSpeed) { speed = MaxSpeed; }
            }
        }

        /// <summary>
        /// Определяет время перелета из текущего местоположения в новое.
        /// </summary>
        /// <param name="newLocation">Координаты нового местоположения.</param>
        /// <returns>Время перелета в часах.</returns>
        public override double GetFlyTime(Point3D newLocation)
        {
            double distance = GetDistance(newLocation);
            // дрон может лететь на расстояние не более предельной дальности.
            if (distance > MaxDistance)
            {
                distance = MaxDistance;
            }

            double unhoveredTime = distance / Speed; //время полета без учета зависаний
            int hovers = (int)(unhoveredTime / HoverTimeInterval);//общее кол-во зависаний в воздухе
            return Math.Round(unhoveredTime + (hovers * HoveredTime), 2);
        }
        /// <summary>
        /// Перемещает дрон из одной точки в другую, меняя при этом координаты на новые. Выводит на экран информацию о перелете.
        /// </summary>
        /// <param name="newLocation">Новое местоположение объекта.</param>
        /// <remarks>
        /// При превышении дальности дрон летит на макс. возможное расстояние (1000км) и приземляется.
        /// Время перелета в часах конвертируем в минуты (умножив на 60) и делим на интервал зависаний (10 мин), таким образом получаем кол-во зависаний.
        /// </remarks>
        public override void FlyTo(Point3D newLocation)
        {
            double distance = Math.Round(GetDistance(newLocation), 2);
            Console.WriteLine($"Дрон находится в точке с координатами {currentLocation}.");

            if (distance >= MaxDistance)
            {
                int hoversCount = (int)(((MaxDistance / Speed) * 60) / 10);
                double hoversTime = Math.Round(((MaxDistance / Speed) / 10), 2);
                Console.WriteLine($"Полетел в точку с координатами {newLocation} на расстояние {distance} км.");
                Console.WriteLine($"Дальность полета дрона ограничена. Дрон пролетел максимальное расстояние 1000 км. и приземлился.");
                Console.WriteLine($"Скорость: {Speed} км/ч.");
                Console.WriteLine($"Во время перелета дрон зависал в воздухе {hoversCount} раз(а) по 1 мин, что составило {hoversTime} ч. от общего времени полета.");
            }
            else
            {
                int hoversCount = (int)(((distance / Speed) * 60) / 10);
                double hoversTime = Math.Round(((distance / Speed) / 10), 2);
                Console.WriteLine($"Переместился в точку с координатами {newLocation}.");
                Console.WriteLine($"Расстояние: {distance} км., cкорость: {Speed} км/ч.");
                Console.WriteLine($"Во время перелета дрон зависал в воздухе {hoversCount} раз(а) по 1 мин, что составило {hoversTime} ч. от общего времени полета.");
            }

            Console.WriteLine($"Время перелета составило: {GetFlyTime(newLocation)} ч.");
            Location = newLocation;
        }
    }
}