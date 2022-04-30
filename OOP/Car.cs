using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// Описывает и выводит на экран данные о сущности "Автомобиль". Содержит доп. поля: крейсерская скорость и клиренс.
    /// </summary>
    class Car : Transport
    {
        public int cruisingSpeed;
        public double clearance;

        public Car(int cruisingSpeed, double clearance, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            this.cruisingSpeed = cruisingSpeed;
            this.clearance = clearance;
        }

        /// <summary>
        /// Выводит полную информацию об экземпляре класса "Автомобиль" в консоль.
        /// </summary>
        public void DisplayInfo()
        {
            DisplayBaseInfo();
            Console.WriteLine($"Прочее. крейсерская скорость: {cruisingSpeed} км/ч; дорожный просвет: {clearance} мм.");
            Console.WriteLine();
        }
    }
}