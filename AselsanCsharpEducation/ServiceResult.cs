namespace AselsanCsharpEducation
{
    
        public class ServiceResult
        {

            public bool IsSuccess { get; set; }

            public int Value { get; set; }

            public string ErrorMessage { get; set; }

            //Success donmek gerekirken
            public static ServiceResult Success(int data)
            {
                return new ServiceResult
                {
                    IsSuccess = true,
                    Value = data
                };
            }

            public static ServiceResult Failure(string errorMessage)
            {
                return new ServiceResult
                {
                    IsSuccess = false,
                    ErrorMessage = errorMessage
                };
            }



    }

    
}
