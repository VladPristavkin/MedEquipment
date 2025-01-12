using MedEquipment.Models;
using MedEquipment.Services;
using System.Data;

namespace MedEquipment.Forms
{
    public partial class UserManagementForm : Form
    {
        private readonly UserService _userService;

        public UserManagementForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        //private void UserManagementForm_Load(object sender, EventArgs e)
        //{
        //    var users = _userService.GetAllUsers();
        //    usersGrid.DataSource = users.Select(u => new
        //    {
        //        u.Id,
        //        u.Name,
        //        Role = u.Role.ToString()
        //    }).ToList();
        //}

        //private void AddUserButton_Click(object sender, EventArgs e)
        //{
        //    var name = nameTextBox.Text;
        //    var role = (Role)Enum.Parse(typeof(Role), roleComboBox.SelectedItem.ToString());
        //    _userService.AddUser(name, role);

        //    MessageBox.Show("Пользователь добавлен!");
        //    UserManagementForm_Load(sender, e); // Refresh grid
        //}
    }
}
