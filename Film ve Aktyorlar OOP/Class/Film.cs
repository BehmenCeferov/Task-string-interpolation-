using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_ve_Aktyorlar_OOP.Class
{
    public class Film
    {
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        public decimal ImdbPoint { get; set; }
        public DateTime releaseDate { get; set; }
        public void RateMovie()
        {
            decimal imdbPoint = ImdbPoint;
            if (imdbPoint >= (decimal)2 && imdbPoint <= (decimal)5)
                Console.WriteLine("Pis");
            else if (imdbPoint is > (decimal)5 and <= (decimal)7.5)
                Console.WriteLine("Yaxşı");
            else if (imdbPoint is > (decimal)7.5 and <= (decimal)10)
                Console.WriteLine("Əla");
        }
    }
}
