using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstraction
{
    internal class ProductService 
    {

        //Servis katmanindan donecek resultlar ayrı bir class objesi olmali

        private readonly ProductRepository _productRepository = new();

        public ServiceResult<List<Product>> GetAll()
        {
            var productListWithTax = new List<Product>();

            var products = _productRepository.GetAll();

            foreach (var product in products)
            {
                var productWithTax = new Product( id: product.Id, name: product.Name, price: product.Price*1.20m );
                productListWithTax.Add(productWithTax);
            }

            return ServiceResult <List<Product>>.Success(productListWithTax);
        }

        public Product GetById(int id)
        {

            var hasProducts = _productRepository.GetById(id);   

            if(hasProducts is null)
            {
                ServiceResult<Product>.Fail("Aranilan urun bulunamadi.");
            }


            return new Product(hasProducts.Id, hasProducts.Name, hasProducts.Price*1.20m);

        }
        



    }
}
