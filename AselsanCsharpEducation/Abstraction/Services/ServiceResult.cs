using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation.Abstraction
{
    public class ServiceResult<T>
    {

        public T Data { get; set; }

        public List<string> Errors { get; set; }

        public static ServiceResult<T> Success(T data)
        {

            return new ServiceResult<T>
            {
                Data = data
            };

        }

        public static ServiceResult<T> Error( List<string> errors )
        {

            return new ServiceResult<T>
            {
                Errors = errors
            };

        }

        public static ServiceResult<T> Fail( string message )
        {

            return new ServiceResult<T>
            {
                Errors = new List<string> { message }
            };
        
        }


    }

}
