using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// Описывает сущность "Шасси".
    /// </summary>
    class Chassis
    {
        public int wheelsCount;
        public string chassisNumber;
        public int permissibleLoad;

        public Chassis(int wheelsCount, string chassisNumber, int permissibleLoad)
        {
            this.wheelsCount = wheelsCount;
            this.chassisNumber = chassisNumber;
            this.permissibleLoad = permissibleLoad;
        }
    }
}