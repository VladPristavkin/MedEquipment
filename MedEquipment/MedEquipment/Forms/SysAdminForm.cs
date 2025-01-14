using MedEquipment.Models;
using MedEquipment.Services;
using MedEquipment.Utils;

namespace MedEquipment.Forms
{
    public partial class SysAdminForm : Form
    {
        private readonly RepairRequestService _repairRequestService;
        private readonly EquipmentService _equipmentService;
        private readonly User _user;
        private string? _equipmentId;
        private string? _repairId;

        public SysAdminForm(User user)
        {
            InitializeComponent();

            _user = user;

            _repairRequestService = new RepairRequestService();
            _equipmentService = new EquipmentService();

            label1.Text = label1.Text.Replace("{FullName}", user.FullName);
            label1.Location = new Point((Size.Width - label1.Width) / 2, label1.Location.Y);

            dataGridView2.Columns.Add("Id", "Id");
            dataGridView2.Columns["Id"].Visible = false;

            dataGridView2.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                    _equipmentId = dataGridView2.Rows[e.RowIndex].Cells["Id"].Value.ToString();

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


            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    _repairId = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                    dataGridView1.Rows[e.RowIndex].Selected = true;
                }
                else
                {
                    _repairId = null;
                }
            };

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ClearSelection();

            Click += (s, e) =>
            {
                dataGridView1.ClearSelection();
                dataGridView2.ClearSelection();
                _repairId = null;
                _equipmentId = null;
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadRequests()
        {
            var requests = _repairRequestService.GetAllRequests();
            var equipments = _equipmentService.GetAllEquipment();

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            foreach (var request in requests)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, request.Equipment.Name, request.Equipment.Model, request.Equipment.SerialNumber,
                    request.User.FullName, request.CreatedDate.ToShortDateString(), request.Status.ToString(), request.Id);
                row.Tag = request;
                dataGridView1.Rows.Add(row);
            };

            foreach (var equipment in equipments)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView2, equipment.Name, equipment.Model, equipment.SerialNumber, equipment.User.FullName,
                    equipment.EquipmentStatus.ToString(), equipment.Id);
                row.Tag = equipment;
                dataGridView2.Rows.Add(row);
            };
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void SysAdminForm_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_repairId != null)
            {
                var request = _repairRequestService.GetRequest(_repairId);
                RepairRequestProcessingForm createRequestForm = new RepairRequestProcessingForm(request);
                createRequestForm.ShowDialog();
                LoadRequests();
            }
            else
            {
                MessageBox.Show(this, "Выберите заявку", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EquipmentForm equipmentForm = new EquipmentForm();
            equipmentForm.ShowDialog();
            LoadRequests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelReport.CreateReport(dataGridView1, _user.FullName + "\\Заявки на ремонт");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExcelReport.CreateReport(dataGridView1, _user.FullName + "\\Управление оборудованием");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_equipmentId != null)
            {
                var equipment = _equipmentService.GetEquipment(_equipmentId);
                EquipmentForm equipmentForm = new EquipmentForm(equipment);
                equipmentForm.ShowDialog();
                LoadRequests();
            }
            else
            {
                MessageBox.Show(this, "Выберите оборудование", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_equipmentId != null)
            {
                if (MessageBox.Show(this, "Вы уверены, что хотите удалить это оборудование?", "Подтверждение удаления",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _equipmentService.DeleteEquipment(_equipmentId);
                    MessageBox.Show(this, "Оборудование успешно удалено", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(this, "Выберите оборудование", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
