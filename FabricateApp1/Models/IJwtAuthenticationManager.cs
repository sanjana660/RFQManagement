namespace FabricateApp1.Models
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}
