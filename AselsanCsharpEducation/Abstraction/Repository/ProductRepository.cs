using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstraction
{
    internal class ProductRepository : IGenericRepository<Product>
    {

        private static List<Product> _products=new();

        //Static constructor --> uygulama ayaga kalkıdıgında bir kere calisir, ilk obje uretildiginde calisir.
        static ProductRepository()
        {
            _products.Add(new Product(id: 1, name: "Kalem-1", price: 10));
            _products.Add(new Product(id: 1, name: "Kalem-2", price: 20));
            _products.Add(new Product(id: 1, name: "Kalem-3", price: 30));

        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        { 
            _products.Remove(GetById(product.Id));  
            
        }

        public Product GetById(int id)
        {
            //FirstOrDefault() --> listede bulamazsa null doner.
            //First() --> listede bulamazsa exception firlatir.

            //return _products.Where(p => p.Id == id).FirstOrDefault();
            //return _products.FirstOrDefault(p => p.Id == id);

            //SingleOrDefault() --> listede birden fazla ayni id ye sahip item varsa exception atar

            return _products.SingleOrDefault( product => product.Id == id); 
        }
       
        public void Update(Product product)
        {
            //Productı listeden bul
            var productToUpdate = _products.SingleOrDefault( p => product.Id == p.Id );

            //Data access layer check mekanizmalari yazilmaz , Business Logic (Service) katmaninda yazilir.

            //if(productToUpdate is null)
            //{
            //    throw new NullReferenceException("Urun veri tabaninda bulunamadi.");
            //}

            //Listedeki 
            productToUpdate.Name = product.Name;
            productToUpdate.Id = product.Id;
            productToUpdate.Price = product.Price;  
        }

        public List<Product> GetAll() => _products;

    }



}
