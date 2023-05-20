using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_ve_Aktyorlar_OOP.Interface
{
    internal interface IGenericOperations<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
        void Delete(T item);
    }
}
