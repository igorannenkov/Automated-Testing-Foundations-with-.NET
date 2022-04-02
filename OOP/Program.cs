using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        class Engine
        {
            public int Power;
            public double Volume;
            public string Type;
            public string SerialNumber;
            public Engine(int Power, double Volume, string Type, string SerialNumber)
            {
                this.Power = Power;
                this.Volume = Volume;
                this.Type = Type;
                this.SerialNumber = SerialNumber;
            }
        }
        class Chassis
        {
            public int WheelsCount;
            public string ChassisNumber;
            public int PermissibleLoad;
            public Chassis(int WheelsCount, string ChassisNumber, int PermissibleLoad)
            {
                this.WheelsCount = WheelsCount;
                this.ChassisNumber = ChassisNumber;
                this.PermissibleLoad = PermissibleLoad;
            }
        }
        class Transmission
        {
            public string TransmissionType;
            public int GearsCount;
            public string Maker;
            public Transmission(string TransmissionType, int GearsCount, string Maker)
            {
                this.TransmissionType = TransmissionType;
                this.GearsCount = GearsCount;
                this.Maker = Maker;
            }
        }
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
            private protected void DisplayBaseInfo()
            {
                Console.WriteLine($"Информация о сущности {GetType().Name}:");
                Console.WriteLine($"Двигатель. мощность: {engine.Power} л.с.; объем: {engine.Volume} л.; тип: {engine.Type}; серийный номер: {engine.SerialNumber};");
                Console.WriteLine($"Шасси. кол-во колес: {chassis.WheelsCount}; номер: {chassis.ChassisNumber}; допустимая нагрузка: {chassis.PermissibleLoad} кг.;");
                Console.WriteLine($"Трансмиссия. тип: {transmission.TransmissionType}; кол-во передач: {transmission.GearsCount}; производитель: {transmission.Maker}.");
            }
        }
        class Car : Transport
        {
            public int cruisingSpeed;
            public double clearance;
            public Car(int cruisingSpeed, double clearance, Engine vechicleEngine, Chassis vehicleChassis, Transmission vehicleTransmission) : base(vechicleEngine, vehicleChassis, vehicleTransmission)
            {
                this.cruisingSpeed = cruisingSpeed;
                this.clearance = clearance;
            }
            public void DisplayInfo()
            {
                DisplayBaseInfo();
                Console.WriteLine($"Прочее. крейсерская скорость: {cruisingSpeed} км/ч; дорожный просвет: {clearance} мм.");
                Console.WriteLine();
            }
        }
        class Truck : Transport
        {
            public string truckType;
            public string cabinType;
            public Truck(string truckType, string cabinType, Engine vechicleEngine, Chassis vehicleChassis, Transmission vehicleTransmission) : base(vechicleEngine, vehicleChassis, vehicleTransmission)
            {
                this.truckType = truckType;
                this.cabinType = cabinType;
            }
            public void DisplayInfo()
            {
                DisplayBaseInfo();
                Console.WriteLine($"Прочее. тип: {truckType}; тип кабины: {cabinType}.");
                Console.WriteLine();
            }
        }
        class Bus : Transport
        {
            public int seatsCount;
            public string purpose;
            public Bus(int seatsCount, string purpose, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
            {
                this.seatsCount = seatsCount;
                this.purpose = purpose;
            }
            public void DisplayInfo()
            {
                DisplayBaseInfo();
                Console.WriteLine($"Прочее. кол-во мест: {seatsCount}; назначение: {purpose}.");
                Console.WriteLine();
            }
        }
        class Scooter : Transport
        {
            public int weight;
            public string startMethod;
            public Scooter(int weight, string startMethod, Engine vechicleEngine, Chassis vehicleChassis, Transmission vehicleTransmission) : base(vechicleEngine, vehicleChassis, vehicleTransmission)
            {
                this.weight = weight;
                this.startMethod = startMethod;
            }
            public void DisplayInfo()
            {
                DisplayBaseInfo();
                Console.WriteLine($"Прочее. масса: {weight} кг.; метод запуска: {startMethod}.");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Car Mazda = new Car(90, 175, new Engine(90, 1.6, "бензиновый", "1KLBN52"), new Chassis(4, "WXM178", 500), new Transmission("автоматическая", 5, "Jatco"));
            Truck Scania = new Truck("тягач", "бескапотная", new Engine(420, 11.7, "дизельный", "3Z23B26"), new Chassis(4, "UTV257", 32000), new Transmission("автоматическая", 12, "Opticruise"));
            Bus Ikarus = new Bus(80, "междугородный", new Engine(192, 10.3, "дизельный", "26RLK9F"), new Chassis(4, "PJ087Y", 9000), new Transmission("ручная", 5, "Eaton"));
            Scooter Suzuki = new Scooter(90, "кикстартер", new Engine(6, 0.5, "бензиновый", "9RW89QY"), new Chassis(2, "FH3TR9", 120), new Transmission("автоматическая", 2, "Allison"));
            Mazda.DisplayInfo();
            Scania.DisplayInfo();
            Ikarus.DisplayInfo();
            Suzuki.DisplayInfo();
        }
    }
}
