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
            passBox = new TextBox();
            repeatBox = new TextBox();
            continueButton = new Button();
            signUpButton = new Button();
            UserNameBox = new TextBox();
            openedEyeImage = new PictureBox();
            closedEyeImage = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openedEyeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closedEyeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            // passBox
            // 
            passBox.BackColor = Color.FromArgb(0, 17, 48);
            passBox.BorderStyle = BorderStyle.None;
            passBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            passBox.ForeColor = Color.DimGray;
            passBox.Location = new Point(298, 186);
            passBox.Name = "passBox";
            passBox.Size = new Size(188, 32);
            passBox.TabIndex = 22;
            passBox.Text = "     Password";
            passBox.Visible = false;
            // 
            // repeatBox
            // 
            repeatBox.BackColor = Color.FromArgb(0, 17, 48);
            repeatBox.BorderStyle = BorderStyle.None;
            repeatBox.Font = new Font("Times New Roman", 18.25F, FontStyle.Bold, GraphicsUnit.Point);
            repeatBox.ForeColor = Color.DimGray;
            repeatBox.Location = new Point(298, 224);
            repeatBox.Name = "repeatBox";
            repeatBox.Size = new Size(188, 28);
            repeatBox.TabIndex = 23;
            repeatBox.Text = "Repeat Password";
            repeatBox.Visible = false;
            // 
            // continueButton
            // 
            continueButton.BackColor = Color.FromArgb(0, 27, 48);
            continueButton.FlatAppearance.BorderSize = 0;
            continueButton.FlatStyle = FlatStyle.Flat;
            continueButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            continueButton.ForeColor = Color.FromArgb(62, 230, 175);
            continueButton.Location = new Point(459, 239);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(164, 43);
            continueButton.TabIndex = 24;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = false;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.FromArgb(0, 27, 48);
            signUpButton.FlatAppearance.BorderSize = 0;
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            signUpButton.ForeColor = Color.FromArgb(62, 230, 175);
            signUpButton.Location = new Point(312, 288);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(164, 43);
            signUpButton.TabIndex = 25;
            signUpButton.Text = "Sign up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Visible = false;
            // 
            // UserNameBox
            // 
            UserNameBox.BackColor = Color.FromArgb(0, 17, 48);
            UserNameBox.BorderStyle = BorderStyle.None;
            UserNameBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameBox.ForeColor = Color.DimGray;
            UserNameBox.Location = new Point(298, 139);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(188, 32);
            UserNameBox.TabIndex = 26;
            UserNameBox.Text = "     Username";
            UserNameBox.Visible = false;
            // 
            // openedEyeImage
            // 
            openedEyeImage.BackgroundImage = (Image)resources.GetObject("openedEyeImage.BackgroundImage");
            openedEyeImage.Location = new Point(508, 186);
            openedEyeImage.Name = "openedEyeImage";
            openedEyeImage.Size = new Size(32, 32);
            openedEyeImage.TabIndex = 27;
            openedEyeImage.TabStop = false;
            openedEyeImage.Visible = false;
            // 
            // closedEyeImage
            // 
            closedEyeImage.BackgroundImage = Properties.Resources.closedeye;
            closedEyeImage.Location = new Point(591, 186);
            closedEyeImage.Name = "closedEyeImage";
            closedEyeImage.Size = new Size(32, 32);
            closedEyeImage.TabIndex = 28;
            closedEyeImage.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.closedeye;
            pictureBox2.Location = new Point(591, 224);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(508, 224);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // signUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 11, 31);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(closedEyeImage);
            Controls.Add(openedEyeImage);
            Controls.Add(UserNameBox);
            Controls.Add(signUpButton);
            Controls.Add(continueButton);
            Controls.Add(repeatBox);
            Controls.Add(passBox);
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
            ((System.ComponentModel.ISupportInitialize)openedEyeImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)closedEyeImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private TextBox passBox;
        private TextBox repeatBox;
        private Button continueButton;
        private Button signUpButton;
        private TextBox UserNameBox;
        private PictureBox openedEyeImage;
        private PictureBox closedEyeImage;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}