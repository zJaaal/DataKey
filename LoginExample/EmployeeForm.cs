using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Domain;
using Common.Cache;
using Presentation;

namespace Presentation
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        /* Those lines are for moving the window using the mouse */

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
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
            AccessLevelLbl.Text = "Access Level: " + UserLoginCache.userAccessLevel;
            DateLbl.Text = "Date: " + DateTime.Today.ToString("dd/MM/yyyy");

        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rectangleShape1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
