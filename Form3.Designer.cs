namespace VisualProgrammingProject
{
    partial class MainApp
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
            lblTitle = new Label();
            lblRole = new Label();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblName = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnUpdate = new Button();
            btnExit = new Button();
            btnAdd = new Button();
            btnSettings = new Button();
            btnHelp = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(375, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 53);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Contact Book";
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top;
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(745, 18);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(12, 25);
            lblRole.TabIndex = 1;
            lblRole.Text = "\r\n";
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.None;
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(251, 151);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(173, 28);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search by Name:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.Location = new Point(436, 155);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(342, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(419, 206);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(161, 39);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            lblName.Location = new Point(251, 291);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 28);
            lblName.TabIndex = 5;
            lblName.Text = "Name:";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.None;
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            lblPhone.Location = new Point(251, 344);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(77, 28);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.Anchor = AnchorStyles.None;
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            lblAddress.Location = new Point(251, 396);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(94, 28);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address:";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Location = new Point(375, 295);
            txtName.Name = "txtName";
            txtName.Size = new Size(403, 27);
            txtName.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.Location = new Point(375, 345);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(399, 27);
            txtPhone.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.None;
            txtAddress.Location = new Point(375, 400);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(403, 27);
            txtAddress.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.FromArgb(224, 224, 224);
            btnUpdate.Font = new Font("Verdana", 10.8F);
            btnUpdate.Location = new Point(468, 483);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 51);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.FromArgb(224, 224, 224);
            btnExit.Font = new Font("Verdana", 10.8F);
            btnExit.Location = new Point(611, 483);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 51);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(224, 224, 224);
            btnAdd.Font = new Font("Verdana", 10.8F);
            btnAdd.Location = new Point(324, 483);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 51);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.None;
            btnSettings.BackColor = Color.FromArgb(224, 224, 224);
            btnSettings.Font = new Font("Verdana", 10.8F);
            btnSettings.Location = new Point(388, 576);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(140, 51);
            btnSettings.TabIndex = 14;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnHelp
            // 
            btnHelp.Anchor = AnchorStyles.None;
            btnHelp.BackColor = Color.FromArgb(224, 224, 224);
            btnHelp.Font = new Font("Verdana", 10.8F);
            btnHelp.Location = new Point(551, 576);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(115, 51);
            btnHelp.TabIndex = 15;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.Main1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1105, 748);
            Controls.Add(btnHelp);
            Controls.Add(btnSettings);
            Controls.Add(btnAdd);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblRole);
            Controls.Add(lblTitle);
            Name = "MainApp";
            Text = "Main App";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRole;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblName;
        private Label lblPhone;
        private Label lblAddress;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Button btnUpdate;
        private Button btnExit;
        private Button btnAdd;
        private Button btnSettings;
        private Button btnHelp;
    }
}