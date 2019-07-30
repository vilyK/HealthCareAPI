namespace HealthCare.Utilities.Exceptions
{
    using System;

    public class UserIncorrectDataException : Exception
    {
        public UserIncorrectDataException(string message, string statusCode)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public string StatusCode { get; }

        public override string Message { get;}
    }
}
