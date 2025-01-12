using MedEquipment.Data;
using MedEquipment.Models;

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
            return _dbContext.RepairRequests.Where(x => x.UserId == userId).ToList();
        }

        public void AddRequest(RepairRequest repairRequest)
        {
            _dbContext.RepairRequests.Add(repairRequest);
            _dbContext.SaveChanges();
        }

        public void UpdateRequestStatus(int requestId, RequestStatus status)
        {
            var request = _dbContext.RepairRequests.Find(requestId);
            if (request != null)
            {
                request.Status = status;
                _dbContext.SaveChanges();
            }
        }
    }
}
