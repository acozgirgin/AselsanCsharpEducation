using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Encapsulation
{




    //Classic -> Encapsulatipn
    public class Person
    {

        public int Id { get; set; }

        private string _name;

        public string Name 
        {
            get => _name;

            set
            {
              
                if (value.Length > 6)
                {
                    throw new Exception("ERROR: Name length is not valid.");
                }

                _name = value;  
            }

        }

        public int Age { get; set; }




        //Classic yontem
        //public void SetName(string name)
        //{
        //    //Control business --> name set etme dis dunyaya kapatildi.

        //    if(name.Length > 6)
        //    {
        //        throw new Exception("ERROR: Name length is not valid.");
        //    }

        //    Name = name;
        //}

        //public string GetName() => Name;

    }





    //Nesneyi kullanacak taraf
    public class PersonClient
    {


        public PersonClient()
        {
            
            var person = new Person()
            {

                Id=1,
                Age = 26                
            };


            person.Name = "can";

            Console.WriteLine(person.Name);


        }

    }

}