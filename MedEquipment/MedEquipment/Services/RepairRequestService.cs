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

        public RepairRequest GetRequest(string requestId)
        {
            return _dbContext.RepairRequests
                .Include(x => x.User)
                .Include(x => x.Equipment)
                .Where(x => x.Id.ToString() == requestId)
                 .AsNoTracking()
                .SingleOrDefault();
        }


        public void AddRequest(RepairRequest repairRequest)
        {
            repairRequest.CreatedDate = DateOnly.FromDateTime(DateTime.Now);
            _dbContext.RepairRequests.Add(repairRequest);
            _dbContext.SaveChanges();
        }

        public void UpdateRequestStatus(int requestId, RequestStatus status)
        {
            var request = _dbContext.RepairRequests.Where(x=>x.Id == requestId).SingleOrDefault();
            if (request != null)
            {
                request.Status = status;
                _dbContext.SaveChanges();
            }
        }

        public void UpdateRequest(string requestId, string? description, string? equipmentId)
        {
            var request = _dbContext.RepairRequests.Find(requestId);

            if (request != null)
            {
                if (description != null)
                {
                    request.Description = description;
                }

                if (equipmentId != null)
                {
                    var equipment = _dbContext.Equipment.Find(equipmentId);

                    if (equipment != null)
                    {
                        request.Equipment = equipment;
                        request.EquipmentId = int.Parse(equipmentId);
                    }
                }

                _dbContext.SaveChanges();
            }
        }

        public void DelereRequest(string requestId)
        {
            var request = _dbContext.RepairRequests.Find(requestId);

            if (request != null)
            {
                _dbContext.RepairRequests.Remove(request);
                _dbContext.SaveChanges();
            }
        }
    }
}
