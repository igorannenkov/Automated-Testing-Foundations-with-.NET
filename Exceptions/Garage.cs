using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Garage
    {
        public List<Car> Cars;

        /// <summary>
        /// Заполняет гараж автомобилями (всего 10 элементов).
        /// </summary>
        public void Initialise()
        {
            Cars = new List<Car> {
               new Car(cruisingSpeed: 90, clearance: 175,
                    new Engine(power: 90, volume: 1.6, engineType: "Бензиновый", serialNumber: "1KLBN52"),
                    new Chassis(wheelsCount: 4, chassisNumber: "WXM178", permissibleLoad: 500),
                    new Transmission(transmissionType: "Автоматическая", gearsCount: 5, maker: "Jatco")),
                new Car(100, 150,
                    new Engine(120, 3.5, "Бензиновый", "GGQ212"),
                    new Chassis(4, "XLW982", 550),
                    new Transmission("Автоматическая", 6, "Allison")),
                new Car(90, 200,
                    new Engine(95, 1.8, "Бензиновый", "FW2341"),
                    new Chassis(4, "PX9323", 550),
                    new Transmission("Ручная", 5, "Volga")),
                new Car(100, 170,
                    new Engine(95, 1.8, "Бензиновый", "GP3221"),
                    new Chassis(4, "JJ2121", 500),
                    new Transmission("Автоматическая", 5, "Eaton")),
                new Car(90, 180,
                    new Engine(85, 1.4, "Бензиновый", "KD3288"),
                    new Chassis(4, "YT0982", 400),
                    new Transmission("Ручная", 5, "Lada")),
                new Car(90, 200,
                    new Engine(100, 2.0, "Бензиновый", "II81002"),
                    new Chassis(4, "OP21WC", 450),
                    new Transmission("Ручная", 6, "Kama")),
                new Car(90, 170,
                    new Engine(100, 1.8, "Бензиновый", "DDK9166"),
                    new Chassis(4, "OPRT211", 400),
                    new Transmission("Автоматическая", 6, "Eaton")),
                new Car(110, 150,
                    new Engine(140, 3.0, "Дизельный", "MBB3099"),
                    new Chassis(4, "BM323RR", 550),
                    new Transmission("Автоматическая", 6, "Allison")),
                new Car(110, 160,
                    new Engine(160, 3.5, "Бензиновый", "AU7722YW"),
                    new Chassis(4, "AU12II0", 600),
                    new Transmission("Автоматическая", 6, "Eaton")),
                new Car(110, 150,
                    new Engine(200, 3.5, "Бензиновый", "TY7772"),
                    new Chassis(4, "TY712100", 550),
                    new Transmission("Автоматическая", 6, "Allison"))
            };
        }
        public void AddCar(Car auto)
        {
            if (auto != null)
            {
                Cars.Add(auto);
            }
            else
            {
                throw new AddException("Автомобиль не содержит данные. Добавление невозможно.");
            }
        }

        public Car GetAutoByParameter(string parameter, string value)
        {
            switch (parameter)
            {
                case "Крейсерская скорость":
                    if (Cars.FirstOrDefault(theCar => theCar.CruisingSpeed.ToString() == value) == null)
                    {
                        throw new GetAutoByParameterException("Невозможно найти автомобиль.", $"Параметр: Крейсерская скорость, значение: {value} км/ч");
                    }

                    return Cars.FirstOrDefault(theCar => theCar.CruisingSpeed.ToString() == value);

                case "Клиренс":
                    if (Cars.FirstOrDefault(theCar => theCar.CruisingSpeed.ToString() == value) == null)
                    {

                        throw new GetAutoByParameterException("Невозможно найти автомобиль.", $"Параметр: Клиренс, значение: {value} мм");
                    }
                    return Cars.FirstOrDefault(theCar => theCar.Clearance.ToString() == value);

                default:
                    throw new GetAutoByParameterException("Невозможно найти автомобиль по указанным данным.", $"Параметр: {parameter}, значение: {value}");
            }
        }

        public void UpdateAuto(int index, Car auto)
        {
            if (index > 0 && index < Cars.Count)
            {
                Cars[index] = auto;
                Console.WriteLine("Данные обновлены.");
            }
            else
            {
                throw new UpdateAutoException($"Невозможно заменить автомобиль по указанному индексу ({index}). Значение должно быть в пределах 0..{Cars.Count}.");
            }
        }

        public void RemoveAuto(int index)
        {
            if (index > 0 && index < Cars.Count)
            {
                Cars.RemoveAt(index);
                Console.WriteLine("Автомобиль удален.");
            }
            else
            {
                throw new RemoveAutoException($"Невозможно удалить автомобиль по указанному индексу ({index}). Значение должно быть в пределах 0..{Cars.Count}.");
            }
        }
    }
}