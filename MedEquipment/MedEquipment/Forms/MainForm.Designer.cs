namespace MedEquipment.Forms
{
    partial class MainForm
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
            SuspendLayout();
            // 
            // MainForm
            // 
            ClientSize = new Size(1043, 562);
            Name = "MainForm";
            Load += MainForm_Load_1;
            ResumeLayout(false);
        }

        // Event handlers
        private void UsersMenuItem_Click(object sender, EventArgs e) => new UserManagementForm().Show();
        private void EquipmentMenuItem_Click(object sender, EventArgs e) => new EquipmentForm().Show();
        private void RequestsMenuItem_Click(object sender, EventArgs e) => new RepairRequestsForm().Show();
        private void ReportsMenuItem_Click(object sender, EventArgs e) => new ReportForm().Show();
        private void ExitMenuItem_Click(object sender, EventArgs e) => this.Close();

#endregion
    }
}