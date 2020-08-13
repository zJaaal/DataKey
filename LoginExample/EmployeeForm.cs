using Common.Cache;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
            {
                this.Close();
                Form1 LF = new Form1();
                LF.Show();
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            SwapBtn.Visible = false;
            FullnameLbl.Text = "Welcome! " + UserLoginCache.userLastName + ", " + UserLoginCache.userName;
            PositionLbl.Text = "Position: " + UserLoginCache.userPosition;
            AccessLevelLbl.Text = "Access Level: " + UserLoginCache.userAccessLevel;
            DateLbl.Text = "Date: " + DateTime.Today.ToString("dd/MM/yyyy");
            if (UserLoginCache.userAccessLevel == "Guard")
            {
                SwapBtn.Visible = true;
            }
            else if (UserLoginCache.userAccessLevel == "Master")
            {
                SwapBtn.Visible = true;
            }
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

        private void SwapBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (UserLoginCache.userAccessLevel == "Guard")
            {
                GuardForm GF = new GuardForm();
                GF.Show();
            }
            else if (UserLoginCache.userAccessLevel == "Master")
            {
                MasterForm MF = new MasterForm();
                MF.Show();
            }
        }
    }
}
