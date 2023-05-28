namespace Kepillik.Forms
{
    partial class dashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardForm));
            movePanel = new Panel();
            minimizeButton = new Button();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            listBox = new ListBox();
            usernameLabel = new Label();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // movePanel
            // 
            movePanel.BackColor = Color.FromArgb(0, 8, 20);
            movePanel.Location = new Point(0, 0);
            movePanel.Name = "movePanel";
            movePanel.Size = new Size(727, 33);
            movePanel.TabIndex = 3;
            movePanel.MouseDown += panelMouseDown;
            movePanel.MouseMove += panelMouseMove;
            // 
            // minimizeButton
            // 
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            minimizeButton.ForeColor = Color.FromArgb(62, 230, 175);
            minimizeButton.Location = new Point(727, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(42, 33);
            minimizeButton.TabIndex = 4;
            minimizeButton.Text = "_";
            minimizeButton.TextAlign = ContentAlignment.TopCenter;
            minimizeButton.UseVisualStyleBackColor = true;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // exitButton
            // 
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.FromArgb(62, 230, 175);
            exitButton.Location = new Point(763, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(37, 33);
            exitButton.TabIndex = 5;
            exitButton.Text = "❌";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(742, 391);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 47);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // listBox
            // 
            listBox.BackColor = Color.FromArgb(0, 11, 31);
            listBox.BorderStyle = BorderStyle.None;
            listBox.ForeColor = Color.FromArgb(62, 230, 175);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(0, 39);
            listBox.Name = "listBox";
            listBox.Size = new Size(375, 405);
            listBox.TabIndex = 13;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Segoe UI", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.Teal;
            usernameLabel.Location = new Point(599, 50);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(136, 28);
            usernameLabel.TabIndex = 14;
            usernameLabel.Text = "Hi, Jivko123!";
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(0, 27, 48);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.FromArgb(62, 230, 175);
            addButton.Location = new Point(551, 159);
            addButton.Name = "addButton";
            addButton.Size = new Size(184, 71);
            addButton.TabIndex = 15;
            addButton.Text = "Add Warranty";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            addButton.MouseDown += add_Down;
            addButton.MouseLeave += add_Leave;
            addButton.MouseMove += add_Move;
            // 
            // dashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 11, 31);
            ClientSize = new Size(800, 450);
            Controls.Add(addButton);
            Controls.Add(usernameLabel);
            Controls.Add(listBox);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            Controls.Add(minimizeButton);
            Controls.Add(movePanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "dashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboardForm";
            Load += dashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel movePanel;
        private Button minimizeButton;
        private Button exitButton;
        private PictureBox pictureBox1;
        private ListBox listBox;
        private Label usernameLabel;
        private Button addButton;
    }
}