using Homework_Exceptions.Models;
using Homework_Exceptions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Exceptions.Controllers
{
    internal class CustomerController
    {
        private readonly CustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        public void GetAll()
        {
            foreach(var customer in _customerService.GetAll())
            {
                Console.WriteLine(customer.FullName + "-" + customer.Address + "-" + customer.Age);
            }
        }

        public void GetById()
        {
            try
            {
                var result = _customerService.GetById(5);
                Console.WriteLine(result.FullName + "-" + result.Address + "-" + result.Age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetAllByAge()
        {
            int age = 21;
            foreach(var customer in _customerService.GetAllByAge(age))
            {
                Console.WriteLine(customer.FullName + "-" + customer.Address + "-" + customer.Age);
            }
        }

        public void GetCount()
        {
            Console.WriteLine(_customerService.GetCount());
        }

        public void OrderByAge()
        {
            string order = "Descending";
            foreach (var customer in _customerService.OrderByAge(order))
            {
                Console.WriteLine(customer.FullName + "-" + customer.Address + "-" + customer.Age);
            }
        }
    }

}
