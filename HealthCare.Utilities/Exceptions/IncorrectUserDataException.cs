namespace HealthCare.Utilities.Exceptions
{
    using System;

    public class IncorrectUserDataException : Exception
    {
        public string StatusCode => "UserNotFound";

        public override string Message => "Username or password is wrong.";
    }
}
