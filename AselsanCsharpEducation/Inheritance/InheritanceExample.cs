using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Inheritance
{

    public class Client
    {

        public void X()
        {
            var person = new Person();

            var manager = new Manager();
        }


    }

    public class Person
    {
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        private string _tcNo;

        protected void PrintPerson() => Console.WriteLine($"Person name: {Name}");
    }


    //Depth + 1 

    public class Editor : Person
    {
        //Miras alınan sınıfın constructorıda calıscak --> Implement etmek gerekiyor.
        public Editor(int id, string name) : base(id, name) { }
     
        public decimal Salary { get; set; }
    }

    //Depth + 1 
    public class Manager : Editor
    {
        //Miras alınan sınıfın constructorıda calıscak --> Implement etmek gerekiyor.
        public Manager(int id, string name) : base(id, name) { }
        
    }






}
