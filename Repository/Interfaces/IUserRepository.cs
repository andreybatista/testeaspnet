using KognitWallet.Models;

namespace KognitWallet.Repository.Interfaces
{
    public interface IUserRepository
    {
        UserModel CreateUser(UserModel user);
        UserModel GetByEmail(string email);
        UserModel GetUserById(int id);
        UserModel UpdateUser(int id, UserModel user);
        bool DeleteUser(int id);
    }
}
