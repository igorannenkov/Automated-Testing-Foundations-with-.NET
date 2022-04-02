using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// Описывает абстрактную сущность "Транспортное средство".
    /// </summary>
    abstract class Transport
    {
        public Engine engine;
        public Chassis chassis;
        public Transmission transmission;

        public Transport(Engine engine, Chassis chassis, Transmission transmission)
        {
            this.engine = engine;
            this.chassis = chassis;
            this.transmission = transmission;
        }

        /// <summary>
        /// Выводит базовую информацию о транспортном средстве в консоль.
        /// </summary>
        private protected void DisplayBaseInfo()
        {
            Console.WriteLine($"Информация о сущности {GetType().Name}:");
            Console.WriteLine($"Двигатель. мощность: {engine.power} л.с.; объем: {engine.volume} л.; тип: {engine.type}; серийный номер: {engine.serialNumber};");
            Console.WriteLine($"Шасси. кол-во колес: {chassis.wheelsCount}; номер: {chassis.chassisNumber}; допустимая нагрузка: {chassis.permissibleLoad} кг.;");
            Console.WriteLine($"Трансмиссия. тип: {transmission.transmissionType}; кол-во передач: {transmission.gearsCount}; производитель: {transmission.maker}.");
        }
    }
}