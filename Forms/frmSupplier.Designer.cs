namespace PeartAgroChemicalsManagementSystem.Forms
{
    partial class frmSupplier
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblHistory = new System.Windows.Forms.Label();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();

            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(13, 71, 161);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(850, 45);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Controls.Add(this.lblTitle);

            this.lblTitle.Text = "🚚 Supplier Management";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";

            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Width = 320;
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Controls.Add(this.lblName);
            this.pnlLeft.Controls.Add(this.txtName);
            this.pnlLeft.Controls.Add(this.lblPhone);
            this.pnlLeft.Controls.Add(this.txtPhone);
            this.pnlLeft.Controls.Add(this.lblCity);
            this.pnlLeft.Controls.Add(this.txtCity);
            this.pnlLeft.Controls.Add(this.lblAddress);
            this.pnlLeft.Controls.Add(this.txtAddress);
            this.pnlLeft.Controls.Add(this.btnSave);
            this.pnlLeft.Controls.Add(this.btnUpdate);
            this.pnlLeft.Controls.Add(this.btnDelete);
            this.pnlLeft.Controls.Add(this.btnClear);

            this.lblName.Text = "Supplier Name *"; this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblName.Location = new System.Drawing.Point(15, 25); this.lblName.AutoSize = true; this.lblName.Name = "lblName";
            this.txtName.Location = new System.Drawing.Point(15, 45); this.txtName.Size = new System.Drawing.Size(280, 22); this.txtName.Name = "txtName";

            this.lblPhone.Text = "Phone"; this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblPhone.Location = new System.Drawing.Point(15, 85); this.lblPhone.AutoSize = true; this.lblPhone.Name = "lblPhone";
            this.txtPhone.Location = new System.Drawing.Point(15, 105); this.txtPhone.Size = new System.Drawing.Size(280, 22); this.txtPhone.Name = "txtPhone";

            this.lblCity.Text = "City"; this.lblCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblCity.Location = new System.Drawing.Point(15, 145); this.lblCity.AutoSize = true; this.lblCity.Name = "lblCity";
            this.txtCity.Location = new System.Drawing.Point(15, 165); this.txtCity.Size = new System.Drawing.Size(280, 22); this.txtCity.Name = "txtCity";

            this.lblAddress.Text = "Address"; this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblAddress.Location = new System.Drawing.Point(15, 205); this.lblAddress.AutoSize = true; this.lblAddress.Name = "lblAddress";
            this.txtAddress.Location = new System.Drawing.Point(15, 225); this.txtAddress.Size = new System.Drawing.Size(280, 60); this.txtAddress.Multiline = true; this.txtAddress.Name = "txtAddress";

            this.btnSave.Text = "💾 Save"; this.btnSave.BackColor = System.Drawing.Color.FromArgb(13, 71, 161); this.btnSave.ForeColor = System.Drawing.Color.White; this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSave.FlatAppearance.BorderSize = 0; this.btnSave.Size = new System.Drawing.Size(65, 32); this.btnSave.Location = new System.Drawing.Point(15, 305); this.btnSave.Name = "btnSave"; this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnUpdate.Text = "✏️ Update"; this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(21, 101, 192); this.btnUpdate.ForeColor = System.Drawing.Color.White; this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnUpdate.FlatAppearance.BorderSize = 0; this.btnUpdate.Size = new System.Drawing.Size(65, 32); this.btnUpdate.Location = new System.Drawing.Point(85, 305); this.btnUpdate.Name = "btnUpdate"; this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "🗑️ Del"; this.btnDelete.BackColor = System.Drawing.Color.FromArgb(183, 28, 28); this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnDelete.FlatAppearance.BorderSize = 0; this.btnDelete.Size = new System.Drawing.Size(65, 32); this.btnDelete.Location = new System.Drawing.Point(155, 305); this.btnDelete.Name = "btnDelete"; this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "🔄 Clear"; this.btnClear.BackColor = System.Drawing.Color.FromArgb(117, 117, 117); this.btnClear.ForeColor = System.Drawing.Color.White; this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClear.FlatAppearance.BorderSize = 0; this.btnClear.Size = new System.Drawing.Size(65, 32); this.btnClear.Location = new System.Drawing.Point(225, 305); this.btnClear.Name = "btnClear"; this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlRight.BackColor = System.Drawing.Color.White; this.pnlRight.Name = "pnlRight";
            this.pnlRight.Controls.Add(this.dgvSupplier);
            this.pnlRight.Controls.Add(this.lblHistory);

            this.lblHistory.Text = "📋 Suppliers List"; this.lblHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.lblHistory.ForeColor = System.Drawing.Color.FromArgb(13, 71, 161); this.lblHistory.Dock = System.Windows.Forms.DockStyle.Top; this.lblHistory.Height = 35; this.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblHistory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0); this.lblHistory.Name = "lblHistory";

            this.dgvSupplier.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvSupplier.BackgroundColor = System.Drawing.Color.White; this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.dgvSupplier.ReadOnly = true; this.dgvSupplier.AllowUserToAddRows = false; this.dgvSupplier.RowHeadersVisible = false; this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; this.dgvSupplier.Name = "dgvSupplier"; this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);

            this.ClientSize = new System.Drawing.Size(850, 480);
            this.Text = "Supplier Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(241, 248, 233);
            this.Name = "frmSupplier";
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Load += new System.EventHandler(this.frmSupplier_Load);

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridView dgvSupplier;
    }
}