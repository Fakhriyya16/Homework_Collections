using Homework_Exceptions.Models;
using Homework_Exceptions.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Exceptions.Services
{
    public class UserService : IUserService
    {
        public User[] GetAll()
        {
            User user1 = new()
            {
                Id = 1,
                Email = "email1@gmail.com",
                Password = "password1"
            };
            User user2 = new()
            {
                Id = 2,
                Email = "email2@gmail.com",
                Password = "password2"
            };
            User user3 = new()
            {
                Id = 3,
                Email = "email3@gmail.com",
                Password = "password3"
            };

            User[] users = { user1, user2, user3 };
            return users;
        }
    }
}
