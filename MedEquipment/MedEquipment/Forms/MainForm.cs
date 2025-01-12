using MedEquipment.Models;

namespace MedEquipment.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //private void MainForm_Load(object sender, EventArgs e)
        //{
        //    // Role-based navigation example
        //    LoginForm loginForm = new LoginForm();
        //    loginForm.ShowDialog();

        //    if (loginForm.CurrentUser != null)
        //    {
        //        switch (loginForm.CurrentUser.Role)
        //        {
        //            case Role.Doctor:
        //                OpenDoctorForm();
        //                break;
        //            case Role.SysAdmin:
        //                OpenSysAdminForm();
        //                break;
        //            case Role.Chief:
        //                OpenChiefForm();
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        Close();
        //    }
        //}

        //private void OpenDoctorForm()
        //{
        //    var doctorForm = new DoctorDashboardForm();
        //    doctorForm.Show();
        //}

        //private void OpenSysAdminForm()
        //{
        //    var sysAdminForm = new SysAdminDashboardForm();
        //    sysAdminForm.Show();
        //}

        //private void OpenChiefForm()
        //{
        //    var chiefForm = new ChiefDashboardForm();
        //    chiefForm.Show();
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
