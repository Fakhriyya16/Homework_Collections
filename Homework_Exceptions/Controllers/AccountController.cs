using Homework_Exceptions.Helpers.Exceptions;
using Homework_Exceptions.Models;
using Homework_Exceptions.Services;
using Homework_Exceptions.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Exceptions.Controllers
{
    public class AccountController
    {
        private readonly IAccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }
        public void SignIn()
        {
            string email = "email1@gmail.com";
            string password = "password1";
            try
            {
                if(!email.Contains('@'))
                {
                    throw new WrongEmailFormatException("Email Format is wrong");
                }
                bool response = _accountService.SignIn(email, password);

                if (response)
                {
                    Console.WriteLine("Sign In Successfull");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        
    }
}
