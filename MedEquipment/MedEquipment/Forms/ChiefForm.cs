using MedEquipment.Models;
using MedEquipment.Services;
using MedEquipment.Utils;

namespace MedEquipment.Forms
{
    public partial class ChiefForm : Form
    {
        private readonly RepairRequestService _repairRequestService;
        private readonly EquipmentService _equipmentService;
        private readonly UserService _userService;
        private readonly User _user;
        private int? _userId;

        public ChiefForm(User user)
        {
            InitializeComponent();

            _user = user;

            _repairRequestService = new RepairRequestService();
            _equipmentService = new EquipmentService();
            _userService = new UserService();

            label1.Text = label1.Text.Replace("{FullName}", user.FullName);
            label1.Location = new Point((Size.Width - label1.Width) / 2, label1.Location.Y);

            Click += (s, e) =>
            {
                ClearSelectionDataGridViews();
                _userId = null;
            };
        }

        private void ChiefForm_Load(object sender, EventArgs e)
        {
            ConfigureDataGridViews();
            RefreshInformation();
        }

        private void InitializeLabels()
        {
            var allUsers = _userService.GetAllUsers();

            label5.Text = allUsers.Sum(user => user.Equipments.Count).ToString();
            label6.Text = allUsers.Sum(user => user.RepairRequests
                .Count(request => request.Status is RequestStatus.InProgress or RequestStatus.Open)).ToString();
            label8.Text = allUsers.Sum(user => user.RepairRequests
                .Count(request => request.Status == RequestStatus.Done)).ToString();
        }

        private void ClearSelectionDataGridViews()
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void FillDataGrid()
        {
            var users = _userService.GetAllUsers();

            var departments = _userService.GetAllUsers().Select(x =>
            new
            {
                Department = x.Department,
                AmountOfEquipment = x.Equipments.Count,
                RepairsForTheMonth = x.RepairRequests.Where(x => x.CreatedDate.Month == DateTime.Now.Month).Count(),
            });

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            foreach (var user in users)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, user.FullName, user.Department, user.Role, user.Equipments.Count, user.Id);
                row.Tag = users;
                dataGridView1.Rows.Add(row);
            };

            foreach (var department in departments)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView2, department.Department, department.AmountOfEquipment, department.RepairsForTheMonth);
                row.Tag = department;
                dataGridView2.Rows.Add(row);
            };
        }

        private void ConfigureDataGridViews()
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    _userId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                    dataGridView1.Rows[e.RowIndex].Selected = true;
                }
                else
                {
                    _userId = null;
                }
            };

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ClearSelection();


            dataGridView2.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    dataGridView2.Rows[e.RowIndex].Selected = true;
                }
            };

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.ClearSelection();
        }

        private void ChiefForm_FormClosed(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ExcelReport.CreateReport(dataGridView1, "Персонал");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelReport.CreateReport(dataGridView1, "Общая статистика");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewClientForm newClientForm = new NewClientForm(null);
            newClientForm.ShowDialog();

            RefreshInformation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_userId != null)
            {
                var user = _userService.GetUser(_userId.Value);
                var newClientForm = new NewClientForm(user);
                newClientForm.ShowDialog();

                RefreshInformation();
            }
            else
            {
                MessageBox.Show(this, "Выберите сотрудника", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_userId != null)
            {
                if (MessageBox.Show(this, "Вы уверены, что хотите удалить этого сотрудника?", "Подтверждение удаления",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _userService.DeleteUser(_userId.Value);
                    MessageBox.Show(this, "Сотрудник успешно удален", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                RefreshInformation();
            }
            else
            {
                MessageBox.Show(this, "Выберите сотрудника", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshInformation()
        {
            InitializeLabels();
            FillDataGrid();
            ClearSelectionDataGridViews();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshInformation();
        }
    }
}
