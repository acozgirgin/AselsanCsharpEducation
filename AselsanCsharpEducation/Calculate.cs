using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    public class Calculate
    {


        public static ServiceResult Add( string input1, string input2)
        {

            //String input-1 check
            var result1 = int.TryParse(input1, out int value1);

            if (result1 is false)
            {

                return ServiceResult.Failure("Paramater-1 is not valid.");
            }

            //String input-2 check

            var result2 = int.TryParse(input2, out int value2);

            if (result2 is false)
            {

                return ServiceResult.Failure("Paramater-2 is not valid.");

            }

            var (isSuccess, sumResult) = SumResultCheck(n1: value1, n2: value2);

            //Failure-Check
            if(!isSuccess)
            {
                return ServiceResult.Failure("Sum result is greater than 50. ERROR ! ");
            }

            //Return Result
            return ServiceResult.Success(data: sumResult);
        }


        public static (bool,int) SumResultCheck( int n1, int n2 ) => (n1+n2>50)?(false,n1+n2):(true,n1+n2);

    }
}
