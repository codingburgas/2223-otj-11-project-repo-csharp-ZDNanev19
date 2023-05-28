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
        public dashboardForm(KepillikDBContext ctx)
        {
            InitializeComponent();
            this._ctx = ctx;
        }

        public Point mouseLocation;
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

        private void dashboardForm_Load(object sender, EventArgs e)
        {
            var products = _ctx.Products
                .Include(p => p.Stores)
                .ToList();

            foreach (var product in products)
            {
                listBox.Items.Add($"{product.Manufacturer}, {product.Model}, {product.Stores.FirstOrDefault().Name}");
            }


        }
    }
}
