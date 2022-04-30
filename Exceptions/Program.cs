using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage Hangar = new Garage();
            Hangar.Initialise();

            Car Niva = new Car(cruisingSpeed: 80, clearance: 250,
                    new Engine(100, 1.6, "Бензиновый", "12345RTW"),
                    new Chassis(4, "12345UUY", 500),
                    new Transmission("Ручная", 5, "Автоваз"));

            // CarInitializationException.
            try
            {
                Car Lada = new Car(cruisingSpeed: -1, clearance: 230,
                    new Engine(100, 1.6, "Бензиновый", "12345RTW"),
                    new Chassis(4, "12345UUY", 500),
                    new Transmission("Ручная", 5, "Автоваз"));
            }
            catch (CarInitializationException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message} Некорректное значение: {ex.Value}");
            }

            // AddException.
            Console.WriteLine();
            try
            {
                Hangar.AddCar(null);
            }
            catch (AddException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            // GetAutoByParameterException.
            Console.WriteLine();
            try
            {
                Car requiredCar = Hangar.GetAutoByParameter("Крейсерская скорость", "190");
                Console.WriteLine("Автомобиль найден.");
                requiredCar.DisplayInfo();
            }
            catch (GetAutoByParameterException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message} {ex.Parameter}");
            }

            // UpdateAutoException.
            Console.WriteLine();
            int index = 20;
            try
            {
                Hangar.UpdateAuto(index, Niva);
            }
            catch (UpdateAutoException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            //RemoveAutoException.
            Console.WriteLine();
            index = 40;
            try
            {
                Hangar.RemoveAuto(index);
            }
            catch (RemoveAutoException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}