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
        private string? _userId;

        public ChiefForm(User user)
        {
            InitializeComponent();

            _user = user;

            _repairRequestService = new RepairRequestService();
            _equipmentService = new EquipmentService();
            _userService = new UserService();

            label5.Text = _userService.GetAllUsers().Sum(x => x.Equipments.Count).ToString();
            label6.Text = _userService.GetAllUsers()
                .Sum(user => user.RepairRequests
                    .Count(request => request.Status == RequestStatus.InProgress || request.Status == RequestStatus.Open))
                .ToString();
            label8.Text = _userService.GetAllUsers()
                .Sum(user => user.RepairRequests
                    .Count(request => request.Status == RequestStatus.Done))
                .ToString();

            label1.Text = label1.Text.Replace("{FullName}", user.FullName);
            label1.Location = new Point((Size.Width - label1.Width) / 2, label1.Location.Y);

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns["Id"].Visible = false;

            dataGridView1.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    _userId = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();

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

            Click += (s, e) =>
            {
                dataGridView1.ClearSelection();
                dataGridView2.ClearSelection();
                _userId = null;
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChiefForm_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void LoadRequests()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ExcelReport.CreateReport(dataGridView1, _user.FullName + "\\Персонал");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelReport.CreateReport(dataGridView1, _user.FullName + "\\Общая статистика");
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewClientForm newClientForm = new NewClientForm();
            newClientForm.ShowDialog();
            LoadRequests();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_userId != null)
            {
                var user= _userService.GetUser(_userId);

                NewClientForm newClientForm = new NewClientForm();
                updateRequestForm.ShowDialog();
                LoadRequests();
            }
            else
            {
                MessageBox.Show(this, "Выберите заявку", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
