﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration_Lambda
{
    public class User_Registration
    {
        List<User_Registration_Model> registrationModels = new List<User_Registration_Model>();
        public User_Registration()
        {
            User_Registration_Model UserClassModel = new User_Registration_Model();
            registrationModels.Add(UserClassModel);
        }
        public void ValidateFirstName(string firstName)
        {
            if (registrationModels.Any(x => x.firstName.IsMatch(firstName)))
            {
                Console.WriteLine("Its valid.");
            }
            else
            {
                Console.WriteLine("Its not valid.");
            }
        }
        public void ValidateLastName(string lastName)
        {
            if (registrationModels.Any(x => x.lastName.IsMatch(lastName)))
            {
                Console.WriteLine("Its valid.");
            }
            else
            {
                Console.WriteLine("Its not valid.");
            }
        }
        public void ValidateEmail(string email)
        {
            if (registrationModels.Any(x => x.email.IsMatch(email)))
            {
                Console.WriteLine("Its valid.");
            }
            else
            {
                Console.WriteLine("Its not valid.");
            }
        }
        public void ValidatePhoneNumber(string number)
        {
            if (registrationModels.Any(x => x.phoneNumber.IsMatch(number)))
            {
                Console.WriteLine("Its valid.");
            }
            else
            {
                Console.WriteLine("Its not valid.");
            }
        }
        public void ValidatePassword(string password)
        {
            if (registrationModels.Any(x => x.PasswordRuleOne.IsMatch(password)))
            {
                Console.WriteLine("Its valid.");
            }
            else
            {
                Console.WriteLine("Its not valid.");
            }
        }
        public void ValidatePasswordString(string password)
        {
            if (registrationModels.Any(x => x.PasswordRuleTwo.IsMatch(password)))
            {
                Console.WriteLine("Its valid.");
            }
            else
            {
                Console.WriteLine("Its not valid.");
            }
        }
        public void ValidateNumericPassword(string password)
        {
            if (registrationModels.Any(x => x.PasswordRuleThree.IsMatch(password)))
            {
                Console.WriteLine("Its valid.");
            }
            else
            {
                Console.WriteLine("Its not valid.");
            }
        }
        public void ValidateSpclCharPassword(string password)
        {
            if (registrationModels.Any(x => x.PasswordRuleFour.IsMatch(password)))
            {
                Console.WriteLine("Its valid.");
            }
            else
            {
                Console.WriteLine("Its not valid.");
            }
        }
    }
}





