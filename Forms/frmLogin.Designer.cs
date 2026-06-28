namespace PeartAgroChemicalsManagementSystem.Forms
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();

            // pnlLogin
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Size = new System.Drawing.Size(380, 300);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Controls.Add(this.lblTitle);
            this.pnlLogin.Controls.Add(this.lblSub);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);

            // lblTitle
            this.lblTitle.Text = "Peart Agro Chemicals";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(27, 94, 32);
            this.lblTitle.AutoSize = false;
            this.lblTitle.Size = new System.Drawing.Size(280, 35);
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Name = "lblTitle";

            // lblSub
            this.lblSub.Text = "Management System";
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSub.ForeColor = System.Drawing.Color.Gray;
            this.lblSub.AutoSize = false;
            this.lblSub.Size = new System.Drawing.Size(280, 20);
            this.lblSub.Location = new System.Drawing.Point(50, 58);
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSub.Name = "lblSub";

            // lblUsername
            this.lblUsername.Text = "Username";
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.AutoSize = false;
            this.lblUsername.Size = new System.Drawing.Size(280, 18);
            this.lblUsername.Location = new System.Drawing.Point(50, 95);
            this.lblUsername.Name = "lblUsername";

            // txtUsername
            this.txtUsername.Size = new System.Drawing.Size(280, 22);
            this.txtUsername.Location = new System.Drawing.Point(50, 115);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Name = "txtUsername";

            // lblPassword
            this.lblPassword.Text = "Password";
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.AutoSize = false;
            this.lblPassword.Size = new System.Drawing.Size(280, 18);
            this.lblPassword.Location = new System.Drawing.Point(50, 155);
            this.lblPassword.Name = "lblPassword";

            // txtPassword
            this.txtPassword.Size = new System.Drawing.Size(280, 22);
            this.txtPassword.Location = new System.Drawing.Point(50, 175);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);

            // btnLogin
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Size = new System.Drawing.Size(280, 40);
            this.btnLogin.Location = new System.Drawing.Point(50, 225);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // frmLogin
            this.ClientSize = new System.Drawing.Size(480, 380);
            this.Text = "Peart Agro Chemicals Management System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(27, 94, 32);
            this.Name = "frmLogin";
            this.Controls.Add(this.pnlLogin);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);

            this.pnlLogin.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}