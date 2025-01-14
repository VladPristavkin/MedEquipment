namespace MedEquipment.Forms
{
    partial class DoctorForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            SerialNumber = new DataGridViewTextBoxColumn();
            LastServiceDate = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            repairRequestBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            RepairName = new DataGridViewTextBoxColumn();
            RepairModel = new DataGridViewTextBoxColumn();
            RepairSerialNumber = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repairRequestBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать, {FullName}! ";
            label1.Click += label1_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Model, SerialNumber, LastServiceDate, statusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = repairRequestBindingSource;
            dataGridView1.Location = new Point(185, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(985, 169);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_3;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.Name = "Model";
            // 
            // SerialNumber
            // 
            SerialNumber.HeaderText = "SerialNumber";
            SerialNumber.Name = "SerialNumber";
            // 
            // LastServiceDate
            // 
            LastServiceDate.HeaderText = "LastServiceDate";
            LastServiceDate.Name = "LastServiceDate";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // repairRequestBindingSource
            // 
            repairRequestBindingSource.DataSource = typeof(Models.RepairRequest);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(189, 591);
            button1.Name = "button1";
            button1.Size = new Size(207, 31);
            button1.TabIndex = 2;
            button1.Text = "Создать заявку на ремонт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(1052, 591);
            button2.Name = "button2";
            button2.Size = new Size(118, 31);
            button2.TabIndex = 3;
            button2.Text = "Отчет";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(559, 380);
            label2.Name = "label2";
            label2.Size = new Size(210, 21);
            label2.TabIndex = 4;
            label2.Text = "Активные заявки на ремонт";
            label2.Click += label2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(439, 591);
            button3.Name = "button3";
            button3.Size = new Size(178, 31);
            button3.TabIndex = 5;
            button3.Text = "Редактировать заявку";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.AutoSize = true;
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(887, 591);
            button4.Name = "button4";
            button4.Size = new Size(129, 31);
            button4.TabIndex = 6;
            button4.Text = "Удалить заявку";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Anchor = AnchorStyles.Top;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { RepairName, RepairModel, RepairSerialNumber, CreatedDate, descriptionDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = repairRequestBindingSource;
            dataGridView2.Location = new Point(189, 423);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(981, 145);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // RepairName
            // 
            RepairName.HeaderText = "Name";
            RepairName.Name = "RepairName";
            // 
            // RepairModel
            // 
            RepairModel.DataPropertyName = "Id";
            RepairModel.HeaderText = "Model";
            RepairModel.Name = "RepairModel";
            // 
            // RepairSerialNumber
            // 
            RepairSerialNumber.HeaderText = "SerialNumber";
            RepairSerialNumber.Name = "RepairSerialNumber";
            // 
            // CreatedDate
            // 
            CreatedDate.HeaderText = "CreatedDate";
            CreatedDate.Name = "CreatedDate";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Status";
            dataGridViewTextBoxColumn6.HeaderText = "Status";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            dataGridViewTextBoxColumn5.HeaderText = "Name";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 154;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "LastServiceDate";
            dataGridViewTextBoxColumn7.HeaderText = "LastServiceDate";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 154;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Actions";
            dataGridViewTextBoxColumn8.HeaderText = "Actions";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 154;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(570, 119);
            label3.Name = "label3";
            label3.Size = new Size(149, 21);
            label3.TabIndex = 8;
            label3.Text = "Мое оборудование";
            label3.Click += label3_Click;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Id";
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Id";
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.AutoSize = true;
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(1052, 345);
            button5.Name = "button5";
            button5.Size = new Size(118, 31);
            button5.TabIndex = 9;
            button5.Text = "Отчет";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button4);
            Text = "DoctorForm";
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repairRequestBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView dataGridView1;
        private BindingSource repairRequestBindingSource;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn SerialNumber;
        private DataGridViewTextBoxColumn LastServiceDate;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn RepairName;
        private DataGridViewTextBoxColumn RepairModel;
        private DataGridViewTextBoxColumn RepairSerialNumber;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private Button button5;
    }
}