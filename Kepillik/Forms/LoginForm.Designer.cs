namespace Kepillik
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            minimizeButton = new Button();
            exitButton = new Button();
            movePanel = new Panel();
            kepillikLabel = new Label();
            loginLabel = new Label();
            usernameBox = new TextBox();
            passBox = new TextBox();
            loginButton = new Button();
            fpLabel = new Label();
            closedEyeImage = new PictureBox();
            openedEyeImage = new PictureBox();
            pictureBox1 = new PictureBox();
            signUpLabel = new Label();
            incorrectLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)closedEyeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openedEyeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            minimizeButton.TabIndex = 0;
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
            exitButton.TabIndex = 1;
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
            movePanel.TabIndex = 2;
            movePanel.MouseDown += panelMouseDown;
            movePanel.MouseMove += panelMouseMove;
            // 
            // kepillikLabel
            // 
            kepillikLabel.AutoSize = true;
            kepillikLabel.BackColor = Color.Transparent;
            kepillikLabel.Font = new Font("Segoe UI", 20.99F, FontStyle.Bold, GraphicsUnit.Point);
            kepillikLabel.ForeColor = Color.FromArgb(62, 230, 175);
            kepillikLabel.Location = new Point(337, 47);
            kepillikLabel.Name = "kepillikLabel";
            kepillikLabel.Size = new Size(115, 38);
            kepillikLabel.TabIndex = 3;
            kepillikLabel.Text = "Kepillik";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.BackColor = Color.Transparent;
            loginLabel.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.ForeColor = Color.Teal;
            loginLabel.Location = new Point(351, 119);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(80, 35);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "Login";
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.FromArgb(0, 17, 48);
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.Font = new Font("Times New Roman", 17F, FontStyle.Bold, GraphicsUnit.Point);
            usernameBox.ForeColor = Color.DimGray;
            usernameBox.Location = new Point(270, 209);
            usernameBox.Multiline = true;
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(254, 33);
            usernameBox.TabIndex = 5;
            usernameBox.Text = "     Username or email";
            usernameBox.Enter += usernameTB_Enter;
            usernameBox.Leave += usernameTB_Leave;
            // 
            // passBox
            // 
            passBox.BackColor = Color.FromArgb(0, 17, 48);
            passBox.BorderStyle = BorderStyle.None;
            passBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            passBox.ForeColor = Color.DimGray;
            passBox.Location = new Point(300, 248);
            passBox.Name = "passBox";
            passBox.Size = new Size(188, 32);
            passBox.TabIndex = 6;
            passBox.Text = "     Password";
            passBox.Enter += passTB_Enter;
            passBox.Leave += passTB_Leave;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(0, 27, 48);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.FromArgb(62, 230, 175);
            loginButton.Location = new Point(339, 322);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(111, 40);
            loginButton.TabIndex = 7;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            loginButton.MouseDown += loginButton_Down;
            loginButton.MouseLeave += loginButton_Leave;
            loginButton.MouseMove += loginButton_Move;
            // 
            // fpLabel
            // 
            fpLabel.AutoSize = true;
            fpLabel.BackColor = Color.Transparent;
            fpLabel.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            fpLabel.ForeColor = Color.Teal;
            fpLabel.Location = new Point(329, 294);
            fpLabel.Name = "fpLabel";
            fpLabel.Size = new Size(134, 20);
            fpLabel.TabIndex = 8;
            fpLabel.Text = "Forgot password?";
            fpLabel.Click += fpLabel_Click;
            fpLabel.MouseDown += forgotPassDown;
            fpLabel.MouseLeave += forgotPassLeave;
            fpLabel.MouseMove += forgotPassMove;
            // 
            // closedEyeImage
            // 
            closedEyeImage.BackgroundImage = Properties.Resources.closedeye;
            closedEyeImage.Location = new Point(494, 248);
            closedEyeImage.Name = "closedEyeImage";
            closedEyeImage.Size = new Size(32, 32);
            closedEyeImage.TabIndex = 9;
            closedEyeImage.TabStop = false;
            closedEyeImage.Click += closedEyeImage_Click;
            closedEyeImage.MouseDown += closedEye_Down;
            closedEyeImage.MouseLeave += closedEye_Leave;
            closedEyeImage.MouseMove += closedEye_Move;
            // 
            // openedEyeImage
            // 
            openedEyeImage.BackgroundImage = (Image)resources.GetObject("openedEyeImage.BackgroundImage");
            openedEyeImage.Location = new Point(494, 248);
            openedEyeImage.Name = "openedEyeImage";
            openedEyeImage.Size = new Size(32, 32);
            openedEyeImage.TabIndex = 10;
            openedEyeImage.TabStop = false;
            openedEyeImage.Visible = false;
            openedEyeImage.Click += openedEyeImage_Click;
            openedEyeImage.MouseDown += openedEye_Down;
            openedEyeImage.MouseLeave += openedEye_Leave;
            openedEyeImage.MouseMove += openedEye_Move;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(742, 391);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 47);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.BackColor = Color.Transparent;
            signUpLabel.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            signUpLabel.ForeColor = Color.Teal;
            signUpLabel.Location = new Point(363, 373);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(63, 20);
            signUpLabel.TabIndex = 12;
            signUpLabel.Text = "Sign Up";
            signUpLabel.Click += signUpLabel_Click;
            signUpLabel.MouseDown += signUp_Down;
            signUpLabel.MouseLeave += signUp_Leave;
            signUpLabel.MouseMove += signUp_Move;
            // 
            // incorrectLabel
            // 
            incorrectLabel.AutoSize = true;
            incorrectLabel.BackColor = Color.Transparent;
            incorrectLabel.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            incorrectLabel.ForeColor = Color.Teal;
            incorrectLabel.Location = new Point(278, 173);
            incorrectLabel.Name = "incorrectLabel";
            incorrectLabel.Size = new Size(240, 20);
            incorrectLabel.TabIndex = 13;
            incorrectLabel.Text = "Incorrect username or password!";
            incorrectLabel.Visible = false;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 11, 31);
            ClientSize = new Size(800, 450);
            Controls.Add(incorrectLabel);
            Controls.Add(signUpLabel);
            Controls.Add(pictureBox1);
            Controls.Add(openedEyeImage);
            Controls.Add(closedEyeImage);
            Controls.Add(fpLabel);
            Controls.Add(loginButton);
            Controls.Add(passBox);
            Controls.Add(usernameBox);
            Controls.Add(loginLabel);
            Controls.Add(kepillikLabel);
            Controls.Add(movePanel);
            Controls.Add(exitButton);
            Controls.Add(minimizeButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += loginForm_Load;
            ((System.ComponentModel.ISupportInitialize)closedEyeImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)openedEyeImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button minimizeButton;
        private Button exitButton;
        private Panel movePanel;
        private Label kepillikLabel;
        private Label loginLabel;
        private TextBox usernameBox;
        private TextBox passBox;
        private Button loginButton;
        private Label fpLabel;
        private PictureBox closedEyeImage;
        private PictureBox openedEyeImage;
        private PictureBox pictureBox1;
        private Label signUpLabel;
        private Label incorrectLabel;
    }
}