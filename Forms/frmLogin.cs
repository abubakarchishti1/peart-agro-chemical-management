using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PeartAgroChemicalsManagementSystem.DAL;
using PeartAgroChemicalsManagementSystem.Helpers;
using PeartAgroChemicalsManagementSystem.Forms;

namespace PeartAgroChemicalsManagementSystem.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           // Panel center karo
            pnlLogin.Left = (this.ClientSize.Width - pnlLogin.Width) / 2;
            pnlLogin.Top = (this.ClientSize.Height - pnlLogin.Height) / 2;

            txtUsername.Focus();
            InsertDefaultAdmin();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username daalen!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password daalen!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Database se check karo
            string query = @"SELECT UserID, FullName, Role 
                             FROM Users 
                             WHERE Username = @user 
                             AND Password = @pass 
                             AND IsActive = 1";

            MySqlParameter[] prms = {
                new MySqlParameter("@user", username),
                new MySqlParameter("@pass", password)
            };

            DataTable dt = DBHelper.ExecuteQuery(query, prms);

            if (dt.Rows.Count > 0)
            {
                // Session mein save karo
                AppSession.UserID = Convert.ToInt32(dt.Rows[0]["UserID"]);
                AppSession.FullName = dt.Rows[0]["FullName"].ToString();
                AppSession.Username = username;
                AppSession.Role = dt.Rows[0]["Role"].ToString();

                // Dashboard open karo
                frmDashboard dashboard = new frmDashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username ya Password galat hai!",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        // Enter key se bhi login ho
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin_Click(sender, e);
        }

        // Default Admin insert karo pehli baar
        private void InsertDefaultAdmin()
        {
            try
            {
                string check = "SELECT COUNT(*) FROM Users WHERE Username = 'admin'";
                int count = Convert.ToInt32(DBHelper.ExecuteScalar(check));

                if (count == 0)
                {
                    string insert = @"INSERT INTO Users 
                        (Username, Password, FullName, Role, IsActive)
                        VALUES ('admin', 'admin123', 'Administrator', 'Admin', 1)";
                    DBHelper.ExecuteNonQuery(insert);
                }
            }
            catch { }
        }

        // App band ho jab login close ho
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}