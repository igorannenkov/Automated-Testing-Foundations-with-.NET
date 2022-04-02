using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Mazda = new Car(cruisingSpeed: 90, clearance: 175,
                new Engine(power: 90, volume: 1.6, type: "бензиновый", serialNumber: "1KLBN52"),
                new Chassis(wheelsCount: 4, chassisNumber: "WXM178", permissibleLoad: 500),
                new Transmission(transmissionType: "автоматическая", gearsCount: 5, maker: "Jatco"));

            Truck Scania = new Truck(truckType: "тягач", cabinType: "бескапотная",
                new Engine(power: 420, volume: 11.7, type: "дизельный", serialNumber: "3Z23B26"),
                new Chassis(wheelsCount: 4, chassisNumber: "UTV257", permissibleLoad: 32000),
                new Transmission(transmissionType: "автоматическая", gearsCount: 12, maker: "Opticruise"));

            Bus Ikarus = new Bus(seatsCount: 80, purpose: "междугородный",
                new Engine(power: 192, volume: 10.3, type: "дизельный", serialNumber: "26RLK9F"),
                new Chassis(wheelsCount: 4, chassisNumber: "PJ087Y", permissibleLoad: 9000),
                new Transmission(transmissionType: "ручная", gearsCount: 5, maker: "Eaton"));

            Scooter Suzuki = new Scooter(weight: 90, startMethod: "кикстартер",
                new Engine(power: 6, volume: 0.5, type: "бензиновый", serialNumber: "9RW89QY"),
                new Chassis(wheelsCount: 2, chassisNumber: "FH3TR9", permissibleLoad: 120),
                new Transmission(transmissionType: "автоматическая", gearsCount: 2, maker: "Allison"));

            Mazda.DisplayInfo();
            Scania.DisplayInfo();
            Ikarus.DisplayInfo();
            Suzuki.DisplayInfo();
        }
    }
}