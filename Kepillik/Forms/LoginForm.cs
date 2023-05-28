
using Kepillik.Forms;
using Kepillik.Models;
using System.Text;
using System.Security.Cryptography;
namespace Kepillik
{
    public partial class loginForm : Form
    {
        KepillikDBContext _ctx;

        public loginForm(KepillikDBContext ctx)
        {
            _ctx = ctx;
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
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
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
            
            string password = ComputeSha256Hash(passBox.Text);
          

            var user = _ctx.Users
                .Where(u => (u.Username == usernameBox.Text || u.Email == usernameBox.Text) && u.Password == password)
                .FirstOrDefault();

            if (user == null)
            {
                incorrectLabel.Visible = true;
                return;
            }

            this.Hide();
            Form frm = new dashboardForm(_ctx);
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
            Form frm = new forgotPassForm(_ctx);
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

        private void signUp_Down(object sender, MouseEventArgs e)
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

        private void signUp_Leave(object sender, EventArgs e)
        {
            signUpLabel.ForeColor = Color.Teal;
            Cursor.Current = Cursors.Arrow;
        }

        private void signUp_Move(object sender, MouseEventArgs e)
        {
            signUpLabel.ForeColor = ColorTranslator.FromHtml("#15264a");

            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new signUpForm(_ctx);
            frm.ShowDialog();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}