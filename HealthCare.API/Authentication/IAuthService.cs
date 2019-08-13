namespace HealthCare.API.Authentication.Managers
{
    public interface IAuthService
    {
        (string, int) RetrieveTokenData(string token);

        string GenerateToken(string username, int userId);
    }
}