namespace MedEquipment.Forms
{
    partial class EquipmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentForm));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            LoginButton = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(585, 176);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 11;
            label3.Text = "Модель";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(585, 113);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 10;
            label2.Text = "Название";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(555, 61);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 9;
            label1.Text = "Оборудование";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Location = new Point(504, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 23);
            textBox2.TabIndex = 8;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top;
            LoginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginButton.Font = new Font("Segoe UI", 12F);
            LoginButton.Location = new Point(400, 453);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(130, 30);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Сохранить";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(504, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(521, 351);
            label4.Name = "label4";
            label4.Size = new Size(195, 21);
            label4.TabIndex = 15;
            label4.Text = "Последнее обслуживание";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(549, 234);
            label5.Name = "label5";
            label5.Size = new Size(134, 21);
            label5.TabIndex = 14;
            label5.Text = "Серийный номер";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top;
            textBox4.Location = new Point(504, 258);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(230, 23);
            textBox4.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(501, 385);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(721, 453);
            button1.Name = "button1";
            button1.Size = new Size(130, 30);
            button1.TabIndex = 17;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(585, 292);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 19;
            label6.Text = "Врач";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(504, 316);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 23);
            comboBox1.TabIndex = 20;
            // 
            // EquipmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 681);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(LoginButton);
            Controls.Add(textBox1);
            Name = "EquipmentForm";
            Text = "EquipmentForm";
            Load += EquipmentForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Button LoginButton;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label6;
        private ComboBox comboBox1;
    }
}