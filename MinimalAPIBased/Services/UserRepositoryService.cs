using MinimalAPIBased.Interfaces;
using MinimalAPIBased.Models;

namespace MinimalAPIBased.Services
{
    public class UserRepositoryService : IUserRepositoryService
    {
        private List<UserDTO> users =>
            new()
            {
                new("Juan Perez","Peres"),
                new("Alejandro Cortez","Cortes"),
                new("Jorge Peres","Peres"),
            };
        public UserDTO GetUser(UserModel userModel)
        {
            return users.FirstOrDefault(x => string.Equals(x.UserName, userModel.UserName) && string.Equals(x.Password, userModel.Password));
        }


    }
}
