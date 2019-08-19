namespace HealthCare.Interfaces
{
    using System;

    public interface IIdentity
    {
        int Id { get; set; }

        int UserContactId { get; set; }

        DateTime UpdateDate { get; set; }
    }
}
