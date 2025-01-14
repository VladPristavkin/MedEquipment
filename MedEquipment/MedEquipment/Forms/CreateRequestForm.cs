using DocumentFormat.OpenXml.Spreadsheet;
using MedEquipment.Models;
using MedEquipment.Services;
using System.Data;

namespace MedEquipment.Forms
{
    public partial class CreateRequestForm : Form
    {
        private readonly EquipmentService _equipmentService;
        private readonly RepairRequestService _repairRequestService;
        private readonly User _user;
        private string _equipmentId;

        public CreateRequestForm(User user)
        {
            InitializeComponent();
            _repairRequestService = new RepairRequestService();
            _equipmentService = new EquipmentService();
            _user = user;
        }

        public CreateRequestForm(User user, string equipmentId)
        {
            InitializeComponent();
            _repairRequestService = new RepairRequestService();
            _equipmentService = new EquipmentService();
            _user = user;
            _equipmentId = equipmentId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateRequestForm_Load(object sender, EventArgs e)
        {
            var equipment = _equipmentService.GetAllUserEquipment(_user.Id);

            comboBox1.DataSource = equipment;
            comboBox1.DisplayMember = nameof(Equipment.Name);
            comboBox1.ValueMember = nameof(Equipment.Id);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repairRequest = new RepairRequest()
            {
                EquipmentId = int.Parse(comboBox1.SelectedValue.ToString()),
                UserId = _user.Id,
                Description = textBox2.Text
            };

            _repairRequestService.AddRequest(repairRequest);

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
