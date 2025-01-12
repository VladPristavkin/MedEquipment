using MedEquipment.Services;
using System.Data;

namespace MedEquipment.Forms
{
    public partial class EquipmentForm : Form
    {
        private readonly EquipmentService _equipmentService;

        public EquipmentForm()
        {
            InitializeComponent();
            _equipmentService = new EquipmentService();
        }

        //private void EquipmentForm_Load(object sender, EventArgs e)
        //{
        //    var equipment = _equipmentService.GetAllEquipment();
        //    equipmentGrid.DataSource = equipment.Select(e => new
        //    {
        //        e.Id,
        //        e.Name,
        //        e.Model,
        //        e.SerialNumber
        //    }).ToList();
        //}

        //private void AddEquipmentButton_Click(object sender, EventArgs e)
        //{
        //    var name = nameTextBox.Text;
        //    var model = modelTextBox.Text;
        //    var serialNumber = serialNumberTextBox.Text;

        //    _equipmentService.AddEquipment(name, model, serialNumber);
        //    MessageBox.Show("Оборудование добавлено!");

        //    EquipmentForm_Load(sender, e); // Refresh grid
        //}

        private void EquipmentForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
