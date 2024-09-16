

using System;

namespace AselsanCsharpEducation
{
    internal class Program
    {
        static void Main(string[] args)
        {

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




            Console.ReadKey();



        }
    }
}
