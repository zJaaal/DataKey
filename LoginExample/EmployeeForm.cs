using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;
using Domain;
using Common;
using Common.Cache;

namespace Presentation
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Logout?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            FullnameLbl.Text = "Welcome! " + UserLoginCache.userLastName + ", " + UserLoginCache.userName;
            PositionLbl.Text = "Position: " + UserLoginCache.userPosition;
            BornYearLbl.Text = "Year born: " + UserLoginCache.userBornYear;
            AccessLevelLbl.Text = "Access Level: " + UserLoginCache.userAccessLevel;
            DateLbl.Text = "Date: " + DateTime.Today.ToString("dd/MM/yyyy");

        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
