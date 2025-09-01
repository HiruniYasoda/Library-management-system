namespace lms_first_try
{
    partial class LostBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LostBooks));
            txtPages = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dtpDOA = new DateTimePicker();
            label8 = new Label();
            searchAvaliailityToolStripMenuItem = new ToolStripMenuItem();
            searchHistoryToolStripMenuItem = new ToolStripMenuItem();
            txtAuthor = new TextBox();
            lblNIC = new Label();
            label5 = new Label();
            lblFullName = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtLastHolder = new TextBox();
            txtBookId = new TextBox();
            txtBookName = new TextBox();
            lblName = new Label();
            label6 = new Label();
            btnclear = new Button();
            btnSave = new Button();
            pictureBox4 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            txtFine = new TextBox();
            label10 = new Label();
            txtLastHoldersId = new TextBox();
            button3 = new Button();
            txtCategory = new TextBox();
            pictureBox3 = new PictureBox();
            button5 = new Button();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtPages
            // 
            txtPages.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtPages.Location = new Point(1033, 684);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(746, 30);
            txtPages.TabIndex = 70;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(617, 684);
            label1.Name = "label1";
            label1.Size = new Size(290, 37);
            label1.TabIndex = 69;
            label1.Text = "Pages";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(617, 608);
            label2.Name = "label2";
            label2.Size = new Size(290, 37);
            label2.TabIndex = 68;
            label2.Text = "Category";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDOA
            // 
            dtpDOA.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDOA.Location = new Point(1033, 533);
            dtpDOA.Name = "dtpDOA";
            dtpDOA.Size = new Size(746, 30);
            dtpDOA.TabIndex = 66;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(617, 533);
            label8.Name = "label8";
            label8.Size = new Size(290, 37);
            label8.TabIndex = 65;
            label8.Text = "Date";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // searchAvaliailityToolStripMenuItem
            // 
            searchAvaliailityToolStripMenuItem.Name = "searchAvaliailityToolStripMenuItem";
            searchAvaliailityToolStripMenuItem.Size = new Size(210, 28);
            searchAvaliailityToolStripMenuItem.Text = "Fined Books";
            searchAvaliailityToolStripMenuItem.Click += searchAvaliailityToolStripMenuItem_Click;
            // 
            // searchHistoryToolStripMenuItem
            // 
            searchHistoryToolStripMenuItem.Name = "searchHistoryToolStripMenuItem";
            searchHistoryToolStripMenuItem.Size = new Size(210, 28);
            searchHistoryToolStripMenuItem.Text = "Lost Book ";
            searchHistoryToolStripMenuItem.Click += searchHistoryToolStripMenuItem_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtAuthor.Location = new Point(1033, 316);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(746, 30);
            txtAuthor.TabIndex = 64;
            // 
            // lblNIC
            // 
            lblNIC.BackColor = Color.Transparent;
            lblNIC.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNIC.Location = new Point(617, 389);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(290, 37);
            lblNIC.TabIndex = 59;
            lblNIC.Text = "Last holder";
            lblNIC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(617, 249);
            label5.Name = "label5";
            label5.Size = new Size(290, 37);
            label5.TabIndex = 58;
            label5.Text = "Book ID";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(617, 179);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(290, 37);
            lblFullName.TabIndex = 57;
            lblFullName.Text = "Book";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.Plum;
            contextMenuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { searchAvaliailityToolStripMenuItem, searchHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 88);
            // 
            // txtLastHolder
            // 
            txtLastHolder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtLastHolder.Location = new Point(1033, 389);
            txtLastHolder.Name = "txtLastHolder";
            txtLastHolder.Size = new Size(746, 30);
            txtLastHolder.TabIndex = 63;
            // 
            // txtBookId
            // 
            txtBookId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtBookId.Location = new Point(1033, 249);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(746, 30);
            txtBookId.TabIndex = 62;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtBookName.Location = new Point(1033, 179);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(746, 30);
            txtBookName.TabIndex = 61;
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(617, 316);
            lblName.Name = "lblName";
            lblName.Size = new Size(290, 37);
            lblName.TabIndex = 60;
            lblName.Text = "Author";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.Purple;
            label6.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(617, 21);
            label6.Name = "label6";
            label6.Size = new Size(1162, 84);
            label6.TabIndex = 56;
            label6.Text = "Lost books";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Purple;
            btnclear.FlatAppearance.BorderSize = 0;
            btnclear.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(1329, 890);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(174, 54);
            btnclear.TabIndex = 55;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Purple;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1082, 890);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(174, 54);
            btnSave.TabIndex = 54;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Purple;
            pictureBox4.Location = new Point(21, 977);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1901, 10);
            pictureBox4.TabIndex = 53;
            pictureBox4.TabStop = false;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.Purple;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Purple;
            button2.FlatAppearance.MouseOverBackColor = Color.Plum;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(135, 21);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(102, 84);
            button2.TabIndex = 51;
            button2.Text = " ☰";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Purple;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Purple;
            button1.FlatAppearance.MouseOverBackColor = Color.Plum;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(31, 21);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(102, 84);
            button1.TabIndex = 50;
            button1.Text = " ←";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Purple;
            pictureBox2.Location = new Point(21, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(461, 849);
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Purple;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1899, 104);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(617, 758);
            label7.Name = "label7";
            label7.Size = new Size(290, 37);
            label7.TabIndex = 71;
            label7.Text = "Fine";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFine
            // 
            txtFine.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtFine.Location = new Point(1033, 758);
            txtFine.Name = "txtFine";
            txtFine.Size = new Size(746, 30);
            txtFine.TabIndex = 75;
            txtFine.TextChanged += txtFine_TextChanged;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(617, 461);
            label10.Name = "label10";
            label10.Size = new Size(290, 37);
            label10.TabIndex = 79;
            label10.Text = "Last holders' ID";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastHoldersId
            // 
            txtLastHoldersId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtLastHoldersId.Location = new Point(1033, 461);
            txtLastHoldersId.Name = "txtLastHoldersId";
            txtLastHoldersId.Size = new Size(746, 30);
            txtLastHoldersId.TabIndex = 80;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Plum;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1575, 890);
            button3.Name = "button3";
            button3.Size = new Size(174, 54);
            button3.TabIndex = 81;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtCategory.Location = new Point(1033, 612);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(746, 30);
            txtCategory.TabIndex = 82;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(31, 135);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(440, 435);
            pictureBox3.TabIndex = 84;
            pictureBox3.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Purple;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.Plum;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(153, 608);
            button5.Name = "button5";
            button5.Size = new Size(174, 54);
            button5.TabIndex = 85;
            button5.Text = "🔍 Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // LostBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1912, 1053);
            Controls.Add(button5);
            Controls.Add(pictureBox3);
            Controls.Add(txtCategory);
            Controls.Add(button3);
            Controls.Add(label10);
            Controls.Add(txtLastHoldersId);
            Controls.Add(label7);
            Controls.Add(txtFine);
            Controls.Add(txtPages);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dtpDOA);
            Controls.Add(label8);
            Controls.Add(txtAuthor);
            Controls.Add(lblNIC);
            Controls.Add(label5);
            Controls.Add(lblFullName);
            Controls.Add(txtLastHolder);
            Controls.Add(txtBookId);
            Controls.Add(txtBookName);
            Controls.Add(lblName);
            Controls.Add(label6);
            Controls.Add(btnclear);
            Controls.Add(btnSave);
            Controls.Add(pictureBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "LostBooks";
            Text = "LostBooks";
            Load += LostBooks_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPages;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpDOA;
        private Label label8;
        private ToolStripMenuItem searchAvaliailityToolStripMenuItem;
        private ToolStripMenuItem searchHistoryToolStripMenuItem;
        private TextBox txtAuthor;
        private Label lblNIC;
        private Label label5;
        private Label lblFullName;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtLastHolder;
        private TextBox txtBookId;
        private TextBox txtBookName;
        private Label lblName;
        private Label label6;
        private Button btnclear;
        private Button btnSave;
        private PictureBox pictureBox4;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox txtFine;
        private Label label10;
        private TextBox txtLastHoldersId;
        private Button button3;
        private TextBox txtCategory;
        private PictureBox pictureBox3;
        private Button button5;
    }
}