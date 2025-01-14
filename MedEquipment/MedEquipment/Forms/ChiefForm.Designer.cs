namespace MedEquipment.Forms
{
    partial class ChiefForm
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
            label1 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            JobTitle = new DataGridViewTextBoxColumn();
            Equipment = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            dataGridView2 = new DataGridView();
            Dep = new DataGridViewTextBoxColumn();
            AmountOfEquipment = new DataGridViewTextBoxColumn();
            RepairsForTheMonth = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(599, 109);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 16;
            label3.Text = "Персонал";
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Department, JobTitle, Equipment });
            dataGridView1.Location = new Point(160, 144);
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
            dataGridView1.Size = new Size(985, 169);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.Name = "Department";
            // 
            // JobTitle
            // 
            JobTitle.HeaderText = "JobTitle";
            JobTitle.Name = "JobTitle";
            // 
            // Equipment
            // 
            Equipment.HeaderText = "Equipment";
            Equipment.Name = "Equipment";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(332, 591);
            button2.Name = "button2";
            button2.Size = new Size(118, 31);
            button2.TabIndex = 11;
            button2.Text = "Отчет";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(573, 394);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 12;
            label2.Text = "Общая статистика";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(422, 319);
            button3.Name = "button3";
            button3.Size = new Size(178, 31);
            button3.TabIndex = 13;
            button3.Text = "Редактировать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.AutoSize = true;
            button6.Font = new Font("Segoe UI", 12F);
            button6.Location = new Point(160, 319);
            button6.Name = "button6";
            button6.Size = new Size(207, 31);
            button6.TabIndex = 18;
            button6.Text = " Добавить сотрудника";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top;
            button7.AutoSize = true;
            button7.Font = new Font("Segoe UI", 12F);
            button7.Location = new Point(663, 319);
            button7.Name = "button7";
            button7.Size = new Size(165, 31);
            button7.TabIndex = 19;
            button7.Text = "Удалить сотрудника";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top;
            button8.AutoSize = true;
            button8.Font = new Font("Segoe UI", 12F);
            button8.Location = new Point(1027, 319);
            button8.Name = "button8";
            button8.Size = new Size(118, 31);
            button8.TabIndex = 20;
            button8.Text = "Отчет";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.Anchor = AnchorStyles.Top;
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
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Dep, AmountOfEquipment, RepairsForTheMonth });
            dataGridView2.Location = new Point(153, 440);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(537, 145);
            dataGridView2.TabIndex = 15;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Dep
            // 
            Dep.HeaderText = "Department";
            Dep.Name = "Dep";
            // 
            // AmountOfEquipment
            // 
            AmountOfEquipment.HeaderText = "AmountOfEquipment";
            AmountOfEquipment.Name = "AmountOfEquipment";
            // 
            // RepairsForTheMonth
            // 
            RepairsForTheMonth.HeaderText = "RepairsForTheMonth";
            RepairsForTheMonth.Name = "RepairsForTheMonth";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(763, 440);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 66);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(20, 34);
            label5.Name = "label5";
            label5.Size = new Size(127, 21);
            label5.TabIndex = 1;
            label5.Text = "{TotalEquipment}";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(4, 0);
            label4.Name = "label4";
            label4.Size = new Size(157, 21);
            label4.TabIndex = 0;
            label4.Text = "Всего оборудования";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(1027, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 66);
            panel2.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(20, 34);
            label6.Name = "label6";
            label6.Size = new Size(114, 21);
            label6.TabIndex = 1;
            label6.Text = "{ActiveRepairs}";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(148, 21);
            label7.TabIndex = 0;
            label7.Text = "Активные ремонты";
            label7.Click += label7_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(872, 531);
            panel3.Name = "panel3";
            panel3.Size = new Size(186, 66);
            panel3.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(20, 33);
            label8.Name = "label8";
            label8.Size = new Size(148, 21);
            label8.TabIndex = 1;
            label8.Text = "{CompletedRepairs}";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(178, 21);
            label9.TabIndex = 0;
            label9.Text = "Завершенные ремонты";
            label9.Click += label9_Click;
            // 
            // ChiefForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Text = "ChiefForm";
            Load += ChiefForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Button button6;
        private Button button7;
        private Button button8;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn JobTitle;
        private DataGridViewTextBoxColumn Equipment;
        private DataGridView dataGridView2;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private Label label9;
        private DataGridViewTextBoxColumn Dep;
        private DataGridViewTextBoxColumn AmountOfEquipment;
        private DataGridViewTextBoxColumn RepairsForTheMonth;
    }
}