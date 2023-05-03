namespace Kepillik.Forms
{
    partial class forgotPassForm
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
            movePanel = new Panel();
            minimizeButton = new Button();
            exitButton = new Button();
            recpassLabel = new Label();
            emailBox = new TextBox();
            sendCodeButton = new Button();
            enterCode = new TextBox();
            resendButton = new Button();
            cancelLabel = new Label();
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
            // recpassLabel
            // 
            recpassLabel.AutoSize = true;
            recpassLabel.BackColor = Color.Transparent;
            recpassLabel.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            recpassLabel.ForeColor = Color.Teal;
            recpassLabel.Location = new Point(284, 85);
            recpassLabel.Name = "recpassLabel";
            recpassLabel.Size = new Size(225, 35);
            recpassLabel.TabIndex = 6;
            recpassLabel.Text = "Recover Password";
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.FromArgb(0, 17, 48);
            emailBox.BorderStyle = BorderStyle.None;
            emailBox.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            emailBox.ForeColor = Color.DimGray;
            emailBox.Location = new Point(243, 173);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(291, 32);
            emailBox.TabIndex = 7;
            emailBox.Text = "     Enter email address";
            emailBox.Enter += email_Enter;
            emailBox.Leave += email_Leave;
            // 
            // sendCodeButton
            // 
            sendCodeButton.BackColor = Color.FromArgb(0, 27, 48);
            sendCodeButton.FlatAppearance.BorderSize = 0;
            sendCodeButton.FlatStyle = FlatStyle.Flat;
            sendCodeButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sendCodeButton.ForeColor = Color.FromArgb(62, 230, 175);
            sendCodeButton.Location = new Point(322, 276);
            sendCodeButton.Name = "sendCodeButton";
            sendCodeButton.Size = new Size(131, 43);
            sendCodeButton.TabIndex = 8;
            sendCodeButton.Text = "Send code";
            sendCodeButton.UseVisualStyleBackColor = false;
            sendCodeButton.Click += sendCodeButton_Click;
            // 
            // enterCode
            // 
            enterCode.BackColor = Color.FromArgb(0, 17, 48);
            enterCode.BorderStyle = BorderStyle.None;
            enterCode.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            enterCode.ForeColor = Color.DimGray;
            enterCode.Location = new Point(313, 223);
            enterCode.MaxLength = 9;
            enterCode.Multiline = true;
            enterCode.Name = "enterCode";
            enterCode.Size = new Size(147, 32);
            enterCode.TabIndex = 9;
            enterCode.Text = "Enter code";
            enterCode.Visible = false;
            enterCode.Enter += code_Enter;
            enterCode.Leave += code_Leave;
            // 
            // resendButton
            // 
            resendButton.BackColor = Color.FromArgb(0, 27, 48);
            resendButton.FlatAppearance.BorderSize = 0;
            resendButton.FlatStyle = FlatStyle.Flat;
            resendButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            resendButton.ForeColor = Color.FromArgb(62, 230, 175);
            resendButton.Location = new Point(322, 340);
            resendButton.Name = "resendButton";
            resendButton.Size = new Size(131, 43);
            resendButton.TabIndex = 10;
            resendButton.Text = "Resend";
            resendButton.UseVisualStyleBackColor = false;
            resendButton.Visible = false;
            // 
            // cancelLabel
            // 
            cancelLabel.AutoSize = true;
            cancelLabel.BackColor = Color.Transparent;
            cancelLabel.Font = new Font("Segoe UI", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelLabel.ForeColor = Color.Teal;
            cancelLabel.Location = new Point(46, 404);
            cancelLabel.Name = "cancelLabel";
            cancelLabel.Size = new Size(54, 20);
            cancelLabel.TabIndex = 11;
            cancelLabel.Text = "Cancel";
            cancelLabel.Click += cancelLabel_Click;
            cancelLabel.MouseDown += cancel_Down;
            cancelLabel.MouseLeave += cancel_Leave;
            cancelLabel.MouseMove += cancel_Move;
            // 
            // forgotPassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 11, 31);
            ClientSize = new Size(800, 450);
            Controls.Add(cancelLabel);
            Controls.Add(resendButton);
            Controls.Add(enterCode);
            Controls.Add(sendCodeButton);
            Controls.Add(emailBox);
            Controls.Add(recpassLabel);
            Controls.Add(exitButton);
            Controls.Add(minimizeButton);
            Controls.Add(movePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "forgotPassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "forgotPassForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel movePanel;
        private Button minimizeButton;
        private Button exitButton;
        private Label recpassLabel;
        private TextBox emailBox;
        private Button sendCodeButton;
        private TextBox enterCode;
        private Button resendButton;
        private Label cancelLabel;
    }
}