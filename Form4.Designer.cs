namespace VisualProgrammingProject
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            label1 = new Label();
            label2 = new Label();
            btnHome = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 52);
            label1.Name = "label1";
            label1.Size = new Size(120, 53);
            label1.TabIndex = 0;
            label1.Text = "Help";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 169);
            label2.Name = "label2";
            label2.Size = new Size(643, 320);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.None;
            btnHome.BackColor = Color.FromArgb(224, 224, 224);
            btnHome.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(323, 550);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(253, 43);
            btnHome.TabIndex = 2;
            btnHome.Text = "Back to Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(167, 433);
            label3.Name = "label3";
            label3.Size = new Size(276, 33);
            label3.TabIndex = 3;
            label3.Text = "contactpal@gmail.com";
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.help;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1102, 756);
            Controls.Add(label3);
            Controls.Add(btnHome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Help";
            Text = "Help";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnHome;
        private Label label3;
    }
}