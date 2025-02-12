using MedEquipment.Data;
using MedEquipment.Models;
using Microsoft.EntityFrameworkCore;

namespace MedEquipment.Services
{
    public class RepairRequestService
    {
        private readonly DatabaseContext _dbContext;

        public RepairRequestService()
        {
            _dbContext = new DatabaseContext();
        }

        public List<RepairRequest> GetAllUserRequests(int userId)
        {
            return _dbContext.RepairRequests
                .Include(x => x.User)
                .Include(x => x.Equipment)
                .Where(x => x.UserId == userId)
                .AsNoTracking()
                .ToList();
        }

        public List<RepairRequest> GetAllRequests()
        {
            return _dbContext.RepairRequests
                .Include(x => x.User)
                .Include(x => x.Equipment)
                .AsNoTracking()
                .ToList();
        }

        public RepairRequest GetRequest(int requestId)
        {
            return _dbContext.RepairRequests
                .Include(x => x.User)
                .Include(x => x.Equipment)
                .Where(x => x.Id == requestId)
                .AsNoTracking()
                .SingleOrDefault();
        }


        public void AddRequest(RepairRequest repairRequest)
        {
            repairRequest.CreatedDate = DateOnly.FromDateTime(DateTime.Now);

            var equipment = _dbContext.Equipment.FirstOrDefault(e => e.Id == repairRequest.EquipmentId);

            _dbContext.RepairRequests.Add(repairRequest);

            equipment.EquipmentStatus = EquipmentStatus.Repaired;

            _dbContext.SaveChanges();
        }

        public void UpdateRequestStatus(int requestId, RequestStatus status)
        {
            var request = _dbContext.RepairRequests.Where(x => x.Id == requestId).SingleOrDefault();
            if (request != null)
            {
                request.Status = status;

                if (request.Status == RequestStatus.Done)
                {
                    var equipment = _dbContext.Equipment.FirstOrDefault(e => e.Id == request.EquipmentId);

                    equipment.EquipmentStatus = EquipmentStatus.Active;
                }
                else
                {
                    var equipment = _dbContext.Equipment.FirstOrDefault(e => e.Id == request.EquipmentId);

                    equipment.EquipmentStatus = EquipmentStatus.Repaired;
                }

                _dbContext.SaveChanges();
            }
        }

        public void UpdateRequest(RepairRequest repairRequest)
        {
            if (repairRequest != null)
            {
                var equipment = _dbContext.Equipment.FirstOrDefault(e => e.Id == repairRequest.EquipmentId);

                equipment.EquipmentStatus = EquipmentStatus.Active;

                _dbContext.RepairRequests.Update(repairRequest);

                _dbContext.SaveChanges();
            }
        }

        public void DeleteRequest(int requestId)
        {
            var request = _dbContext.RepairRequests.Where(x => x.Id == requestId).SingleOrDefault();

            if (request != null)
            {
                var equipment = _dbContext.Equipment.FirstOrDefault(e => e.Id == request.EquipmentId);

                equipment.EquipmentStatus = EquipmentStatus.Active;

                _dbContext.RepairRequests.Remove(request);

                _dbContext.SaveChanges();
            }
        }
    }
}
