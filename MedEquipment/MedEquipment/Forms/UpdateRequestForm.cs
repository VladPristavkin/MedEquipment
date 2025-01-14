using MedEquipment.Models;
using MedEquipment.Services;
using System.Data;

namespace MedEquipment.Forms
{
    public partial class UpdateRequestForm : Form
    {
        private readonly EquipmentService _equipmentService;
        private readonly RepairRequestService _repairRequestService;
        private readonly User _user;
        private string _equipmentId;
        private string? _description;
        private string _requestId;

        public UpdateRequestForm(User user, string requestId, string equipmentId, string? description)
        {
            InitializeComponent();
            _repairRequestService = new RepairRequestService();
            _equipmentService = new EquipmentService();
            _user = user;
            _requestId = requestId;
            _equipmentId = equipmentId;
            _description = description;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void UpdateRequestForm_Load(object sender, EventArgs e)
        {
            var equipment = _equipmentService.GetAllUserEquipment(_user.Id);
            textBox1.Text = equipment.Where(x => x.Id.ToString() == _equipmentId).First().Name;
            textBox2.Text = _description;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _repairRequestService.UpdateRequest(_requestId, _description, _equipmentId);

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
