using MedEquipment.Models;
using MedEquipment.Services;

namespace MedEquipment.Forms
{
    public partial class RequestForm : Form
    {
        private readonly RepairRequestService _repairRequestService;
        private readonly EquipmentService _equipmentService;
        private RepairRequest? _repairRequest;
        private int _equipmentId;

        public RequestForm(int equipmentId)
        {
            InitializeComponent();
            _equipmentService = new EquipmentService();
            _repairRequestService = new RepairRequestService();
            _equipmentId = equipmentId;
        }

        public RequestForm(int equipmentId, RepairRequest repairRequest)
        {
            InitializeComponent();
            _repairRequestService = new RepairRequestService();
            _equipmentService = new EquipmentService();
            _repairRequest = repairRequest;
            _equipmentId = equipmentId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_repairRequest != null)
            {
                var repairRequest = _repairRequestService.GetRequest(_repairRequest.Id);

                repairRequest = new RepairRequest()
                {
                    Id = repairRequest.Id,
                    Description = textBox2.Text,
                    UserId = repairRequest.UserId,
                    EquipmentId = repairRequest.EquipmentId,
                    CreatedDate = repairRequest.CreatedDate,
                    Status = repairRequest.Status
                };

                _repairRequestService.UpdateRequest(repairRequest);
            }
            else
            {
                var equipment = _equipmentService.GetEquipment(_equipmentId);

                if (_equipmentService.CountOfRepairRequest(_equipmentId) == 0)
                {
                    var repairRequest = new RepairRequest()
                    {
                        Description = textBox2.Text,
                        UserId = equipment.UserId,
                        EquipmentId = equipment.Id,
                        Status = RequestStatus.Open,
                    };

                    _repairRequestService.AddRequest(repairRequest);
                }
                else
                {
                    MessageBox.Show(this, "Вы не можете сделать больше одной заявки на одно оборудование", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            var equipment = _equipmentService.GetEquipment(_equipmentId);

            label4.Text = $"{equipment.Name}   {equipment.Model}-{equipment.SerialNumber}";
            label4.Location = new Point((Size.Width - label4.Width) / 2, label4.Location.Y);

            if (_repairRequest != null)
            {
                label1.Text = "Редактирование заявки";
                textBox2.Text = _repairRequest.Description;
            }
        }
    }
}
