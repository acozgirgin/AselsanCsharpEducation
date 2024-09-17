using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    internal partial class IfElseSwitchCase
    {

        public void IfElse(int a,  int b)
        {

            //Suslu parentez klasik if else
            //if (a > b)
            //{
            //    Console.WriteLine("a is greater than b.");
            //}
            //else
            //{
            //    Console.WriteLine("b is greater than a.");
            //}

            //Tek satir if else suslu paranteze gerek yok
            //if(a>b)
            //    Console.WriteLine("a is greater than b.");
            //else
            //    Console.WriteLine("b is greater than a.");


            //(?:) operator
            // return (a>b) ? " a is greater than b " : " b is greater than a";




        }

        //Clean code olmayan version
        public void IfElseBad(int a)
        {
            if(a<10)
            {

            }

            else if(a<50)
            {


            }

            else if(a<100)
            {


            }
        }

        //Clean code
        public string IfElseGood(int a)
        {

            if (a < 10)
            {
                return "a is less than 10";
            }

            if (a < 50)
            {
                return "a is less than 50";
            }

            if (a < 100)
            {
                return "a is less than 100";
            }

            return "a is greater than 100";

        }

        //Clean code
        public void IfElseGood(int a, int b)
        {

            if (a==b)
            {
                Console.WriteLine("A is equal B.");
                return;
            }

            if (a>b)
            {
                Console.WriteLine("A is greater than B.");
                return;
            }

            if (b>a)
            {
                Console.WriteLine("B is greater than A.");
                return;
            }


        }

        //Exception atilan version
        public int Calculate(string a, string b)
        {
            //Fast fail --> Clean Code
            //Guard Clauses

            //String input-1 check
            var result1 = int.TryParse(a, out int value1);

            if(result1 is false)
            {
                throw new Exception("a degeri sayisal bir deger degildir.");
                //Console.WriteLine("a degeri sayısal bir degel degildir.");
                //return 0;
            }

            //String input-1 check

            var result2 = int.TryParse(b, out int value2);

            if(result2 is false)
            {
                throw new Exception("b degeri sayisal bir deger degildir.");
                //Console.WriteLine("b degeri sayısal bir degel degildir.");
                //return 0;
            }


            if(value1 > 10 && value2 > 10)
            {
                return value1 + value2; 
            }

            return value1 + value2;

            
        }

        //Exception atilmadan tuple donerek

        public (bool isSuccess, int data, string errorMessage) Calculate2(string a , string b)
        {
            //String input-1 check
            var result1 = int.TryParse(a, out int value1);

            if (result1 is false)
            {
                return (isSuccess: false, data: 0, errorMessage: "Input a is not valid");
            }

            //String input-1 check

            var result2 = int.TryParse(b, out int value2);

            if (result2 is false)
            {
                return (isSuccess: false, data: 0, errorMessage: "Input b is not valid");

            }

            if (value1 > 10 && value2 > 10)
            {
                return (isSuccess: true, data: value1+value2+10, errorMessage: "NO ERROR");
            }

            return (isSuccess: true, data: value1 + value2, errorMessage: "NO ERROR - NO CONDITION");

        }


        //Tuple yerine ServiceResult gibi bir class kullanırsak 

        public ServiceResult Calculate3(string a, string b)
        {

            //String input-1 check
            var result1 = int.TryParse(a, out int value1);

            if (result1 is false)
            {

                return new ServiceResult
                {
                    ErrorMessage = "Parameter-1 is not valid.",
                    IsSuccess = false,
                    Value = 0
                };
            }

            //String input-1 check

            var result2 = int.TryParse(b, out int value2);

            if (result2 is false)
            {

                return new ServiceResult
                {
                    ErrorMessage = "Parameter-2 is not valid.",
                    IsSuccess = false,
                    Value = 0
                };
            }

            if (value1 > 10 && value2 > 10)
            {

                return new ServiceResult
                {
                    ErrorMessage = string.Empty,
                    IsSuccess = true,
                    Value = value1+ value2+10
                };
            }

            return new ServiceResult
            {
                ErrorMessage = string.Empty,
                IsSuccess = true,
                Value = value1 + value2
            };

        }

        //Surekli newlemek yerine daha clean kullanım
        public ServiceResult Calculate4(string a, string b)
        {

            //String input-1 check
            var result1 = int.TryParse(a, out int value1);

            if (result1 is false)
            {

                return ServiceResult.Failure("Paramater-1 is not valid.");
            }

            //String input-1 check

            var result2 = int.TryParse(b, out int value2);

            if (result2 is false)
            {

                return ServiceResult.Failure("Paramater-2 is not valid.");

            }

            if (value1 > 10 && value2 > 10)
            {

                return ServiceResult.Success(value1 + value2 +10);

            }

            return ServiceResult.Success(value1+value2);


        }


    }
}
