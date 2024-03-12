using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Exceptions.Helpers.Exceptions
{
    public class LoginUnsuccessfull : Exception
    {
        public LoginUnsuccessfull(string message):base(message)
        {
            
        }
    }
}
