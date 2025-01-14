using MedEquipment.Models;
using MedEquipment.Services;
using MedEquipment.Utils;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MedEquipment.Forms
{
    public partial class DoctorForm : Form
    {
        private readonly RepairRequestService _repairRequestService;
        private readonly EquipmentService _equipmentService;
        private readonly User _user;
        private string? _equipmentId;
        private string? _repairId;

        public DoctorForm(User user)
        {
            InitializeComponent();

            _user = user;

            _repairRequestService = new RepairRequestService();
            _equipmentService = new EquipmentService();

            label1.Text = label1.Text.Replace("{FullName}", user.FullName);
            label1.Location = new Point((Size.Width - label1.Width) / 2, label1.Location.Y);

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    _equipmentId = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                    dataGridView1.Rows[e.RowIndex].Selected = true;
                }
                else
                {
                    _equipmentId = null;
                }
            };

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ClearSelection();


            dataGridView2.Columns.Add("Id", "Id");
            dataGridView2.Columns["Id"].Visible = false;

            dataGridView2.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                    _repairId = dataGridView2.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                    dataGridView2.Rows[e.RowIndex].Selected = true;
                }
                else
                {
                    _equipmentId = null;
                }
            };

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.ClearSelection();

            Click += (s, e) =>
            {
                dataGridView1.ClearSelection();
                dataGridView2.ClearSelection();
                _repairId = null;
                _equipmentId = null;
            };
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
            if (_equipmentId != null)
            {
                CreateRequestForm createRequestForm = new CreateRequestForm(_user);
                createRequestForm.ShowDialog();
                LoadRequests();
            }
            else
            {
                MessageBox.Show(this, "Выберите оборудование", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelReport.CreateReport(dataGridView1, _user.FullName + "\\Активные заявки на ремонт");
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
            var equipments = _equipmentService.GetAllUserEquipment(_user.Id);

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            foreach (var equipment in equipments)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, equipment.Name, equipment.Model, equipment.SerialNumber, equipment.LastServiceDate.ToShortDateString(),
                    equipment.EquipmentStatus.ToString(), equipment.Id);
                row.Tag = equipment;
                dataGridView1.Rows.Add(row);
            };

            foreach (var request in requests)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView2, request.Equipment.Name, request.Equipment.Model, request.Equipment.SerialNumber,
                    request.CreatedDate.ToShortDateString(), request.Description, request.Status.ToString(), request.Id);
                row.Tag = request;
                dataGridView2.Rows.Add(row);
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_repairId != null)
            {
                var request = _repairRequestService.GetAllUserRequests(_user.Id).ToList().First(x => x.Id.ToString() == _repairId);

                UpdateRequestForm updateRequestForm = new UpdateRequestForm(_user, _repairId, request.EquipmentId.ToString(), request.Description);
                updateRequestForm.ShowDialog();
                LoadRequests();
            }
            else
            {
                MessageBox.Show(this, "Выберите заявку", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_repairId != null)
            {
                if (MessageBox.Show(this, "Вы уверены, что хотите удалить эту заявку?", "Подтверждение удаления",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _repairRequestService.DelereRequest(_repairId);
                    MessageBox.Show(this, "Заявка успешно удалена", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(this, "Выберите заявку", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExcelReport.CreateReport(dataGridView1, _user.FullName + "\\Мое оборудование");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
