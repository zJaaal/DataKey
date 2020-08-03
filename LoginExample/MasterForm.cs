using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;
namespace Presentation
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Access_LevelLbl_Click(object sender, EventArgs e)
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
            UserModel userModel = new UserModel();
            try
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
                MessageBox.Show(Ex.ToString());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
