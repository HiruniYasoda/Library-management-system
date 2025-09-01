namespace lms_first_try
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblUserName = new Label();
            lblPW = new Label();
            txtUserName = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            lblUserName.Location = new Point(86, 636);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(124, 27);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Username";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPW
            // 
            lblPW.AutoSize = true;
            lblPW.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            lblPW.Location = new Point(86, 740);
            lblPW.Name = "lblPW";
            lblPW.Size = new Size(122, 27);
            lblPW.TabIndex = 1;
            lblPW.Text = "Password";
            lblPW.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.BurlyWood;
            txtUserName.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            txtUserName.Location = new Point(485, 621);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(434, 42);
            txtUserName.TabIndex = 2;
            // 
            // txtPW
            // 
            txtPW.BackColor = Color.BurlyWood;
            txtPW.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            txtPW.Location = new Point(485, 726);
            txtPW.Multiline = true;
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(434, 41);
            txtPW.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.BurlyWood;
            btnLogin.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(485, 838);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(192, 52);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Maroon;
            btnClose.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveBorder;
            btnClose.Location = new Point(727, 838);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(192, 52);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtUserName);
            Controls.Add(lblPW);
            Controls.Add(lblUserName);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblPW;
        private TextBox txtUserName;
        private TextBox txtPW;
        private Button btnLogin;
        private Button btnClose;
    }
}
