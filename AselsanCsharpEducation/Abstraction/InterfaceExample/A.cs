using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstraction.InterfaceExample
{
    internal class A
    {

        private IDummy _idummy;


        public A(IDummy dummy)
        {
             _idummy = dummy;   
        }

        internal void f()
        {

            //Tightly-coupled code ornegi

            // B classında yapılan degisikler --> A classindan probleme sebeb olabilir Add methoduna 3. parametre getirilebilir.

            _idummy.GetName();  




        }



    }
}
