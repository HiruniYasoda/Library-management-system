namespace lms_first_try
{
    partial class BookUsage
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookUsage));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label3 = new Label();
            dataGridView3 = new DataGridView();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            txtBookId = new TextBox();
            label5 = new Label();
            txtBookName = new TextBox();
            lblFullName = new Label();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            dataGridView4 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1275, 350);
            label3.Name = "label3";
            label3.Size = new Size(575, 35);
            label3.TabIndex = 134;
            label3.Text = "Pain fines";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.Peru;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(999, 397);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(901, 251);
            dataGridView3.TabIndex = 133;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 545);
            label1.Name = "label1";
            label1.Size = new Size(500, 35);
            label1.TabIndex = 132;
            label1.Text = "Borrowed members\r\n\r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Peru;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 592);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(906, 377);
            dataGridView1.TabIndex = 131;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Sienna;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Peru;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1579, 194);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 54);
            btnSearch.TabIndex = 144;
            btnSearch.Text = " 🔍 Search\r\n";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBookId
            // 
            txtBookId.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtBookId.Location = new Point(678, 252);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(746, 30);
            txtBookId.TabIndex = 143;
            // 
            // label5
            // 
            label5.BackColor = Color.Sienna;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(262, 245);
            label5.Name = "label5";
            label5.Size = new Size(290, 37);
            label5.TabIndex = 142;
            label5.Text = "Book ID";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            txtBookName.Location = new Point(678, 169);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(746, 30);
            txtBookName.TabIndex = 141;
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.Sienna;
            lblFullName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(262, 169);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(290, 37);
            lblFullName.TabIndex = 140;
            lblFullName.Text = "Name";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
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
            button1.Location = new Point(12, 21);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(102, 84);
            button1.TabIndex = 138;
            button1.Text = " ←";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Sienna;
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1888, 110);
            pictureBox4.TabIndex = 137;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Sienna;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(21, 140);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(196, 175);
            pictureBox5.TabIndex = 136;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Sienna;
            pictureBox6.Location = new Point(12, 128);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(1888, 197);
            pictureBox6.TabIndex = 135;
            pictureBox6.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(320, 350);
            label2.Name = "label2";
            label2.Size = new Size(500, 38);
            label2.TabIndex = 146;
            label2.Text = "Currenty ";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Peru;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 397);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RightToLeft = RightToLeft.No;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView2.Size = new Size(906, 125);
            dataGridView2.TabIndex = 145;
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1275, 669);
            label4.Name = "label4";
            label4.Size = new Size(575, 35);
            label4.TabIndex = 148;
            label4.Text = "Reserved History";
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = Color.Peru;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(999, 707);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(901, 262);
            dataGridView4.TabIndex = 147;
            // 
            // BookUsage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1912, 1053);
            Controls.Add(label4);
            Controls.Add(dataGridView4);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(btnSearch);
            Controls.Add(txtBookId);
            Controls.Add(label5);
            Controls.Add(txtBookName);
            Controls.Add(lblFullName);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(label3);
            Controls.Add(dataGridView3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "BookUsage";
            Text = "BookUsage";
            Load += BookUsage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView dataGridView3;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnSearch;
        private TextBox txtBookId;
        private Label label5;
        private TextBox txtBookName;
        private Label lblFullName;
        private Button button1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label4;
        private DataGridView dataGridView4;
    }
}