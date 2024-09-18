using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstraction
{

    //contract
    internal interface IProductRepository
    {
        //Contract-1 olacak sadece
        List<Product> GetAll();

        Product GetById(int id);

        void Add(Product product);

        void Update(Product product);

        void Delete(Product product);


    }
}
