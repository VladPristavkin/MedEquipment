﻿namespace MedEquipment.Forms
{
    partial class RepairRequestProcessingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepairRequestProcessingForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(490, 54);
            label1.Name = "label1";
            label1.Size = new Size(265, 25);
            label1.TabIndex = 2;
            label1.Text = "Обработка заявки на ремонт";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(525, 105);
            label2.Name = "label2";
            label2.Size = new Size(170, 21);
            label2.TabIndex = 3;
            label2.Text = "Информация о заявке";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(167, 150);
            label3.Name = "label3";
            label3.Size = new Size(134, 21);
            label3.TabIndex = 4;
            label3.Text = "Оборудование: {}";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(167, 171);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 5;
            label4.Text = "Заявитель: {}";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(167, 192);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 6;
            label5.Text = "Отделение: {}";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(167, 213);
            label6.Name = "label6";
            label6.Size = new Size(131, 21);
            label6.TabIndex = 7;
            label6.Text = "Дата создания: {}";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(915, 155);
            label7.Name = "label7";
            label7.Size = new Size(122, 21);
            label7.TabIndex = 8;
            label7.Text = "Статус ремонта";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(916, 190);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(850, 522);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 11;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(264, 522);
            button1.Name = "button1";
            button1.Size = new Size(147, 31);
            button1.TabIndex = 10;
            button1.Text = "Сохранить заявку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(394, 253);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(465, 230);
            textBox1.TabIndex = 13;
            textBox1.Text = "                                               Описание:\r\n{}";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // RepairRequestProcessingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 681);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RepairRequestProcessingForm";
            Text = "RepairRequestProcessingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
    }
}