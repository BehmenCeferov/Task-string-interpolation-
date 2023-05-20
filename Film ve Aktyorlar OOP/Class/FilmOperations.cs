using Film_ve_Aktyorlar_OOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_ve_Aktyorlar_OOP.Class
{
    internal class FilmOperations : IGenericOperations<Film>
    {
        private List<Film> _films = new List<Film>();

        public void Add(Film item)
        {
            _films.Add(item);
        }

        public void Delete(Film item)
        {
            _films.Remove(item);
        }

        public IEnumerable<Film> GetAll()
        {
            return _films;
        }
    }
}
