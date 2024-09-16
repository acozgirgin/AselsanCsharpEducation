using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    
    public class ConvertType
    {


        public void CastTypeMethod()
        {
            //Implicit Cast
            int a = 5;
            double b = a;

            //Explicit Cast
            double c = 5.5;
            int d =(int)c;

            //Convert
            string str = "5";
            int strVal = Convert.ToInt32(str);

            //Parse
            string str2 = "5";
            int strVal2 = int.Parse(str2);

            //TryParse
            string str3 = "5";  
            bool result = int.TryParse(str2, out int strVal3);

            if(result)
            {
                Console.WriteLine("Value converted successfully: " + strVal3);
            }
            else
            {
                Console.WriteLine("Value has not been converted.");
                throw new Exception("Value cannot convert to Int32");
            }

        }

        //Exception fırlatmaktan daha etkili method --> tuple fırlatma
        public (int result, string errorMessage) SumWithErrorMessage(string num1, string num2)
        {

            if (int.TryParse(num1, out int num1Val) is false)
            {
                return (result:0, errorMessage: "First paramater is not valid.");
            }

            if(int.TryParse(num2,out int num2Val) is false)
            {
                return (result: 0, errorMessage: "Second paramater is not valid.");
            }

            return( result: num1Val+num2Val , errorMessage:string.Empty);   


        }

        //Exception fırlatmalı ornek
        public int SumWithException(string num1, string num2)
        {

            if (int.TryParse(num1, out int num1Val) is false)
            {
                throw new Exception("Parameter-1 is not valid.");
            }

            if (int.TryParse(num2, out int num2Val))
            {
                throw new Exception("Parameter-2 is not valid.");
            }

            return (num1Val + num2Val);


        }


    }

}
