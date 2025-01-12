using MedEquipment.Data;
using MedEquipment.Models;
using MedEquipment.Utils;

namespace MedEquipment.Services
{
    public class UserService
    {
        private readonly DatabaseContext _dbContext;

        public UserService()
        {
            _dbContext = new DatabaseContext();
        }

        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }

        public void AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public User? VerifyUserLoginAndPassword(string login, string password)
        {
            var hashLogin = HashHelper.HashString(login);
            var hashPassword = HashHelper.HashString(password);

            var user = _dbContext.Users.Where(x => x.Password == hashPassword && x.Login == hashLogin).SingleOrDefault();

            return user;
        }
    }
}
