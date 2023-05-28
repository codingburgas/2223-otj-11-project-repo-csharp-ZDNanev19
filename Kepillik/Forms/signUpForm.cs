using Kepillik.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
namespace Kepillik.Forms
{
    public partial class signUpForm : Form
    {
        public signUpForm(KepillikDBContext ctx)
        {
            InitializeComponent();
            this._ctx = ctx;
        }

        public Point mouseLocation;
        public bool isPasswordBlank;
        public bool isPasswordBlankCopy;
        public bool isEyeOpened = false;
        public bool isEyeOpenedCopy = false;
        public bool isButtonPressed = false;
        private readonly KepillikDBContext _ctx;
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
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelMouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelMouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (emailBox.Text == "           Email")
            {
                emailBox.Text = "";
                emailBox.ForeColor = ColorTranslator.FromHtml("#3ee6af");
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (emailBox.Text == "")
            {

                emailBox.Text = "           Email";
                emailBox.ForeColor = Color.DimGray;
            }
        }

        private void fName_Enter(object sender, EventArgs e)
        {
            if (firstNameBox.Text == "First Name")
            {
                firstNameBox.Text = "";
                firstNameBox.ForeColor = ColorTranslator.FromHtml("#3ee6af");
            }
        }

        private void fName_Leave(object sender, EventArgs e)
        {
            if (firstNameBox.Text == "")
            {

                firstNameBox.Text = "First Name";
                firstNameBox.ForeColor = Color.DimGray;
            }
        }

        private void lName_Enter(object sender, EventArgs e)
        {
            if (lastNameBox.Text == "Last Name")
            {
                lastNameBox.Text = "";
                lastNameBox.ForeColor = ColorTranslator.FromHtml("#3ee6af");
            }
        }

        private void lName_Leave(object sender, EventArgs e)
        {
            if (lastNameBox.Text == "")
            {

                lastNameBox.Text = "Last Name";
                lastNameBox.ForeColor = Color.DimGray;
            }
        }

        private void age_Enter(object sender, EventArgs e)
        {
            if (ageBox.Text == "Age")
            {
                ageBox.Text = "";
                ageBox.ForeColor = ColorTranslator.FromHtml("#3ee6af");
            }
        }

        private void age_Leave(object sender, EventArgs e)
        {
            if (ageBox.Text == "")
            {

                ageBox.Text = "Age";
                ageBox.ForeColor = Color.DimGray;
            }
        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if (UserNameBox.Text == "     Username")
            {
                UserNameBox.Text = "";
                UserNameBox.ForeColor = ColorTranslator.FromHtml("#3ee6af");
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (UserNameBox.Text == "")
            {

                UserNameBox.Text = "     Username";
                UserNameBox.ForeColor = Color.DimGray;
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {

            emailBox.Visible = false;
            firstNameBox.Visible = false;
            lastNameBox.Visible = false;
            ageBox.Visible = false;
            continueButton.Visible = false;
            backLabel.Visible = true;
            UserNameBox.Visible = true;
            passBox.Visible = true;
            repeatBox.Visible = true;
            signUpButton.Visible = true;
            closedEyeImage.Visible = true;
            closedEyeImageCopy.Visible = true;
        }

        private void pass_Enter(object sender, EventArgs e)
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

        private void pass_Leave(object sender, EventArgs e)
        {
            if (passBox.Text == "")
            {

                passBox.Text = "     Password";
                passBox.ForeColor = Color.DimGray;
                passBox.UseSystemPasswordChar = false;
                isPasswordBlank = false;
            }
        }

        private void repeat_Enter(object sender, EventArgs e)
        {
            if (repeatBox.Text == "Repeat Password")
            {
                repeatBox.Text = "";
                repeatBox.ForeColor = ColorTranslator.FromHtml("#3ee6af");
                repeatBox.UseSystemPasswordChar = false;
                isPasswordBlankCopy = true;
            }
            if (!isEyeOpenedCopy)
            {
                repeatBox.UseSystemPasswordChar = true;
            }
        }

        private void repeat_Leave(object sender, EventArgs e)
        {
            if (repeatBox.Text == "")
            {

                repeatBox.Text = "Repeat Password";
                repeatBox.ForeColor = Color.DimGray;
                repeatBox.UseSystemPasswordChar = false;
                isPasswordBlankCopy = false;
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

        private void closedEyeImageCopy_Click(object sender, EventArgs e)
        {
            closedEyeImageCopy.Visible = false;
            closedEyeImageCopy.Enabled = false;

            openedEyeImageCopy.Visible = true;
            openedEyeImageCopy.Enabled = true;
            repeatBox.UseSystemPasswordChar = false;
            isEyeOpenedCopy = true;
        }

        private void openedEyeImageCopy_Click(object sender, EventArgs e)
        {
            openedEyeImageCopy.Visible = false;
            openedEyeImageCopy.Enabled = false;
            closedEyeImageCopy.Visible = true;
            closedEyeImageCopy.Enabled = true;
            if (isPasswordBlankCopy)
            {
                repeatBox.UseSystemPasswordChar = true;
            }
            isEyeOpenedCopy = false;
        }

        private void cancelLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new loginForm(_ctx);
            frm.ShowDialog();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (UserNameBox.Text == "" || UserNameBox.Text == "     Username" || passBox.Text == "" || passBox.Text == "     Password" || repeatBox.Text == "" || repeatBox.Text == "Repeat Password" || emailBox.Text == "" || emailBox.Text == "           Email" || firstNameBox.Text == "" || firstNameBox.Text == "First Name" || lastNameBox.Text == "" || lastNameBox.Text == "Last Name" || ageBox.Text == "" || ageBox.Text == "Age")
            {
                incorrectLabel.Visible = true;
                return;
            }
            int number;
            if (!int.TryParse(ageBox.Text, out number))
            {
                ageLabel.Visible = true;
                return;
            }

            if (!emailBox.Text.Contains('@') || !emailBox.Text.Contains('.'))
            {
                wrongEmail.Visible = true;
                return;
            }
            if (passBox.Text != repeatBox.Text)
            {
                repeatLabel.Visible = true;
                return;
            }

            Models.User obj = new Models.User();
            obj.Email = emailBox.Text;
            obj.FirstName = firstNameBox.Text;
            obj.LastName = lastNameBox.Text;
            obj.Username = UserNameBox.Text;
            obj.Password = ComputeSha256Hash(passBox.Text);
            obj.Age = int.Parse(ageBox.Text);
            _ctx.Add(obj);
            _ctx.SaveChanges();



            this.Hide();
            Form frm = new loginForm(_ctx);
            frm.ShowDialog();

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
            Cursor.Current = Cursors.Arrow;
            isButtonPressed = false;
        }

        private void signUp_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void continue_Down(object sender, MouseEventArgs e)
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

        private void continue_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
            isButtonPressed = false;
        }

        private void continue_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            emailBox.Visible = true;
            firstNameBox.Visible = true;
            lastNameBox.Visible = true;
            ageBox.Visible = true;
            continueButton.Visible = true;
            backLabel.Visible = false;
            UserNameBox.Visible = false;
            passBox.Visible = false;
            repeatBox.Visible = false;
            signUpButton.Visible = false;
            closedEyeImage.Visible = false;
            closedEyeImageCopy.Visible = false;
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
            backLabel.ForeColor = Color.Teal;
            Cursor.Current = Cursors.Arrow;
        }

        private void back_Move(object sender, MouseEventArgs e)
        {
            backLabel.ForeColor = ColorTranslator.FromHtml("#15264a");

            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void opened_Down(object sender, MouseEventArgs e)
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

        private void opened_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
        }

        private void opened_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void closed_Down(object sender, MouseEventArgs e)
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

        private void closed_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
        }

        private void closed_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void openedCpy_Down(object sender, MouseEventArgs e)
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

        private void openedCpy_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
        }

        private void openedCpy_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void closedCpy_Down(object sender, MouseEventArgs e)
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

        private void closedCpy_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
        }

        private void closedCpy_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }
    }
}
