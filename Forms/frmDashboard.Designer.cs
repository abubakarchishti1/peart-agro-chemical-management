namespace PeartAgroChemicalsManagementSystem.Forms
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNavSupplier = new System.Windows.Forms.Button();
            this.btnNavPesticide = new System.Windows.Forms.Button();
            this.lblNav2 = new System.Windows.Forms.Label();
            this.btnNavReport = new System.Windows.Forms.Button();
            this.btnNavStockOut = new System.Windows.Forms.Button();
            this.btnNavStockIn = new System.Windows.Forms.Button();
            this.lblNav1 = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.pnllowstock = new System.Windows.Forms.Panel();
            this.lbllowstock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlExpired = new System.Windows.Forms.Panel();
            this.lblExpired = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.pnlTopBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnllowstock.SuspendLayout();
            this.pnlSupplier.SuspendLayout();
            this.pnlExpired.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.AutoSize = true;
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.pnlTopBar.Controls.Add(this.lblDateTime);
            this.pnlTopBar.Controls.Add(this.lblAppTitle);
            this.pnlTopBar.Controls.Add(this.lblUserInfo);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(800, 36);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.lblDateTime.Location = new System.Drawing.Point(750, 18);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(82, 15);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "📅 Date Time";
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(15, 14);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(383, 22);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "🌿 Peart Agro Chemicals Management System";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.lblUserInfo.Location = new System.Drawing.Point(900, 18);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(60, 15);
            this.lblUserInfo.TabIndex = 0;
            this.lblUserInfo.Text = "👤 Admin";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnReports);
            this.pnlMenu.Controls.Add(this.btnMaster);
            this.pnlMenu.Controls.Add(this.btnStock);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 36);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(800, 35);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(700, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 35);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(320, 0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(100, 35);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "📈 Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnMaster
            // 
            this.btnMaster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaster.FlatAppearance.BorderSize = 0;
            this.btnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMaster.ForeColor = System.Drawing.Color.White;
            this.btnMaster.Location = new System.Drawing.Point(210, 0);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(110, 35);
            this.btnMaster.TabIndex = 2;
            this.btnMaster.Text = "🗂️ Master Data";
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnStock
            // 
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(110, 0);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(100, 35);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "📦 Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(110, 35);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "📊 Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(233)))));
            this.pnlSidebar.Controls.Add(this.btnNavSupplier);
            this.pnlSidebar.Controls.Add(this.btnNavPesticide);
            this.pnlSidebar.Controls.Add(this.lblNav2);
            this.pnlSidebar.Controls.Add(this.btnNavReport);
            this.pnlSidebar.Controls.Add(this.btnNavStockOut);
            this.pnlSidebar.Controls.Add(this.btnNavStockIn);
            this.pnlSidebar.Controls.Add(this.lblNav1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 71);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(170, 379);
            this.pnlSidebar.TabIndex = 2;
            // 
            // btnNavSupplier
            // 
            this.btnNavSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnNavSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSupplier.FlatAppearance.BorderSize = 0;
            this.btnNavSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNavSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnNavSupplier.Location = new System.Drawing.Point(0, 197);
            this.btnNavSupplier.Name = "btnNavSupplier";
            this.btnNavSupplier.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavSupplier.Size = new System.Drawing.Size(170, 32);
            this.btnNavSupplier.TabIndex = 6;
            this.btnNavSupplier.Text = "🚚 Suppliers";
            this.btnNavSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSupplier.UseVisualStyleBackColor = false;
            this.btnNavSupplier.Click += new System.EventHandler(this.btnNavSupplier_Click);
            // 
            // btnNavPesticide
            // 
            this.btnNavPesticide.BackColor = System.Drawing.Color.Transparent;
            this.btnNavPesticide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPesticide.FlatAppearance.BorderSize = 0;
            this.btnNavPesticide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPesticide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNavPesticide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnNavPesticide.Location = new System.Drawing.Point(0, 165);
            this.btnNavPesticide.Name = "btnNavPesticide";
            this.btnNavPesticide.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavPesticide.Size = new System.Drawing.Size(170, 32);
            this.btnNavPesticide.TabIndex = 5;
            this.btnNavPesticide.Text = "🌿 Pesticides";
            this.btnNavPesticide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPesticide.UseVisualStyleBackColor = false;
            this.btnNavPesticide.Click += new System.EventHandler(this.btnNavPesticide_Click);
            // 
            // lblNav2
            // 
            this.lblNav2.BackColor = System.Drawing.Color.Transparent;
            this.lblNav2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblNav2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.lblNav2.Location = new System.Drawing.Point(0, 140);
            this.lblNav2.Name = "lblNav2";
            this.lblNav2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNav2.Size = new System.Drawing.Size(170, 25);
            this.lblNav2.TabIndex = 4;
            this.lblNav2.Text = "MASTER DATA";
            this.lblNav2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNavReport
            // 
            this.btnNavReport.BackColor = System.Drawing.Color.Transparent;
            this.btnNavReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReport.FlatAppearance.BorderSize = 0;
            this.btnNavReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNavReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnNavReport.Location = new System.Drawing.Point(0, 99);
            this.btnNavReport.Name = "btnNavReport";
            this.btnNavReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavReport.Size = new System.Drawing.Size(170, 32);
            this.btnNavReport.TabIndex = 3;
            this.btnNavReport.Text = "📋 Stock Report";
            this.btnNavReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReport.UseVisualStyleBackColor = false;
            this.btnNavReport.Click += new System.EventHandler(this.btnNavReport_Click);
            // 
            // btnNavStockOut
            // 
            this.btnNavStockOut.BackColor = System.Drawing.Color.Transparent;
            this.btnNavStockOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavStockOut.FlatAppearance.BorderSize = 0;
            this.btnNavStockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNavStockOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnNavStockOut.Location = new System.Drawing.Point(0, 67);
            this.btnNavStockOut.Name = "btnNavStockOut";
            this.btnNavStockOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavStockOut.Size = new System.Drawing.Size(170, 32);
            this.btnNavStockOut.TabIndex = 2;
            this.btnNavStockOut.Text = "➖ Stock Out";
            this.btnNavStockOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavStockOut.UseVisualStyleBackColor = false;
            this.btnNavStockOut.Click += new System.EventHandler(this.btnNavStockOut_Click);
            // 
            // btnNavStockIn
            // 
            this.btnNavStockIn.BackColor = System.Drawing.Color.Transparent;
            this.btnNavStockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavStockIn.FlatAppearance.BorderSize = 0;
            this.btnNavStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNavStockIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnNavStockIn.Location = new System.Drawing.Point(0, 35);
            this.btnNavStockIn.Name = "btnNavStockIn";
            this.btnNavStockIn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavStockIn.Size = new System.Drawing.Size(170, 32);
            this.btnNavStockIn.TabIndex = 1;
            this.btnNavStockIn.Text = "➕ Stock In";
            this.btnNavStockIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavStockIn.UseVisualStyleBackColor = false;
            this.btnNavStockIn.Click += new System.EventHandler(this.btnNavStockIn_Click);
            // 
            // lblNav1
            // 
            this.lblNav1.BackColor = System.Drawing.Color.Transparent;
            this.lblNav1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblNav1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(139)))), ((int)(((byte)(47)))));
            this.lblNav1.Location = new System.Drawing.Point(0, 10);
            this.lblNav1.Name = "lblNav1";
            this.lblNav1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNav1.Size = new System.Drawing.Size(170, 25);
            this.lblNav1.TabIndex = 0;
            this.lblNav1.Text = "STOCK";
            this.lblNav1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCards
            // 
            this.pnlCards.Controls.Add(this.pnllowstock);
            this.pnlCards.Controls.Add(this.pnlSupplier);
            this.pnlCards.Controls.Add(this.pnlExpired);
            this.pnlCards.Controls.Add(this.pnlTotal);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(170, 71);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(630, 115);
            this.pnlCards.TabIndex = 3;
            // 
            // pnllowstock
            // 
            this.pnllowstock.AutoSize = true;
            this.pnllowstock.BackColor = System.Drawing.Color.White;
            this.pnllowstock.Controls.Add(this.lbllowstock);
            this.pnllowstock.Controls.Add(this.label1);
            this.pnllowstock.ForeColor = System.Drawing.Color.Black;
            this.pnllowstock.Location = new System.Drawing.Point(200, 15);
            this.pnllowstock.Name = "pnllowstock";
            this.pnllowstock.Size = new System.Drawing.Size(170, 80);
            this.pnllowstock.TabIndex = 6;
            // 
            // lbllowstock
            // 
            this.lbllowstock.AutoSize = true;
            this.lbllowstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lbllowstock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.lbllowstock.Location = new System.Drawing.Point(10, 28);
            this.lbllowstock.Name = "lbllowstock";
            this.lbllowstock.Size = new System.Drawing.Size(32, 36);
            this.lbllowstock.TabIndex = 1;
            this.lbllowstock.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Low Stock";
            // 
            // pnlSupplier
            // 
            this.pnlSupplier.BackColor = System.Drawing.Color.White;
            this.pnlSupplier.Controls.Add(this.lblSupplier);
            this.pnlSupplier.Controls.Add(this.label5);
            this.pnlSupplier.ForeColor = System.Drawing.Color.Black;
            this.pnlSupplier.Location = new System.Drawing.Point(570, 15);
            this.pnlSupplier.Name = "pnlSupplier";
            this.pnlSupplier.Size = new System.Drawing.Size(170, 80);
            this.pnlSupplier.TabIndex = 5;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(71)))), ((int)(((byte)(161)))));
            this.lblSupplier.Location = new System.Drawing.Point(10, 28);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(32, 36);
            this.lblSupplier.TabIndex = 1;
            this.lblSupplier.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Suppliers";
            // 
            // pnlExpired
            // 
            this.pnlExpired.AutoSize = true;
            this.pnlExpired.BackColor = System.Drawing.Color.White;
            this.pnlExpired.Controls.Add(this.lblExpired);
            this.pnlExpired.Controls.Add(this.label4);
            this.pnlExpired.ForeColor = System.Drawing.Color.Black;
            this.pnlExpired.Location = new System.Drawing.Point(385, 15);
            this.pnlExpired.Name = "pnlExpired";
            this.pnlExpired.Size = new System.Drawing.Size(170, 80);
            this.pnlExpired.TabIndex = 2;
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblExpired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblExpired.Location = new System.Drawing.Point(10, 28);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(32, 36);
            this.lblExpired.TabIndex = 1;
            this.lblExpired.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Expired";
            // 
            // pnlTotal
            // 
            this.pnlTotal.AutoSize = true;
            this.pnlTotal.BackColor = System.Drawing.Color.White;
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Controls.Add(this.lblProducts);
            this.pnlTotal.ForeColor = System.Drawing.Color.Black;
            this.pnlTotal.Location = new System.Drawing.Point(15, 15);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(170, 80);
            this.pnlTotal.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(10, 28);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 36);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblProducts.ForeColor = System.Drawing.Color.Gray;
            this.lblProducts.Location = new System.Drawing.Point(10, 10);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(76, 13);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "Total Products";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(170, 186);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(630, 264);
            this.dgvStock.TabIndex = 4;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopBar);
            this.Name = "frmDashboard";
            this.Text = "Peart Agro Chemicals Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);
            this.pnlCards.PerformLayout();
            this.pnllowstock.ResumeLayout(false);
            this.pnllowstock.PerformLayout();
            this.pnlSupplier.ResumeLayout(false);
            this.pnlSupplier.PerformLayout();
            this.pnlExpired.ResumeLayout(false);
            this.pnlExpired.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();


            this.pnlChartArea = new System.Windows.Forms.Panel();
            this.pnlChartArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChartArea.Height = 220;
            this.pnlChartArea.BackColor = System.Drawing.Color.White;
            this.pnlChartArea.Name = "pnlChartArea";
            this.Controls.Add(this.pnlChartArea);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnNavStockIn;
        private System.Windows.Forms.Label lblNav1;
        private System.Windows.Forms.Button btnNavReport;
        private System.Windows.Forms.Button btnNavStockOut;
        private System.Windows.Forms.Label lblNav2;
        private System.Windows.Forms.Button btnNavPesticide;
        private System.Windows.Forms.Button btnNavSupplier;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Panel pnlExpired;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel pnllowstock;
        private System.Windows.Forms.Label lbllowstock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlChartArea;

    }
}