using MinimalAPIBased.Models;

namespace MinimalAPIBased.Interfaces
{
    public interface IUserRepositoryService
    {
        UserDTO GetUser(UserModel userModel);
    }
}
