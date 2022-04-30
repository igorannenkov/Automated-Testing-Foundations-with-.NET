using System;
using System.Collections.Generic;


namespace Interfaces_and_Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //примеры использования методов
            //начальные и конечные точки генерируем случайным образом.
            Console.WriteLine("Примеры: \r\n");
            Random rand = new Random();

            Point3D currentLocation = new Point3D(rand.Next(50), rand.Next(50), rand.Next(50));
            Point3D newLocation = new Point3D(rand.Next(50), rand.Next(50), rand.Next(50));
            Bird theBird = new Bird(currentLocation);
            theBird.FlyTo(newLocation);
            Console.WriteLine();

            currentLocation = new Point3D(rand.Next(1500), rand.Next(1500), rand.Next(1500));
            newLocation = new Point3D(rand.Next(1500), rand.Next(1500), rand.Next(1500));
            Airplane airbus = new Airplane(currentLocation);
            airbus.FlyTo(newLocation);
            Console.WriteLine();

            currentLocation = new Point3D(rand.Next(1500), rand.Next(1500), rand.Next(1500));
            newLocation = new Point3D(rand.Next(1500), rand.Next(1500), rand.Next(1500));
            Drone hermes = new Drone(currentLocation);
            hermes.FlyTo(newLocation);
        }
    }
}