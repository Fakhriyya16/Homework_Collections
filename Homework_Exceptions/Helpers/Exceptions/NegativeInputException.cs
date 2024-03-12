using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Exceptions.Helpers.Exceptions
{
    internal class NegativeInputException : Exception
    {
        public NegativeInputException(string message): base(message)
        {
            
        }
    }
}
