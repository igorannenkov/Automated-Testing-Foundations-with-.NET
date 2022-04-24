using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /// <summary>
    /// Описывает сущность "Двигатель".
    /// </summary>
    class Engine
    {
        public int Power;
        public double Volume;
        public string EngineType;
        public string SerialNumber;

        public Engine(int power, double volume, string engineType, string serialNumber)
        {
            Power = power;
            Volume = volume;
            EngineType = engineType;
            SerialNumber = serialNumber;
        }
    }
}