namespace MedEquipment.Forms
{
    partial class SysAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysAdminForm));
            label1 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button2 = new Button();
            button6 = new Button();
            DataGridView1Name = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            SerialNumber = new DataGridViewTextBoxColumn();
            Applicant = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            RepairName = new DataGridViewTextBoxColumn();
            RepairModel = new DataGridViewTextBoxColumn();
            RepairSerialNumber = new DataGridViewTextBoxColumn();
            AssignedTo = new DataGridViewTextBoxColumn();
            EquipmentStatus = new DataGridViewTextBoxColumn();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(502, 50);
            label1.Name = "label1";
            label1.Size = new Size(290, 25);
            label1.TabIndex = 1;
            label1.Text = "Добро пожаловать, {FullName}! ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(575, 110);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 16;
            label3.Text = "Заявки на ремонт";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Anchor = AnchorStyles.Top;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { RepairName, RepairModel, RepairSerialNumber, AssignedTo, EquipmentStatus });
            dataGridView2.Location = new Point(174, 421);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(981, 145);
            dataGridView2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DataGridView1Name, Model, SerialNumber, Applicant, CreatedDate, Status });
            dataGridView1.Location = new Point(170, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(985, 169);
            dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(174, 572);
            button1.Name = "button1";
            button1.Size = new Size(207, 31);
            button1.TabIndex = 10;
            button1.Text = "Добавить оборудование";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(543, 383);
            label2.Name = "label2";
            label2.Size = new Size(214, 21);
            label2.TabIndex = 12;
            label2.Text = "Управление оборудованием";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(557, 325);
            button3.Name = "button3";
            button3.Size = new Size(178, 31);
            button3.TabIndex = 13;
            button3.Text = "Обработать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.AutoSize = true;
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(693, 572);
            button4.Name = "button4";
            button4.Size = new Size(186, 31);
            button4.TabIndex = 14;
            button4.Text = "Удалить оборудование";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.AutoSize = true;
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(417, 572);
            button5.Name = "button5";
            button5.Size = new Size(243, 31);
            button5.TabIndex = 17;
            button5.Text = "Редактировать оборудование";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(1037, 325);
            button2.Name = "button2";
            button2.Size = new Size(118, 31);
            button2.TabIndex = 18;
            button2.Text = "Отчет";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.AutoSize = true;
            button6.Font = new Font("Segoe UI", 12F);
            button6.Location = new Point(1037, 572);
            button6.Name = "button6";
            button6.Size = new Size(118, 31);
            button6.TabIndex = 19;
            button6.Text = "Отчет";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // DataGridView1Name
            // 
            DataGridView1Name.HeaderText = "Название";
            DataGridView1Name.Name = "DataGridView1Name";
            // 
            // Model
            // 
            Model.HeaderText = "Модель";
            Model.Name = "Model";
            // 
            // SerialNumber
            // 
            SerialNumber.HeaderText = "Серийный номер";
            SerialNumber.Name = "SerialNumber";
            // 
            // Applicant
            // 
            Applicant.HeaderText = "Заявитель";
            Applicant.Name = "Applicant";
            // 
            // CreatedDate
            // 
            CreatedDate.HeaderText = "Дата создания";
            CreatedDate.Name = "CreatedDate";
            // 
            // Status
            // 
            Status.HeaderText = "Статус";
            Status.Name = "Status";
            // 
            // RepairName
            // 
            RepairName.HeaderText = "Название";
            RepairName.Name = "RepairName";
            // 
            // RepairModel
            // 
            RepairModel.DataPropertyName = "Id";
            RepairModel.HeaderText = "Модель";
            RepairModel.Name = "RepairModel";
            // 
            // RepairSerialNumber
            // 
            RepairSerialNumber.HeaderText = "Серийный номер";
            RepairSerialNumber.Name = "RepairSerialNumber";
            // 
            // AssignedTo
            // 
            AssignedTo.HeaderText = "Закреплено за";
            AssignedTo.Name = "AssignedTo";
            // 
            // EquipmentStatus
            // 
            EquipmentStatus.HeaderText = "Статус";
            EquipmentStatus.Name = "EquipmentStatus";
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top;
            button7.AutoSize = true;
            button7.Font = new Font("Segoe UI", 12F);
            button7.Location = new Point(1122, 27);
            button7.Name = "button7";
            button7.Size = new Size(118, 31);
            button7.TabIndex = 26;
            button7.Text = "Обновить";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // SysAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 681);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label1);
            Name = "SysAdminForm";
            Text = "SysAdminForm";
            Load += SysAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button2;
        private Button button6;
        private DataGridViewTextBoxColumn RepairName;
        private DataGridViewTextBoxColumn RepairModel;
        private DataGridViewTextBoxColumn RepairSerialNumber;
        private DataGridViewTextBoxColumn AssignedTo;
        private DataGridViewTextBoxColumn EquipmentStatus;
        private DataGridViewTextBoxColumn DataGridView1Name;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn SerialNumber;
        private DataGridViewTextBoxColumn Applicant;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn Status;
        private Button button7;
    }
}