using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{

    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    internal class CollectionExample
    {

        public CollectionExample() 
        {
        
            List<Stock> stockList = new List<Stock>
            {
                new Stock(){Id=1, Name="Kalem1"},
                new Stock(){Id=2, Name="Kalem2"},
            };
        

            Dictionary<int, Stock> dictionaryStock = new Dictionary<int, Stock>();

            dictionaryStock.Add(1, new Stock() { Id = 1, Name = "kalem 1" });
            dictionaryStock.Add(1, new Stock() { Id = 1, Name = "kalem 1" });
            dictionaryStock.Add(1, new Stock() { Id = 1, Name = "kalem 1" });





        }



    }
}
