using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PeartAgroChemicalsManagementSystem.DAL;

namespace PeartAgroChemicalsManagementSystem.Forms
{
    public partial class frmStockOut : Form
    {
        public frmStockOut()
        {
            InitializeComponent();
        }

        private void frmStockOut_Load(object sender, EventArgs e)
        {
            LoadPesticides();
            LoadHistory();
        }

        private void LoadPesticides()
        {
            DataTable dt = DBHelper.ExecuteQuery(
                "SELECT PesticideID, ProductName, StockQty, UnitPrice FROM Pesticides ORDER BY ProductName");
            cmbPesticide.DataSource = dt;
            cmbPesticide.DisplayMember = "ProductName";
            cmbPesticide.ValueMember = "PesticideID";
            cmbPesticide.SelectedIndex = -1;
        }

        private void LoadHistory()
        {
            string query = @"SELECT so.StockOutID, p.ProductName,
                            so.Quantity, so.UnitPrice, so.TotalAmount,
                            so.CustomerName, so.StockOutDate
                            FROM StockOut so
                            JOIN Pesticides p ON so.PesticideID = p.PesticideID
                            ORDER BY so.StockOutDate DESC";
            dgvStockOut.DataSource = DBHelper.ExecuteQuery(query);
            StyleGrid();
        }

        private void StyleGrid()
        {
            dgvStockOut.EnableHeadersVisualStyles = false;
            dgvStockOut.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(183, 28, 28);
            dgvStockOut.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStockOut.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvStockOut.ColumnHeadersHeight = 32;
            dgvStockOut.RowTemplate.Height = 28;
            dgvStockOut.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238);
        }

        private void cmbPesticide_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPesticide.SelectedIndex == -1) return;
            string query = "SELECT StockQty, UnitPrice FROM Pesticides WHERE PesticideID = @id";
            MySqlParameter[] p = { new MySqlParameter("@id", cmbPesticide.SelectedValue) };
            DataTable dt = DBHelper.ExecuteQuery(query, p);
            if (dt.Rows.Count > 0)
            {
                lblCurrentStock.Text = "Available Stock: " + dt.Rows[0]["StockQty"].ToString();
                txtUnitPrice.Text = dt.Rows[0]["UnitPrice"].ToString();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            try
            {
                int qty = string.IsNullOrEmpty(txtQuantity.Text) ? 0 : int.Parse(txtQuantity.Text);
                decimal price = string.IsNullOrEmpty(txtUnitPrice.Text) ? 0 : decimal.Parse(txtUnitPrice.Text);
                lblTotal.Text = "Total: Rs. " + (qty * price).ToString("N0");
            }
            catch { lblTotal.Text = "Total: Rs. 0"; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbPesticide.SelectedIndex == -1)
            { MessageBox.Show("Pesticide select karein!"); return; }
            if (string.IsNullOrEmpty(txtQuantity.Text))
            { MessageBox.Show("Quantity daalen!"); return; }
            if (string.IsNullOrEmpty(txtCustomer.Text.Trim()))
            { MessageBox.Show("Customer Name daalen!"); return; }

            try
            {
                int qty = int.Parse(txtQuantity.Text);

                // Stock check karo
                string chkQ = "SELECT StockQty FROM Pesticides WHERE PesticideID = @id";
                int available = Convert.ToInt32(DBHelper.ExecuteScalar(chkQ,
                    new[] { new MySqlParameter("@id", cmbPesticide.SelectedValue) }));

                if (qty > available)
                {
                    MessageBox.Show("Insufficient stock! Available: " + available, "Stock Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal price = decimal.Parse(txtUnitPrice.Text);
                decimal total = qty * price;

                MySqlParameter[] prms = {
                    new MySqlParameter("@pid",      cmbPesticide.SelectedValue),
                    new MySqlParameter("@qty",      qty),
                    new MySqlParameter("@price",    price),
                    new MySqlParameter("@total",    total),
                    new MySqlParameter("@customer", txtCustomer.Text.Trim()),
                    new MySqlParameter("@rem",      txtRemarks.Text.Trim())
                };

                DBHelper.ExecuteNonQuery(@"INSERT INTO StockOut
                    (PesticideID, Quantity, UnitPrice, TotalAmount, CustomerName, Remarks)
                    VALUES(@pid, @qty, @price, @total, @customer, @rem)", prms);

                // Stock kam karo
                DBHelper.ExecuteNonQuery(@"UPDATE Pesticides 
                    SET StockQty = StockQty - @qty 
                    WHERE PesticideID = @pid",
                    new[] {
                        new MySqlParameter("@qty", qty),
                        new MySqlParameter("@pid", cmbPesticide.SelectedValue)
                    });

                MessageBox.Show("Stock Out saved!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadHistory();
                LoadPesticides();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearForm();

        private void ClearForm()
        {
            cmbPesticide.SelectedIndex = -1;
            txtQuantity.Clear();
            txtUnitPrice.Clear();
            txtCustomer.Clear();
            txtRemarks.Clear();
            lblCurrentStock.Text = "Available Stock: -";
            lblTotal.Text = "Total: Rs. 0";
        }
    }
}