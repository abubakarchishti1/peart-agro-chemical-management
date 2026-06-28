using PeartAgroChemicalsManagementSystem.BLL;
using PeartAgroChemicalsManagementSystem.Helpers;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PeartAgroChemicalsManagementSystem.Forms
{
    public partial class frmDashboard : Form
    {
        StockBLL bll = new StockBLL();
        Timer clockTimer = new Timer();
        private Chart stockChart;

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblUserInfo.Text = "👤 " + AppSession.FullName;
            clockTimer.Interval = 1000;
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
            lblDateTime.Text = "📅 " + DateTime.Now.ToString("dd-MMM-yyyy  hh:mm tt");
            lblUserInfo.Location = new Point(pnlTopBar.Width - lblUserInfo.Width - 15, 15);
            lblDateTime.Location = new Point(pnlTopBar.Width - lblUserInfo.Width - lblDateTime.Width - 30, 15);
            LoadDashboard();
            CreateChart();
            LoadChart();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = "📅 " + DateTime.Now.ToString("dd-MMM-yyyy  hh:mm tt");
            lblDateTime.Location = new Point(pnlTopBar.Width - lblUserInfo.Width - lblDateTime.Width - 30, 15);
        }

        private void LoadDashboard()
        {
            try
            {
                lblTotal.Text = bll.GetTotalProducts().ToString();
                lbllowstock.Text = bll.GetLowStockCount().ToString();
                lblExpired.Text = bll.GetExpiredCount().ToString();
                lblSupplier.Text = GetSupplierCount().ToString();
                dgvStock.DataSource = bll.GetAllPesticides();
                StyleGrid();
                if (stockChart != null) LoadChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data load error: " + ex.Message);
            }
        }

        private int GetSupplierCount()
        {
            string q = "SELECT COUNT(*) FROM Suppliers";
            return Convert.ToInt32(DAL.DBHelper.ExecuteScalar(q));
        }

        private void StyleGrid()
        {
            dgvStock.EnableHeadersVisualStyles = false;
            dgvStock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 94, 32);
            dgvStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStock.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvStock.ColumnHeadersHeight = 35;
            dgvStock.RowTemplate.Height = 30;
            dgvStock.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233);
            dgvStock.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 125, 50);
            dgvStock.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void CreateChart()
        {
            stockChart = new Chart();
            stockChart.BackColor = Color.White;

            ChartArea chartArea = new ChartArea();
            chartArea.BackColor = Color.White;
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 7F);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 7F);
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);
            stockChart.ChartAreas.Add(chartArea);

            Legend legend = new Legend();
            legend.Font = new Font("Segoe UI", 8F);
            legend.BackColor = Color.Transparent;
            stockChart.Legends.Add(legend);

            Series seriesStock = new Series("Stock Qty");
            seriesStock.ChartType = SeriesChartType.Column;
            seriesStock.Color = Color.FromArgb(46, 125, 50);
            stockChart.Series.Add(seriesStock);

            Series seriesMin = new Series("Min Level");
            seriesMin.ChartType = SeriesChartType.Column;
            seriesMin.Color = Color.FromArgb(230, 81, 0);
            stockChart.Series.Add(seriesMin);

            stockChart.Dock = DockStyle.Fill;
            pnlChartArea.Controls.Add(stockChart);
        }

        private void LoadChart()
        {
            try
            {
                string query = @"SELECT ProductName, StockQty, MinStockLevel 
                                FROM Pesticides ORDER BY StockQty ASC LIMIT 8";
                DataTable dt = DAL.DBHelper.ExecuteQuery(query);

                stockChart.Series["Stock Qty"].Points.Clear();
                stockChart.Series["Min Level"].Points.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    stockChart.Series["Stock Qty"].Points.AddXY(
                        row["ProductName"].ToString(), Convert.ToInt32(row["StockQty"]));
                    stockChart.Series["Min Level"].Points.AddXY(
                        row["ProductName"].ToString(), Convert.ToInt32(row["MinStockLevel"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chart error: " + ex.Message);
            }
        }

        private void frmDashboard_Resize(object sender, EventArgs e)
        {
            lblUserInfo.Location = new Point(pnlTopBar.Width - lblUserInfo.Width - 15, 15);
            lblDateTime.Location = new Point(pnlTopBar.Width - lblUserInfo.Width - lblDateTime.Width - 30, 15);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout karna chahte hain?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AppSession.Clear();
                clockTimer.Stop();
                frmLogin login = new frmLogin();
                login.Show();
                this.Close();
            }
        }

        private void btnNavPesticide_Click(object sender, EventArgs e)
        { new frmPesticide().ShowDialog(); LoadDashboard(); }

        private void btnNavStockIn_Click(object sender, EventArgs e)
        { new frmStockIn().ShowDialog(); LoadDashboard(); }

        private void btnNavStockOut_Click(object sender, EventArgs e)
        { new frmStockOut().ShowDialog(); LoadDashboard(); }

        private void btnNavSupplier_Click(object sender, EventArgs e)
        { new frmSupplier().ShowDialog(); LoadDashboard(); }

        private void btnNavReport_Click(object sender, EventArgs e)
        { new frmReport().ShowDialog(); }

        private void btnDashboard_Click(object sender, EventArgs e)
        { LoadDashboard(); }

        private void btnStock_Click(object sender, EventArgs e)
        { new frmStockIn().ShowDialog(); LoadDashboard(); }

        private void btnMaster_Click(object sender, EventArgs e)
        { new frmPesticide().ShowDialog(); LoadDashboard(); }

        private void btnReports_Click(object sender, EventArgs e)
        { new frmReport().ShowDialog(); }
    }
}