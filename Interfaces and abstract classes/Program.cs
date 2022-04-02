using System;
using System.Collections.Generic;

namespace Interfaces_and_Abstract_Classes
{
    class Program
    {
        //структура "Координата" для храненя 3D координат объекта. Принимаются только положительные значения координат.
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
            //метод PrintPoint3D для вывода координаты на экран в консоли
            public string PrintPoint3D()
            {
                return $"[{x},{y},{z}]";
            }
        }
        interface IFlyable
        {
            void FlyTo(Point3D newPosition);
            double GetFlyTime(Point3D newPosition);
        }
        //Реазизация интерфейса IFlyable возложена на производные классы, унаследованные от абстрактного класса Flying
        abstract class Flying : IFlyable
        {
            protected Point3D currentPosition;
            protected int speed;
            public virtual int Speed { get; set; }
            public Point3D Location
            {
                get { return currentPosition; }
                set { currentPosition = value; }
            }
            public Flying(Point3D position, int Speed)
            {
                currentPosition = position;
                speed = Speed;
            }
            public virtual double GetDistance(Point3D newPosition)//метод GetDistance возвращает расстояние между двумя точками в пространстве (по теореме Пифагора).
            {
                int dX = newPosition.X - currentPosition.X;
                int dY = newPosition.Y - currentPosition.Y;
                int dZ = newPosition.Z - currentPosition.Z;
                return Math.Round(Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2) + Math.Pow(dZ, 2)), 3);
            }
            public virtual void FlyTo(Point3D newPosition)//дефолтная реализация метода FlyTo меняет текущие координаты объекта на новые заданные.
            {
                currentPosition = newPosition;
            }
            public abstract double GetFlyTime(Point3D newPosition);//абстрактный метод GetFlyTime реализуем в производных классах 
        }
        /*Птица летит все расстояние с постоянной скоростью в диапазоне 0-20 км/ч (заданной случайно).
          Если генерируется скорость = 0 км/ч, тогда птица никуда не летит и остается на месте.*/
        class Bird : Flying
        {
            public Bird(Point3D position) : base(position, 0)
            { }
            public override void FlyTo(Point3D newPosition)
            {
                Speed = new Random().Next(20);
                Console.WriteLine($"Птица сидит на дереве с координатами {currentPosition.PrintPoint3D()}.");
                double distance = Math.Round(GetDistance(newPosition), 2);
                if (Speed == 0)
                {
                    Console.WriteLine($"Решила отдохнуть и никуда не полетела, скорость 0 км/ч.");
                }
                else
                {
                    Console.WriteLine($"Перелетела в точку с координатами {newPosition.PrintPoint3D()}.");
                    Console.WriteLine($"Расстояние: {distance} км., cкорость: {Speed} км/ч.");
                }
                Console.WriteLine($"Время перелета составило: {GetFlyTime(newPosition)} ч.");
                Location = newPosition;
            }
            public override double GetFlyTime(Point3D newPosition)
            {
                if (Speed == 0)
                {
                    return 0;
                }
                return Math.Round((GetDistance(newPosition) / Speed), 1);
            }
        }
        //Самолет увеличивает скорость на 10 км/ч каждые 10 км полета от начальной скорости 200 км/ч.
        // Самолет не может разогнаться выше максимальной скорости 1000км/ч
        class Airplane : Flying
        {
            const int MIN_SPEED = 200;
            const int MAX_SPEED = 1000;
            const int SPEED_INCREMENT = 10; //шаг увеличения скорости за каждый пролетаемый отрезок пути
            const int SPEED_SECTION = 10; //отрезок пути, за который самолет увеличивает скорость
            public override int Speed //переопределяем свойство, ограничиваем диапазон допустимых скоростей
            {
                get { return speed; }
                set
                {
                    if (value <= MIN_SPEED) { speed = MIN_SPEED; }
                    if (value < MAX_SPEED && value > MIN_SPEED) { speed = value; }
                    if (value >= MAX_SPEED) { speed = MAX_SPEED; }
                }
            }
            public Airplane(Point3D position) : base(position, MIN_SPEED)
            { }
            public override void FlyTo(Point3D newPosition)
            {
                Speed = MIN_SPEED;
                Console.WriteLine($"Самолет находится в аэропорту c координатами {currentPosition.PrintPoint3D()}.");
                double distance = Math.Round(GetDistance(newPosition), 3);
                Console.WriteLine($"Вылетает в аэропорт с координатам {newPosition.PrintPoint3D()}.");
                double passedDistance = 0;
                //определяем скорость, достигнутую в полете (пока пройденное расстояние не превысило длину пути, увеличиваем скорость через каждые 10 км на 10км/ч
                while (passedDistance < distance)
                {
                    Speed += SPEED_INCREMENT;
                    passedDistance += SPEED_SECTION;
                }
                Console.WriteLine($"Расстояние: {distance} км. Во время перелета увеличил скорость до {speed} из 1000 км/ч.");
                Console.WriteLine($"Время перелета составило: {GetFlyTime(newPosition)} ч.");
                Location = newPosition;
            }
            public override double GetFlyTime(Point3D newPosition)
            {
                Speed = MIN_SPEED;
                double flyTime = 0;
                double fullDistance = GetDistance(newPosition);
                double remainingDistance = fullDistance;
                //считаем время в пути как сумму всех времен перелета на каждом участке длиной 10км.
                //на каждом последующем участке длиной 10км увеличиваем скорость на 10км/ч, пока не достигнем 1000км/ч либо оставшееся расстояние перелета будет менее 10км.           
                while ((Speed < MAX_SPEED) && (remainingDistance > SPEED_SECTION))
                {
                    Speed += SPEED_INCREMENT;//увеличим скорость на 10км/ч
                    flyTime += (double)SPEED_SECTION / (double)(Speed);//определим время, за которое самолет пролетел очередной участок длиной 10км с текущей скоростью
                    remainingDistance -= SPEED_SECTION; //уменьшим оставшееся расстояние на длину очередного расстояния 10км 
                }
                //оставшееся расстояние самолет летит на максимально развитой скорости, но не более 1000км/ч
                if (remainingDistance > 0)
                {
                    flyTime += remainingDistance / (Speed);
                }
                return Math.Round(flyTime, 2);
            }
        }
        //дрон зависает в воздухе каждые 10 минут полета на 1 минуту
        //дальность полета ограничена расстоянием в 1000км. Дрон может летать на скорости не ниже 50км/ч и не выше 300км/ч. скорость генерируется случайным образом.
        class Drone : Flying
        {
            const double MAX_DISTANCE = 1000; //максимальная дальность полета дрона.
            const int MIN_SPEED = 50;
            const int MAX_SPEED = 300;
            const double HOVERED_TIME = 0.0166666; // 1мин = 1/60ч = 0,0166666ч (время, на которое дрон зависает в воздухе)
            const double NEED_TO_HOVER_TIME_INTERVAL = 0.166666; // 10 мин = 1/6ч = 0,166666ч (интервал времени, через которое дрон зависает в воздухе очередной раз)
            public Drone(Point3D position) : base(position, new Random().Next(MIN_SPEED, MAX_SPEED))
            { }
            public override int Speed //переопределяем свойство, ограничиваем диапазон допустимых скоростей дрона
            {
                get { return speed; }
                set
                {
                    if (value < MIN_SPEED) { speed = MIN_SPEED; }
                    if (value < MAX_SPEED && value > MIN_SPEED) { speed = value; }
                    if (value >= MAX_SPEED) { speed = MAX_SPEED; }
                }
            }
            public override double GetFlyTime(Point3D newPosition)
            {
                double distance = GetDistance(newPosition);
                //если сгенерировано расстояние свыше дальности перелета дрона, дрон летит на предельную дальность полета (1000км).
                if (distance > MAX_DISTANCE)
                {
                    distance = MAX_DISTANCE;
                }
                double noHoverTime = distance / Speed; //время полета без зависаний в часах
                int hovers = (int)(noHoverTime / NEED_TO_HOVER_TIME_INTERVAL);//общее кол-во зависаний в воздухе
                return Math.Round(noHoverTime + (hovers * HOVERED_TIME), 2);// общее время перелета = время полета без зависаний + (кол-во зависаний, умноженное на время одного зависания)
            }
            public override void FlyTo(Point3D newPosition)
            {
                Console.WriteLine($"Дрон находится в точке с координатами {currentPosition.PrintPoint3D()}.");
                double distance = Math.Round(GetDistance(newPosition), 2);
                //если сгенерировано расстояние свыше дальности перелета дрона, дрон летит на предельную дальность полета (1000км) и приземляется.
                if (distance >= MAX_DISTANCE)
                {
                    Console.WriteLine($"Попытка переместиться в точку с координатами {newPosition.PrintPoint3D()} на расстояние {distance} км.");
                    Console.WriteLine($"Дальность полета дрона ограничена. Дрон пролетел максимальное расстояние 1000 км. и приземлился.");
                    Console.WriteLine($"Скорость: {Speed} км/ч.");
                    //Время перелета в часах конвертируем в минуты (умножив на 60) и делим на интервал зависаний (10 мин) и получаем кол-во необходимых зависаний.
                    Console.WriteLine($"Во время перелета дрон зависал в воздухе {(int)(((MAX_DISTANCE / Speed) * 60) / 10)} раз(а) по 1 мин, что составило {Math.Round(((MAX_DISTANCE / Speed) / 10), 2)} ч. от общего времени полета.");
                }
                else
                {
                    Console.WriteLine($"Перемещается в точку с координатами {newPosition.PrintPoint3D()}.");
                    Console.WriteLine($"Расстояние: {distance} км., cкорость: {Speed} км/ч.");
                    //аналогично время перелета в часах конвертируем в минуты (умножив на 60) и делим на интервал зависаний (10 мин) и получаем кол-во необходимых зависаний.
                    Console.WriteLine($"Во время перелета дрон зависал в воздухе {(int)(((distance / Speed) * 60) / 10)} раз(а) по 1 мин, что составило {Math.Round(((distance / Speed) / 10), 2)} ч. от общего времени полета.");
                }
                Console.WriteLine($"Время перелета составило: {GetFlyTime(newPosition)} ч.");
                Location = newPosition;
            }
        }
        static void Main(string[] args)
        {
            //примеры использования методов
            //начальные и конечные точки генерируем случайным образом.

            Console.WriteLine("Примеры: \r\n");
            Random rand = new Random();

            Point3D currentPosition = new Point3D(rand.Next(50), rand.Next(50), rand.Next(50));
            Point3D newPosition = new Point3D(rand.Next(50), rand.Next(50), rand.Next(50));
            Bird MigratingBird = new Bird(currentPosition);
            MigratingBird.FlyTo(newPosition);
            Console.WriteLine();

            currentPosition = new Point3D(rand.Next(1500), rand.Next(1500), rand.Next(1500));
            newPosition = new Point3D(rand.Next(1500), rand.Next(1500), rand.Next(1500));
            Airplane Airbus = new Airplane(currentPosition);
            Airbus.FlyTo(newPosition);
            Console.WriteLine();

            currentPosition = new Point3D(rand.Next(1500), rand.Next(1500), rand.Next(1500));
            newPosition = new Point3D(rand.Next(1500), rand.Next(1500), rand.Next(1500));
            Drone Hermes = new Drone(currentPosition);
            Hermes.FlyTo(newPosition);
        }
    }
}
