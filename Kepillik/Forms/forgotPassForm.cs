﻿using Kepillik.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Kepillik.Forms
{
    public partial class forgotPassForm : Form
    {

        public forgotPassForm(KepillikDBContext ctx)
        {
            InitializeComponent();
            this._ctx = ctx;
        }
        public Point mouseLocation;
        public bool isButtonPressed = false;
        private readonly KepillikDBContext _ctx;

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelMouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void sendCodeButton_Click(object sender, EventArgs e)
        {
            sendCodeButton.Visible = false;
            emailBox.Visible = false;
            enterCode.Visible = true;
            resendButton.Visible = true;
            confirmButton.Visible = true;



        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (emailBox.Text == "     Enter email address")
            {
                emailBox.Text = "";
                emailBox.ForeColor = ColorTranslator.FromHtml("#3ee6af");
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (enterCode.Text == "")
            {

                enterCode.Text = "     Enter email address";
                enterCode.ForeColor = Color.DimGray;
            }
        }

        private void code_Enter(object sender, EventArgs e)
        {
            if (enterCode.Text == "Enter code")
            {
                enterCode.Text = "";
                enterCode.ForeColor = ColorTranslator.FromHtml("#3ee6af");
            }
        }

        private void code_Leave(object sender, EventArgs e)
        {
            if (enterCode.Text == "")
            {

                enterCode.Text = "Enter code";
                enterCode.ForeColor = Color.DimGray;
            }
        }

        private void cancel_Down(object sender, MouseEventArgs e)
        {
            if (isButtonPressed)
            {
                Cursor.Current = Cursors.Hand;
            }
            else
            {
                Cursor.Current = Cursors.Arrow;
            }
        }

        private void cancel_Leave(object sender, EventArgs e)
        {
            cancelLabel.ForeColor = Color.Teal;
            Cursor.Current = Cursors.Arrow;
        }

        private void cancel_Move(object sender, MouseEventArgs e)
        {
            cancelLabel.ForeColor = ColorTranslator.FromHtml("#15264a");

            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void cancelLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new loginForm(_ctx);
            frm.ShowDialog();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //if (codeIsCorrect)
            //{
            goBackButton.Visible = true;
            resendButton.Visible = false;
            confirmButton.Visible = false;
            //notCorrectLabel.Visible = false;
            //}
            //else{
            //  notCorrectLabel.Visible = true;
            //}
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new loginForm(_ctx);
            frm.ShowDialog();
        }

        private void sendCode_Down(object sender, MouseEventArgs e)
        {
            if (isButtonPressed)
            {
                Cursor.Current = Cursors.Hand;
            }
            else
            {
                Cursor.Current = Cursors.Arrow;
            }
        }

        private void sendCode_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
            isButtonPressed = false;
        }

        private void sendCode_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void confirm_Down(object sender, MouseEventArgs e)
        {
            if (isButtonPressed)
            {
                Cursor.Current = Cursors.Hand;
            }
            else
            {
                Cursor.Current = Cursors.Arrow;
            }
        }

        private void confirm_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
            isButtonPressed = false;
        }

        private void confirm_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void resend_Down(object sender, MouseEventArgs e)
        {
            if (isButtonPressed)
            {
                Cursor.Current = Cursors.Hand;
            }
            else
            {
                Cursor.Current = Cursors.Arrow;
            }
        }

        private void resend_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
            isButtonPressed = false;
        }

        private void resend_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void back_Down(object sender, MouseEventArgs e)
        {
            if (isButtonPressed)
            {
                Cursor.Current = Cursors.Hand;
            }
            else
            {
                Cursor.Current = Cursors.Arrow;
            }
        }

        private void back_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
            isButtonPressed = false;
        }

        private void back_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void forgotPassForm_Load(object sender, EventArgs e)
        {

        }
    }
}
