using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// Описывает сущность "Двигатель".
    /// </summary>
    class Engine
    {
        public int power;
        public double volume;
        public string type;
        public string serialNumber;

        public Engine(int power, double volume, string type, string serialNumber)
        {
            this.power = power;
            this.volume = volume;
            this.type = type;
            this.serialNumber = serialNumber;
        }
    }
}