namespace HealthCare.DataLayer.Entities.Base
{
    using System.ComponentModel.DataAnnotations;

    public class IdentityData
    {
        [Key]
        public int Id { get; set; }
    }
}
