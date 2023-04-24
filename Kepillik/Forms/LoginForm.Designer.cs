namespace Kepillik
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.minimizeButton = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.kepillikLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closedEyeImage = new System.Windows.Forms.PictureBox();
            this.openedEyeImage = new System.Windows.Forms.PictureBox();
            this.fpLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.closedEyeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openedEyeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(230)))), ((int)(((byte)(175)))));
            this.minimizeButton.Location = new System.Drawing.Point(727, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(42, 33);
            this.minimizeButton.TabIndex = 10;
            this.minimizeButton.Text = "_";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(230)))), ((int)(((byte)(175)))));
            this.buttonClose.Location = new System.Drawing.Point(763, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(37, 33);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "❌";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // kepillikLabel
            // 
            this.kepillikLabel.AutoSize = true;
            this.kepillikLabel.BackColor = System.Drawing.Color.Transparent;
            this.kepillikLabel.Font = new System.Drawing.Font("Segoe UI", 20.99F, System.Drawing.FontStyle.Bold);
            this.kepillikLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(230)))), ((int)(((byte)(175)))));
            this.kepillikLabel.Location = new System.Drawing.Point(337, 47);
            this.kepillikLabel.Name = "kepillikLabel";
            this.kepillikLabel.Size = new System.Drawing.Size(115, 38);
            this.kepillikLabel.TabIndex = 12;
            this.kepillikLabel.Text = "Kepillik";
            this.kepillikLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 33);
            this.panel1.TabIndex = 13;
          
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(48)))));
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.usernameBox.ForeColor = System.Drawing.Color.DimGray;
            this.usernameBox.Location = new System.Drawing.Point(300, 185);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(188, 32);
            this.usernameBox.TabIndex = 23;
            this.usernameBox.Text = "     Username";
            this.usernameBox.Enter += new System.EventHandler(this.usernameTB_Enter);
            this.usernameBox.Leave += new System.EventHandler(this.usernameTB_Leave);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(48)))));
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.passwordBox.ForeColor = System.Drawing.Color.DimGray;
            this.passwordBox.Location = new System.Drawing.Point(300, 248);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(188, 32);
            this.passwordBox.TabIndex = 24;
            this.passwordBox.Text = "     Password";
            this.passwordBox.Enter += new System.EventHandler(this.passwordTB_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordTB_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(351, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // closedEyeImage
            // 
            this.closedEyeImage.Image = ((System.Drawing.Image)(resources.GetObject("closedEyeImage.Image")));
            this.closedEyeImage.Location = new System.Drawing.Point(494, 248);
            this.closedEyeImage.Name = "closedEyeImage";
            this.closedEyeImage.Size = new System.Drawing.Size(32, 32);
            this.closedEyeImage.TabIndex = 26;
            this.closedEyeImage.TabStop = false;
            this.closedEyeImage.Click += new System.EventHandler(this.closedEyeImage_Click);
            this.closedEyeImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClosedEyeImagePressed);
            this.closedEyeImage.MouseLeave += new System.EventHandler(this.closedEyeImageLeave);
            this.closedEyeImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.closedEyeImageMove);
            // 
            // openedEyeImage
            // 
            this.openedEyeImage.Enabled = false;
            this.openedEyeImage.Image = ((System.Drawing.Image)(resources.GetObject("openedEyeImage.Image")));
            this.openedEyeImage.Location = new System.Drawing.Point(494, 248);
            this.openedEyeImage.Name = "openedEyeImage";
            this.openedEyeImage.Size = new System.Drawing.Size(32, 32);
            this.openedEyeImage.TabIndex = 27;
            this.openedEyeImage.TabStop = false;
            this.openedEyeImage.Visible = false;
            this.openedEyeImage.Click += new System.EventHandler(this.openedEyeImage_Click);
            this.openedEyeImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openedEyeImagePressed);
            this.openedEyeImage.MouseLeave += new System.EventHandler(this.openedEyeImageLeave);
            this.openedEyeImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openedEyeImageMove);
            // 
            // fpLabel
            // 
            this.fpLabel.AutoSize = true;
            this.fpLabel.BackColor = System.Drawing.Color.Transparent;
            this.fpLabel.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.fpLabel.ForeColor = System.Drawing.Color.Teal;
            this.fpLabel.Location = new System.Drawing.Point(329, 300);
            this.fpLabel.Name = "fpLabel";
            this.fpLabel.Size = new System.Drawing.Size(134, 20);
            this.fpLabel.TabIndex = 28;
            this.fpLabel.Text = "Forgot password?";
            this.fpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.fpLabel.Click += new System.EventHandler(this.fpLabel_Click);
            this.fpLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forgotPassPressed);
            this.fpLabel.MouseLeave += new System.EventHandler(this.forgotPassLeave);
            this.fpLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.forgotPassMove);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(230)))), ((int)(((byte)(175)))));
            this.loginButton.Location = new System.Drawing.Point(339, 344);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(111, 40);
            this.loginButton.TabIndex = 29;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginButtonPressed);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButtonLeave);
            this.loginButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginButtonMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.fpLabel);
            this.Controls.Add(this.openedEyeImage);
            this.Controls.Add(this.closedEyeImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kepillikLabel);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.minimizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            ((System.ComponentModel.ISupportInitialize)(this.closedEyeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openedEyeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label kepillikLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox closedEyeImage;
        private System.Windows.Forms.PictureBox openedEyeImage;
        private System.Windows.Forms.Label fpLabel;
        private System.Windows.Forms.Button loginButton;
    }
}

