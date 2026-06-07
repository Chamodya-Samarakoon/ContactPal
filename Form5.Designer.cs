namespace VisualProgrammingProject
{
    partial class Settings
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
            label1 = new Label();
            lblUsername = new Label();
            lblCurrentPass = new Label();
            lblNewPass = new Label();
            lblConfirmPass = new Label();
            txtUsername = new TextBox();
            txtCurrentPass = new TextBox();
            txtNewPass = new TextBox();
            txtConfirmPass = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 63);
            label1.Name = "label1";
            label1.Size = new Size(459, 68);
            label1.TabIndex = 0;
            label1.Text = "Account Settings";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.None;
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            lblUsername.Location = new Point(228, 175);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(168, 41);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblCurrentPass
            // 
            lblCurrentPass.Anchor = AnchorStyles.None;
            lblCurrentPass.AutoSize = true;
            lblCurrentPass.BackColor = Color.Transparent;
            lblCurrentPass.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            lblCurrentPass.Location = new Point(228, 230);
            lblCurrentPass.Name = "lblCurrentPass";
            lblCurrentPass.Size = new Size(275, 41);
            lblCurrentPass.TabIndex = 2;
            lblCurrentPass.Text = "Current Password:";
            // 
            // lblNewPass
            // 
            lblNewPass.Anchor = AnchorStyles.None;
            lblNewPass.AutoSize = true;
            lblNewPass.BackColor = Color.Transparent;
            lblNewPass.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            lblNewPass.Location = new Point(228, 281);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(232, 41);
            lblNewPass.TabIndex = 3;
            lblNewPass.Text = "New Password:";
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.Anchor = AnchorStyles.None;
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.BackColor = Color.Transparent;
            lblConfirmPass.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold);
            lblConfirmPass.Location = new Point(228, 333);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(282, 41);
            lblConfirmPass.TabIndex = 4;
            lblConfirmPass.Text = "Confirm Password:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(519, 186);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(284, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtCurrentPass
            // 
            txtCurrentPass.Anchor = AnchorStyles.None;
            txtCurrentPass.Location = new Point(519, 230);
            txtCurrentPass.Name = "txtCurrentPass";
            txtCurrentPass.Size = new Size(284, 27);
            txtCurrentPass.TabIndex = 6;
            // 
            // txtNewPass
            // 
            txtNewPass.Anchor = AnchorStyles.None;
            txtNewPass.Location = new Point(519, 291);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(284, 27);
            txtNewPass.TabIndex = 7;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Anchor = AnchorStyles.None;
            txtConfirmPass.Location = new Point(519, 344);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(284, 27);
            txtConfirmPass.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.FromArgb(224, 224, 224);
            btnUpdate.Font = new Font("Verdana", 13.8F);
            btnUpdate.Location = new Point(244, 498);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(219, 56);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update Settings";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(224, 224, 224);
            btnCancel.Font = new Font("Verdana", 13.8F);
            btnCancel.Location = new Point(705, 498);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 56);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "✖️Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Verdana", 13.8F);
            button1.Location = new Point(506, 498);
            button1.Name = "button1";
            button1.Size = new Size(155, 56);
            button1.TabIndex = 13;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.settings;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1139, 759);
            Controls.Add(button1);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtNewPass);
            Controls.Add(txtCurrentPass);
            Controls.Add(txtUsername);
            Controls.Add(lblConfirmPass);
            Controls.Add(lblNewPass);
            Controls.Add(lblCurrentPass);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Name = "Settings";
            Text = "Settings";
            WindowState = FormWindowState.Maximized;
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsername;
        private Label lblCurrentPass;
        private Label lblNewPass;
        private Label lblConfirmPass;
        private TextBox txtUsername;
        private TextBox txtCurrentPass;
        private TextBox txtNewPass;
        private TextBox txtConfirmPass;
        private Button btnUpdate;
        private Button btnCancel;
        private Button button1;
    }
}