namespace HealthCare.BusinessLayer
{
    using System.Threading.Tasks;

    public interface IUserHandler
    {
        Task RegisterUser();

        Task LoginUser();
    }
}