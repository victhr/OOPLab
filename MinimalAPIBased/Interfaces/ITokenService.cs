using MinimalAPIBased.Models;

namespace MinimalAPIBased.Interfaces
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, UserDTO user);
    }
}
