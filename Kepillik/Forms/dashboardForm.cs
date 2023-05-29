using Kepillik.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class dashboardForm : Form
    {
        public dashboardForm(KepillikDBContext ctx, int userid, string username)
        {
            InitializeComponent();
            this._ctx = ctx;
            this.userid = userid;
            this.username = username;
        }
        public bool isButtonPressed = false;
        public Point mouseLocation;
        private readonly KepillikDBContext _ctx;
        public int userid;
        public string username;
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

        private void dashboardForm_Load(object sender, EventArgs e)
        {
            var products = _ctx.Products
                .Include(p => p.Stores)
                .ToList();

            foreach (var product in products)
            {
                listBox.Items.Add($"{product.Manufacturer}, {product.Model}, {product.Stores.FirstOrDefault().Name}");
            }
            usernameLabel.Text = "Hi, " + username + "!";

        }

        private void add_Down(object sender, MouseEventArgs e)
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

        private void add_Leave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
            isButtonPressed = false;
        }

        private void add_Move(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form frm = new addWarrantyForm();
            frm.ShowDialog();
        }

        private void logout_Down(object sender, MouseEventArgs e)
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

        private void logout_Leave(object sender, EventArgs e)
        {
            logoutLabel.ForeColor = Color.Teal;
            Cursor.Current = Cursors.Arrow;
        }

        private void logout_Move(object sender, MouseEventArgs e)
        {

            logoutLabel.ForeColor = ColorTranslator.FromHtml("#15264a");

            Cursor.Current = Cursors.Hand;
            isButtonPressed = true;


        }

        private void logoutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new loginForm(_ctx);
            frm.ShowDialog();
        }

       
    }
}
