namespace HealthCare.Contracts.Models
{
    using Utilities.Enums;

    public class ResponseResult
    {
        public string Message { get; set; }

        public ResponseStatus ResponseStatus { get; set; }
    }
}
