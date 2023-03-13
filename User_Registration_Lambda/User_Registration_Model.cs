﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Lambda
{
    public class User_Registration_Model
    {
        public Regex firstName = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex lastName = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex email = new Regex(@"^[a-zA-Z]{3,}[.+-_]{0,1}[0-9]{0,}[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$");
    }
}

