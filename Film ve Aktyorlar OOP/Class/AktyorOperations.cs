using Film_ve_Aktyor_OOP.Class;
using Film_ve_Aktyorlar_OOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_ve_Aktyorlar_OOP.Class
{
    internal class AktyorOperations : IGenericOperations<Aktyor>
    {
        private List<Aktyor> _aktyors = new List<Aktyor>();

        public void Add(Aktyor item)
        {
            _aktyors.Add(item);
        }

        public void Delete(Aktyor item)
        {
            _aktyors.Remove(item);
        }

        public IEnumerable<Aktyor> GetAll()
        {
            return _aktyors;
        }
    }
}
