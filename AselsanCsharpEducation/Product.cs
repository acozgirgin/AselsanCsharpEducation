using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    internal class Product
    {

        //Field --> getter setter yazmadıgınız degiskenler


        //Property 1 
        internal int Id { get; set; }

        //Property 2

        //Getter ve setter methodları asagidaki gibi ozellestirebiliriz.
        private string _name;
        internal string Name 
        {
            get => _name;

            set
            {
                if (value.Length <= 6)
                {
                    throw new Exception(" Name length is less than 6 characters ! ");
                }

                _name = value;
            } 
        
        }

        internal decimal Price { get; set; }


        public Product(int Id, string Name, decimal Price)
        {

            this.Id = Id;
            this.Name = Name;
            this.Price = Price;

        }
    }
}
