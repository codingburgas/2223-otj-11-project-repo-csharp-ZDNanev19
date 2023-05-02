using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Kepillik.Forms
{
    public partial class forgotPassForm : Form
    {

        public forgotPassForm()
        {
            InitializeComponent();
        }
        public Point mouseLocation;

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
    }
}
