using MedEquipment.Services;
using System.Data;

namespace MedEquipment.Forms
{
    public partial class ReportForm : Form
    {
        private readonly RepairRequestService _repairRequestService;

        public ReportForm()
        {
            InitializeComponent();
            _repairRequestService = new RepairRequestService();
        }

        //private void ReportForm_Load(object sender, EventArgs e)
        //{
        //    var requests = _repairRequestService.GetAllRequests();
        //    reportGrid.DataSource = requests.Select(r => new
        //    {
        //        r.Id,
        //        EquipmentId = r.EquipmentId, // Placeholder for equipment name
        //        UserId = r.UserId, // Placeholder for user name
        //        r.Description,
        //        r.Status
        //    }).ToList();
        //}
    }
}
