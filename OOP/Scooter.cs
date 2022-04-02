using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// Описывает и выводит на экран данные о сущности "Скутер". Содержит доп. поля: вес и метод запуска.
    /// </summary>
    class Scooter : Transport
    {
        public int weight;
        public string startMethod;

        public Scooter(int weight, string startMethod, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            this.weight = weight;
            this.startMethod = startMethod;
        }

        /// <summary>
        /// Выводит полную информацию об экземпляре класса "Скутер" в консоль.
        /// </summary>
        public void DisplayInfo()
        {
            DisplayBaseInfo();
            Console.WriteLine($"Прочее. масса: {weight} кг.; метод запуска: {startMethod}.");
            Console.WriteLine();
        }
    }
}