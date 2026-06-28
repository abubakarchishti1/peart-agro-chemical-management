namespace PeartAgroChemicalsManagementSystem.Forms
{
    partial class frmReport
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();

            this.pnlTop.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(27, 94, 32);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 45;
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Controls.Add(this.lblTitle);

            this.lblTitle.Text = "📊 Stock Reports";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";

            // pnlFilter
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Height = 55;
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Controls.Add(this.lblType);
            this.pnlFilter.Controls.Add(this.cmbReportType);
            this.pnlFilter.Controls.Add(this.lblFrom);
            this.pnlFilter.Controls.Add(this.dtpFrom);
            this.pnlFilter.Controls.Add(this.lblTo);
            this.pnlFilter.Controls.Add(this.dtpTo);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.btnPrint);

            this.lblType.Text = "Report Type:"; this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblType.Location = new System.Drawing.Point(10, 18); this.lblType.AutoSize = true; this.lblType.Name = "lblType";
            this.cmbReportType.Location = new System.Drawing.Point(100, 14); this.cmbReportType.Size = new System.Drawing.Size(170, 22); this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbReportType.Name = "cmbReportType"; this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);

            this.lblFrom.Text = "From:"; this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblFrom.Location = new System.Drawing.Point(285, 18); this.lblFrom.AutoSize = true; this.lblFrom.Name = "lblFrom";
            this.dtpFrom.Location = new System.Drawing.Point(325, 14); this.dtpFrom.Size = new System.Drawing.Size(120, 22); this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpFrom.Value = System.DateTime.Today.AddMonths(-1); this.dtpFrom.Name = "dtpFrom";

            this.lblTo.Text = "To:"; this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold); this.lblTo.Location = new System.Drawing.Point(455, 18); this.lblTo.AutoSize = true; this.lblTo.Name = "lblTo";
            this.dtpTo.Location = new System.Drawing.Point(475, 14); this.dtpTo.Size = new System.Drawing.Size(120, 22); this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short; this.dtpTo.Value = System.DateTime.Today; this.dtpTo.Name = "dtpTo";

            this.btnFilter.Text = "🔍 Filter"; this.btnFilter.BackColor = System.Drawing.Color.FromArgb(27, 94, 32); this.btnFilter.ForeColor = System.Drawing.Color.White; this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnFilter.FlatAppearance.BorderSize = 0; this.btnFilter.Size = new System.Drawing.Size(80, 28); this.btnFilter.Location = new System.Drawing.Point(610, 13); this.btnFilter.Name = "btnFilter"; this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);

            this.btnPrint.Text = "🖨️ Print"; this.btnPrint.BackColor = System.Drawing.Color.FromArgb(69, 90, 100); this.btnPrint.ForeColor = System.Drawing.Color.White; this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnPrint.FlatAppearance.BorderSize = 0; this.btnPrint.Size = new System.Drawing.Size(80, 28); this.btnPrint.Location = new System.Drawing.Point(700, 13); this.btnPrint.Name = "btnPrint"; this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Controls.Add(this.dgvReport);
            this.pnlContent.Controls.Add(this.pnlInfo);

            // pnlInfo
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Height = 38;
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Controls.Add(this.lblReportTitle);
            this.pnlInfo.Controls.Add(this.lblCount);

            this.lblReportTitle.Text = "📦 All Stock Report"; this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.lblReportTitle.ForeColor = System.Drawing.Color.FromArgb(27, 94, 32); this.lblReportTitle.Location = new System.Drawing.Point(10, 10); this.lblReportTitle.AutoSize = true; this.lblReportTitle.Name = "lblReportTitle";
            this.lblCount.Text = "Total Records: 0"; this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9F); this.lblCount.ForeColor = System.Drawing.Color.Gray; this.lblCount.Location = new System.Drawing.Point(700, 12); this.lblCount.AutoSize = true; this.lblCount.Name = "lblCount";

            // dgvReport
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvReport.BackgroundColor = System.Drawing.Color.White; this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.dgvReport.ReadOnly = true; this.dgvReport.AllowUserToAddRows = false; this.dgvReport.RowHeadersVisible = false; this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; this.dgvReport.Name = "dgvReport";

            // frmReport
            this.ClientSize = new System.Drawing.Size(950, 580);
            this.Text = "Stock Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "frmReport";
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlTop);
            this.Load += new System.EventHandler(this.frmReport_Load);

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvReport;
    }
}