using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PeartAgroChemicalsManagementSystem.DAL;
using PeartAgroChemicalsManagementSystem.BLL;

namespace PeartAgroChemicalsManagementSystem.Forms
{
    public partial class frmPesticide : Form
    {
        StockBLL bll = new StockBLL();
        int selectedID = 0;

        public frmPesticide()
        {
            InitializeComponent();
        }

        private void frmPesticide_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadFormTypes();
            LoadPesticides();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadCategories()
        {
            DataTable dt = DBHelper.ExecuteQuery(
                "SELECT CategoryID, CategoryName FROM Categories");
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = -1;
        }

        private void LoadFormTypes()
        {
            cmbFormType.Items.AddRange(new string[] {
                "Liquid","Powder","Granule","Tablet","Emulsion","Other"});
            cmbFormType.SelectedIndex = -1;
        }

        private void LoadPesticides()
        {
            dgvPesticide.DataSource = bll.GetAllPesticides();
            StyleGrid();
        }

        private void StyleGrid()
        {
            dgvPesticide.EnableHeadersVisualStyles = false;
            dgvPesticide.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 94, 32);
            dgvPesticide.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPesticide.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvPesticide.ColumnHeadersHeight = 32;
            dgvPesticide.RowTemplate.Height = 28;
            dgvPesticide.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text.Trim()))
            { MessageBox.Show("Product Name daalen!"); return; }
            if (cmbCategory.SelectedIndex == -1)
            { MessageBox.Show("Category select karein!"); return; }
            if (string.IsNullOrEmpty(txtUnitPrice.Text.Trim()))
            { MessageBox.Show("Unit Price daalen!"); return; }

            try
            {
                MySqlParameter[] p = {
                    new MySqlParameter("@name",   txtProductName.Text.Trim()),
                    new MySqlParameter("@cat",    cmbCategory.SelectedValue),
                    new MySqlParameter("@comp",   txtCompany.Text.Trim()),
                    new MySqlParameter("@form",   cmbFormType.SelectedIndex >= 0 ? cmbFormType.SelectedItem.ToString() : ""),
                    new MySqlParameter("@price",  decimal.Parse(txtUnitPrice.Text)),
                    new MySqlParameter("@min",    string.IsNullOrEmpty(txtMinStock.Text) ? 10 : int.Parse(txtMinStock.Text)),
                    new MySqlParameter("@expiry", dtpExpiry.Value.Date),
                    new MySqlParameter("@regno",  txtRegNo.Text.Trim())
                };
                DBHelper.ExecuteNonQuery(@"INSERT INTO Pesticides
                    (ProductName,CategoryID,Company,FormType,UnitPrice,
                     StockQty,MinStockLevel,ExpiryDate,RegistrationNo)
                    VALUES(@name,@cat,@comp,@form,@price,0,@min,@expiry,@regno)", p);
                MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); LoadPesticides();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0) return;
            try
            {
                MySqlParameter[] p = {
                    new MySqlParameter("@name",   txtProductName.Text.Trim()),
                    new MySqlParameter("@cat",    cmbCategory.SelectedValue),
                    new MySqlParameter("@comp",   txtCompany.Text.Trim()),
                    new MySqlParameter("@form",   cmbFormType.SelectedIndex >= 0 ? cmbFormType.SelectedItem.ToString() : ""),
                    new MySqlParameter("@price",  decimal.Parse(txtUnitPrice.Text)),
                    new MySqlParameter("@min",    string.IsNullOrEmpty(txtMinStock.Text) ? 10 : int.Parse(txtMinStock.Text)),
                    new MySqlParameter("@expiry", dtpExpiry.Value.Date),
                    new MySqlParameter("@regno",  txtRegNo.Text.Trim()),
                    new MySqlParameter("@id",     selectedID)
                };
                DBHelper.ExecuteNonQuery(@"UPDATE Pesticides SET
                    ProductName=@name,CategoryID=@cat,Company=@comp,
                    FormType=@form,UnitPrice=@price,MinStockLevel=@min,
                    ExpiryDate=@expiry,RegistrationNo=@regno
                    WHERE PesticideID=@id", p);
                MessageBox.Show("Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); LoadPesticides();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0) return;
            if (MessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DBHelper.ExecuteNonQuery("DELETE FROM Pesticides WHERE PesticideID=@id",
                        new[] { new MySqlParameter("@id", selectedID) });
                    MessageBox.Show("Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(); LoadPesticides();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearForm();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(kw)) { LoadPesticides(); return; }
            dgvPesticide.DataSource = DBHelper.ExecuteQuery(
                @"SELECT p.PesticideID,p.ProductName,p.CategoryID,c.CategoryName,
                  p.Company,p.FormType,p.UnitPrice,p.StockQty,p.MinStockLevel,
                  p.ExpiryDate,p.RegistrationNo FROM Pesticides p
                  LEFT JOIN Categories c ON p.CategoryID=c.CategoryID
                  WHERE p.ProductName LIKE @kw OR p.Company LIKE @kw",
                new[] { new MySqlParameter("@kw", "%" + kw + "%") });
            StyleGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        { txtSearch.Clear(); LoadPesticides(); }

        private void dgvPesticide_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvPesticide.Rows[e.RowIndex];
            selectedID = Convert.ToInt32(row.Cells["PesticideID"].Value);
            txtProductName.Text = row.Cells["ProductName"].Value.ToString();
            txtCompany.Text = row.Cells["Company"].Value.ToString();
            txtUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
            txtMinStock.Text = row.Cells["MinStockLevel"].Value.ToString();
            txtRegNo.Text = row.Cells["RegistrationNo"].Value.ToString();
            cmbCategory.SelectedValue = row.Cells["CategoryID"].Value;
            cmbFormType.SelectedItem = row.Cells["FormType"].Value.ToString();
            if (row.Cells["ExpiryDate"].Value != DBNull.Value)
                dtpExpiry.Value = Convert.ToDateTime(row.Cells["ExpiryDate"].Value);
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }

        private void ClearForm()
        {
            selectedID = 0;
            txtProductName.Clear(); txtCompany.Clear();
            txtUnitPrice.Clear(); txtMinStock.Clear();
            txtRegNo.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbFormType.SelectedIndex = -1;
            dtpExpiry.Value = DateTime.Today;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}