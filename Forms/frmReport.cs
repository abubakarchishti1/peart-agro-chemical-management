using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PeartAgroChemicalsManagementSystem.DAL;

namespace PeartAgroChemicalsManagementSystem.Forms
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            cmbReportType.Items.AddRange(new string[] {
                "All Stock",
                "Low Stock Alert",
                "Expired Products",
                "Stock In History",
                "Stock Out History"
            });
            cmbReportType.SelectedIndex = 0;
            LoadReport();
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            string query = "";
            string title = "";

            switch (cmbReportType.SelectedIndex)
            {
                case 0: // All Stock
                    title = "📦 All Stock Report";
                    query = @"SELECT p.PesticideID, p.ProductName, c.CategoryName,
                              p.Company, p.FormType, p.UnitPrice,
                              p.StockQty, p.MinStockLevel, p.ExpiryDate
                              FROM Pesticides p
                              LEFT JOIN Categories c ON p.CategoryID = c.CategoryID
                              ORDER BY p.ProductName";
                    StyleGrid(Color.FromArgb(27, 94, 32));
                    break;

                case 1: // Low Stock
                    title = "⚠️ Low Stock Alert";
                    query = @"SELECT p.ProductName, c.CategoryName,
                              p.StockQty AS CurrentStock,
                              p.MinStockLevel AS MinRequired,
                              (p.MinStockLevel - p.StockQty) AS ShortageQty
                              FROM Pesticides p
                              LEFT JOIN Categories c ON p.CategoryID = c.CategoryID
                              WHERE p.StockQty <= p.MinStockLevel
                              ORDER BY p.StockQty ASC";
                    StyleGrid(Color.FromArgb(230, 81, 0));
                    break;

                case 2: // Expired
                    title = "❌ Expired Products";
                    query = @"SELECT p.ProductName, c.CategoryName,
                              p.Company, p.StockQty, p.ExpiryDate,
                              DATEDIFF(CURDATE(), p.ExpiryDate) AS DaysExpired
                              FROM Pesticides p
                              LEFT JOIN Categories c ON p.CategoryID = c.CategoryID
                              WHERE p.ExpiryDate < CURDATE()
                              ORDER BY p.ExpiryDate ASC";
                    StyleGrid(Color.FromArgb(183, 28, 28));
                    break;

                case 3: // Stock In History
                    title = "📥 Stock In History";
                    query = @"SELECT si.StockInID, p.ProductName,
                              s.SupplierName, si.Quantity,
                              si.UnitCost, si.TotalCost, si.StockInDate
                              FROM StockIn si
                              JOIN Pesticides p ON si.PesticideID = p.PesticideID
                              JOIN Suppliers s  ON si.SupplierID  = s.SupplierID
                              ORDER BY si.StockInDate DESC";
                    StyleGrid(Color.FromArgb(13, 71, 161));
                    break;

                case 4: // Stock Out History
                    title = "📤 Stock Out History";
                    query = @"SELECT so.StockOutID, p.ProductName,
                              so.Quantity, so.UnitPrice, so.TotalAmount,
                              so.CustomerName, so.StockOutDate
                              FROM StockOut so
                              JOIN Pesticides p ON so.PesticideID = p.PesticideID
                              ORDER BY so.StockOutDate DESC";
                    StyleGrid(Color.FromArgb(74, 20, 140));
                    break;
            }

            lblReportTitle.Text = title;

            // Date filter apply karo agar Stock In/Out hai
            if (cmbReportType.SelectedIndex >= 3)
            {
                query += " AND DATE(" +
                    (cmbReportType.SelectedIndex == 3 ? "si.StockInDate" : "so.StockOutDate") +
                    ") BETWEEN @from AND @to";

                MySqlParameter[] p = {
                    new MySqlParameter("@from", dtpFrom.Value.Date),
                    new MySqlParameter("@to",   dtpTo.Value.Date)
                };
                try { dgvReport.DataSource = DBHelper.ExecuteQuery(query, p); }
                catch
                {
                    dgvReport.DataSource = DBHelper.ExecuteQuery(
                    query.Replace(" AND DATE(" + (cmbReportType.SelectedIndex == 3 ?
                    "si.StockInDate" : "so.StockOutDate") + ") BETWEEN @from AND @to", ""));
                }
            }
            else
            {
                dgvReport.DataSource = DBHelper.ExecuteQuery(query);
            }

            lblCount.Text = "Total Records: " + dgvReport.Rows.Count;
        }

        private void StyleGrid(Color headerColor)
        {
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReport.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvReport.ColumnHeadersHeight = 35;
            dgvReport.RowTemplate.Height = 28;
            dgvReport.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvReport.DefaultCellStyle.SelectionBackColor = headerColor;
            dgvReport.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print feature coming soon!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}