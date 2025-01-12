using MedEquipment.Models;

namespace MedEquipment.Forms
{
    public partial class RoleSpecificForm : Form
    {
        public RoleSpecificForm()
        {
            InitializeComponent();
        }

        //private void RoleSpecificForm_Load(object sender, EventArgs e)
        //{
        //    switch (CurrentUser.Role)
        //    {
        //        case Role.Doctor:
        //            ShowDoctorDashboard();
        //            break;
        //        case Role.SysAdmin:
        //            ShowSysAdminDashboard();
        //            break;
        //        case Role.Chief:
        //            ShowChiefDashboard();
        //            break;
        //    }
        //}

        //private void ShowDoctorDashboard()
        //{
        //    var doctorForm = new DoctorDashboardForm();
        //    doctorForm.Show();
        //}

        //private void ShowSysAdminDashboard()
        //{
        //    var sysAdminForm = new SysAdminDashboardForm();
        //    sysAdminForm.Show();
        //}

        //private void ShowChiefDashboard()
        //{
        //    var chiefForm = new ChiefDashboardForm();
        //    chiefForm.Show();
        //}

        private void RoleSpecificForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
