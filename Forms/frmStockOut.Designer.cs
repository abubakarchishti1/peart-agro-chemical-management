namespace PeartAgroChemicalsManagementSystem.Forms
{
    partial class frmStockOut
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
            this.lblPesticide = new System.Windows.Forms.Label();
            this.cmbPesticide = new System.Windows.Forms.ComboBox();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblHistory = new System.Windows.Forms.Label();
            this.dgvStockOut = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOut)).BeginInit();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(183, 28, 28);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(900, 45);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Controls.Add(this.lblTitle);

            this.lblTitle.Text = "📤 Stock Out — Sale / Issue";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";

            // pnlLeft
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Width = 340;
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Controls.Add(this.lblPesticide);
            this.pnlLeft.Controls.Add(this.cmbPesticide);
            this.pnlLeft.Controls.Add(this.lblCurrentStock);
            this.pnlLeft.Controls.Add(this.lblQuantity);
            this.pnlLeft.Controls.Add(this.txtQuantity);
            this.pnlLeft.Controls.Add(this.lblUnitPrice);
            this.pnlLeft.Controls.Add(this.txtUnitPrice);
            this.pnlLeft.Controls.Add(this.lblTotal);
            this.pnlLeft.Controls.Add(this.lblCustomer);
            this.pnlLeft.Controls.Add(this.txtCustomer);
            this.pnlLeft.Controls.Add(this.lblRemarks);
            this.pnlLeft.Controls.Add(this.txtRemarks);
            this.pnlLeft.Controls.Add(this.btnSave);
            this.pnlLeft.Controls.Add(this.btnClear);

            this.lblPesticide.Text = "Select Pesticide *"; this.lblPesticide.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblPesticide.Location = new System.Drawing.Point(15, 20); this.lblPesticide.AutoSize = true; this.lblPesticide.Name = "lblPesticide";
            this.cmbPesticide.Location = new System.Drawing.Point(15, 40); this.cmbPesticide.Size = new System.Drawing.Size(300, 22); this.cmbPesticide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbPesticide.Name = "cmbPesticide"; this.cmbPesticide.SelectedIndexChanged += new System.EventHandler(this.cmbPesticide_SelectedIndexChanged);

            this.lblCurrentStock.Text = "Available Stock: -"; this.lblCurrentStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblCurrentStock.ForeColor = System.Drawing.Color.FromArgb(183, 28, 28); this.lblCurrentStock.Location = new System.Drawing.Point(15, 68); this.lblCurrentStock.AutoSize = true; this.lblCurrentStock.Name = "lblCurrentStock";

            this.lblQuantity.Text = "Quantity *"; this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblQuantity.Location = new System.Drawing.Point(15, 100); this.lblQuantity.AutoSize = true; this.lblQuantity.Name = "lblQuantity";
            this.txtQuantity.Location = new System.Drawing.Point(15, 120); this.txtQuantity.Size = new System.Drawing.Size(140, 22); this.txtQuantity.Name = "txtQuantity"; this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);

            this.lblUnitPrice.Text = "Unit Price (Rs) *"; this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblUnitPrice.Location = new System.Drawing.Point(170, 100); this.lblUnitPrice.AutoSize = true; this.lblUnitPrice.Name = "lblUnitPrice";
            this.txtUnitPrice.Location = new System.Drawing.Point(170, 120); this.txtUnitPrice.Size = new System.Drawing.Size(140, 22); this.txtUnitPrice.Name = "txtUnitPrice"; this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);

            this.lblTotal.Text = "Total: Rs. 0"; this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold); this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(183, 28, 28); this.lblTotal.Location = new System.Drawing.Point(15, 155); this.lblTotal.AutoSize = true; this.lblTotal.Name = "lblTotal";

            this.lblCustomer.Text = "Customer Name *"; this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblCustomer.Location = new System.Drawing.Point(15, 190); this.lblCustomer.AutoSize = true; this.lblCustomer.Name = "lblCustomer";
            this.txtCustomer.Location = new System.Drawing.Point(15, 210); this.txtCustomer.Size = new System.Drawing.Size(300, 22); this.txtCustomer.Name = "txtCustomer";

            this.lblRemarks.Text = "Remarks"; this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblRemarks.Location = new System.Drawing.Point(15, 245); this.lblRemarks.AutoSize = true; this.lblRemarks.Name = "lblRemarks";
            this.txtRemarks.Location = new System.Drawing.Point(15, 265); this.txtRemarks.Size = new System.Drawing.Size(300, 55); this.txtRemarks.Multiline = true; this.txtRemarks.Name = "txtRemarks";

            this.btnSave.Text = "💾 Save Stock Out"; this.btnSave.BackColor = System.Drawing.Color.FromArgb(183, 28, 28); this.btnSave.ForeColor = System.Drawing.Color.White; this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSave.FlatAppearance.BorderSize = 0; this.btnSave.Size = new System.Drawing.Size(145, 35); this.btnSave.Location = new System.Drawing.Point(15, 335); this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnSave.Name = "btnSave"; this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnClear.Text = "🔄 Clear"; this.btnClear.BackColor = System.Drawing.Color.FromArgb(117, 117, 117); this.btnClear.ForeColor = System.Drawing.Color.White; this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnClear.FlatAppearance.BorderSize = 0; this.btnClear.Size = new System.Drawing.Size(145, 35); this.btnClear.Location = new System.Drawing.Point(170, 335); this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F); this.btnClear.Name = "btnClear"; this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // pnlRight
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill; this.pnlRight.BackColor = System.Drawing.Color.White; this.pnlRight.Name = "pnlRight";
            this.pnlRight.Controls.Add(this.dgvStockOut);
            this.pnlRight.Controls.Add(this.lblHistory);

            this.lblHistory.Text = "📋 Stock Out History"; this.lblHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.lblHistory.ForeColor = System.Drawing.Color.FromArgb(183, 28, 28); this.lblHistory.Dock = System.Windows.Forms.DockStyle.Top; this.lblHistory.Height = 35; this.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; this.lblHistory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0); this.lblHistory.Name = "lblHistory";

            this.dgvStockOut.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvStockOut.BackgroundColor = System.Drawing.Color.White; this.dgvStockOut.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvStockOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.dgvStockOut.ReadOnly = true; this.dgvStockOut.AllowUserToAddRows = false; this.dgvStockOut.RowHeadersVisible = false; this.dgvStockOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; this.dgvStockOut.Name = "dgvStockOut";

            // frmStockOut
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Text = "Stock Out";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(241, 248, 233);
            this.Name = "frmStockOut";
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Load += new System.EventHandler(this.frmStockOut_Load);

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockOut)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblPesticide;
        private System.Windows.Forms.ComboBox cmbPesticide;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridView dgvStockOut;
    }
}