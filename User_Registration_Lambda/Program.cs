using System;
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
            Console.ReadLine();
        }
    }
    }

