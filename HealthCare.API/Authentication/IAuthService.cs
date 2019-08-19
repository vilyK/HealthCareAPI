namespace HealthCare.API.Authentication
{
    public interface IAuthService
    {
        (string, int) RetrieveTokenData(string token);

        string GenerateToken(string username, int userId);
    }
}