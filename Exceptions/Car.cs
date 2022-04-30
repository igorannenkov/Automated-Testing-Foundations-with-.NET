﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// Описывает и выводит на экран данные о сущности "Автомобиль". Содержит доп. поля: крейсерская скорость и клиренс.
    /// </summary>
    class Car : Transport
    {
        public int CruisingSpeed;
        public double Clearance;

        public Car(int cruisingSpeed, double clearance, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            if (cruisingSpeed < 0)
            {
                throw new CarInitializationException("Крейсерская скорость автомобиля не может быть отрицательной!", cruisingSpeed);
            }
            else
            {
                CruisingSpeed = cruisingSpeed;
            }

            Clearance = clearance;
        }

        /// <summary>
        /// Выводит полную информацию об экземпляре класса "Автомобиль" в консоль.
        /// </summary>
        public void DisplayInfo()
        {
            DisplayBaseInfo();
            Console.WriteLine($"Прочее. крейсерская скорость: {CruisingSpeed} км/ч; дорожный просвет: {Clearance} мм.");
            Console.WriteLine();
        }
    }
}