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
        private int? _equipmentId;
        private int? _repairId;

        public SysAdminForm(User user)
        {
            InitializeComponent();

            _user = user;

            _repairRequestService = new RepairRequestService();
            _equipmentService = new EquipmentService();

            label1.Text = label1.Text.Replace("{FullName}", user.FullName);
            label1.Location = new Point((Size.Width - label1.Width) / 2, label1.Location.Y);

            Click += (s, e) =>
            {
                ClearSelectionDataGridViews();
                _repairId = null;
                _equipmentId = null;
            };
        }

        private void SysAdminForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridViews();
            RefreshInformation();
        }

        private void SysAdminForm_FormClosed(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Hide();
        }

        private void RefreshInformation()
        {
            FillDataGrid();
            ClearSelectionDataGridViews();
        }

        private void ClearSelectionDataGridViews()
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void FillDataGrid()
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

        private void ConfigureDataGridViews()
        {
            dataGridView2.Columns.Add("Id", "Id");
            dataGridView2.Columns["Id"].Visible = false;

            dataGridView2.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                    _equipmentId = (int)dataGridView2.Rows[e.RowIndex].Cells["Id"].Value;

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

                    _repairId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_repairId != null)
            {
                var request = _repairRequestService.GetRequest(_repairId.Value);
                RepairRequestProcessingForm createRequestForm = new RepairRequestProcessingForm(request);
                createRequestForm.ShowDialog();
                RefreshInformation();
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
            RefreshInformation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelReport.CreateReport(dataGridView1, _user.FullName + "\\Заявки на ремонт");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExcelReport.CreateReport(dataGridView1, _user.FullName + "\\Управление оборудованием");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_equipmentId != null)
            {
                var equipment = _equipmentService.GetEquipment(_equipmentId.Value);
                EquipmentForm equipmentForm = new EquipmentForm(equipment);
                equipmentForm.ShowDialog();
                RefreshInformation();
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
                    _equipmentService.DeleteEquipment(_equipmentId.Value);
                    MessageBox.Show(this, "Оборудование успешно удалено", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                RefreshInformation();
            }
            else
            {
                MessageBox.Show(this, "Выберите оборудование", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RefreshInformation();
        }
    }
}
