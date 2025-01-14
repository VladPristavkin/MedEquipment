using MedEquipment.Models;
using MedEquipment.Services;

namespace MedEquipment.Forms
{
    public partial class RepairRequestProcessingForm : Form
    {
        private RepairRequest _repairRequest;
        private readonly RepairRequestService _repairRequestService;

        public RepairRequestProcessingForm(RepairRequest request)
        {
            InitializeComponent();
            _repairRequest = request;
            _repairRequestService = new RepairRequestService();

            label3.Text = label3.Text.Replace("{}", request.Equipment.Name);
            label4.Text = label4.Text.Replace("{}", request.User.FullName);
            label5.Text = label5.Text.Replace("{}", request.User.Department);
            label6.Text = label6.Text.Replace("{}", request.CreatedDate.ToShortDateString());

            comboBox1.DataSource = Enum.GetValues(typeof(RequestStatus))
             .Cast<RequestStatus>()
             .Select(status => new { Value = status, Display = status.ToString() })
             .ToList();

            comboBox1.DisplayMember = "Display";
            comboBox1.ValueMember = "Value";

            comboBox1.SelectedValue = request?.Status ?? RequestStatus.Open;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _repairRequestService.UpdateRequestStatus(_repairRequest.Id, Enum.Parse<RequestStatus>(comboBox1.Text));

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RepairRequestProcessingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
