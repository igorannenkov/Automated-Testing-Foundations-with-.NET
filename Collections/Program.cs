using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections
{
    class Program
    {
        public static List<Transport> InitVehicles()
        {
            Truck Scania = new Truck(truckType: "Тягач", cabinType: "Бескапотная",
                new Engine(power: 420, volume: 11.7, engineType: "Дизельный", serialNumber: "3Z23B26"),
                new Chassis(wheelsCount: 4, chassisNumber: "UTV257", permissibleLoad: 32000),
                new Transmission(transmissionType: "Автоматическая", gearsCount: 12, maker: "Opticruise"));
            Truck Ural = new Truck("Тягач", "Бескапотная",
                new Engine(600, 12.0, "Дизельный", "WZ89R12"),
                new Chassis(6, "TTI683", 40000),
                new Transmission("Ручная", 10, "TMZ"));
            Truck Volvo = new Truck("Тягач", "Капотная",
                new Engine(350, 9.6, "Дизельный", "PY94624"),
                new Chassis(4, "EW86GH", 20000),
                new Transmission("Автоматическая", 10, "Eaton"));
            Truck Iveco = new Truck("Фургон", "Полукапотная",
                new Engine(320, 8, "Дизельный", "LK81178"),
                new Chassis(4, "IE9822C", 8000),
                new Transmission("Автоматическая", 8, "Jatco"));
            Truck Hyundai = new Truck("Фургон", "Бескапотная",
                new Engine(80, 2.5, "Дизельный", "PKRT221"),
                new Chassis(6, "HT89FDS", 950),
                new Transmission("Автоматическая", 5, "Allison"));
            Truck Mercedes = new Truck("Фургон", "Полукапотная",
                new Engine(90, 2.5, "Бензиновый", "YU7WRR2"),
                new Chassis(5, "KJJ111IO", 2800),
                new Transmission("Ручная", 5, "Eaton"));
            Truck KIA = new Truck("Фургон", "Бескапотная",
                new Engine(80, 3.0, "Бензиновый", "SSW8299"),
                new Chassis(5, "MB2KKKQ", 3000),
                new Transmission("Ручная", 5, "Allison"));
            Truck UAZ = new Truck("Фургон", "Бескапотная",
                new Engine(76, 2.5, "Бензиновый", "UAZ452D"),
                new Chassis(5, "UAZRT7822", 1225),
                new Transmission("Ручная", 5, "UAZ"));
            Truck Kamaz = new Truck("Тягач", "Бескапотная",
                new Engine(440, 10, "Дизельный", "KAMZ218"),
                new Chassis(6, "KMZ8YTW2", 20000),
                new Transmission("Ручная", 10, "Kamaz"));
            Truck Aumark = new Truck("Фургон", "Бескапотная",
                new Engine(141, 5, "Дизельный", "FT342Y"),
                new Chassis(6, "KMZ8YTW2", 14000),
                new Transmission("Ручная", 10, "FTRO433"));

            Car Mazda = new Car(cruisingSpeed: 90, clearance: 175,
                new Engine(power: 90, volume: 1.6, engineType: "Бензиновый", serialNumber: "1KLBN52"),
                new Chassis(wheelsCount: 4, chassisNumber: "WXM178", permissibleLoad: 500),
                new Transmission(transmissionType: "Автоматическая", gearsCount: 5, maker: "Jatco"));
            Car Porshe = new Car(100, 150,
                new Engine(120, 3.5, "Бензиновый", "GGQ212"),
                new Chassis(4, "XLW982", 550),
                new Transmission("Автоматическая", 6, "Allison"));
            Car Volga = new Car(90, 200,
                new Engine(95, 1.8, "Бензиновый", "FW2341"),
                new Chassis(4, "PX9323", 550),
                new Transmission("Ручная", 5, "Volga"));
            Car Ford = new Car(100, 170,
                new Engine(95, 1.8, "Бензиновый", "GP3221"),
                new Chassis(4, "JJ2121", 500),
                new Transmission("Автоматическая", 5, "Eaton"));
            Car Lada = new Car(90, 180,
                new Engine(85, 1.4, "Бензиновый", "KD3288"),
                new Chassis(4, "YT0982", 400),
                new Transmission("Ручная", 5, "Lada"));
            Car Niva = new Car(90, 200,
                new Engine(100, 2.0, "Бензиновый", "II81002"),
                new Chassis(4, "OP21WC", 450),
                new Transmission("Ручная", 6, "Kama"));
            Car Opel = new Car(90, 170,
                new Engine(100, 1.8, "Бензиновый", "DDK9166"),
                new Chassis(4, "OPRT211", 400),
                new Transmission("Автоматическая", 6, "Eaton"));
            Car BMW = new Car(110, 150,
                new Engine(140, 3.0, "Дизельный", "MBB3099"),
                new Chassis(4, "BM323RR", 550),
                new Transmission("Автоматическая", 6, "Allison"));
            Car Audi = new Car(110, 160,
                new Engine(160, 3.5, "Бензиновый", "AU7722YW"),
                new Chassis(4, "AU12II0", 600),
                new Transmission("Автоматическая", 6, "Eaton"));
            Car Toyota = new Car(110, 150,
                new Engine(200, 3.5, "Бензиновый", "TY7772"),
                new Chassis(4, "TY712100", 550),
                new Transmission("Автоматическая", 6, "Allison"));

            Bus Ikarus = new Bus(seatsCount: 80, purpose: "Междугородный",
                new Engine(power: 192, volume: 10.3, engineType: "Дизельный", serialNumber: "26RLK9F"),
                new Chassis(wheelsCount: 4, chassisNumber: "PJ087Y", permissibleLoad: 9000),
                new Transmission(transmissionType: "Ручная", gearsCount: 5, maker: "Eaton"));
            Bus Volzganin = new Bus(120, "Городской",
                new Engine(260, 14.0, "Дизельный", "VLG32UI"),
                new Chassis(4, "VL2187", 10000),
                new Transmission("Ручная", 6, "Vaz"));
            Bus Paz = new Bus(45, "Пригородный",
                new Engine(170, 4.4, "Дизельный", "PZ54932"),
                new Chassis(4, "PZ2342T", 8000),
                new Transmission("Ручная", 6, "Paz"));
            Bus Liaz = new Bus(104, "Пригородный",
                new Engine(238, 6.4, "Дизельный", "LI325Y3"),
                new Chassis(4, "LI832UU", 6500),
                new Transmission("Автоматическая", 6, "Allison"));
            Bus Skoda = new Bus(120, "Междугородный",
                new Engine(250, 7.2, "Дизельный", "SK727T"),
                new Chassis(4, "SKD36H", 6000),
                new Transmission("Автоматическая", 6, "Eaton"));
            Bus MAN = new Bus(90, "Междугородный",
                new Engine(190, 4.8, "Дизельный", "MN7710Y"),
                new Chassis(4, "MNJ306", 5000),
                new Transmission("Ручная", 6, "Allison"));
            Bus KingLong = new Bus(110, "Междугородный",
                new Engine(200, 5.5, "Дизельный", "KL72BBN"),
                new Chassis(6, "KLOQ12", 5000),
                new Transmission("Автоматическая", 6, "KingLong"));
            Bus Volgabus = new Bus(110, "Городской",
                new Engine(190, 4.8, "Дизельный", "СКННЕ62"),
                new Chassis(6, "CKW8232", 5000),
                new Transmission("Автоматическая", 7, "Kama"));
            Bus Otokar = new Bus(90, "Междугородный",
                new Engine(200, 5.2, "Дизельный", "СКННЕ62"),
                new Chassis(6, "OT5621", 5200),
                new Transmission("Ручная", 6, "Eaton"));
            Bus EvoBus = new Bus(120, "Городской",
                new Engine(200, 5.2, "Дизельный", "EV5542"),
                new Chassis(6, "EV719I", 5400),
                new Transmission("Автоматическая", 6, "Eaton"));

            Scooter Suzuki = new Scooter(weight: 90, startMethod: "Кикстартер",
                new Engine(power: 6, volume: 0.5, engineType: "Бензиновый", serialNumber: "9RW89QY"),
                new Chassis(wheelsCount: 2, chassisNumber: "FH3TR9", permissibleLoad: 120),
                new Transmission(transmissionType: "Автоматическая", gearsCount: 2, maker: "Allison"));
            Scooter Tourist = new Scooter(100, "Кикстартер",
                new Engine(6, 0.6, "Бензиновый", "TR27289"),
                new Chassis(2, "TRS2398", 150),
                new Transmission("Автоматическая", 3, "Eaton"));
            Scooter Electron = new Scooter(80, "Электростартер",
                new Engine(5, 0.5, "Бензиновый", "EL88321"),
                new Chassis(2, "EL0092G", 110),
                new Transmission("Ручная", 2, "Electron"));
            Scooter Baltmotors = new Scooter(130, "Кикстартер",
                new Engine(7, 0.6, "Бензиновый", "BM8230X"),
                new Chassis(2, "BLT1102", 150),
                new Transmission("Ручная", 2, "Allison"));
            Scooter Adly = new Scooter(110, "Электростартер",
                new Engine(5, 0.6, "Бензиновый", "UYF78100"),
                new Chassis(2, "IWW8902", 150),
                new Transmission("Автоматическая", 3, "Eaton"));
            Scooter Beta = new Scooter(100, "Кикстартер",
                new Engine(5, 0.4, "Бензиновый", "BT28299"),
                new Chassis(2, "BTN3222", 150),
                new Transmission("Ручная", 3, "Auris"));
            Scooter Forza = new Scooter(90, "Кикстартер",
                new Engine(5, 0.5, "Бензиновый", "FR000124"),
                new Chassis(2, "FZ91231", 100),
                new Transmission("Автоматическая", 2, "Allison"));
            Scooter Garelli = new Scooter(100, "Кикстартер",
                new Engine(5, 0.4, "Бензиновый", "GRL9391"),
                new Chassis(2, "GRY8282", 130),
                new Transmission("Ручная", 3, "Auris"));
            Scooter Kawasaki = new Scooter(120, "Электростартер",
                new Engine(5, 0.6, "Бензиновый", "KW299111"),
                new Chassis(2, "KWS92300", 130),
                new Transmission("Автоматическая", 2, "Kawasaki"));
            Scooter Yamaha = new Scooter(130, "Кикстартер",
                new Engine(7, 0.7, "Бензиновый", "YMH990YE"),
                new Chassis(2, "YM89117", 140),
                new Transmission("Ручная", 2, "Yamaha"));

            return new List<Transport>()
            {
                Scania, Ural, Volvo, Iveco, Hyundai, Mercedes, KIA, UAZ, Kamaz, Aumark,
                Mazda, Porshe, Volga, Ford, Lada, Niva, Opel, BMW, Audi, Toyota,
                Ikarus, Volzganin, Paz, Liaz, Skoda, MAN, KingLong, Volgabus, Otokar, EvoBus,
                Suzuki, Tourist, Electron, Baltmotors, Adly, Beta, Forza, Garelli, Kawasaki, Yamaha
            };
        }

        static void Main(string[] args)
        {
            List<Transport> Vehicles = InitVehicles(); //заполняем коллекцию транспортных средств

            //Полная информация о всех транспортных средствах, обьем двигателя которых больше чем 1.5 литров
            var bigEnginesQuery = from transport in Vehicles
                                  where transport.Engine.Volume > 1.5
                                  select transport;

            XDocument xmlDocument = new XDocument();
            XElement xBigEnginesTransport = new XElement("BigEngines");

            foreach (Transport t in bigEnginesQuery)
            {
                XElement xTransport = new XElement("Transport");
                XAttribute xCategory = new XAttribute("category", t.GetType().Name);

                XElement xEngine = new XElement("Engine");
                XElement xPower = new XElement("Power", t.Engine.Power);
                XElement xVolume = new XElement("Volume", t.Engine.Volume);
                XElement xEngType = new XElement("Type", t.Engine.EngineType);
                XElement xSerNumber = new XElement("SerialNo", t.Engine.SerialNumber);
                xEngine.Add(xPower, xVolume, xEngType, xSerNumber);

                XElement xChassis = new XElement("Chassis");
                XElement xWheelsCount = new XElement("WheelsCount", t.Chassis.WheelsCount);
                XElement xChassisNo = new XElement("ChassisNo", t.Chassis.ChassisNumber);
                XElement xPermLoad = new XElement("PermissibleLoad", t.Chassis.PermissibleLoad);
                xChassis.Add(xWheelsCount, xChassisNo, xPermLoad);

                XElement xTransmission = new XElement("Transmission");
                XElement xTrType = new XElement("TransmissionType", t.Transmission.TransmissionType);
                XElement xGearsCount = new XElement("GearsCount", t.Transmission.GearsCount);
                XElement xMaker = new XElement("Maker", t.Transmission.Maker);
                xTransmission.Add(xTrType, xGearsCount, xMaker);

                //добавляем доп. инфо, у каждого типа транспортного средства оно свое
                XElement xOther = new XElement("Other");

                switch (t.GetType().Name)
                {
                    case "Bus":
                        Bus bus = (Bus)t;
                        XElement xSeatsCount = new XElement("SeatsCount", bus.SeatsCount);
                        XElement xPurpose = new XElement("Purpose", bus.Purpose);
                        xOther.Add(xSeatsCount, xPurpose);
                        break;
                    case "Truck":
                        Truck truck = (Truck)t;
                        XElement xTruckType = new XElement("TruckType", truck.TruckType);
                        XElement xCabinType = new XElement("CabinType", truck.CabinType);
                        xOther.Add(xTruckType, xCabinType);
                        break;
                    case "Car":
                        Car car = (Car)t;
                        XElement xCruisingSpeed = new XElement("CruisingSpeed", car.CruisingSpeed);
                        XElement xClearance = new XElement("Clearance", car.Clearance);
                        xOther.Add(xCruisingSpeed, xClearance);
                        break;
                    case "Scooter":
                        Scooter scooter = (Scooter)t;
                        XElement xWeight = new XElement("Weight", scooter.Weight);
                        XElement xStartMethod = new XElement("StartMethod", scooter.StartMethod);
                        xOther.Add(xWeight, xStartMethod);
                        break;
                }

                xTransport.Add(xCategory, xEngine, xChassis, xTransmission, xOther);
                xBigEnginesTransport.Add(xTransport);
            }

            xmlDocument.Add(xBigEnginesTransport);
            xmlDocument.Save("BigEnginesTransport.xml");
            Console.WriteLine("1. Полная информация о всех транспортных средствах, обьем двигателя которых больше чем 1.5 литров");
            Console.WriteLine("Файл BigEnginesTransport.xml");
            Console.WriteLine();

            //Тип двигателя, серийный номер и его мощность для всех автобусов и грузовиков
            var busesAndTrucksQuery = from transport in Vehicles
                                      where transport.GetType().Equals(typeof(Bus)) || transport.GetType().Equals(typeof(Truck))
                                      group transport by transport.GetType().Name;

            xmlDocument = new XDocument();
            XElement xEngines = new XElement("BusesAndTrucksEngines");

            foreach (var transportGroup in busesAndTrucksQuery)
            {
                XElement xTransport = new XElement("Transport");
                XAttribute xCategory = new XAttribute("category", transportGroup.Key);
                xTransport.Add(xCategory);

                foreach (var vehicle in transportGroup)
                {
                    XElement xEngine = new XElement("Engine");
                    XElement xEngineType = new XElement("Type", vehicle.Engine.EngineType);
                    XElement xEngineSerial = new XElement("SerialNo", vehicle.Engine.SerialNumber);
                    XElement xEnginePower = new XElement("Power", vehicle.Engine.Power);
                    xEngine.Add(xEngineType, xEngineSerial, xEnginePower);
                    xTransport.Add(xEngine);
                }

                xEngines.Add(xTransport);
            }

            xmlDocument.Add(xEngines);
            xmlDocument.Save("BusesAndTrucks.xml");

            Console.WriteLine("2. Тип двигателя, серийный номер и его мощность для всех автобусов и грузовиков");
            Console.WriteLine("Файл BusesAndTrucks.xml");
            Console.WriteLine();

            //Полная информация о всех транспортных средствах, сгруппированная по типу трансмиссии
            var transmissionGroupedQuery = from transport in Vehicles
                                           group transport by transport.Transmission.TransmissionType;

            xmlDocument = new XDocument();
            XElement xTransmissionGroupedTransport = new XElement("TransmissionGroupedTransport");

            foreach (var transmissionGroup in transmissionGroupedQuery)
            {
                XElement xTransmissions = new XElement("Transmission");
                XAttribute xTransmissionType = new XAttribute("type", transmissionGroup.Key);
                xTransmissions.Add(xTransmissionType);

                foreach (var vehicle in transmissionGroup)
                {
                    XElement xTransport = new XElement("Transport");
                    XAttribute xCategory = new XAttribute("category", vehicle.GetType().Name);

                    XElement xEngine = new XElement("Engine");
                    XElement xPower = new XElement("Power", vehicle.Engine.Power);
                    XElement xVolume = new XElement("Volume", vehicle.Engine.Volume);
                    XElement xEngType = new XElement("Type", vehicle.Engine.EngineType);
                    XElement xSerNumber = new XElement("SerialNo", vehicle.Engine.SerialNumber);
                    xEngine.Add(xPower, xVolume, xEngType, xSerNumber);

                    XElement xChassis = new XElement("Chassis");
                    XElement xWheelsCount = new XElement("WheelsCount", vehicle.Chassis.WheelsCount);
                    XElement xChassisNo = new XElement("ChassisNo", vehicle.Chassis.ChassisNumber);
                    XElement xPermLoad = new XElement("PermissibleLoad", vehicle.Chassis.PermissibleLoad);
                    xChassis.Add(xWheelsCount, xChassisNo, xPermLoad);

                    XElement xTransmission = new XElement("Transmission");
                    XElement xTrType = new XElement("TransmissionType", vehicle.Transmission.TransmissionType);
                    XElement xGearsCount = new XElement("GearsCount", vehicle.Transmission.GearsCount);
                    XElement xMaker = new XElement("Maker", vehicle.Transmission.Maker);
                    xTransmission.Add(xTrType, xGearsCount, xMaker);

                    XElement xOther = new XElement("Other"); //добавляем доп. инфо, у каждого типа транспортного средства оно свое
                    switch (vehicle.GetType().Name)
                    {
                        case "Bus":
                            Bus bus = (Bus)vehicle;
                            XElement xSeatsCount = new XElement("SeatsCount", bus.SeatsCount);
                            XElement xPurpose = new XElement("Purpose", bus.Purpose);
                            xOther.Add(xSeatsCount, xPurpose);
                            break;
                        case "Truck":
                            Truck truck = (Truck)vehicle;
                            XElement xTruckType = new XElement("TruckType", truck.TruckType);
                            XElement xCabinType = new XElement("CabinType", truck.CabinType);
                            xOther.Add(xTruckType, xCabinType);
                            break;
                        case "Car":
                            Car car = (Car)vehicle;
                            XElement xCruisingSpeed = new XElement("CruisingSpeed", car.CruisingSpeed);
                            XElement xClearance = new XElement("Clearance", car.Clearance);
                            xOther.Add(xCruisingSpeed, xClearance);
                            break;
                        case "Scooter":
                            Scooter scooter = (Scooter)vehicle;
                            XElement xWeight = new XElement("Weight", scooter.Weight);
                            XElement xStartMethod = new XElement("StartMethod", scooter.StartMethod);
                            xOther.Add(xWeight, xStartMethod);
                            break;
                    }

                    xTransport.Add(xCategory, xEngine, xChassis, xTransmission, xOther);
                    xTransmissions.Add(xTransport);
                }

                xTransmissionGroupedTransport.Add(xTransmissions);
            }

            xmlDocument.Add(xTransmissionGroupedTransport);
            xmlDocument.Save("TransmissionGroupedTransport.xml");

            Console.WriteLine("3. Полная информация о всех транспортных средствах, сгруппированных по типу трансмиссии");
            Console.WriteLine("Файл TransmissionGroupedTransport.xml");
        }
    }
}