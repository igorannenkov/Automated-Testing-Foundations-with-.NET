using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// Описывает и выводит на экран данные о сущности "Автобус". Содержит доп. поля: количество мест и тип автобуса.
    /// </summary>
    class Bus : Transport
    {
        public int SeatsCount;
        public string Purpose;

        public Bus(int seatsCount, string purpose, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            SeatsCount = seatsCount;
            Purpose = purpose;
        }

        /// <summary>
        /// Выводит полную информацию об экземпляре класса "Автобус" в консоль.
        /// </summary>
        public void DisplayInfo()
        {
            DisplayBaseInfo();
            Console.WriteLine($"Прочее. кол-во мест: {SeatsCount}; назначение: {Purpose}.");
            Console.WriteLine();
        }
    }
}