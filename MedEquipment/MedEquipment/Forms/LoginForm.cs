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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Этот пользователь не зарегистрирован", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
