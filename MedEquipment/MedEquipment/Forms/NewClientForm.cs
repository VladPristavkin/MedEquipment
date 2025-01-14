using MedEquipment.Models;
using MedEquipment.Services;
using MedEquipment.Utils;
using System.Data;
using System.Windows.Forms;

namespace MedEquipment.Forms
{
    public partial class NewClientForm : Form
    {
        private readonly UserService _userService;
        private User? _user;

        public NewClientForm(User user)
        {
            InitializeComponent();
            _userService = new UserService();
            _user = user;

            if (_user != null)
            {
                textBox4.Text = user.FullName;
                textBox3.Text = user.Department;

                label1.Text = "Редактирование пользователя";

                comboBox1.DataSource = Enum.GetValues(typeof(Role))
                 .Cast<Role>()
                 .Select(role => new { Value = role, Display = role.ToString() })
                 .ToList();

                comboBox1.DisplayMember = "Display";
                comboBox1.ValueMember = "Value";

                comboBox1.SelectedValue = _user?.Role ?? Role.Doctor;
            }
            else
            {
                comboBox1.DataSource = Enum.GetValues(typeof(Role))
                 .Cast<Role>()
                 .Select(role => new { Value = role, Display = role.ToString() })
                 .ToList();

                comboBox1.DisplayMember = "Display";
                comboBox1.ValueMember = "Value";

                comboBox1.SelectedValue = Role.Doctor;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (_user != null)
            {
                var user = _userService.GetUser(_user.Id);

                user = new User()
                {
                    Id = user.Id,
                    FullName = textBox4.Text,
                    Department = textBox3.Text,
                    Login = HashHelper.HashString(textBox1.Text),
                    Password = HashHelper.HashString(textBox2.Text),
                    Role = Enum.Parse<Role>(comboBox1.Text)
                };

                _userService.UpdateUser(user);
            }
            else
            {
                var user = new User()
                {
                    FullName = textBox4.Text,
                    Department = textBox3.Text,
                    Login = HashHelper.HashString(textBox1.Text),
                    Password = HashHelper.HashString(textBox2.Text),
                    Role = Enum.Parse<Role>(comboBox1.Text)
                };

                _userService.AddUser(user);
            }

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NewClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
