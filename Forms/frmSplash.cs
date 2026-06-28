using System;
using System.Windows.Forms;

namespace PeartAgroChemicalsManagementSystem.Forms
{
    public partial class frmSplash : Form
    {
        private int _progress = 0;

        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _progress += 2;
            progressBar1.Value = _progress;

            if (_progress == 10)
                lblStatus.Text = "Loading components...";
            else if (_progress == 20)
                lblStatus.Text = "Connecting to database...";
            else if (_progress == 35)
                lblStatus.Text = "Loading stock data...";
            else if (_progress == 50)
                lblStatus.Text = "Prepar...";
            else if (_progress == 75)
                lblStatus.Text = "Almost ready...";

            if (_progress >= 100)
            {
                timer1.Stop();
                lblStatus.Text = "Done!";
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();  
            }
        }
    }
}