using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Exceptions.Models
{
    internal class Customer : BaseEntity
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
