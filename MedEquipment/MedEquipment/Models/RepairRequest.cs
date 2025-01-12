namespace MedEquipment.Models
{
    public class RepairRequest
    {
        public int Id { get; set; }
        public int? EquipmentId { get; set; }
        public Equipment? Equipment { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public string Description { get; set; }
        public RequestStatus Status { get; set; } = RequestStatus.Open;
    }
}
