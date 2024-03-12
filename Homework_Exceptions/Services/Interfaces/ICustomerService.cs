using Homework_Exceptions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Exceptions.Services.Interfaces
{
    internal interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int? id);
        List<Customer> GetAllByAge(int? age);
        int GetCount();
        List<Customer> OrderByAge(string order);

    }
}
