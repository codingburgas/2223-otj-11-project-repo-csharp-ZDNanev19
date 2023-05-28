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
    public partial class addWarrantyForm : Form
    {
        public addWarrantyForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            Hide();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (enterCode.Text == "" || enterCode.Text == "Enter code")
            {
                incorrectLabel.Visible = true;
                return;
            }
            Hide();
        }
    }
}
