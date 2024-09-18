

using AselsanCsharpEducation.Abstraction.InterfaceExample;
using AselsanCsharpEducation.Encapsulation;
using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace AselsanCsharpEducation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            A a = new A(new B());
            a.f();


            List<string> list = new()
            { 
                "a",
                "b",
                "c",
                "d"
            
            };






        }
    }
}
