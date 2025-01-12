namespace MedEquipment.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
