namespace VisualProgrammingProject
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            btnAlreadyRegistered = new Button();
            txtEmail = new Label();
            textBox1 = new TextBox();
            cmbRole = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 26);
            label1.Name = "label1";
            label1.Size = new Size(309, 53);
            label1.TabIndex = 0;
            label1.Text = "Register Now!";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label2.Location = new Point(138, 182);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label3.Location = new Point(138, 232);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(260, 175);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(376, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(260, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(376, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.BackColor = Color.FromArgb(224, 224, 224);
            btnRegister.Font = new Font("Verdana", 10.8F);
            btnRegister.Location = new Point(127, 397);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(239, 53);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnAlreadyRegistered
            // 
            btnAlreadyRegistered.Anchor = AnchorStyles.None;
            btnAlreadyRegistered.BackColor = Color.FromArgb(224, 224, 224);
            btnAlreadyRegistered.Font = new Font("Verdana", 10.8F);
            btnAlreadyRegistered.Location = new Point(248, 504);
            btnAlreadyRegistered.Name = "btnAlreadyRegistered";
            btnAlreadyRegistered.Size = new Size(214, 76);
            btnAlreadyRegistered.TabIndex = 6;
            btnAlreadyRegistered.Text = "Already Registered?    Click here!";
            btnAlreadyRegistered.UseVisualStyleBackColor = false;
            btnAlreadyRegistered.Click += button2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.AutoSize = true;
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            txtEmail.Location = new Point(138, 137);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(69, 28);
            txtEmail.TabIndex = 7;
            txtEmail.Text = "Email:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(260, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 27);
            textBox1.TabIndex = 8;
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.None;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(260, 279);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(376, 28);
            cmbRole.TabIndex = 9;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            label4.Location = new Point(138, 282);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 10;
            label4.Text = "Role:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Verdana", 10.8F);
            button1.Location = new Point(370, 397);
            button1.Name = "button1";
            button1.Size = new Size(232, 53);
            button1.TabIndex = 11;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Register;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1087, 744);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(cmbRole);
            Controls.Add(textBox1);
            Controls.Add(txtEmail);
            Controls.Add(btnAlreadyRegistered);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;
        private Button btnAlreadyRegistered;
        private Label txtEmail;
        private TextBox textBox1;
        private ComboBox cmbRole;
        private Label label4;
        private Button button1;
    }
}
