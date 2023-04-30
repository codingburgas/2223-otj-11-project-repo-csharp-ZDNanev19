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
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.movePanel = new System.Windows.Forms.Panel();
            this.kepillikLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.fpLabel = new System.Windows.Forms.Label();
            this.closedEyeImage = new System.Windows.Forms.PictureBox();
            this.openedEyeImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closedEyeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openedEyeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(230)))), ((int)(((byte)(175)))));
            this.minimizeButton.Location = new System.Drawing.Point(727, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(42, 33);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.Text = "_";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(230)))), ((int)(((byte)(175)))));
            this.exitButton.Location = new System.Drawing.Point(763, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(37, 33);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "❌";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // movePanel
            // 
            this.movePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.movePanel.Location = new System.Drawing.Point(0, 0);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(727, 33);
            this.movePanel.TabIndex = 2;
            this.movePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMouseDown);
            this.movePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMouseMove);
            // 
            // kepillikLabel
            // 
            this.kepillikLabel.AutoSize = true;
            this.kepillikLabel.BackColor = System.Drawing.Color.Transparent;
            this.kepillikLabel.Font = new System.Drawing.Font("Segoe UI", 20.99F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kepillikLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(230)))), ((int)(((byte)(175)))));
            this.kepillikLabel.Location = new System.Drawing.Point(337, 47);
            this.kepillikLabel.Name = "kepillikLabel";
            this.kepillikLabel.Size = new System.Drawing.Size(115, 38);
            this.kepillikLabel.TabIndex = 3;
            this.kepillikLabel.Text = "Kepillik";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.Color.Teal;
            this.loginLabel.Location = new System.Drawing.Point(351, 119);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(80, 35);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Login";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(48)))));
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameBox.ForeColor = System.Drawing.Color.DimGray;
            this.usernameBox.Location = new System.Drawing.Point(300, 185);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(188, 32);
            this.usernameBox.TabIndex = 5;
            this.usernameBox.Text = "     Username";
            this.usernameBox.Enter += new System.EventHandler(this.usernameTB_Enter);
            this.usernameBox.Leave += new System.EventHandler(this.usernameTB_Leave);
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(48)))));
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passBox.ForeColor = System.Drawing.Color.DimGray;
            this.passBox.Location = new System.Drawing.Point(300, 248);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(188, 32);
            this.passBox.TabIndex = 6;
            this.passBox.Text = "     Password";
            this.passBox.Enter += new System.EventHandler(this.passTB_Enter);
            this.passBox.Leave += new System.EventHandler(this.passTB_Leave);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(48)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(230)))), ((int)(((byte)(175)))));
            this.loginButton.Location = new System.Drawing.Point(339, 344);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(111, 40);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginButton_Down);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_Leave);
            this.loginButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginButton_Move);
            // 
            // fpLabel
            // 
            this.fpLabel.AutoSize = true;
            this.fpLabel.BackColor = System.Drawing.Color.Transparent;
            this.fpLabel.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fpLabel.ForeColor = System.Drawing.Color.Teal;
            this.fpLabel.Location = new System.Drawing.Point(329, 300);
            this.fpLabel.Name = "fpLabel";
            this.fpLabel.Size = new System.Drawing.Size(134, 20);
            this.fpLabel.TabIndex = 8;
            this.fpLabel.Text = "Forgot password?";
            this.fpLabel.Click += new System.EventHandler(this.fpLabel_Click);
            this.fpLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forgotPassDown);
            this.fpLabel.MouseLeave += new System.EventHandler(this.forgotPassLeave);
            this.fpLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.forgotPassMove);
            // 
            // closedEyeImage
            // 
            this.closedEyeImage.BackgroundImage = global::Kepillik.Properties.Resources.closedeye;
            this.closedEyeImage.Location = new System.Drawing.Point(494, 248);
            this.closedEyeImage.Name = "closedEyeImage";
            this.closedEyeImage.Size = new System.Drawing.Size(32, 32);
            this.closedEyeImage.TabIndex = 9;
            this.closedEyeImage.TabStop = false;
            this.closedEyeImage.Click += new System.EventHandler(this.closedEyeImage_Click);
            this.closedEyeImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closedEye_Down);
            this.closedEyeImage.MouseLeave += new System.EventHandler(this.closedEye_Leave);
            this.closedEyeImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.closedEye_Move);
            // 
            // openedEyeImage
            // 
            this.openedEyeImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openedEyeImage.BackgroundImage")));
            this.openedEyeImage.Location = new System.Drawing.Point(494, 248);
            this.openedEyeImage.Name = "openedEyeImage";
            this.openedEyeImage.Size = new System.Drawing.Size(32, 32);
            this.openedEyeImage.TabIndex = 10;
            this.openedEyeImage.TabStop = false;
            this.openedEyeImage.Visible = false;
            this.openedEyeImage.Click += new System.EventHandler(this.openedEyeImage_Click);
            this.openedEyeImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openedEye_Down);
            this.openedEyeImage.MouseLeave += new System.EventHandler(this.openedEye_Leave);
            this.openedEyeImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openedEye_Move);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openedEyeImage);
            this.Controls.Add(this.closedEyeImage);
            this.Controls.Add(this.fpLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.kepillikLabel);
            this.Controls.Add(this.movePanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.minimizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.closedEyeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openedEyeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}