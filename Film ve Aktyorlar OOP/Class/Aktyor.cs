using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_ve_Aktyor_OOP.Class
{
    public class Aktyor
    {  
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string FullName()
            {
                return $"{FirstName} {LastName}";
            }
    }
}
