using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class, new()
    {
        void TAdd(T t);

        void TUpdate(T t);

        void TDelete(T t);

        List<T> GetList();

        T GetById(int id);
    }
}
