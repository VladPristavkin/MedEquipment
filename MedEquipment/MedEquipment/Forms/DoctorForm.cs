using MedEquipment.Models;
using MedEquipment.Services;
using System.Data;

namespace MedEquipment.Forms
{
    public partial class DoctorForm : Form
    {
        private readonly RepairRequestService _repairRequestService;
        private readonly User _user;

        public DoctorForm(User user)
        {
            InitializeComponent();
            _user = user;
            _repairRequestService = new RepairRequestService();
            label1.Text = label1.Text.Replace("{FullName}", user.FullName);
            label1.Location = new Point((Size.Width - label1.Width) / 2, label1.Location.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateRequestForm createRequestForm = new CreateRequestForm(_user);
            createRequestForm.ShowDialog();
            LoadRequests();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void LoadRequests()
        {
            var requests = _repairRequestService.GetAllUserRequests(_user.Id);

            dataGridView1.DataSource = requests;
        }
    }
}
