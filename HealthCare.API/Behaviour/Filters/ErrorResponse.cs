namespace HealthCare.API.Behaviour.Filters
{
    using System;
    using Newtonsoft.Json;

    public class ErrorResponse
    {
        public string  StatusCode { get; set; }

        public string Description { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object Response { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Exception Exception { get; set; }
    }
}
