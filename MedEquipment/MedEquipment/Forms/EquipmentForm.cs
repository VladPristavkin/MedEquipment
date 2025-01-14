using DocumentFormat.OpenXml.Office2016.Excel;
using MedEquipment.Models;
using MedEquipment.Services;
using System;
using System.Data;

namespace MedEquipment.Forms
{
    public partial class EquipmentForm : Form
    {
            private readonly EquipmentService _equipmentService;
            private readonly UserService _userService;
            private Equipment? _equipment;

        public EquipmentForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _equipmentService = new EquipmentService();
        }

        public EquipmentForm(Equipment equipment)
        {
            InitializeComponent();
            _equipmentService = new EquipmentService();
            _userService = new UserService();
            _equipment = equipment;

            if (equipment != null)
            {
                textBox1.Text = equipment.Name;
                textBox2.Text = equipment.Model;
                textBox4.Text = equipment.SerialNumber;
                dateTimePicker1.Value = new DateTime(equipment.LastServiceDate.Year, equipment.LastServiceDate.Month, equipment.LastServiceDate.Day);
            }
        }
        private void EquipmentForm_Load_1(object sender, EventArgs e)
        {
            var users = _userService.GetAllUsers();

            comboBox1.DataSource = users;
            comboBox1.DisplayMember = nameof(User.FullName);
            comboBox1.ValueMember = nameof(User.Id);

            if (_equipment != null)
            {
                comboBox1.SelectedValue = _equipment.UserId.Value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (_equipment != null)
            {
                var equipment = _equipmentService.GetEquipment(_equipment.Id.ToString());

                equipment = new Equipment()
                {
                    Id = equipment.Id,
                    Name = textBox1.Text,
                    Model = textBox2.Text,
                    SerialNumber = textBox4.Text,
                    LastServiceDate = DateOnly.FromDateTime(dateTimePicker1.Value),
                    EquipmentStatus = equipment.EquipmentStatus,
                    User = equipment.User,
                    UserId = equipment.UserId
                };

                _equipmentService.UpdateEquipment(equipment);
            }
            else
            {
                var equipment = new Equipment()
                {
                    Name = textBox1.Text,
                    Model = textBox2.Text,
                    SerialNumber = textBox4.Text,
                    LastServiceDate = DateOnly.FromDateTime(dateTimePicker1.Value),
                    EquipmentStatus = EquipmentStatus.Active,
                    User = _userService.GetAllUsers().Where(x => x.Id.ToString() == comboBox1.SelectedValue.ToString()).SingleOrDefault(),
                    UserId = int.Parse(comboBox1.SelectedValue.ToString())
                };

                _equipmentService.AddEquipment(equipment);
            }

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
