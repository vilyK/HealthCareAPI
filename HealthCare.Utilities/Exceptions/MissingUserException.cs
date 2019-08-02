namespace HealthCare.Utilities.Exceptions
{
    using System;

    public class MissingUserException : Exception
    {
        public string StatusCode => "UserExists";

        public override string Message => "Username has been already exist.";
    }
}
