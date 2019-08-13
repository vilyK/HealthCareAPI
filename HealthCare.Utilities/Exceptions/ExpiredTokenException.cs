namespace HealthCare.Utilities.Exceptions
{
    using System;

    public class ExpiredTokenException : Exception
    {
        public string StatusCode => "ExpiredToken";

        public override string Message => "Given token is expired.";
    }
}
