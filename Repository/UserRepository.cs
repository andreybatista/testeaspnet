using KognitWallet.Data;
using KognitWallet.Models;
using KognitWallet.Repository.Interfaces;

namespace KognitWallet.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly KognitWalletDbContext _context;

        public UserRepository(KognitWalletDbContext context)
        {
            _context = context;
        }

        public UserModel GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }

        public UserModel CreateUser(UserModel user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public UserModel GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        public UserModel UpdateUser(int id, UserModel user)
        {
            var existingUser = _context.Users.Find(id);
            if (existingUser == null)
            {
                return null;
            }
            existingUser.Name = user.Name;
            existingUser.BirthDate = user.BirthDate;
            existingUser.CPF = user.CPF;
            _context.SaveChanges();
            return existingUser;
        }

        public bool DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return false;
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return true;
        }
    }

}
