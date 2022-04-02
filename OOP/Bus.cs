using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// Описывает и выводит на экран данные о сущности "Автобус". Содержит доп. поля: количество мест и тип автобуса.
    /// </summary>
    class Bus : Transport
    {
        public int seatsCount;
        public string purpose;

        public Bus(int seatsCount, string purpose, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            this.seatsCount = seatsCount;
            this.purpose = purpose;
        }

        /// <summary>
        /// Выводит полную информацию об экземпляре класса "Автобус" в консоль.
        /// </summary>
        public void DisplayInfo()
        {
            DisplayBaseInfo();
            Console.WriteLine($"Прочее. кол-во мест: {seatsCount}; назначение: {purpose}.");
            Console.WriteLine();
        }
    }
}