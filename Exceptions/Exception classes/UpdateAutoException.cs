using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class UpdateAutoException : Exception
    {
        public UpdateAutoException(string message) : base(message) { }
    }
}