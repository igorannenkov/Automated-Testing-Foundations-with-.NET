using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// Описывает и выводит на экран данные о сущности "Грузовик". Содержит доп. поля: тип грузовика и тип кабины.
    /// </summary>
    class Truck : Transport
    {
        public string TruckType;
        public string CabinType;

        public Truck(string truckType, string cabinType, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            TruckType = truckType;
            CabinType = cabinType;
        }

        /// <summary>
        /// Выводит полную информацию об экземпляре класса "Грузовик" в консоль.
        /// </summary>
        public void DisplayInfo()
        {
            DisplayBaseInfo();
            Console.WriteLine($"Прочее. тип: {TruckType}; тип кабины: {CabinType}.");
            Console.WriteLine();
        }
    }
}