using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes
{
    /// <summary>
    /// Содержит определения методов FlyTo и GetGlyTime
    /// </summary>
    interface IFlyable
    {
        void FlyTo(Point3D newLocation);
        double GetFlyTime(Point3D newLocation);
    }
}