using MedEquipment.Data;
using MedEquipment.Models;
using MedEquipment.Utils;
using Microsoft.EntityFrameworkCore;

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
            return _dbContext.Users
                .Include(x => x.Equipments)
                .Include(x => x.RepairRequests)
                .AsNoTracking()
                .ToList();
        }

        public User GetUser(int id)
        {
            return _dbContext.Users
                .Include(x => x.Equipments)
                .Include(x => x.RepairRequests)
                .Where(x => x.Id == id)
                .AsNoTracking()
                .SingleOrDefault();
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

        public void UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
        }
    }
}
