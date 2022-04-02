using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// Описывает и выводит на экран данные о сущности "Грузовик". Содержит доп. поля: тип грузовика и тип кабины.
    /// </summary>
    class Truck : Transport
    {
        public string truckType;
        public string cabinType;

        public Truck(string truckType, string cabinType, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            this.truckType = truckType;
            this.cabinType = cabinType;
        }

        /// <summary>
        /// Выводит полную информацию об экземпляре класса "Грузовик" в консоль.
        /// </summary>
        public void DisplayInfo()
        {
            DisplayBaseInfo();
            Console.WriteLine($"Прочее. тип: {truckType}; тип кабины: {cabinType}.");
            Console.WriteLine();
        }
    }
}