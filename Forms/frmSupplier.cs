using MySql.Data.MySqlClient;
using PeartAgroChemicalsManagementSystem.DAL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PeartAgroChemicalsManagementSystem.Forms
{
    public partial class frmSupplier : Form
    {
        int selectedID = 0;

        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadSuppliers()
        {
            dgvSupplier.DataSource = DBHelper.ExecuteQuery(
                "SELECT SupplierID, SupplierName, Phone, Address, City FROM Suppliers ORDER BY SupplierName");
            StyleGrid();
        }

        private void StyleGrid()
        {
            dgvSupplier.EnableHeadersVisualStyles = false;
            dgvSupplier.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 71, 161);
            dgvSupplier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSupplier.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvSupplier.ColumnHeadersHeight = 32;
            dgvSupplier.RowTemplate.Height = 28;
            dgvSupplier.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(227, 242, 253);
            dgvSupplier.DefaultCellStyle.SelectionBackColor = Color.FromArgb(13, 71, 161);
            dgvSupplier.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            { MessageBox.Show("Supplier Name daalen!"); return; }

            try
            {
                MySqlParameter[] p = {
                    new MySqlParameter("@name",    txtName.Text.Trim()),
                    new MySqlParameter("@phone",   txtPhone.Text.Trim()),
                    new MySqlParameter("@address", txtAddress.Text.Trim()),
                    new MySqlParameter("@city",    txtCity.Text.Trim())
                };
                DBHelper.ExecuteNonQuery(@"INSERT INTO Suppliers 
                    (SupplierName, Phone, Address, City)
                    VALUES(@name, @phone, @address, @city)", p);

                MessageBox.Show("Supplier saved!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadSuppliers();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0) return;
            try
            {
                MySqlParameter[] p = {
                    new MySqlParameter("@name",    txtName.Text.Trim()),
                    new MySqlParameter("@phone",   txtPhone.Text.Trim()),
                    new MySqlParameter("@address", txtAddress.Text.Trim()),
                    new MySqlParameter("@city",    txtCity.Text.Trim()),
                    new MySqlParameter("@id",      selectedID)
                };
                DBHelper.ExecuteNonQuery(@"UPDATE Suppliers SET
                    SupplierName=@name, Phone=@phone, Address=@address, City=@city
                    WHERE SupplierID=@id", p);

                MessageBox.Show("Updated!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadSuppliers();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0) return;
            if (MessageBox.Show("Delete karna chahte hain?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DBHelper.ExecuteNonQuery("DELETE FROM Suppliers WHERE SupplierID=@id",
                        new[] { new MySqlParameter("@id", selectedID) });
                    MessageBox.Show("Deleted!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadSuppliers();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearForm();

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvSupplier.Rows[e.RowIndex];
            selectedID = Convert.ToInt32(row.Cells["SupplierID"].Value);
            txtName.Text = row.Cells["SupplierName"].Value.ToString();
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
            txtCity.Text = row.Cells["City"].Value.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }

        private void ClearForm()
        {
            selectedID = 0;
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}