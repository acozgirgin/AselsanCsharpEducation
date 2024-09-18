using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AselsanCsharpEducation.Generic
{



    public class Calculate
    {
        public double AddDoubles(double x, double y) => x + y;

       
    }


    public class Client
    {

        void X()
        {

            Editor editor = new Editor();

            var editorId = editor.Id;   

            Manager manager = new Manager();    

            var managerId = manager.Id; 

        }

    }

    public class PersonBase<T1,T2>
    {
        public T1 Id { get; set; }

        public T2 Age { get; set; }
        public string Name { get; set; }
    }


    public class Editor : PersonBase<int,double>
    {
       

    }

    public class Manager: PersonBase<string,int>
    {


    }



}
