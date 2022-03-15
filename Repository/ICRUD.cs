using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal interface ICRUD<T, K>
    {
        T Create(K obj);
        ICollection<K> GetAll();
        T GetT(K obj);
        T Update(K obj);
        void Delete(T obj);
    }
}
