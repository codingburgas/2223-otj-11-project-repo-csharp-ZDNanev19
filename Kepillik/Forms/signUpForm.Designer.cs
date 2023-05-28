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
            closedEyeImageCopy = new PictureBox();
            openedEyeImageCopy = new PictureBox();
            backLabel = new Label();
            cancelLabel = new Label();
            incorrectLabel = new Label();
            repeatLabel = new Label();
            wrongEmail = new Label();
            ageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openedEyeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closedEyeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closedEyeImageCopy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openedEyeImageCopy).BeginInit();
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
            emailBox.Enter += email_Enter;
            emailBox.Leave += email_Leave;
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
            firstNameBox.Enter += fName_Enter;
            firstNameBox.Leave += fName_Leave;
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
            lastNameBox.Enter += lName_Enter;
            lastNameBox.Leave += lName_Leave;
            // 
            // ageBox
            // 
            ageBox.BackColor = Color.FromArgb(0, 17, 48);
            ageBox.BorderStyle = BorderStyle.None;
            ageBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ageBox.ForeColor = Color.DimGray;
            ageBox.Location = new Point(212, 243);
            ageBox.MaxLength = 3;
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(52, 32);
            ageBox.TabIndex = 21;
            ageBox.Text = "Age";
            ageBox.Enter += age_Enter;
            ageBox.Leave += age_Leave;
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
            passBox.Enter += pass_Enter;
            passBox.Leave += pass_Leave;
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
            repeatBox.Enter += repeat_Enter;
            repeatBox.Leave += repeat_Leave;
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
            continueButton.Click += continueButton_Click;
            continueButton.MouseDown += continue_Down;
            continueButton.MouseLeave += continue_Leave;
            continueButton.MouseMove += continue_Move;
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
            signUpButton.Click += signUpButton_Click;
            signUpButton.MouseDown += signUp_Down;
            signUpButton.MouseLeave += signUp_Leave;
            signUpButton.MouseMove += signUp_Move;
            // 
            // UserNameBox
            // 
            UserNameBox.BackColor = Color.FromArgb(0, 17, 48);
            UserNameBox.BorderStyle = BorderStyle.None;
            UserNameBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameBox.ForeColor = Color.DimGray;
            UserNameBox.Location = new Point(298, 139);
            UserNameBox.MaxLength = 11;
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(188, 32);
            UserNameBox.TabIndex = 26;
            UserNameBox.Text = "     Username";
            UserNameBox.Visible = false;
            UserNameBox.Enter += userName_Enter;
            UserNameBox.Leave += userName_Leave;
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
            openedEyeImage.Click += openedEyeImage_Click;
            openedEyeImage.MouseDown += opened_Down;
            openedEyeImage.MouseLeave += opened_Leave;
            openedEyeImage.MouseMove += opened_Move;
            // 
            // closedEyeImage
            // 
            closedEyeImage.BackgroundImage = Properties.Resources.closedeye;
            closedEyeImage.Location = new Point(508, 186);
            closedEyeImage.Name = "closedEyeImage";
            closedEyeImage.Size = new Size(32, 32);
            closedEyeImage.TabIndex = 28;
            closedEyeImage.TabStop = false;
            closedEyeImage.Visible = false;
            closedEyeImage.Click += closedEyeImage_Click;
            closedEyeImage.MouseDown += closed_Down;
            closedEyeImage.MouseLeave += closed_Leave;
            closedEyeImage.MouseMove += closed_Move;
            // 
            // closedEyeImageCopy
            // 
            closedEyeImageCopy.BackgroundImage = Properties.Resources.closedeye;
            closedEyeImageCopy.Location = new Point(508, 224);
            closedEyeImageCopy.Name = "closedEyeImageCopy";
            closedEyeImageCopy.Size = new Size(32, 32);
            closedEyeImageCopy.TabIndex = 29;
            closedEyeImageCopy.TabStop = false;
            closedEyeImageCopy.Visible = false;
            closedEyeImageCopy.Click += closedEyeImageCopy_Click;
            closedEyeImageCopy.MouseDown += closedCpy_Down;
            closedEyeImageCopy.MouseLeave += closedCpy_Leave;
            closedEyeImageCopy.MouseMove += closedCpy_Move;
            // 
            // openedEyeImageCopy
            // 
            openedEyeImageCopy.BackgroundImage = (Image)resources.GetObject("openedEyeImageCopy.BackgroundImage");
            openedEyeImageCopy.Location = new Point(508, 224);
            openedEyeImageCopy.Name = "openedEyeImageCopy";
            openedEyeImageCopy.Size = new Size(32, 32);
            openedEyeImageCopy.TabIndex = 30;
            openedEyeImageCopy.TabStop = false;
            openedEyeImageCopy.Visible = false;
            openedEyeImageCopy.Click += openedEyeImageCopy_Click;
            openedEyeImageCopy.MouseDown += openedCpy_Down;
            openedEyeImageCopy.MouseLeave += openedCpy_Leave;
            openedEyeImageCopy.MouseMove += openedCpy_Move;
            // 
            // backLabel
            // 
            backLabel.AutoSize = true;
            backLabel.BackColor = Color.Transparent;
            backLabel.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            backLabel.ForeColor = Color.Teal;
            backLabel.Location = new Point(233, 302);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(42, 20);
            backLabel.TabIndex = 31;
            backLabel.Text = "Back";
            backLabel.Visible = false;
            backLabel.Click += backLabel_Click;
            backLabel.MouseDown += back_Down;
            backLabel.MouseLeave += back_Leave;
            backLabel.MouseMove += back_Move;
            // 
            // cancelLabel
            // 
            cancelLabel.AutoSize = true;
            cancelLabel.BackColor = Color.Transparent;
            cancelLabel.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelLabel.ForeColor = Color.Teal;
            cancelLabel.Location = new Point(34, 408);
            cancelLabel.Name = "cancelLabel";
            cancelLabel.Size = new Size(54, 20);
            cancelLabel.TabIndex = 32;
            cancelLabel.Text = "Cancel";
            cancelLabel.Click += cancelLabel_Click;
            cancelLabel.MouseDown += cancel_Down;
            cancelLabel.MouseLeave += cancel_Leave;
            cancelLabel.MouseMove += cancel_Move;
            // 
            // incorrectLabel
            // 
            incorrectLabel.AutoSize = true;
            incorrectLabel.BackColor = Color.Transparent;
            incorrectLabel.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            incorrectLabel.ForeColor = Color.Teal;
            incorrectLabel.Location = new Point(286, 345);
            incorrectLabel.Name = "incorrectLabel";
            incorrectLabel.Size = new Size(208, 20);
            incorrectLabel.TabIndex = 33;
            incorrectLabel.Text = "Please fill out every text box";
            incorrectLabel.Visible = false;
            // 
            // repeatLabel
            // 
            repeatLabel.AutoSize = true;
            repeatLabel.BackColor = Color.Transparent;
            repeatLabel.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            repeatLabel.ForeColor = Color.Teal;
            repeatLabel.Location = new Point(286, 382);
            repeatLabel.Name = "repeatLabel";
            repeatLabel.Size = new Size(206, 20);
            repeatLabel.TabIndex = 34;
            repeatLabel.Text = "The password doesnt match";
            repeatLabel.Visible = false;
            // 
            // wrongEmail
            // 
            wrongEmail.AutoSize = true;
            wrongEmail.BackColor = Color.Transparent;
            wrongEmail.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            wrongEmail.ForeColor = Color.Teal;
            wrongEmail.Location = new Point(331, 362);
            wrongEmail.Name = "wrongEmail";
            wrongEmail.Size = new Size(114, 20);
            wrongEmail.TabIndex = 35;
            wrongEmail.Text = "Incorrect email";
            wrongEmail.Visible = false;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.Transparent;
            ageLabel.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            ageLabel.ForeColor = Color.Teal;
            ageLabel.Location = new Point(298, 408);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(176, 20);
            ageLabel.TabIndex = 36;
            ageLabel.Text = "Age has to be a number";
            ageLabel.Visible = false;
            // 
            // signUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 11, 31);
            ClientSize = new Size(800, 450);
            Controls.Add(ageLabel);
            Controls.Add(wrongEmail);
            Controls.Add(repeatLabel);
            Controls.Add(incorrectLabel);
            Controls.Add(cancelLabel);
            Controls.Add(backLabel);
            Controls.Add(openedEyeImageCopy);
            Controls.Add(closedEyeImageCopy);
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
            ((System.ComponentModel.ISupportInitialize)closedEyeImageCopy).EndInit();
            ((System.ComponentModel.ISupportInitialize)openedEyeImageCopy).EndInit();
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
        private PictureBox closedEyeImageCopy;
        private PictureBox openedEyeImageCopy;
        private Label backLabel;
        private Label cancelLabel;
        private Label incorrectLabel;
        private Label repeatLabel;
        private Label wrongEmail;
        private Label ageLabel;
    }
}