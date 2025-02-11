using MedEquipment.Services;

namespace MedEquipment.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            var user = _userService.VerifyUserLoginAndPassword(login, password);

            if (user != null)
            {
                if (user.Role == Models.Role.Doctor)
                {
                    DoctorForm doctor = new DoctorForm(user);
                    doctor.Show();
                }
                else if (user.Role == Models.Role.SysAdmin)
                {
                    SysAdminForm sysAdmin = new SysAdminForm(user);
                    sysAdmin.Show();
                }
                else if (user.Role == Models.Role.Chief)
                {
                    ChiefForm chiefForm = new ChiefForm(user);
                    chiefForm.Show();
                }
                Hide();
            }
            else
            {
                MessageBox.Show(this, "Пользователь не найден. Проверьте логин и пароль. \nЕсли забыли, обратитесь к главе отделения.", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginForm_FormClosed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
