using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    internal class Product
    {
        public string Name { get; set; } // instance property

        public decimal Price { get; private set; } // kullanıcının price set etmesini istemiyorum. -> private set

        public static int Tax { get; set; } = 20; // static field

        

        //Instance constructor
        //Her instance alindiginda calisir.

        public Product()
        {
            
        }

        //Productstan ilk nese ornegi alindiginda calisir -> ( bir kere )
        //Static constructor
        static Product()
        {
            //Uygulama ilk calistigi anda calismasini istedigimiz constructor.
            //Ilk alinan ornekten sonra calismaz !!
        }

        public void SetPrice(decimal price) => this.Price = price;  

        //Static method
        public static int Calculate(int a, int b)
        {
            return a + b;
        }




    }
}
