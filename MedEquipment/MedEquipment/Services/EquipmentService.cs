using MedEquipment.Data;
using MedEquipment.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql.TypeMapping;

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

        public Equipment GetEquipment(int equipmentId)
        {
            return _dbContext.Equipment
                .Include(x => x.User)
                .Where(x => x.Id == equipmentId)
                .AsNoTracking()
                .SingleOrDefault();
        }

        public void AddEquipment(Equipment equipment)
        {
            _dbContext.Equipment.Add(equipment);
            _dbContext.SaveChanges();
        }

        public int CountOfRepairRequest(int equipmentId)
        {
            return _dbContext.RepairRequests.Where(x => x.EquipmentId == equipmentId).Count();
        }

        public void UpdateEquipment(Equipment equipment)
        {
            if (equipment != null)
            {
                _dbContext.Equipment.Update(equipment);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteEquipment(int equipmentId)
        {
            var equipment = _dbContext.Equipment.Where(x => x.Id == equipmentId).SingleOrDefault();

            if (equipment != null)
            {
                _dbContext.Equipment.Remove(equipment);
                _dbContext.SaveChanges();
            }
        }
    }
}
