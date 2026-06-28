namespace PeartAgroChemicalsManagementSystem.Forms
{
    partial class frmPesticide
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lblFormType = new System.Windows.Forms.Label();
            this.cmbFormType = new System.Windows.Forms.ComboBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblMinStock = new System.Windows.Forms.Label();
            this.txtMinStock = new System.Windows.Forms.TextBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvPesticide = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesticide)).BeginInit();
            this.SuspendLayout();

            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(27, 94, 32);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(884, 45);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Controls.Add(this.lblTitle);

            this.lblTitle.Text = "🌿 Pesticide Management";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";

            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Width = 340;
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Controls.Add(this.lblProductName);
            this.pnlLeft.Controls.Add(this.txtProductName);
            this.pnlLeft.Controls.Add(this.lblCategory);
            this.pnlLeft.Controls.Add(this.cmbCategory);
            this.pnlLeft.Controls.Add(this.lblCompany);
            this.pnlLeft.Controls.Add(this.txtCompany);
            this.pnlLeft.Controls.Add(this.lblFormType);
            this.pnlLeft.Controls.Add(this.cmbFormType);
            this.pnlLeft.Controls.Add(this.lblUnitPrice);
            this.pnlLeft.Controls.Add(this.txtUnitPrice);
            this.pnlLeft.Controls.Add(this.lblMinStock);
            this.pnlLeft.Controls.Add(this.txtMinStock);
            this.pnlLeft.Controls.Add(this.lblExpiry);
            this.pnlLeft.Controls.Add(this.dtpExpiry);
            this.pnlLeft.Controls.Add(this.lblRegNo);
            this.pnlLeft.Controls.Add(this.txtRegNo);
            this.pnlLeft.Controls.Add(this.btnSave);
            this.pnlLeft.Controls.Add(this.btnUpdate);
            this.pnlLeft.Controls.Add(this.btnDelete);
            this.pnlLeft.Controls.Add(this.btnClear);

            this.lblProductName.Text = "Product Name *"; this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblProductName.Location = new System.Drawing.Point(15, 20); this.lblProductName.AutoSize = true; this.lblProductName.Name = "lblProductName";
            this.txtProductName.Location = new System.Drawing.Point(15, 40); this.txtProductName.Size = new System.Drawing.Size(290, 22); this.txtProductName.Name = "txtProductName";
            this.lblCategory.Text = "Category *"; this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblCategory.Location = new System.Drawing.Point(15, 75); this.lblCategory.AutoSize = true; this.lblCategory.Name = "lblCategory";
            this.cmbCategory.Location = new System.Drawing.Point(15, 95); this.cmbCategory.Size = new System.Drawing.Size(290, 22); this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbCategory.Name = "cmbCategory";
            this.lblCompany.Text = "Company"; this.lblCompany.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblCompany.Location = new System.Drawing.Point(15, 130); this.lblCompany.AutoSize = true; this.lblCompany.Name = "lblCompany";
            this.txtCompany.Location = new System.Drawing.Point(15, 150); this.txtCompany.Size = new System.Drawing.Size(290, 22); this.txtCompany.Name = "txtCompany";
            this.lblFormType.Text = "Form Type"; this.lblFormType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblFormType.Location = new System.Drawing.Point(15, 185); this.lblFormType.AutoSize = true; this.lblFormType.Name = "lblFormType";
            this.cmbFormType.Location = new System.Drawing.Point(15, 205); this.cmbFormType.Size = new System.Drawing.Size(290, 22); this.cmbFormType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbFormType.Name = "cmbFormType";
            this.lblUnitPrice.Text = "Unit Price (Rs) *"; this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblUnitPrice.Location = new System.Drawing.Point(15, 240); this.lblUnitPrice.AutoSize = true; this.lblUnitPrice.Name = "lblUnitPrice";
            this.txtUnitPrice.Location = new System.Drawing.Point(15, 260); this.txtUnitPrice.Size = new System.Drawing.Size(135, 22); this.txtUnitPrice.Name = "txtUnitPrice";
            this.lblMinStock.Text = "Min Stock *"; this.lblMinStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblMinStock.Location = new System.Drawing.Point(165, 240); this.lblMinStock.AutoSize = true; this.lblMinStock.Name = "lblMinStock";
            this.txtMinStock.Location = new System.Drawing.Point(165, 260); this.txtMinStock.Size = new System.Drawing.Size(135, 22); this.txtMinStock.Name = "txtMinStock";
            this.lblExpiry.Text = "Expiry Date *"; this.lblExpiry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblExpiry.Location = new System.Drawing.Point(15, 295); this.lblExpiry.AutoSize = true; this.lblExpiry.Name = "lblExpiry";
            this.dtpExpiry.Location = new System.Drawing.Point(15, 315); this.dtpExpiry.Size = new System.Drawing.Size(290, 22); this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpExpiry.Name = "dtpExpiry";
            this.lblRegNo.Text = "Registration No"; this.lblRegNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblRegNo.Location = new System.Drawing.Point(15, 350); this.lblRegNo.AutoSize = true; this.lblRegNo.Name = "lblRegNo";
            this.txtRegNo.Location = new System.Drawing.Point(15, 370); this.txtRegNo.Size = new System.Drawing.Size(290, 22); this.txtRegNo.Name = "txtRegNo";

            this.btnSave.Text = "💾 Save"; this.btnSave.BackColor = System.Drawing.Color.FromArgb(27, 94, 32); this.btnSave.ForeColor = System.Drawing.Color.White; this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSave.FlatAppearance.BorderSize = 0; this.btnSave.Size = new System.Drawing.Size(75, 32); this.btnSave.Location = new System.Drawing.Point(15, 415); this.btnSave.Name = "btnSave"; this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnUpdate.Text = "✏️ Update"; this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(21, 101, 192); this.btnUpdate.ForeColor = System.Drawing.Color.White; this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnUpdate.FlatAppearance.BorderSize = 0; this.btnUpdate.Size = new System.Drawing.Size(75, 32); this.btnUpdate.Location = new System.Drawing.Point(95, 415); this.btnUpdate.Name = "btnUpdate"; this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnDelete.Text = "🗑️ Delete"; this.btnDelete.BackColor = System.Drawing.Color.FromArgb(183, 28, 28); this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnDelete.FlatAppearance.BorderSize = 0; this.btnDelete.Size = new System.Drawing.Size(75, 32); this.btnDelete.Location = new System.Drawing.Point(175, 415); this.btnDelete.Name = "btnDelete"; this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Text = "🔄 Clear"; this.btnClear.BackColor = System.Drawing.Color.FromArgb(117, 117, 117); this.btnClear.ForeColor = System.Drawing.Color.White; this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClear.FlatAppearance.BorderSize = 0; this.btnClear.Size = new System.Drawing.Size(75, 32); this.btnClear.Location = new System.Drawing.Point(255, 415); this.btnClear.Name = "btnClear"; this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlRight.BackColor = System.Drawing.Color.White; this.pnlRight.Name = "pnlRight";
            this.pnlRight.Controls.Add(this.dgvPesticide);
            this.pnlRight.Controls.Add(this.pnlSearch);

            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top; this.pnlSearch.Height = 45; this.pnlSearch.BackColor = System.Drawing.Color.WhiteSmoke; this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.btnRefresh);

            this.lblSearch.Text = "🔍 Search:"; this.lblSearch.Location = new System.Drawing.Point(10, 13); this.lblSearch.AutoSize = true; this.lblSearch.Name = "lblSearch";
            this.txtSearch.Location = new System.Drawing.Point(80, 10); this.txtSearch.Size = new System.Drawing.Size(200, 22); this.txtSearch.Name = "txtSearch";
            this.btnSearch.Text = "Search"; this.btnSearch.BackColor = System.Drawing.Color.FromArgb(27, 94, 32); this.btnSearch.ForeColor = System.Drawing.Color.White; this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSearch.Size = new System.Drawing.Size(75, 28); this.btnSearch.Location = new System.Drawing.Point(290, 10); this.btnSearch.Name = "btnSearch"; this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnRefresh.Text = "🔄 All"; this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(69, 90, 100); this.btnRefresh.ForeColor = System.Drawing.Color.White; this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnRefresh.Size = new System.Drawing.Size(60, 28); this.btnRefresh.Location = new System.Drawing.Point(370, 10); this.btnRefresh.Name = "btnRefresh"; this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.dgvPesticide.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvPesticide.BackgroundColor = System.Drawing.Color.White; this.dgvPesticide.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvPesticide.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.dgvPesticide.ReadOnly = true; this.dgvPesticide.AllowUserToAddRows = false; this.dgvPesticide.RowHeadersVisible = false; this.dgvPesticide.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; this.dgvPesticide.Name = "dgvPesticide"; this.dgvPesticide.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesticide_CellClick);

            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Text = "Pesticide Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(241, 248, 233);
            this.Name = "frmPesticide";
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Load += new System.EventHandler(this.frmPesticide_Load);

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesticide)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblFormType;
        private System.Windows.Forms.ComboBox cmbFormType;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblMinStock;
        private System.Windows.Forms.TextBox txtMinStock;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvPesticide;
    }
}