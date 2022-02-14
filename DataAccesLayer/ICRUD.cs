using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public  interface ICRUD<T>
    {
         void Create(T obj);
         ICollection<T> GetAll();
         T Update(T obj);
         void Delete(T obj);

    }
}
