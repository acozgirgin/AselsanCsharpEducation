using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{

    public class Pen
    {
        // Acces modifiers --> 
        // public 
        // internal --> sadece aynı assembly (proje) içerisinde  eriselibilir 

        internal string Color { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        //Constructors
        public Pen()
        {
        
        
        }

        public Pen(int width, int height)      
        {
            this.Width = width; 
            this.Height = height;
        }

        public Pen(string color, string brand, decimal price, int height, int width)
        {
            this.Color = color;
            this.Brand = brand;
            this.Price = price;
            this.Height = height;
            this.Width = width;
        }

        //Methods
        internal void WriteBrandName() => Console.WriteLine($"Brand name: {Brand}");
     
        internal void WriteName(string nameOfProuct) => Console.WriteLine(nameOfProuct);

        //TUPLE TYPES
        public Tuple<string, string> ReturnTuple() 
        {
            return new Tuple<string, string>(this.Color, this.Brand); 
        }   

        internal (string color, string brand) ReturnTuple2()
        {
            return ("red" , "faber castell ");
        }


        //Out keyword
        public decimal CalculateKDV(decimal price, out int tax)
        {
            //KDV li dönen deger
            tax = 18;
            return price * 1.18m;
        }


    }


}
