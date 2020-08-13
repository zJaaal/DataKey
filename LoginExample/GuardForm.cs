using Common.Cache;
using Domain;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation
{
    public partial class GuardForm : Form
    {
        UserModel userModel = new UserModel();
        public GuardForm()
        {
            InitializeComponent();
        }

        /* Those lines are for moving the window using the mouse */

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void GuardForm_Load(object sender, EventArgs e)
        {
            IDTbox.Clear();
            NameTBox.Clear();
            Last_NameTBox.Clear();
            PositionTBox.Clear();
            KeyPassTBox.Clear();
            Access_LevelTBox.Clear();
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDTbox.Text == "ID" || IDTbox.Text == "")
                {
                    MessageBox.Show("Please enter an ID", "Advice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var ValidID = userModel.RegisterInfo(IDTbox.Text);
                    if (ValidID == true)
                    {
                        NameTBox.Text = RegisterCache.userName;
                        Last_NameTBox.Text = RegisterCache.userLastName;
                        IDTbox.Text = RegisterCache.userID.ToString();
                        PositionTBox.Text = RegisterCache.userPosition;
                        KeyPassTBox.Text = RegisterCache.userKeyPass;
                        Access_LevelTBox.Text = RegisterCache.userAccessLevel;
                        KeyPassGenBtn.Visible = true;
                        UpdateBtn.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("The ID is not in the Data Base", "Error");
                    }
                }
            }
            catch (Exception Ex)
            {
                var message = Ex.ToString();
                MessageBox.Show(message);
            }
        }

        private void KeyPassGenBtn_Click(object sender, EventArgs e)
        {
            DialogResult Answer = MessageBox.Show("Are you sure to generete a New KeyPass? (Remember to update it in the Data Base)", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Answer == DialogResult.Yes)
            {
                KeyPassGenerator _KPG = new KeyPassGenerator();
                var KeyPass = _KPG.GenKeyPass();
                KeyPassTBox.Text = KeyPass;
            }
        }

        private void GuardForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDTbox.Text == "ID" || IDTbox.Text == "")
                {
                    MessageBox.Show("Please enter an ID", "Advice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var MsgBoxDes = userModel.Update(IDTbox.Text, PositionTBox.Text, NameTBox.Text, Last_NameTBox.Text, Access_LevelTBox.Text, KeyPassTBox.Text);

                    if (MsgBoxDes == true)
                    {
                        MessageBox.Show("The ID information has been updated");
                    }
                    else
                    {
                        MessageBox.Show("The ID Information has been added");
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error has occurred: " + Ex);
            }
        }

        private void IDTbox_TextChanged(object sender, EventArgs e)
        {
            UpdateBtn.Visible = false;
            KeyPassGenBtn.Visible = false;
            Access_LevelTBox.Clear();
            NameTBox.Clear();
            Last_NameTBox.Clear();
            PositionTBox.Clear();
            KeyPassTBox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 LF = new Form1();
            EmployeeForm EF = new EmployeeForm();
            this.Hide();
            EF.Show();
        }
    }
}
