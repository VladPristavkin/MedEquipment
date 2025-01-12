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

        public CreateRequestForm(User user)
        {
            InitializeComponent();
            _repairRequestService = new RepairRequestService();
            _equipmentService = new EquipmentService();
            _user = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateRequestForm_Load(object sender, EventArgs e)
        {
            var equipment = _equipmentService.GetAllUserEquipment(_user.Id);
            comboBox1.DataSource = equipment;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repairRequest = new RepairRequest()
            {
                EquipmentId = comboBox1.SelectedIndex,
                UserId = _user.Id,
                Description = textBox2.Text
            };

            _repairRequestService.AddRequest(repairRequest);
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
