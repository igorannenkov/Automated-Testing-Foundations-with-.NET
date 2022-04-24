using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    /// <summary>
    /// Описывает сущность "Шасси".
    /// </summary>
    class Chassis
    {
        public int WheelsCount;
        public string ChassisNumber;
        public int PermissibleLoad;

        public Chassis(int wheelsCount, string chassisNumber, int permissibleLoad)
        {
            WheelsCount = wheelsCount;
            ChassisNumber = chassisNumber;
            PermissibleLoad = permissibleLoad;
        }
    }
}