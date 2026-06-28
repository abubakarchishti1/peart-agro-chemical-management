using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PeartAgroChemicalsManagementSystem.DAL;

namespace PeartAgroChemicalsManagementSystem.Forms
{
    public partial class frmStockIn : Form
    {
        public frmStockIn()
        {
            InitializeComponent();
        }

        private void frmStockIn_Load(object sender, EventArgs e)
        {
            LoadPesticides();
            LoadSuppliers();
            LoadHistory();
        }

        private void LoadPesticides()
        {
            DataTable dt = DBHelper.ExecuteQuery(
                "SELECT PesticideID, ProductName FROM Pesticides ORDER BY ProductName");
            cmbPesticide.DataSource = dt;
            cmbPesticide.DisplayMember = "ProductName";
            cmbPesticide.ValueMember = "PesticideID";
            cmbPesticide.SelectedIndex = -1;
        }

        private void LoadSuppliers()
        {
            DataTable dt = DBHelper.ExecuteQuery(
                "SELECT SupplierID, SupplierName FROM Suppliers ORDER BY SupplierName");
            cmbSupplier.DataSource = dt;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierID";
            cmbSupplier.SelectedIndex = -1;
        }

        private void LoadHistory()
        {
            string query = @"SELECT si.StockInID, p.ProductName,
                            s.SupplierName, si.Quantity, si.UnitCost,
                            si.TotalCost, si.StockInDate
                            FROM StockIn si
                            JOIN Pesticides p ON si.PesticideID = p.PesticideID
                            JOIN Suppliers s  ON si.SupplierID  = s.SupplierID
                            ORDER BY si.StockInDate DESC";
            dgvStockIn.DataSource = DBHelper.ExecuteQuery(query);
            StyleGrid();
        }

        private void StyleGrid()
        {
            dgvStockIn.EnableHeadersVisualStyles = false;
            dgvStockIn.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 94, 32);
            dgvStockIn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStockIn.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvStockIn.ColumnHeadersHeight = 32;
            dgvStockIn.RowTemplate.Height = 28;
            dgvStockIn.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233);
        }

        private void cmbPesticide_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPesticide.SelectedIndex == -1) return;
            // Current stock show karo
            string query = "SELECT StockQty FROM Pesticides WHERE PesticideID = @id";
            MySqlParameter[] p = { new MySqlParameter("@id", cmbPesticide.SelectedValue) };
            object result = DBHelper.ExecuteScalar(query, p);
         
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtUnitCost_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            try
            {
                int qty = string.IsNullOrEmpty(txtQuantity.Text) ? 0 : int.Parse(txtQuantity.Text);
                decimal cost = string.IsNullOrEmpty(txtUnitCost.Text) ? 0 : decimal.Parse(txtUnitCost.Text);
                lblTotal.Text = "Total: Rs. " + (qty * cost).ToString("N0");
            }
            catch { lblTotal.Text = "Total: Rs. 0"; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (cmbPesticide.SelectedIndex == -1)
            { MessageBox.Show("Pesticide select karein!"); return; }
            if (cmbSupplier.SelectedIndex == -1)
            { MessageBox.Show("Supplier select karein!"); return; }
            if (string.IsNullOrEmpty(txtQuantity.Text))
            { MessageBox.Show("Quantity daalen!"); return; }
            if (string.IsNullOrEmpty(txtUnitCost.Text))
            { MessageBox.Show("Unit Cost daalen!"); return; }

            try
            {
                int qty = int.Parse(txtQuantity.Text);
                decimal unitCost = decimal.Parse(txtUnitCost.Text);
                decimal total = qty * unitCost;

                MySqlParameter[] prms = {
                    new MySqlParameter("@pid",  cmbPesticide.SelectedValue),
                    new MySqlParameter("@sid",  cmbSupplier.SelectedValue),
                    new MySqlParameter("@qty",  qty),
                    new MySqlParameter("@cost", unitCost),
                    new MySqlParameter("@tot",  total),
                    new MySqlParameter("@rem",  txtRemarks.Text.Trim())
                };

                // StockIn table mein insert
                DBHelper.ExecuteNonQuery(@"INSERT INTO StockIn
                    (PesticideID,SupplierID,Quantity,UnitCost,TotalCost,Remarks)
                    VALUES(@pid,@sid,@qty,@cost,@tot,@rem)", prms);

                // Pesticide stock update
                DBHelper.ExecuteNonQuery(@"UPDATE Pesticides 
                    SET StockQty = StockQty + @qty 
                    WHERE PesticideID = @pid",
                    new[] {
                        new MySqlParameter("@qty", qty),
                        new MySqlParameter("@pid", cmbPesticide.SelectedValue)
                    });

                MessageBox.Show("Stock In saved!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadHistory();
                // Stock refresh
                cmbPesticide_SelectedIndexChanged(sender, e);
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
            cmbSupplier.SelectedIndex = -1;
            txtQuantity.Clear();
            txtUnitCost.Clear();
            txtRemarks.Clear();
            lblCurrentStock.Text = "Current Stock: -";
            lblTotal.Text = "Total: Rs. 0";
        }
    }
}