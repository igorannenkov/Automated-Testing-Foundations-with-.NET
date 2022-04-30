using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /// <summary>
    /// Описывает сущность "Трансмиссия".
    /// </summary>
    class Transmission
    {
        public string TransmissionType;
        public int GearsCount;
        public string Maker;

        public Transmission(string transmissionType, int gearsCount, string maker)
        {
            TransmissionType = transmissionType;
            GearsCount = gearsCount;
            Maker = maker;
        }
    }
}