using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal interface ICRUD<T>
    {
        T Create(T obj);
        ICollection<T> GetAll();
        T GetT(object obj);
        T Update(T obj);
        void Delete(T obj);
    }
}
