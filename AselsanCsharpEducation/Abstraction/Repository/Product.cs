using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstraction
{

    //Primary constructor --> olarak ekliyebiliriz.
    internal class Product(int id, string name, decimal price)
    {
        public int Id { get; set; } = id;

        public string Name { get; set; } = name;

        public decimal Price { get; set; } = price;

    } 
}
