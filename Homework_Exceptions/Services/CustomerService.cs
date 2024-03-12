using Homework_Exceptions.Datas;
using Homework_Exceptions.Models;
using Homework_Exceptions.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Exceptions.Services
{
    internal class CustomerService : ICustomerService
    {
        public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }
        public List<Customer> GetAllByAge(int? age)
        {
            return age == null ? throw new ArgumentNullException() : AppDbContext.customers.Where(m=> m.Age == age).ToList();
        }

        public Customer GetById(int? id)
        {
            return id == null ? throw new ArgumentNullException() : AppDbContext.customers.FirstOrDefault(m => m.Id == id); 
        }
        public int GetCount()
        {
            return AppDbContext.customers.Count;
        }
        public List<Customer> OrderByAge(string order)
        {
            switch (order)
            {
                case "Ascending":
                   return AppDbContext.customers.OrderBy(customer => customer.Age).ToList();
                case "Descending":
                    return AppDbContext.customers.OrderByDescending(customer => customer.Age).ToList();
                default:
                    throw new Exception("Wrong format for order");
            }
        }
    }
}
