using Homework_Exceptions.Helpers.Exceptions;
using Homework_Exceptions.Models;
using Homework_Exceptions.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Exceptions.Services
{
    internal class AccountService : IAccountService
    {
        private readonly IUserService _userService;

        public AccountService()
        {
            _userService = new UserService();
        }
        public bool SignIn(string email, string password)
        {
            User[] users = _userService.GetAll();

            User existUser = users.FirstOrDefault(m=> m.Email == email && m.Password == password);

            return existUser == null ? throw new LoginUnsuccessfull("Email or Password is wrong") : true;
        }
    }
}
