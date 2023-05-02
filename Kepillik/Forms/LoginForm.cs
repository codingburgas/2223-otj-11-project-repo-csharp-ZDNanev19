
namespace Kepillik
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        public Point mouseLocation;
        public bool isPasswordBlank;
        public bool isEyeOpened = false;
        public bool isButtonPressed = false;
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

        private void usernameTB_Enter(object sender, EventArgs e)
        {
            if (usernameBox.Text == "     Username or email")
            {
                usernameBox.Text = "";
                usernameBox.ForeColor = ColorTranslator.FromHtml("#3ee6af");
            }
        }

        private void usernameTB_Leave(object sender, EventArgs e)
        {
            if (usernameBox.Text == "")
            {

                usernameBox.Text = "     Username or email";
                usernameBox.ForeColor = Color.DimGray;
            }
        }

        private void passTB_Enter(object sender, EventArgs e)
        {
            if (passBox.Text == "     Password")
            {
                passBox.Text = "";
                passBox.ForeColor = ColorTranslator.FromHtml("#3ee6af");
                passBox.UseSystemPasswordChar = false;
                isPasswordBlank = true;
            }
            if (!isEyeOpened)
            {
                passBox.UseSystemPasswordChar = true;
            }
        }

        private void passTB_Leave(object sender, EventArgs e)
        {
            if (passBox.Text == "")
            {

                passBox.Text = "     Password";
                passBox.ForeColor = Color.DimGray;
                passBox.UseSystemPasswordChar = false;
                isPasswordBlank = false;
            }
        }

        private void closedEyeImage_Click(object sender, EventArgs e)
        {
            closedEyeImage.Visible = false;
            closedEyeImage.Enabled = false;

            openedEyeImage.Visible = true;
            openedEyeImage.Enabled = true;
            passBox.UseSystemPasswordChar = false;
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
                passBox.UseSystemPasswordChar = true;
            }
            isEyeOpened = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.dashboardForm frm = new Forms.dashboardForm();
            frm.ShowDialog();
        }

        private void loginButton_Down(object sender, MouseEventArgs e)
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

        private void loginButton_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
            isButtonPressed = false;

        }

        private void loginButton_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;

        }

        private void forgotPassDown(object sender, MouseEventArgs e)
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

        private void forgotPassLeave(object sender, EventArgs e)
        {
            fpLabel.ForeColor = Color.Teal;
            Cursor.Current = Cursors.Arrow;
        }

        private void forgotPassMove(object sender, MouseEventArgs e)
        {
            fpLabel.ForeColor = ColorTranslator.FromHtml("#15264a");

            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void fpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.forgotPassForm frm = new Forms.forgotPassForm();
            frm.ShowDialog();
        }

        private void openedEye_Down(object sender, MouseEventArgs e)
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

        private void openedEye_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
        }

        private void openedEye_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void closedEye_Down(object sender, MouseEventArgs e)
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

        private void closedEye_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
        }

        private void closedEye_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }
    }
}