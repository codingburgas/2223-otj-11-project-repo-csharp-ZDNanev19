namespace Kepillik.Forms
{
    partial class addWarrantyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exitButton = new Button();
            enterCode = new TextBox();
            addButton = new Button();
            incorrectLabel = new Label();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.FromArgb(62, 230, 175);
            exitButton.Location = new Point(369, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(37, 33);
            exitButton.TabIndex = 6;
            exitButton.Text = "❌";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // enterCode
            // 
            enterCode.BackColor = Color.FromArgb(0, 17, 48);
            enterCode.BorderStyle = BorderStyle.None;
            enterCode.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            enterCode.ForeColor = Color.DimGray;
            enterCode.Location = new Point(75, 70);
            enterCode.MaxLength = 9;
            enterCode.Multiline = true;
            enterCode.Name = "enterCode";
            enterCode.Size = new Size(147, 32);
            enterCode.TabIndex = 10;
            enterCode.Text = "Enter code";
            enterCode.Enter += code_Enter;
            enterCode.Leave += code_Leave;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(0, 27, 48);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.FromArgb(62, 230, 175);
            addButton.Location = new Point(282, 70);
            addButton.Name = "addButton";
            addButton.Size = new Size(69, 32);
            addButton.TabIndex = 11;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // incorrectLabel
            // 
            incorrectLabel.AutoSize = true;
            incorrectLabel.BackColor = Color.Transparent;
            incorrectLabel.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            incorrectLabel.ForeColor = Color.Teal;
            incorrectLabel.Location = new Point(75, 22);
            incorrectLabel.Name = "incorrectLabel";
            incorrectLabel.Size = new Size(155, 28);
            incorrectLabel.TabIndex = 15;
            incorrectLabel.Text = "Incorrect code!";
            incorrectLabel.Visible = false;
            // 
            // addWarrantyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 11, 39);
            ClientSize = new Size(408, 148);
            Controls.Add(incorrectLabel);
            Controls.Add(addButton);
            Controls.Add(enterCode);
            Controls.Add(exitButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addWarrantyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addWarrantyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private TextBox enterCode;
        private Button addButton;
        private Label incorrectLabel;
    }
}