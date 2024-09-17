using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    public class Loop
    {


        public void ForLoop()
        {

            for (int i = 0; i < 30; i += 2)
            {
                
                if(i==18) 
                    break;

                Console.WriteLine($"for loop {i}");

            }


        }

        public void WhileLoop()
        {

            var i = 0;
            while (i < 20)
            {
                Console.WriteLine($"while loop count {i++}");
            }

        }

        public void DoWhileLoop()
        {
            var i = 0;
            do
            {
                Console.WriteLine($"do-while loop count {i++}");

            } while (i < 20);
        }
    }
}
