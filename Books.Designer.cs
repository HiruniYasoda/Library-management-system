namespace lms_first_try
{
    partial class Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            pictureBox3 = new PictureBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnclear = new Button();
            btnSave = new Button();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            searchHistoryToolStripMenuItem = new ToolStripMenuItem();
            searchAvaliailityToolStripMenuItem = new ToolStripMenuItem();
            addToBookStockToolStripMenuItem = new ToolStripMenuItem();
            txtAuthor = new TextBox();
            txtPublisher = new TextBox();
            txtBookId = new TextBox();
            txtBookName = new TextBox();
            lblName = new Label();
            lblNIC = new Label();
            label5 = new Label();
            lblFullName = new Label();
            dtpDOA = new DateTimePicker();
            label8 = new Label();
            cbCat = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtPages = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Sienna;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(39, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(399, 385);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.Sienna;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Sienna;
            button1.FlatAppearance.MouseOverBackColor = Color.Peru;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(20, 21);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(102, 84);
            button1.TabIndex = 7;
            button1.Text = " ←";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Sienna;
            pictureBox2.Location = new Point(10, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(461, 849);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Sienna;
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1899, 104);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Sienna;
            btnclear.FlatAppearance.BorderSize = 0;
            btnclear.FlatAppearance.MouseOverBackColor = Color.Peru;
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(1393, 903);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(174, 54);
            btnclear.TabIndex = 21;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Sienna;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.Peru;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1168, 903);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(174, 54);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Sienna;
            pictureBox4.Location = new Point(10, 977);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1901, 10);
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.BackColor = Color.Sienna;
            label6.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(606, 21);
            label6.Name = "label6";
            label6.Size = new Size(1162, 84);
            label6.TabIndex = 33;
            label6.Text = "Add new books";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.Peru;
            contextMenuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { searchHistoryToolStripMenuItem, searchAvaliailityToolStripMenuItem, addToBookStockToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(220, 88);
            // 
            // searchHistoryToolStripMenuItem
            // 
            searchHistoryToolStripMenuItem.Name = "searchHistoryToolStripMenuItem";
            searchHistoryToolStripMenuItem.Size = new Size(219, 28);
            searchHistoryToolStripMenuItem.Text = "Search Book";
            searchHistoryToolStripMenuItem.Click += searchHistoryToolStripMenuItem_Click;
            // 
            // searchAvaliailityToolStripMenuItem
            // 
            searchAvaliailityToolStripMenuItem.Name = "searchAvaliailityToolStripMenuItem";
            searchAvaliailityToolStripMenuItem.Size = new Size(219, 28);
            searchAvaliailityToolStripMenuItem.Text = "see usage";
            searchAvaliailityToolStripMenuItem.Click += searchAvaliailityToolStripMenuItem_Click;
            // 
            // addToBookStockToolStripMenuItem
            // 
            addToBookStockToolStripMenuItem.Name = "addToBookStockToolStripMenuItem";
            addToBookStockToolStripMenuItem.Size = new Size(219, 28);
            addToBookStockToolStripMenuItem.Text = "Add to book stock";
            addToBookStockToolStripMenuItem.Click += addToBookStockToolStripMenuItem_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtAuthor.Location = new Point(1008, 266);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(746, 30);
            txtAuthor.TabIndex = 41;
            // 
            // txtPublisher
            // 
            txtPublisher.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtPublisher.Location = new Point(1008, 332);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(746, 30);
            txtPublisher.TabIndex = 40;
            // 
            // txtBookId
            // 
            txtBookId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtBookId.Location = new Point(1008, 399);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(746, 30);
            txtBookId.TabIndex = 39;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtBookName.Location = new Point(1008, 204);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(746, 30);
            txtBookName.TabIndex = 38;
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(592, 266);
            lblName.Name = "lblName";
            lblName.Size = new Size(290, 37);
            lblName.TabIndex = 37;
            lblName.Text = "Author";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNIC
            // 
            lblNIC.BackColor = Color.Transparent;
            lblNIC.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNIC.Location = new Point(592, 332);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(290, 37);
            lblNIC.TabIndex = 36;
            lblNIC.Text = "Publisher";
            lblNIC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(592, 399);
            label5.Name = "label5";
            label5.Size = new Size(290, 37);
            label5.TabIndex = 35;
            label5.Text = "Book ID";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(592, 204);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(290, 37);
            lblFullName.TabIndex = 34;
            lblFullName.Text = "Name";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDOA
            // 
            dtpDOA.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDOA.Location = new Point(1008, 467);
            dtpDOA.Name = "dtpDOA";
            dtpDOA.Size = new Size(746, 30);
            dtpDOA.TabIndex = 43;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(592, 466);
            label8.Name = "label8";
            label8.Size = new Size(290, 37);
            label8.TabIndex = 42;
            label8.Text = "Date";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbCat
            // 
            cbCat.AllowDrop = true;
            cbCat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCat.FormattingEnabled = true;
            cbCat.Items.AddRange(new object[] { "Kids", "Novels", "Translations", "Short stories", "Science fictions", "Adventure", "Political", "Religion", "Poetry", "Drama", "" });
            cbCat.Location = new Point(1008, 541);
            cbCat.Name = "cbCat";
            cbCat.Size = new Size(746, 31);
            cbCat.TabIndex = 44;
            cbCat.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(592, 612);
            label1.Name = "label1";
            label1.Size = new Size(290, 37);
            label1.TabIndex = 46;
            label1.Text = "Pages";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(592, 541);
            label2.Name = "label2";
            label2.Size = new Size(290, 37);
            label2.TabIndex = 45;
            label2.Text = "Category";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPages
            // 
            txtPages.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtPages.Location = new Point(1008, 616);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(746, 30);
            txtPages.TabIndex = 47;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.Sienna;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Sienna;
            button2.FlatAppearance.MouseOverBackColor = Color.Peru;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(124, 21);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(102, 84);
            button2.TabIndex = 8;
            button2.Text = " ☰";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1912, 1053);
            Controls.Add(txtPages);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cbCat);
            Controls.Add(dtpDOA);
            Controls.Add(label8);
            Controls.Add(txtAuthor);
            Controls.Add(txtPublisher);
            Controls.Add(txtBookId);
            Controls.Add(txtBookName);
            Controls.Add(lblName);
            Controls.Add(lblNIC);
            Controls.Add(label5);
            Controls.Add(lblFullName);
            Controls.Add(label6);
            Controls.Add(btnclear);
            Controls.Add(btnSave);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Books";
            Text = "Books";
            Load += Books_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnclear;
        private Button btnSave;
        private PictureBox pictureBox4;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem searchHistoryToolStripMenuItem;
        private ToolStripMenuItem searchAvaliailityToolStripMenuItem;
        private ToolStripMenuItem addToBookStockToolStripMenuItem;
        private TextBox txtAuthor;
        private TextBox txtPublisher;
        private TextBox txtBookId;
        private TextBox txtBookName;
        private Label lblName;
        private Label lblNIC;
        private Label label5;
        private Label lblFullName;
        private DateTimePicker dtpDOA;
        private Label label8;
        private ComboBox cbCat;
        private Label label1;
        private Label label2;
        private TextBox txtPages;
        private Button button2;
    }
}