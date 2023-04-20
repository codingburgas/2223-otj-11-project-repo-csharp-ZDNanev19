using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kepillik
{
    public partial class LoginForm : Form
    {
        public Point mouseLocation;
        public LoginForm()
        {
            InitializeComponent();
        }
        public bool isPasswordBlank;
        public bool isEyeOpened=false;
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X,mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void usernameTB_Enter(object sender, EventArgs e)
        {
            if (usernameBox.Text == "     Username")
            {
                usernameBox.Text = "";
                usernameBox.ForeColor = ColorTranslator.FromHtml("#3ee6af");
            }
           
        }

        private void usernameTB_Leave(object sender, EventArgs e)
        {
            if (usernameBox.Text == "")
            {

                usernameBox.Text = "     Username";
                usernameBox.ForeColor = Color.DimGray;
            }
        }

        private void passwordTB_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "     Password" )
            {
                passwordBox.Text = "";
                passwordBox.ForeColor = ColorTranslator.FromHtml("#3ee6af");
                passwordBox.UseSystemPasswordChar = false;
                isPasswordBlank = true;
            }
            if (!isEyeOpened)
            {
                passwordBox.UseSystemPasswordChar = true;
            }
          
           
        }

        private void passwordTB_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {

                passwordBox.Text = "     Password";
                passwordBox.ForeColor = Color.DimGray;
                passwordBox.UseSystemPasswordChar = false;
                isPasswordBlank = false;
            }

        }

        private void closedEyeImage_Click(object sender, EventArgs e)
        {
            closedEyeImage.Visible = false;
            closedEyeImage.Enabled = false;

            openedEyeImage.Visible = true;
            openedEyeImage.Enabled = true;
            passwordBox.UseSystemPasswordChar = false;
            isEyeOpened = true;
        }

        private void openedEyeImage_Click(object sender, EventArgs e)
        {
            openedEyeImage.Visible = false;
            openedEyeImage.Enabled = false;
            closedEyeImage.Visible = true;
            closedEyeImage.Enabled = true;
            if (isPasswordBlank)
            {
                passwordBox.UseSystemPasswordChar = true;
            }
            isEyeOpened = false;
        }

     

        private void fpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.forgotPassForm frm = new Forms.forgotPassForm();
            frm.ShowDialog();
        }
    }
}
