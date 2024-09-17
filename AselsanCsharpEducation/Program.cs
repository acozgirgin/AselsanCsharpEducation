

using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace AselsanCsharpEducation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Loop loop = new Loop();

            //loop.DoWhileLoop();

            //Product product = new Product();
            //product.Name = "kalem";
            //product.SetPrice(15.15m);
            //var resultStatic= Product.Calculate(3, 5); // static method direkt class ismi uzerınden cagirabiliriz.

            //var ifElseSwitch = new IfElseSwitchCase();

            ////Tuple return type
            //var( isSuccess, result,errorMessage ) = ifElseSwitch.Calculate2(a: "1" , b: "2");

            ////ServiceResult object return type
            //ServiceResult serviceResult = ifElseSwitch.Calculate3(a: "1" , b: "2");   

            CollectionLesson example = new CollectionLesson();
            example.HashSetExample();

            Console.ReadKey();  

        }
    }
}
