using MedEquipment.Data;
using MedEquipment.Models;

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
            return _dbContext.Equipment.Where(x => x.UserId == userId).ToList();
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
    }
}
