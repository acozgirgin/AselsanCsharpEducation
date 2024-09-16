

using System;
using System.Collections.Generic;

namespace AselsanCsharpEducation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //ConvertType

            ConvertType convertType = new ConvertType();
            var (result , errorMessage) = convertType.SumWithErrorMessage("1", "2");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Error message: {errorMessage}");


            //Deger atanmayan degiskenler
            int NumberAsEmpty;

            //VALUE TYPES --> Tam Sayilar
            int MyNumber = 10;
            byte MyByte = 0x31;
            short MyShort = 200;
            long MyLong = 100;
            
            //VALUE TYPES --> Ondalikli Degerler
            float MyFloat = 1.50f;
            double numberDouble = 10.00;
            decimal numberDecimal = 20.00m;
            DateTime dateTime = DateTime.Now;

            //Console Yazdirma Ornekleri
            Console.WriteLine($"Gun: {dateTime.Day}, Ay: {dateTime.Month} Yıl: {dateTime.Year}");
            Console.WriteLine($"Saat:{dateTime.TimeOfDay}");

            //Place holder kullanimi
            string rowProductName = "name:{0}";
            Console.WriteLine(rowProductName, MyNumber);


            ////Git change gorunecek mi --> Pushlanacak
            //Random rnd = new Random();
            //var x = new List<int>(256);
            //for (int i = 0; i < x.Capacity; ++i) { x.Add(rnd.Next(100)); }
            //foreach (int i in x) Console.WriteLine(i);


            //Best practice
            Pen pen = new Pen
            {
                Brand = "Faber Castel",
                Width = 5,
                Height = 15,
                Color = "Red",
                Price = 20.0m
            };


            pen.WriteBrandName();
            int taxValue;
            decimal KdvPrice = pen.CalculateKDV(100, out taxValue);
            Console.WriteLine($" KDV li deger: {KdvPrice} KDV Vergi orani: {taxValue}");

            //Tuples deneme
            Tuple<string,string> Tuple1 = pen.ReturnTuple();
            Console.WriteLine("Tuple Veri 1:" +  Tuple1.Item1);
            Console.WriteLine("Tuple Veri 2:" +  Tuple1.Item2);

            var Tupl2 = pen.ReturnTuple2();                            
            var (color,brand) =pen.ReturnTuple2();




            var p1 = new Product(Id: 1, Name: "abidin can ozgirgin", Price: 100.08m);




            Console.ReadKey();
        }
    }
}
