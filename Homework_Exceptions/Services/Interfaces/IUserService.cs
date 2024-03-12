using Homework_Exceptions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Exceptions.Services.Interfaces
{
    internal interface IUserService
    {
        User[] GetAll();
    }
}
