using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /// <summary>
    /// Описывает и выводит на экран данные о сущности "Скутер". Содержит доп. поля: вес и метод запуска.
    /// </summary>
    class Scooter : Transport
    {
        public int Weight;
        public string StartMethod;

        public Scooter(int weight, string startMethod, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            Weight = weight;
            StartMethod = startMethod;
        }

        /// <summary>
        /// Выводит полную информацию об экземпляре класса "Скутер" в консоль.
        /// </summary>
        public void DisplayInfo()
        {
            DisplayBaseInfo();
            Console.WriteLine($"Прочее. масса: {Weight} кг.; метод запуска: {StartMethod}.");
            Console.WriteLine();
        }
    }
}