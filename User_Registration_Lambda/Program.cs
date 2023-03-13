﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration_Lambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            User_Registration userRegistration = new User_Registration();
            userRegistration.ValidateFirstName("Tanvi");
            userRegistration.ValidateLastName("Kapoor");
            userRegistration.ValidateEmail("shindetanvi0203@gmail.com");
            userRegistration.ValidatePhoneNumber("91 8007622250");
            userRegistration.ValidatePassword("Password");
            userRegistration.ValidatePasswordString("Tanvi123");
            userRegistration.ValidateNumericPassword("Tanu0203");
            Console.ReadLine();
        }
    }
    }

