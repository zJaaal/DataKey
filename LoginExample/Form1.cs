﻿using System;
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

namespace LoginExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Those lines are for moving the window using the mouse */

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNick_Enter(object sender, EventArgs e)
        {
            if(textBoxNick.Text == "ID")
            {
                textBoxNick.Text = "";
                textBoxNick.ForeColor = Color.LightGray;
            }
        }

        private void textBoxNick_Leave(object sender, EventArgs e)
        {
            if(textBoxNick.Text == "")
            {
                textBoxNick.Text = "ID";
                textBoxNick.ForeColor = Color.DimGray;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "KeyPass")
            {
                textBoxPass.Text = "";
                textBoxPass.ForeColor = Color.LightGray;
                textBoxPass.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "")
            {
                textBoxPass.Text = "KeyPass";
                textBoxPass.ForeColor = Color.DimGray;
                textBoxPass.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (textBoxNick.Text != "ID") 
            {
                if (textBoxPass.Text != "KeyPass")
                {
                    UserModel user = new UserModel();
                    var validlogin = user.Loginuser(textBoxNick.Text, textBoxPass.Text);
                    if (validlogin == true)
                    {
                        //* Here you can call the respective child form as master, Employee or Security Checker. Just now I'll just show a MessageBox*//
                        MessageBox.Show("Login Succesfully");
                        //*Overload the event nameoftheform.FormClose = LogOut()*//
                    }
                    else
                    {
                        msgError("Incorrect ID or KeyPass. \nPlease Try Again");

                        textBoxNick.Clear();
                        textBoxPass.Clear();
                        textBoxNick.Focus();
                    }
                }
                else msgError("Please enter KeyPass.");
            }
            else msgError("Please enter ID.");
        }

        private void msgError(string msg)
        {
            lbErrorMessage.Text = msg;
            lbErrorMessage.Visible = true;
        }
        //* This method will be use on the others form for logout and show the login form*//
        private void LogOut (object sender, FormClosedEventArgs e)
        {
            textBoxNick.Text = "ID";
            textBoxPass.Text = "KeyPass";
            textBoxPass.UseSystemPasswordChar = false;
            lbErrorMessage.Visible = false;
            this.Show();
            textBoxNick.Focus();

        }
    }
}