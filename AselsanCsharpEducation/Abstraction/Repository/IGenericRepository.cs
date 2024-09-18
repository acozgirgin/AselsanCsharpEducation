using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstraction
{
    public interface IGenericRepository<T>
    {

        //Contract-1 olacak sadece
        List<T> GetAll();

        T GetById(int id);

        void Add(T item);

        void Update(T item);

        void Delete(T item);

    }
}
