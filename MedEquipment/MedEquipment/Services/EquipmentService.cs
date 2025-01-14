using MedEquipment.Data;
using MedEquipment.Models;
using Microsoft.EntityFrameworkCore;

namespace MedEquipment.Services
{
    public class EquipmentService
    {
        private readonly DatabaseContext _dbContext;

        public EquipmentService()
        {
            _dbContext = new DatabaseContext();
        }

        public List<Equipment> GetAllUserEquipment(int userId)
        {
            return _dbContext.Equipment
                .Include(x => x.User)
                .Where(x => x.UserId == userId)
                 .AsNoTracking()
                .ToList();
        }

        public List<Equipment> GetAllEquipment()
        {
            return _dbContext.Equipment
                .Include(x => x.User)
                 .AsNoTracking()
                .ToList();
        }

        public Equipment GetEquipment(string equipmentId)
        {
            return _dbContext.Equipment
                .Include(x => x.User)
                .Where(x=>x.Id.ToString() == equipmentId)
                .AsNoTracking()
                .SingleOrDefault();
        }

        public void AddEquipment(Equipment equipment)
        {
            _dbContext.Equipment.Add(equipment);
            _dbContext.SaveChanges();
        }

        public void AssignToUser(int equipmentId, int userId)
        {
            var equipment = _dbContext.Equipment.Find(equipmentId);
            if (equipment != null)
            {
                equipment.UserId = userId;
                _dbContext.SaveChanges();
            }
        }

        public void UpdateEquipment(Equipment equipment)
        {
            _dbContext.Equipment.Update(equipment);
            _dbContext.SaveChanges();
        }

        public void DeleteEquipment(string equipmentId)
        {
            var equipment = _dbContext.Equipment.Find(equipmentId);

            if (equipment != null)
            {
                _dbContext.Equipment.Remove(equipment);
                _dbContext.SaveChanges();
            }
        }
    }
}
