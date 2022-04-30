using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// Описывает сущность "Трансмиссия".
    /// </summary>
    class Transmission
    {
        public string transmissionType;
        public int gearsCount;
        public string maker;

        public Transmission(string transmissionType, int gearsCount, string maker)
        {
            this.transmissionType = transmissionType;
            this.gearsCount = gearsCount;
            this.maker = maker;
        }
    }
}