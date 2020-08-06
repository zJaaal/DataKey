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
    public partial class MasterForm : Form
    {
        UserModel userModel = new UserModel();
        public MasterForm()
        {
            InitializeComponent();
        }

        /* Those lines are for moving the window using the mouse */

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            IDTbox.Clear();
            NameTBox.Clear();
            Last_NameTBox.Clear();
            PositionTBox.Clear();
            KeyPassTBox.Clear();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDTbox.Text == "")
                {
                    MessageBox.Show("Please enter an ID to search", "Advice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    userModel.RegisterInfo(IDTbox.Text);
                    var ValidID = userModel.RegisterInfo(IDTbox.Text);
                    if (ValidID == true)
                    {
                        NameTBox.Text = RegisterCache.userName;
                        Last_NameTBox.Text = RegisterCache.userLastName;
                        IDTbox.Text = RegisterCache.userID.ToString();
                        PositionTBox.Text = RegisterCache.userPosition;
                        KeyPassTBox.Text = RegisterCache.userKeyPass;
                        Access_LevelCBox.Text = RegisterCache.userAccessLevel;
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IDGenBtn_Click(object sender, EventArgs e)
        {
            NameTBox.Clear();
            Last_NameTBox.Clear();
            PositionTBox.Clear();
            KeyPassTBox.Clear();

            IDGenerator IDG = new IDGenerator();
            IDG.GenID();
            var _Verification = IDG.GenID();
            try
            {
                if (_Verification == IDG.NewID)
                {
                    IDTbox.Text = IDG.NewID;
                }
            }
            catch (Exception Ex)
            {
                var Message = Ex.ToString();
                MessageBox.Show(Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(IDTbox.Text == "" || 
                   NameTBox.Text == "" || 
                   Last_NameTBox.Text == "" || 
                   PositionTBox.Text == "" || 
                   KeyPassTBox.Text == "" || 
                   Access_LevelCBox.Text == "")
                {
                    MessageBox.Show("Some spaces are empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult Answer = MessageBox.Show("Are you sure to change the Data Base?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Answer == DialogResult.Yes)
                    {
                        var MsgBoxDes = userModel.Update(IDTbox.Text, PositionTBox.Text, NameTBox.Text, Last_NameTBox.Text, Access_LevelCBox.Text, KeyPassTBox.Text);

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
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error has occurred: " + Ex);
            }
        }

        private void Erasebtn_Click(object sender, EventArgs e)
        {
            try
            {
                var WarningMesg = userModel.EraseAdvice(IDTbox.Text);
                if (WarningMesg == true)
                {
                    DialogResult Result = MessageBox.Show("Are you sure to erase this ID information from the Data Base?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(Result == DialogResult.Yes)
                    {
                        userModel.Erase(IDTbox.Text);
                        MessageBox.Show("The ID information has been erased from the Data Base");
                        NameTBox.Clear();
                        Last_NameTBox.Clear();
                        PositionTBox.Clear();
                        KeyPassTBox.Clear();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error has occurred: " + Ex);
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

        private void MasterForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
