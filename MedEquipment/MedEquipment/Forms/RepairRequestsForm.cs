using MedEquipment.Services;
using System.Data;

namespace MedEquipment.Forms
{
    public partial class RepairRequestsForm : Form
    {
        private readonly RepairRequestService _repairRequestService;

        public RepairRequestsForm()
        {
            InitializeComponent();
            _repairRequestService = new RepairRequestService();
        }

        //private void RepairRequestsForm_Load(object sender, EventArgs e)
        //{
        //    var requests = _repairRequestService.GetAllRequests();
        //    repairRequestsGrid.DataSource = requests.Select(r => new
        //    {
        //        r.Id,
        //        EquipmentName = r.EquipmentId, // Placeholder for Equipment Name
        //        UserName = r.UserId, // Placeholder for User Name
        //        r.Description,
        //        r.Status
        //    }).ToList();
        //}
    }
}
