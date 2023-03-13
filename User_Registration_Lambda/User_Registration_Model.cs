using System;
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
    }
}
