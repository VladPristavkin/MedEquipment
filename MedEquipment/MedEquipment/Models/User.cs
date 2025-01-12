namespace MedEquipment.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public List<Equipment>? Equipments { get; set; }
        public List<RepairRequest>? RepairRequests { get; set; }
    }
}
