using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /// <summary>
    /// Описывает абстрактную сущность "Транспортное средство".
    /// </summary>
    abstract class Transport
    {
        public Engine Engine;
        public Chassis Chassis;
        public Transmission Transmission;

        public Transport(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }

        /// <summary>
        /// Выводит базовую информацию о транспортном средстве в консоль.
        /// </summary>
        private protected void DisplayBaseInfo()
        {
            Console.WriteLine($"Информация о сущности {GetType().Name}:");
            Console.WriteLine($"Двигатель. мощность: {Engine.Power} л.с.; объем: {Engine.Volume} л.; тип: {Engine.EngineType}; серийный номер: {Engine.SerialNumber};");
            Console.WriteLine($"Шасси. кол-во колес: {Chassis.WheelsCount}; номер: {Chassis.ChassisNumber}; допустимая нагрузка: {Chassis.PermissibleLoad} кг.;");
            Console.WriteLine($"Трансмиссия. тип: {Transmission.TransmissionType}; кол-во передач: {Transmission.GearsCount}; производитель: {Transmission.Maker}.");
        }
    }
}