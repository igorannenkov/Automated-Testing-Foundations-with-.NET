using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class CarInitializationException : ArgumentException
    {
        public int Value;
        public CarInitializationException(string message, int val) : base(message)
        {
            Value = val;
        }
    }
}