using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class GetAutoByParameterException : Exception
    {
        public string Parameter;
        public GetAutoByParameterException(string message, string parameter) : base(message)
        {
            Parameter = parameter;
        }
    }
}