namespace lms_first_try
{
    partial class members
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(members));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            searchMembersActivitiesToolStripMenuItem = new ToolStripMenuItem();
            searchMembersToolStripMenuItem = new ToolStripMenuItem();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblFullName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblNIC = new Label();
            lblName = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnSave = new Button();
            btnclear = new Button();
            txtFullName = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            txtNIC = new TextBox();
            txtName = new TextBox();
            txtGancon = new TextBox();
            txtDarantor = new TextBox();
            txtMID = new TextBox();
            dtpDOR = new DateTimePicker();
            dtpDOB = new DateTimePicker();
            cbMale = new CheckBox();
            cbFemale = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Brown;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1890, 104);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Brown;
            pictureBox2.Location = new Point(12, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(461, 849);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Brown;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Brown;
            button1.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(22, 21);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(102, 84);
            button1.TabIndex = 2;
            button1.Text = " ←";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.Brown;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Brown;
            button2.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(126, 21);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(102, 84);
            button2.TabIndex = 3;
            button2.Text = " ☰";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.IndianRed;
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { searchMembersActivitiesToolStripMenuItem, searchMembersToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(253, 92);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // searchMembersActivitiesToolStripMenuItem
            // 
            searchMembersActivitiesToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchMembersActivitiesToolStripMenuItem.Name = "searchMembersActivitiesToolStripMenuItem";
            searchMembersActivitiesToolStripMenuItem.Size = new Size(252, 30);
            searchMembersActivitiesToolStripMenuItem.Text = "See members activities";
            searchMembersActivitiesToolStripMenuItem.Click += searchMembersActivitiesToolStripMenuItem_Click;
            // 
            // searchMembersToolStripMenuItem
            // 
            searchMembersToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchMembersToolStripMenuItem.Name = "searchMembersToolStripMenuItem";
            searchMembersToolStripMenuItem.Size = new Size(252, 30);
            searchMembersToolStripMenuItem.Text = "Search members info";
            searchMembersToolStripMenuItem.Click += searchMembersToolStripMenuItem_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Brown;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(42, 153);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(399, 385);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Brown;
            pictureBox4.Location = new Point(12, 977);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1890, 10);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(598, 147);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(290, 37);
            lblFullName.TabIndex = 6;
            lblFullName.Text = "Full name";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
            lblFullName.Click += lblFullName_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(598, 649);
            label1.Name = "label1";
            label1.Size = new Size(290, 37);
            label1.TabIndex = 7;
            label1.Text = "Garantor";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(598, 523);
            label2.Name = "label2";
            label2.Size = new Size(290, 37);
            label2.TabIndex = 8;
            label2.Text = "Contact number";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(598, 399);
            label3.Name = "label3";
            label3.Size = new Size(290, 37);
            label3.TabIndex = 9;
            label3.Text = "Gender";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(598, 462);
            label4.Name = "label4";
            label4.Size = new Size(290, 37);
            label4.TabIndex = 10;
            label4.Text = "Date of birth";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(598, 335);
            label5.Name = "label5";
            label5.Size = new Size(290, 37);
            label5.TabIndex = 11;
            label5.Text = "Address";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label5.Click += label5_Click;
            // 
            // lblNIC
            // 
            lblNIC.BackColor = Color.Transparent;
            lblNIC.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNIC.Location = new Point(598, 275);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(290, 37);
            lblNIC.TabIndex = 12;
            lblNIC.Text = "NIC";
            lblNIC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(598, 209);
            lblName.Name = "lblName";
            lblName.Size = new Size(290, 37);
            lblName.TabIndex = 13;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(598, 841);
            label8.Name = "label8";
            label8.Size = new Size(290, 37);
            label8.TabIndex = 14;
            label8.Text = "Date of reg";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(598, 780);
            label9.Name = "label9";
            label9.Size = new Size(290, 37);
            label9.TabIndex = 15;
            label9.Text = "Members ID";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(598, 712);
            label10.Name = "label10";
            label10.Size = new Size(290, 37);
            label10.TabIndex = 16;
            label10.Text = "Garantors' contact number";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Brown;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1171, 899);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(174, 54);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Brown;
            btnclear.FlatAppearance.BorderSize = 0;
            btnclear.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(1396, 899);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(174, 54);
            btnclear.TabIndex = 18;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtFullName.Location = new Point(1014, 147);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(746, 30);
            txtFullName.TabIndex = 19;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtContact.Location = new Point(1014, 523);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(746, 30);
            txtContact.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtAddress.Location = new Point(1014, 335);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(746, 30);
            txtAddress.TabIndex = 21;
            // 
            // txtNIC
            // 
            txtNIC.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtNIC.Location = new Point(1014, 275);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(746, 30);
            txtNIC.TabIndex = 22;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtName.Location = new Point(1014, 209);
            txtName.Name = "txtName";
            txtName.Size = new Size(746, 30);
            txtName.TabIndex = 23;
            // 
            // txtGancon
            // 
            txtGancon.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtGancon.Location = new Point(1014, 712);
            txtGancon.Name = "txtGancon";
            txtGancon.Size = new Size(746, 30);
            txtGancon.TabIndex = 24;
            // 
            // txtDarantor
            // 
            txtDarantor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtDarantor.Location = new Point(1014, 649);
            txtDarantor.Name = "txtDarantor";
            txtDarantor.Size = new Size(746, 30);
            txtDarantor.TabIndex = 25;
            // 
            // txtMID
            // 
            txtMID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtMID.Location = new Point(1014, 780);
            txtMID.Name = "txtMID";
            txtMID.Size = new Size(746, 30);
            txtMID.TabIndex = 27;
            // 
            // dtpDOR
            // 
            dtpDOR.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDOR.Location = new Point(1014, 841);
            dtpDOR.Name = "dtpDOR";
            dtpDOR.Size = new Size(746, 30);
            dtpDOR.TabIndex = 28;
            // 
            // dtpDOB
            // 
            dtpDOB.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dtpDOB.Location = new Point(1014, 462);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(741, 30);
            dtpDOB.TabIndex = 29;
            // 
            // cbMale
            // 
            cbMale.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cbMale.Location = new Point(1014, 399);
            cbMale.Name = "cbMale";
            cbMale.Size = new Size(336, 30);
            cbMale.TabIndex = 30;
            cbMale.Text = "Male";
            cbMale.UseVisualStyleBackColor = true;
            // 
            // cbFemale
            // 
            cbFemale.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            cbFemale.Location = new Point(1405, 399);
            cbFemale.Name = "cbFemale";
            cbFemale.Size = new Size(350, 24);
            cbFemale.TabIndex = 31;
            cbFemale.Text = "Female";
            cbFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.BackColor = Color.Brown;
            label6.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(598, 21);
            label6.Name = "label6";
            label6.Size = new Size(1162, 84);
            label6.TabIndex = 32;
            label6.Text = "Register members";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(598, 588);
            label7.Name = "label7";
            label7.Size = new Size(290, 37);
            label7.TabIndex = 33;
            label7.Text = "Email";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtEmail.Location = new Point(1014, 588);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(746, 30);
            txtEmail.TabIndex = 34;
            // 
            // members
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1912, 1053);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbFemale);
            Controls.Add(cbMale);
            Controls.Add(dtpDOB);
            Controls.Add(dtpDOR);
            Controls.Add(txtMID);
            Controls.Add(txtDarantor);
            Controls.Add(txtGancon);
            Controls.Add(txtName);
            Controls.Add(txtNIC);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtFullName);
            Controls.Add(btnclear);
            Controls.Add(btnSave);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lblName);
            Controls.Add(lblNIC);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblFullName);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "members";
            Text = "members";
            Load += members_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem searchMembersActivitiesToolStripMenuItem;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ToolStripMenuItem searchMembersToolStripMenuItem;
        private Label lblFullName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblNIC;
        private Label lblName;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnSave;
        private Button btnclear;
        private TextBox txtFullName;
        private TextBox txtContact;
        private TextBox txtAddress;
        private TextBox txtNIC;
        private TextBox txtName;
        private TextBox txtGancon;
        private TextBox txtDarantor;
        private TextBox txtMID;
        private DateTimePicker dtpDOR;
        private DateTimePicker dtpDOB;
        private CheckBox cbMale;
        private CheckBox cbFemale;
        private Label label6;
        private Label label7;
        private TextBox txtEmail;
    }
}