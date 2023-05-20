namespace Kepillik.Forms
{
    partial class signUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUpForm));
            pictureBox1 = new PictureBox();
            minimizeButton = new Button();
            exitButton = new Button();
            movePanel = new Panel();
            signUpLabel = new Label();
            emailBox = new TextBox();
            firstNameBox = new TextBox();
            lastNameBox = new TextBox();
            ageBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(742, 391);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 47);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
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
            minimizeButton.TabIndex = 14;
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
            exitButton.TabIndex = 15;
            exitButton.Text = "❌";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // movePanel
            // 
            movePanel.BackColor = Color.FromArgb(0, 8, 20);
            movePanel.Location = new Point(0, 0);
            movePanel.Name = "movePanel";
            movePanel.Size = new Size(727, 33);
            movePanel.TabIndex = 16;
            movePanel.MouseDown += panelMouse_Down;
            movePanel.MouseMove += panelMouse_Move;
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.BackColor = Color.Transparent;
            signUpLabel.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            signUpLabel.ForeColor = Color.Teal;
            signUpLabel.Location = new Point(341, 72);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(104, 35);
            signUpLabel.TabIndex = 17;
            signUpLabel.Text = "Sign up";
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.FromArgb(0, 17, 48);
            emailBox.BorderStyle = BorderStyle.None;
            emailBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            emailBox.ForeColor = Color.DimGray;
            emailBox.Location = new Point(212, 129);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(223, 32);
            emailBox.TabIndex = 18;
            emailBox.Text = "           Email";
            // 
            // firstNameBox
            // 
            firstNameBox.BackColor = Color.FromArgb(0, 17, 48);
            firstNameBox.BorderStyle = BorderStyle.None;
            firstNameBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameBox.ForeColor = Color.DimGray;
            firstNameBox.Location = new Point(212, 167);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(138, 32);
            firstNameBox.TabIndex = 19;
            firstNameBox.Text = "First Name";
            // 
            // lastNameBox
            // 
            lastNameBox.BackColor = Color.FromArgb(0, 17, 48);
            lastNameBox.BorderStyle = BorderStyle.None;
            lastNameBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameBox.ForeColor = Color.DimGray;
            lastNameBox.Location = new Point(213, 205);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(137, 32);
            lastNameBox.TabIndex = 20;
            lastNameBox.Text = "Last Name";
            // 
            // ageBox
            // 
            ageBox.BackColor = Color.FromArgb(0, 17, 48);
            ageBox.BorderStyle = BorderStyle.None;
            ageBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ageBox.ForeColor = Color.DimGray;
            ageBox.Location = new Point(212, 243);
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(52, 32);
            ageBox.TabIndex = 21;
            ageBox.Text = "Age";
            // 
            // signUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 11, 31);
            ClientSize = new Size(800, 450);
            Controls.Add(ageBox);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            Controls.Add(emailBox);
            Controls.Add(signUpLabel);
            Controls.Add(movePanel);
            Controls.Add(exitButton);
            Controls.Add(minimizeButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "signUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "signUpForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button minimizeButton;
        private Button exitButton;
        private Panel movePanel;
        private Label signUpLabel;
        private TextBox emailBox;
        private TextBox firstNameBox;
        private TextBox lastNameBox;
        private TextBox ageBox;
    }
}